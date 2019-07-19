Imports System.Web.Script.Serialization

Public Class WCADM

  Public ORQ As String = "T"
  Public FECHA_DMSA As String = ""
  Public RUTFUN As String = ""
  Public VAMENU As String = ""
  Public MENSAJE As String = ""
  Public VIGENCIA As String = ""
  Public MREINT As String = ""
  Public DIASREI As String = ""
  Public MARCA As String = ""
  Public NUMING As String = ""
  Public GLOINDDIA As String = ""
  Public SALDO_ADM As String = ""
  Public NRODIA_ADM As String = ""
  Public FECHA_ADM As String = ""
  Public FECRES_ADM As String = ""
  Public NUMRES_ADM As String = ""

  Public CF As List(Of CFType)
  Private __js As JavaScriptSerializer
  Private __dic As Dictionary(Of String, Object)

  Public WebService As New WS.WebService

  Public Class CFType
    Public MREINT As String = ""
    Public DIASREI As String = ""
    Public MARCA As String = ""
    Public NUMING As String = ""
    Public GLOINDDIA As String = ""
    Public SALDO_ADM As String = ""
    Public NRODIA_ADM As String = ""
    Public FECHA_ADM As String = ""
    Public FECRES_ADM As String = ""
    Public NUMRES_ADM As String = ""
  End Class

  Sub New()
  End Sub

  Public Function CallIspec() As WCADM

    Dim ISPEC As String = WebService.WCADM(ORQ, FECHA_DMSA, RUTFUN, VAMENU)
    Dim WCADM As Object = New JavaScriptSerializer().DeserializeObject(ISPEC)

    __dic = TryCast(WCADM, Dictionary(Of String, Object))

    If (Not __dic Is Nothing) Then
      If (__dic.ContainsKey("ERROR")) Then
        Throw New WSException(__dic("ERROR")("Message"), "WCADM")
      End If
    End If

    If __dic.Count = 0 Then
      Throw New Exception("Error de conexion con el Webservice")
    End If

    Me.FECHA_DMSA = WCADM("__PARAMETERS__")(0)("FECHA_DMSA")
    Me.RUTFUN = WCADM("__PARAMETERS__")(0)("RUTFUN")
    Me.VAMENU = WCADM("__PARAMETERS__")(0)("VAMENU")

    Dim cftype As WCADM.CFType
    Me.CF = New List(Of CFType)

    For Each reg In WCADM("__COPYFROM__")
      cftype = New WCADM.CFType()
      cftype.MREINT = reg("MREINT")
      cftype.DIASREI = reg("DIASREI")
      cftype.MARCA = reg("MARCA")
      cftype.NUMING = reg("NUMING")
      cftype.GLOINDDIA = reg("GLOINDDIA")
      cftype.SALDO_ADM = reg("SALDO_ADM")
      cftype.NRODIA_ADM = reg("NRODIA_ADM")
      cftype.FECHA_ADM = reg("FECHA_ADM")
      cftype.FECRES_ADM = reg("FECRES_ADM")
      cftype.NUMRES_ADM = reg("NUMRES_ADM")
      Me.CF.Add(cftype)

    Next

    Return Me

  End Function

End Class


Imports lfprmbDll

Namespace Tipos

  Public Class oWCADM

#Region "Atributos públicos"

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

#End Region

#Region "Constructores"

    Sub New()
    End Sub

    Friend Sub New(ByVal miWCADMCFType As WCADM.CFType)
      MREINT = miWCADMCFType.MREINT
      DIASREI = miWCADMCFType.DIASREI
      MARCA = miWCADMCFType.MARCA
      NUMING = miWCADMCFType.NUMING
      GLOINDDIA = miWCADMCFType.GLOINDDIA
      SALDO_ADM = miWCADMCFType.SALDO_ADM
      NRODIA_ADM = miWCADMCFType.NRODIA_ADM
      FECHA_ADM = miWCADMCFType.FECHA_ADM
      FECRES_ADM = miWCADMCFType.FECRES_ADM
      NUMRES_ADM = miWCADMCFType.NUMRES_ADM
    End Sub

#End Region

#Region "Métodos privados"

    Private Function __callIspec(ByVal Ispec As WCADM) As List(Of WCADM.CFType)

      Try

        Return Ispec.CallIspec().CF

      Catch ex As MCPResponseException

        Throw New Exception(ex.getMessage)

      Catch ex As WSRequestException

        Throw New Exception(ex.getMessage())

      Catch ex As InvalidTokenException

        Throw New Exception(ex.getMessage())

      End Try

    End Function

#End Region

#Region "Métodos públicos"

    Public Function consultaMasiva(ByVal FECHA_DMSA As String, ByVal RUTFUN As String, ByVal VAMENU As String) As List(Of oWCADM)

      Dim miWCADM As New WCADM()
      Dim lista As New List(Of oWCADM)

      miWCADM.FECHA_DMSA = FECHA_DMSA
      miWCADM.RUTFUN = RUTFUN
      miWCADM.VAMENU = VAMENU

      For Each reg As WCADM.CFType In Me.__callIspec(miWCADM)
        lista.Add(New oWCADM(reg))
      Next

      Return lista

    End Function

#End Region

  End Class

End Namespace


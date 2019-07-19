Imports System.Web.Script.Serialization

Public Class CCHAE

  Public ORQ As String = "T"
  Public DIA_I As String = ""
  Public PERIODO As String = ""
  Public RUTFUN As String = ""
  Public VAMENU As String = ""
  Public MENSAJE As String = ""
  Public MIN_FE As String = ""
  Public PUNTO_F As String = ""
  Public CAN_FE As String = ""
  Public IND_FE As String = ""
  Public NUM_FE As String = ""
  Public MIN_NO As String = ""
  Public PUNTO_N As String = ""
  Public CAN_NO As String = ""
  Public FECTER_H As String = ""
  Public IND_NO As String = ""
  Public NUM_NO As String = ""
  Public TOTALNOCHE As String = ""
  Public MIN_DI As String = ""
  Public PUNTO_D As String = ""
  Public CAN_DI As String = ""
  Public FECINI_H As String = ""
  Public IND_DI As String = ""
  Public NUM_DI As String = ""
  Public TOT_MIAT As String = ""
  Public PUNTO_10 As String = ""
  Public TOT_HOAT As String = ""
  Public FECTER As String = ""
  Public TOT_AUSEN As String = ""
  Public FECINI As String = ""
  Public NOMBRE_FUN As String = ""
  Public APEMAT_FUN As String = ""
  Public APEPAT_FUN As String = ""
  Public MINATRAS As String = ""
  Public PUNTO_9 As String = ""
  Public HORATRAS As String = ""
  Public RMINUSAL As String = ""
  Public PUNTO_8 As String = ""
  Public RHORASAL As String = ""
  Public RMINECOL As String = ""
  Public PUNTO_7 As String = ""
  Public RHORECOL As String = ""
  Public RMINSCOL As String = ""
  Public PUNTO_6 As String = ""
  Public RHORSCOL As String = ""
  Public RMINUENT As String = ""
  Public PUNTO_5 As String = ""
  Public RHORAENT As String = ""
  Public GLO_ASI As String = ""
  Public EST_DIA As String = ""
  Public MINUSAL As String = ""
  Public PUNTO_4 As String = ""
  Public HORASAL As String = ""
  Public MTOLENTC As String = ""
  Public MINECOL As String = ""
  Public PUNTO_3 As String = ""
  Public HORECOL As String = ""
  Public MINSCOL As String = ""
  Public PUNTO_2 As String = ""
  Public HORSCOL As String = ""
  Public MTOLENT As String = ""
  Public HORAENT As String = ""
  Public PUNTO_1 As String = ""
  Public MINUENT As String = ""
  Public GLO_HOR As String = ""
  Public DIAHORA As String = ""

  Public CF As List(Of CFType)

  Private __js As JavaScriptSerializer
  Private __dic As Dictionary(Of String, Object)

  Public WebService As New WS.WebService

  Public Class CFType

    Public MINATRAS As String = ""
    Public PUNTO_9 As String = ""
    Public HORATRAS As String = ""
    Public RMINUSAL As String = ""
    Public PUNTO_8 As String = ""
    Public RHORASAL As String = ""
    Public RMINECOL As String = ""
    Public PUNTO_7 As String = ""
    Public RHORECOL As String = ""
    Public RMINSCOL As String = ""
    Public PUNTO_6 As String = ""
    Public RHORSCOL As String = ""
    Public RMINUENT As String = ""
    Public PUNTO_5 As String = ""
    Public RHORAENT As String = ""
    Public GLO_ASI As String = ""
    Public EST_DIA As String = ""
    Public MINUSAL As String = ""
    Public PUNTO_4 As String = ""
    Public HORASAL As String = ""
    Public MTOLENTC As String = ""
    Public MINECOL As String = ""
    Public PUNTO_3 As String = ""
    Public HORECOL As String = ""
    Public MINSCOL As String = ""
    Public PUNTO_2 As String = ""
    Public HORSCOL As String = ""
    Public MTOLENT As String = ""
    Public HORAENT As String = ""
    Public PUNTO_1 As String = ""
    Public MINUENT As String = ""
    Public GLO_HOR As String = ""
    Public DIAHORA As String = ""
  End Class

  Sub New()
  End Sub

  Public Function CallIspec() As CCHAE

    Dim ISPEC As String = WebService.CCHAE(ORQ, DIA_I, PERIODO, RUTFUN)
    Dim CCHAE As Object = New JavaScriptSerializer().DeserializeObject(ISPEC)
    
    __dic = TryCast(CCHAE, Dictionary(Of String, Object))

    If __dic.ContainsKey("ERROR") Then
      __dic.Clear()
      Me.CF = New List(Of CFType)
      Return Me
    End If

    If (Not __dic Is Nothing) Then
      If (__dic.ContainsKey("ERROR")) Then
        Throw New WSException(__dic("ERROR")("Message"), "CCHAE")
      End If
    End If

    If __dic.Count = 0 Then
      Throw New Exception("Error de conexion con el Webservice")
    End If

    Me.DIA_I = CCHAE("__PARAMETERS__")(0)("DIA_I")
    Me.PERIODO = CCHAE("__PARAMETERS__")(0)("PERIODO")
    Me.RUTFUN = CCHAE("__PARAMETERS__")(0)("RUTFUN")


    Dim cftype As CCHAE.CFType
    Me.CF = New List(Of CFType)

    For Each reg In CCHAE("__COPYFROM__")
      cftype = New CCHAE.CFType()
      cftype.MINATRAS = reg("MINATRAS")
      cftype.PUNTO_9 = reg("PUNTO_9")
      cftype.HORATRAS = reg("HORATRAS")
      cftype.RMINUSAL = reg("RMINUSAL")
      cftype.PUNTO_8 = reg("PUNTO_8")
      cftype.RHORASAL = reg("RHORASAL")
      cftype.RMINECOL = reg("RMINECOL")
      cftype.PUNTO_7 = reg("PUNTO_7")
      cftype.RHORECOL = reg("RHORECOL")
      cftype.RMINSCOL = reg("RMINSCOL")
      cftype.PUNTO_6 = reg("PUNTO_6")
      cftype.RHORSCOL = reg("RHORSCOL")
      cftype.RMINUENT = reg("RMINUENT")
      cftype.PUNTO_5 = reg("PUNTO_5")
      cftype.RHORAENT = reg("RHORAENT")
      cftype.GLO_ASI = reg("GLO_ASI")
      cftype.EST_DIA = reg("EST_DIA")
      cftype.MINUSAL = reg("MINUSAL")
      cftype.PUNTO_4 = reg("PUNTO_4")
      cftype.HORASAL = reg("HORASAL")
      cftype.MTOLENTC = reg("MTOLENTC")
      cftype.MINECOL = reg("MINECOL")
      cftype.PUNTO_3 = reg("PUNTO_3")
      cftype.HORECOL = reg("HORECOL")
      cftype.MINSCOL = reg("MINSCOL")
      cftype.PUNTO_2 = reg("PUNTO_2")
      cftype.HORSCOL = reg("HORSCOL")
      cftype.MTOLENT = reg("MTOLENT")
      cftype.HORAENT = reg("HORAENT")
      cftype.PUNTO_1 = reg("PUNTO_1")
      cftype.MINUENT = reg("MINUENT")
      cftype.GLO_HOR = reg("GLO_HOR")
      cftype.DIAHORA = reg("DIAHORA")
      Me.CF.Add(cftype)

    Next

    Return Me

  End Function

  Public Function CallIspecInquiry() As CCHAE

    Dim ISPEC As String = WebService.CCHAE(ORQ, DIA_I, PERIODO, RUTFUN)
    Dim CCHAE As Object = New JavaScriptSerializer().DeserializeObject(ISPEC)

    __dic = TryCast(CCHAE, Dictionary(Of String, Object))

    If (Not __dic Is Nothing) Then
      If (__dic.ContainsKey("ERROR")) Then
        Throw New WSException(__dic("ERROR")("Message"), "CCHAE")
      End If
    End If

    If __dic.Count = 0 Then
      Throw New Exception("Error de conexion con el Webservice")
    End If

    Me.DIA_I = CCHAE("__PARAMETERS__")(0)("DIA_I")
    Me.MIN_FE = CCHAE("__PARAMETERS__")(0)("MIN_FE")
    Me.CAN_FE = CCHAE("__PARAMETERS__")(0)("CAN_FE")
    Me.MIN_NO = CCHAE("__PARAMETERS__")(0)("MIN_NO")
    Me.CAN_NO = CCHAE("__PARAMETERS__")(0)("CAN_NO")
    Me.MIN_DI = CCHAE("__PARAMETERS__")(0)("MIN_DI")
    Me.CAN_DI = CCHAE("__PARAMETERS__")(0)("CAN_DI")
    Me.FECTER = CCHAE("__PARAMETERS__")(0)("FECTER")
    Me.TOT_AUSEN = CCHAE("__PARAMETERS__")(0)("TOT_AUSEN")
    Me.FECINI = CCHAE("__PARAMETERS__")(0)("FECINI")
    Me.TOT_HOAT = CCHAE("__PARAMETERS__")(0)("TOT_HOAT")

    Return Me

  End Function

End Class


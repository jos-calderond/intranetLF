Imports lfprmbDll

Namespace Tipos

  Public Class oCCHAE

#Region "Atributos públicos"

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
#End Region

#Region "Constructores"

    Sub New()
    End Sub

    Private Sub __IspecToModel(ByVal Ispec As CCHAE)


      Me.DIA_I = Ispec.DIA_I
      Me.MIN_FE = Ispec.MIN_FE
      Me.CAN_FE = Ispec.CAN_FE
      Me.IND_FE = Ispec.IND_FE
      Me.NUM_FE = Ispec.NUM_FE
      Me.MIN_NO = Ispec.MIN_NO
      Me.CAN_NO = Ispec.CAN_NO
      Me.FECTER_H = Ispec.FECTER_H
      Me.IND_NO = Ispec.IND_NO
      Me.NUM_NO = Ispec.NUM_NO
      Me.TOTALNOCHE = Ispec.TOTALNOCHE
      Me.MIN_DI = Ispec.MIN_DI
      Me.CAN_DI = Ispec.CAN_DI
      Me.IND_DI = Ispec.IND_DI
      Me.NUM_DI = Ispec.NUM_DI
      Me.TOT_MIAT = Ispec.TOT_MIAT
      Me.FECTER = Ispec.FECTER
      Me.TOT_AUSEN = Ispec.TOT_AUSEN
      Me.FECINI = Ispec.FECINI
      Me.TOT_HOAT = Ispec.TOT_HOAT

    End Sub

    Private Function __ModelToIspec() As CCHAE

      Dim Ispec As New CCHAE()

      Ispec.DIA_I = Me.DIA_I
      Ispec.MIN_FE = Me.MIN_FE
      Ispec.CAN_FE = Me.CAN_FE
      Ispec.IND_FE = Me.IND_FE
      Ispec.NUM_FE = Me.NUM_FE
      Ispec.MIN_NO = Me.MIN_NO
      Ispec.CAN_NO = Me.CAN_NO
      Ispec.FECTER_H = Me.FECTER_H
      Ispec.IND_NO = Me.IND_NO
      Ispec.NUM_NO = Me.NUM_NO
      Ispec.TOTALNOCHE = Me.TOTALNOCHE
      Ispec.MIN_DI = Me.MIN_DI
      Ispec.CAN_DI = Me.CAN_DI
      Ispec.IND_DI = Me.IND_DI
      Ispec.NUM_DI = Me.NUM_DI
      Ispec.TOT_MIAT = Me.TOT_MIAT
      Ispec.FECTER = Me.FECTER
      Ispec.TOT_AUSEN = Me.TOT_AUSEN
      Ispec.FECINI = Me.FECINI
      Ispec.TOT_HOAT = Me.TOT_HOAT

      Return Ispec

    End Function

    Friend Sub New(ByVal miCCHAECFType As CCHAE.CFType)

      MINATRAS = miCCHAECFType.MINATRAS
      PUNTO_9 = miCCHAECFType.PUNTO_9
      HORATRAS = miCCHAECFType.HORATRAS
      RMINUSAL = miCCHAECFType.RMINUSAL
      PUNTO_8 = miCCHAECFType.PUNTO_8
      RHORASAL = miCCHAECFType.RHORASAL
      RMINECOL = miCCHAECFType.RMINECOL
      PUNTO_7 = miCCHAECFType.PUNTO_7
      RHORECOL = miCCHAECFType.RHORECOL
      RMINSCOL = miCCHAECFType.RMINSCOL
      PUNTO_6 = miCCHAECFType.PUNTO_6
      RHORSCOL = miCCHAECFType.RHORSCOL
      RMINUENT = miCCHAECFType.RMINUENT
      PUNTO_5 = miCCHAECFType.PUNTO_5
      RHORAENT = miCCHAECFType.RHORAENT
      GLO_ASI = miCCHAECFType.GLO_ASI
      EST_DIA = miCCHAECFType.EST_DIA
      MINUSAL = miCCHAECFType.MINUSAL
      PUNTO_4 = miCCHAECFType.PUNTO_4
      HORASAL = miCCHAECFType.HORASAL
      MTOLENTC = miCCHAECFType.MTOLENTC
      MINECOL = miCCHAECFType.MINECOL
      PUNTO_3 = miCCHAECFType.PUNTO_3
      HORECOL = miCCHAECFType.HORECOL
      MINSCOL = miCCHAECFType.MINSCOL
      PUNTO_2 = miCCHAECFType.PUNTO_2
      HORSCOL = miCCHAECFType.HORSCOL
      MTOLENT = miCCHAECFType.MTOLENT
      HORAENT = miCCHAECFType.HORAENT
      PUNTO_1 = miCCHAECFType.PUNTO_1
      MINUENT = miCCHAECFType.MINUENT
      GLO_HOR = miCCHAECFType.GLO_HOR
      DIAHORA = miCCHAECFType.DIAHORA

    End Sub

#End Region

#Region "Métodos privados"

    Private Function __callIspec(ByVal Ispec As CCHAE) As List(Of CCHAE.CFType)

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

    Private Function __callIspecInquiry(ByVal Ispec As CCHAE) As CCHAE
      Try
        Return Ispec.CallIspecInquiry()
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

    Public Function consultaMasiva(ByVal DIA_I As String, ByVal PERIODO As String, ByVal RUTFUN As String) As List(Of oCCHAE)

      Dim miCCHAE As New CCHAE()

      Dim lista As New List(Of oCCHAE)

      miCCHAE.PERIODO = PERIODO
      miCCHAE.RUTFUN = RUTFUN
      miCCHAE.DIA_I = DIA_I
      miCCHAE.ORQ = "T"

      For Each reg As CCHAE.CFType In Me.__callIspec(miCCHAE)
        lista.Add(New oCCHAE(reg))
      Next

      Return lista

    End Function

    Public Sub consultar(ByVal PERIODO As String, ByVal RUTFUN As String)

      Dim miIspec As New CCHAE()
      miIspec.RUTFUN = RUTFUN
      miIspec.PERIODO = PERIODO
      miIspec.DIA_I = DIA_I

      __IspecToModel(Me.__callIspecInquiry(miIspec))

    End Sub

#End Region

  End Class

End Namespace


Imports System.Collections.Generic
Imports lfprmbModel

''' <summary>
''' 05/06/2019 rtorreblanca: Creación.
''' </summary>
''' <remarks></remarks>
Partial Class jScrollAsistencia
  Inherits System.Web.UI.Page
  Private __pagina As String = "../acciones/jScrollAsistencia.aspx"
  Private __accion As String = ""

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      ' Control de acceso.
      Dim caller As String = HttpContext.Current.Request.ServerVariables("HTTP_REFERER")
      If caller Is Nothing Then
        Throw New Exception("Acceso no autorizado.")
        Exit Sub
      Else
        If Not caller.Contains("/pages/frm") Then
          Throw New Exception("Acceso no autorizado.")
          Exit Sub
        End If
      End If

      ' Control de sesión
      If Session("Usuario.Rut") Is Nothing Then
        Throw New Exception(Funciones.gSessionCaducadaForJscroll)
      End If

      __accion = Request.QueryString("accion")

      Select Case __accion

        Case "consultaMasiva"

          Dim jScroll As New JScrollV2(Request, __pagina)
          Dim row As New JScrollV2.myRow(Request)

          row.OnDblclickJsFunction = "jScrollLicenciasRowClick"

          Dim ano As String = jScroll.GetQueryString("ano")
          Dim mes As String = jScroll.GetQueryString("mes")
          Select Case mes
            Case "Enero"
              mes = 1
            Case "Febrero"
              mes = 2
            Case "Marzo"
              mes = 3
            Case "Abril"
              mes = 4
            Case "Mayo"
              mes = 5
            Case "Junio"
              mes = 6
            Case "Julio"
              mes = 7
            Case "Agosto"
              mes = 8
            Case "Septiembre"
              mes = 9
            Case "Octubre"
              mes = 10
            Case "Noviembre"
              mes = 11
            Case "Diciembre"
              mes = 12
          End Select

          Dim periodo As String = String.Empty

          If mes < 10 Then
            periodo = String.Concat(ano, "0", mes)
          Else
            periodo = String.Concat(ano, mes)
          End If

          Dim rut As String = Session("Usuario.Rut")
          Dim ini As String = String.Empty
          Dim datos As List(Of Tipos.oCCHAE) = New Tipos.oCCHAE().consultaMasiva(ini, periodo, rut)
          jScroll.Data = datos

          Dim fieldNUMLIC As New JScrollV2.myField("DIAHORA", "DIA")
          fieldNUMLIC.Width = 8
          row.Fields.Add(fieldNUMLIC)

          Dim fieldFECINI As New JScrollV2.myField("", "Descripcción")
          fieldFECINI.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
                                              Return rowDataObject("GLO_HOR") & "<br />" & rowDataObject("GLO_ASI")
                                            End Function
          fieldFECINI.Width = 8
          row.Fields.Add(fieldFECINI)

          Dim fieldFECTER As New JScrollV2.myField("", "Entrada")
          fieldFECTER.Width = 8
          fieldFECTER.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
                                              Return rowDataObject("HORAENT") & ":" & rowDataObject("MINUENT") & "<br / >" & rowDataObject("RHORAENT") & ":" & rowDataObject("RMINUENT")
                                            End Function
          row.Fields.Add(fieldFECTER)

          Dim fieldGLODIRECC As New JScrollV2.myField("", "Salida")
          fieldGLODIRECC.Width = 8
          fieldGLODIRECC.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
                                                 Return rowDataObject("HORASAL") & ":" & rowDataObject("MINUSAL") & "<br / >" & rowDataObject("RHORASAL") & ":" & rowDataObject("RMINUSAL")
                                               End Function
          row.Fields.Add(fieldGLODIRECC)

          Dim fieldNRODIALIC As New JScrollV2.myField("", "Atraso")
          fieldNRODIALIC.Width = 8
          fieldNRODIALIC.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
                                                 Return rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS") & "<br / >" & rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS")
                                               End Function
          row.Fields.Add(fieldNRODIALIC)

          'Dim fieldFECACC_LIC As New JScrollV2.myField("", "Hrs Extra Diurna")
          'fieldFECACC_LIC.Width = 8
          'fieldFECACC_LIC.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
          '                                        Return rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS") & "<br / >" & rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS")
          '                                      End Function
          'row.Fields.Add(fieldFECACC_LIC)

          'Dim fieldFECRESL As New JScrollV2.myField("", "Hrs Extra Nocturna")
          'fieldFECRESL.Width = 8
          'fieldFECRESL.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
          '                                     Return rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS") & "<br / >" & rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS")
          '                                   End Function
          'row.Fields.Add(fieldFECRESL)

          'Dim fieldRESSAL As New JScrollV2.myField("", "Hrs Extra Festivas")
          'fieldRESSAL.Width = 8
          'fieldRESSAL.CustomFieldFunction = Function(rowDataObject As Object, rowSequence As Integer) As String
          '                                    Return rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS") & "<br / >" & rowDataObject("HORATRAS") & ":" & rowDataObject("MINATRAS")
          '                                  End Function
          'row.Fields.Add(fieldRESSAL)

          Dim fieldObserva As New JScrollV2.myField("EST_DIA", "Observación")
          fieldObserva.Width = 8
          row.Fields.Add(fieldObserva)

          jScroll.RowConfiguration = row
          Response.Write(jScroll.GetMyGrid())

      End Select

    Catch ex As Exception

      Response.Write(ex.Message)

    End Try

  End Sub

End Class
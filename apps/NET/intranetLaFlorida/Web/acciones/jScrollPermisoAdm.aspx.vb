Imports System.Collections.Generic
Imports lfprmbModel

''' <summary>
''' 18/07/2019 jcalderon: Creación.
''' </summary>
''' <remarks></remarks>
Partial Class jScrollPermisoAdm
  Inherits System.Web.UI.Page
  Private __pagina As String = "../acciones/jScrollPermisoAdm.aspx"
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
          Dim menu As String = ""
          ano = String.Concat("0101", ano)
          Dim rut As String = Session("Usuario.Rut")

          Dim datos As List(Of Tipos.oWCADM) = New Tipos.oWCADM().consultaMasiva(ano, rut, menu)

          jScroll.Data = datos

          Dim fieldResolucion As New JScrollV2.myField("NUMING", "N° Resolución")
          fieldResolucion.Width = 8
          row.Fields.Add(fieldResolucion)

          Dim fieldFec As New JScrollV2.myField("FECHA_ADM", "Fecha Resolución")
          fieldFec.Width = 8
          row.Fields.Add(fieldFec)

          Dim fieldDias As New JScrollV2.myField("NRODIA_ADM", "N° Dias")
          fieldDias.Width = 8
          row.Fields.Add(fieldDias)

          Dim fieldSaldo As New JScrollV2.myField("SALDO_ADM", "Saldo")
          fieldSaldo.Width = 8
          row.Fields.Add(fieldSaldo)

          Dim fieldJornada As New JScrollV2.myField("GLOINDDIA", "Jornada")
          fieldJornada.Width = 8
          row.Fields.Add(fieldJornada)

          jScroll.RowConfiguration = row
          Response.Write(jScroll.GetMyGrid())

      End Select

    Catch ex As Exception

      Response.Write(ex.Message)

    End Try

  End Sub

End Class
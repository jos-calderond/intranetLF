Imports System.Collections.Generic
Imports lfprmbModel
Imports System.Web.Script.Serialization

''' <summary>
''' 05/06/2019 rtorreblanca: Creación.
''' </summary>
''' <remarks></remarks>
Partial Class sAsistencia
  Inherits System.Web.UI.Page

  Private __js As New JavaScriptSerializer

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
        Throw New TimeoutException(Funciones.gSessionCaducadaForJsFunction)
      End If

      Dim accion = Request.QueryString("accion")

      Select Case accion

        Case "consultar"

          Dim rut = Session("Usuario.Rut")
          Dim ano = Request.QueryString("ano")
          Dim mes = Request.QueryString("mes")
          Dim valor As String = String.Empty

          If rut.Length < 10 Then
            rut = " " + rut
          End If

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

          If mes < 10 Then
            valor = String.Empty
            valor = String.Concat(ano, "0", mes)
          Else
            valor = String.Concat(ano, mes)
          End If


          Dim reg As New Tipos.oCCHAE()
          reg.consultar(valor, rut)

          Response.Write(__js.Serialize(reg))

        Case "cargarMeses"

          Dim rut = Session("Usuario.Rut")
          If rut.Length < 10 Then
            rut = " " + rut
          End If
          Dim ano = Request.QueryString("ano")
          Dim diaIni = ""
          Dim listaMeses As New List(Of String)
          Dim valor As String = ""
          Dim mes As String = String.Empty
          For index = 1 To 12
            If index < 10 Then
              valor = String.Empty
              valor = String.Concat(ano, "0", index)
            Else
              valor = String.Concat(ano, index)
            End If

            Dim reg As List(Of Tipos.oCCHAE) = New Tipos.oCCHAE().consultaMasiva(diaIni, valor, rut)

            If reg.Count <> 0 Then
              Select Case index
                Case 1
                  mes = "Enero"
                Case 2
                  mes = "Febrero"
                Case 3
                  mes = "Marzo"
                Case 4
                  mes = "Abril"
                Case 5
                  mes = "Mayo"
                Case 6
                  mes = "Junio"
                Case 7
                  mes = "Julio"
                Case 8
                  mes = "Agosto"
                Case 9
                  mes = "Septiembre"
                Case 10
                  mes = "Octubre"
                Case 11
                  mes = "Noviembre"
                Case 12
                  mes = "Diciembre"
              End Select
            End If
            If mes <> String.Empty Then
              listaMeses.Add(mes.ToString())
            End If
          Next

          Dim valoresUnicos As New List(Of String)
          Dim Existe As Boolean = False

          For Each ElementString As String In listaMeses
            Existe = False
            For Each ElementStringInResult As String In valoresUnicos
              If ElementString = ElementStringInResult Then
                Existe = True
                Exit For
              End If
            Next

            If Not Existe Then
              valoresUnicos.Add(ElementString)
            End If
          Next

          Response.Write(__js.Serialize(valoresUnicos))

        Case "cargarAnos"
          Dim ano = ConfigurationManager.AppSettings.Item("rangoAnos").ToString()
          Dim actual = Date.Now.Year
          ano = actual - ano
          Dim lista As New List(Of String)

          While ano <= actual
            If lista.Count = 0 Then
              lista.Add(ano.ToString())
            Else
              For x As Integer = 0 To lista.Count - 1
                If lista.Item(x) <> ano Then
                  lista.Add(ano.ToString())
                End If
              Next
            End If
            ano += 1
          End While

          Dim valoresUnicos As New List(Of String)
          Dim Existe As Boolean = False

          For Each ElementString As String In lista
            Existe = False
            For Each ElementStringInResult As String In valoresUnicos
              If ElementString = ElementStringInResult Then
                Existe = True
                Exit For
              End If
            Next

            If Not Existe Then
              valoresUnicos.Add(ElementString)
            End If
          Next

          Response.Write(__js.Serialize(valoresUnicos))

      End Select

    Catch ex0 As TimeoutException

      Dim err As New Dictionary(Of String, Exception)
      err.Add("timeouterror", New Exception(ex0.Message.Replace(vbLf, " ").Replace(vbCr, " ")))
      Response.Write(__js.Serialize(err))

    Catch ex As Exception

      Dim err As New Dictionary(Of String, Exception)
      err.Add("error", New Exception(ex.Message.Replace(vbLf, " ").Replace(vbCr, " ")))
      Response.Write(__js.Serialize(err))

    End Try

  End Sub

End Class
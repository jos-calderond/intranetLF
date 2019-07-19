Imports System.Collections.Generic
Imports lfprmbModel

Partial Class Site
  Inherits System.Web.UI.MasterPage

  Public scriptVersion As Integer = Integer.Parse(ConfigurationManager.AppSettings("script.version"))

  Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
    PageTitle.InnerHtml = ConfigurationManager.AppSettings("sistemaNombre").ToString()

    bSistemaNombre.InnerText = ConfigurationManager.AppSettings("sistemaNombre").ToString()
    bSistemaNombreMin.InnerText = ConfigurationManager.AppSettings("sistemaNombre").ToString()

    Me.menu.InnerHtml = Session("Usuario.Permisos")
    Me.spnUsuario.InnerText = Session("Usuario.Nombre")
    'Me.spnRol.InnerText = Session("Rol.Nombre")

  End Sub
End Class

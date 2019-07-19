<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmAsistencia.aspx.vb" Inherits="frmAsistencia"
  MasterPageFile="~/Site.Master" %>

<%@ Register Src="../controles/wucAsistencia.ascx" TagName="wucAsistencia" TagPrefix="uc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
  <uc1:wucAsistencia runat="server" ID="miWucAsistencia" />
</asp:Content>

<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wucPermisoAdm.ascx.vb"
    Inherits="wucPermisoAdm" %>
<div class="row">
    <div class="col-sm-12 col-md-12 main">
        <!-- Cuerpo -->
        <div class="panel panel-primary">
            <!-- Cabecera -->
            <nav class="navbar navbar-default navbar-title">
        <div id="divTitleContainer" class="container-fluid">
          <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#myNavbar" aria-expanded="false">
              <span class="icon-bar" style="background-color: white;"></span>
              <span class="icon-bar" style="background-color: white;"></span>
              <span class="icon-bar" style="background-color: white;"></span>
            </button>
            <div id="divNavbarBrand" class="navbar-brand" href="#">PERMISOS ADMINISTRATIVOS</div>
          </div>
        </div>
      </nav>
            <!-- Cuerpo -->
            <div style="padding-top: 0px;">
                <!-- Lista de Usuarios -->
                <div id="divLista" class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <b>&nbsp;CONSULTA PERMISOS ADMINISTRATIVOS</b></h4>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label for="cmbAno">
                                        Seleccione Año</label>
                                    <select id="cmbAno" name="cmbAno" class="form-control uppercase">
                                        <option value="2008">2008</option>
                                        <option value="2009">2009</option>
                                        <option value="2010">2010</option>
                                        <option value="2011">2011</option>
                                        <option value="2012">2012</option>
                                        <option value="2013">2013</option>
                                        <option value="2014">2014</option>
                                        <option value="2015">2015</option>
                                        <option value="2016">2016</option>
                                        <option value="2017">2017</option>
                                        <option value="2018">2018</option>
                                        <option value="2019">2019</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Mantenedor de Licencia -->
                <div id="divMantenedor" class="panel panel-default" style="display: none;">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <b>&nbsp;Detalle De Permisos Administrativos</b>
                            <button type="button" id="btnVerLista" class="navbar-right btn-md btn-default" tabindex="1">
                                <i class="fa fa-arrow-left"></i>&nbsp;Ver Lista</button>
                        </h4>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label for="txtSaldo">
                                        Saldo al</label>
                                    <input type="text" name="txtSaldo" id="txtSaldo" class="form-control uppercase"
                                        tabindex="1" maxlength="8" disabled />
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <div id="listaDePermisosAdm">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

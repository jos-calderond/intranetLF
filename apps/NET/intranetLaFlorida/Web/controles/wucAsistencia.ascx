<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wucAsistencia.ascx.vb"
    Inherits="wucAsistencia" %>
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
            <div id="divNavbarBrand" class="navbar-brand" href="#">MI ASISTENCIA</div>
          </div>
        </div>
      </nav>
            <!-- Cuerpo -->
            <div style="padding-top: 0px;">
                <!-- Lista de Usuarios -->
                <div id="divLista" class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <b>&nbsp;ASISTENCIA SEGUN PERIODO</b></h4>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label for="cmbAno">
                                        Seleccione Año</label>
                                    <select id="cmbAno" name="cmbAno" class="form-control uppercase">
                                    </select>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label for="cmbMes">
                                        Seleccione Mes</label>
                                    <select id="cmbMes" name="cmbMes" class="form-control uppercase">
                                             <option value="1">ENERO</option>                            
                                             <option value="2">FEBRERO</option>                            
                                             <option value="3">MARZO</option>                            
                                             <option value="4">ABRIL</option>                            
                                             <option value="5">MAYO</option>                            
                                             <option value="6">JUNIO</option>                            
                                             <option value="7">JULIO</option>                            
                                             <option value="8">AGOSTO</option>                            
                                             <option value="9">SEPTIEMBRE</option>
                                             <option value="10">OCTUBRE</option>                            
                                             <option value="11">NOVIEMBRE</option>                                                        
                                             <option value="12">DICIEMBRE</option>                            
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
                            <b>&nbsp;Detalle De Asistencia</b>
                            <button type="button" id="btnVerLista" class="navbar-right btn-md btn-default" tabindex="1">
                                <i class="fa fa-arrow-left"></i>&nbsp;Ver Lista</button>
                        </h4>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtFecIni">
                                        Fecha Inicio</label>
                                    <input type="text" name="txtFecIni" id="txtFecIni" class="form-control uppercase"
                                        tabindex="2" maxlength="8" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtFecTermi">
                                        Fecha Termino</label>
                                    <input type="text" name="txtFecTermi" id="txtFecTermi" class="form-control uppercase"
                                        tabindex="3" maxlength="12" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtAusencias">
                                        Total Ausencias
                                    </label>
                                    <input type="text" name="txtAusencias" id="txtAusencias" class="form-control uppercase"
                                        tabindex="4" maxlength="10" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtAtrasos">
                                        Total Atrasos</label>
                                    <input type="text" name="txtAtrasos" id="txtAtrasos" class="form-control uppercase"
                                        tabindex="5" maxlength="3" disabled />
                                </div>
                            </div>
                        </div>
                        <legend>Horas Extras Efectuadas</legend>
                        <div class="row">
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtDiurnas">
                                        Diurnas</label>
                                    <input type="text" name="txtDiurnas" id="txtDiurnas" class="form-control" tabindex="6"
                                        maxlength="10" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtNocturnas">
                                        Nocturnas</label>
                                    <input type="text" name="txtNocturnas" id="txtNocturnas" class="form-control uppercase"
                                        tabindex="7" maxlength="10" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtFectivas">
                                        Festivas</label>
                                    <input type="text" name="txtFectivas" id="txtFectivas" class="form-control uppercase"
                                        tabindex="8" maxlength="10" disabled />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label for="txtNoches">
                                        Noches</label>
                                    <input type="text" name="txtNoches" id="txtNoches" class="form-control uppercase"
                                        tabindex="9" maxlength="10" disabled />
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <div id="listaDeAsistencia">
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

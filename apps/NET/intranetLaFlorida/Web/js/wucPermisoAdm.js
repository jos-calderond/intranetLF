/*
18/07/2019 Jcalderon: Creación.
*/
$(document).ready(function () {

    $(document).ajaxStart(function () {
        $.LoadingOverlay("show");
    });

    $(document).ajaxStop(function () {
        $.LoadingOverlay("hide");
    });

    $("#aspnetForm").validate({ highlight: function (element) { $(element).closest('.form-group').addClass('has-error'); }, unhighlight: function (element) { $(element).closest('.form-group').removeClass('has-error'); }, errorClass: 'help-block' });

    $.validator.addMethod('sinEspacio', function (value, element) { return gValidatextoSinEspacio(value); }, 'No puede contener espacios');
    $.validator.addMethod('noVacio', function (value, element) { return gValidatextoNoVacio(value); }, 'no puede contener espacios.');

    (function ($) { $.each(['show', 'hide'], function (i, ev) { var el = $.fn[ev]; $.fn[ev] = function () { this.trigger(ev); return el.apply(this, arguments); }; }); })(jQuery);

    $("#divLista").show();
    $("#divMantenedor").hide();

    $("#btnVerLista").click(function (e) {
        $("#divLista").show();
        $("#divMantenedor").hide();
    });

    $('#cmbAno').change(function (e) {
        var ano = $('#cmbAno').val();
        //        cargarRegistro(ano, mes)
        jscrollListaDePermisoAdm(ano);
        $("#divMantenedor").show();
        $("#divLista").hide();
    });
});

function jscrollListaDePermisoAdm(ano) {
    var link = new jscroll_set_link();
    link.page = "../acciones/jScrollPermisoAdm.aspx";
    link.scrollname = "listaDePermisosAdm";
    link.setparameter("ano", ano);
    link.setparameter("accion", "consultaMasiva");
    link.getlink();
}

//function cargarRegistro(ano, mes) {

//    gClearValidations();

//    var callback = function (data) {
//        if (gValidateData(data)) {
//            $("#txtFecIni").val(data.FECINI);
//            $("#txtFecTermi").val(data.FECTER);
//            $("#txtDiurnas").val(data.CAN_DI + ":" + data.MIN_DI);
//            $("#txtNocturnas").val(data.CAN_NO + ":" + data.MIN_NO);
//            $("#txtFectivas").val(data.CAN_FE + ":" + data.MIN_FE);
//            $("#txtNoches").val(data.CAN_DI + ":" + data.MIN_DI);
//            $("#txtAusencias").val(data.TOT_AUSEN);
//            $("#txtAtrasos").val(data.TOT_HOAT);
//        }
//    };
//    var asistencia = new sAsistencia();
//    asistencia.callback = callback;
//    asistencia.consultar(ano, mes);
//}




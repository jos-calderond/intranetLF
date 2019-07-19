/*
05/06/2019 rtorreblanca: Creación.
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

    cargarAnos();

    $("#divLista").show();
    $("#divMantenedor").hide();

    $("#btnVerLista").click(function (e) {
        $("#divLista").show();
        $("#divMantenedor").hide();
        $("#divDescripcionLicencia").hide();
    });

//        $('#cmbAno').change(function (e) {
//            var ano = $('#cmbAno').val();
//            cargarMeses(ano);
//        });

        $('#cmbMes').change(function (e) {
            var ano = $('#cmbAno').val();
            var mes = $('#cmbMes').val();
            $("#divMantenedor").show();
            cargarRegistro(ano,mes)
            jscrollListaDeAsistencia(ano, mes)
            $("#divLista").hide();
            $("#divMantenedor").show();
        });
});

function jscrollListaDeAsistencia(ano,mes) {
    var link = new jscroll_set_link();
    link.page = "../acciones/jScrollAsistencia.aspx";
    link.scrollname = "listaDeAsistencia";
    link.setparameter("ano", ano);
    link.setparameter("mes", mes);
    link.setparameter("accion", "consultaMasiva");
    link.getlink();
}

function cargarRegistro(ano,mes) {

    gClearValidations();

    var callback = function (data) {
        if (gValidateData(data)) {
            $("#txtFecIni").val(data.FECINI);
            $("#txtFecTermi").val(data.FECTER);
            $("#txtDiurnas").val(data.CAN_DI + ":"+ data.MIN_DI);
            $("#txtNocturnas").val(data.CAN_NO + ":" + data.MIN_NO);
            $("#txtFectivas").val(data.CAN_FE + ":" + data.MIN_FE);
            $("#txtNoches").val(data.CAN_DI + ":" + data.MIN_DI);
            $("#txtAusencias").val(data.TOT_AUSEN);
            $("#txtAtrasos").val(data.TOT_HOAT);
        }
    };
    var asistencia = new sAsistencia();
    asistencia.callback = callback;
    asistencia.consultar(ano,mes);
}

function cargarAnos() {

    gClearValidations();

    var callback = function (data) {
        if (gValidateData(data)) {
            $('#cmbAno').empty();
            $.each(data, function (i, p) {
                $('#cmbAno').append($('<option></option>').val(p).html(p));
            });
//            var ano = $('#cmbAno').val();
//            cargarMeses(ano);
        }
    };
    var asistencia = new sAsistencia();
    asistencia.callback = callback;
    asistencia.cargarAnos();
}

//function cargarMeses(ano) {

//    gClearValidations();

//    var callback = function (data) {
//        if (gValidateData(data)) {
//            $('#cmbMes').empty();
//            $.each(data, function (i, p) {
//                $('#cmbMes').append($('<option></option>').val(p).html(p));
//            });
//        }
//    };
//    var asistencia = new sAsistencia();
//    asistencia.callback = callback;
//    asistencia.cargarMeses(ano);
//}


function sAsistencia() {

    this.source = '../services/sAsistencia.aspx';

  this.callback = null;
  this.extra = null;

  this.consultar = function (ano,mes) {
    var _data = "";
    var that = this;

    $.ajax({
      url: this.source,
      data: {
        accion: "consultar",
        ano: ano,
        mes:mes
      },
      success: function (data) {
        _data = jQuery.parseJSON(data);
        if (that.callback) that.callback(_data, that.extra);
      },
      error: function () {
        alert("error!");
      },
      async: true
    });
  };

  this.cargarMeses = function (ano) {
    var _data = "";
    var that = this;

    $.ajax({
      url: this.source,
      data: {
          accion: "cargarMeses",
          ano:ano
      },
      success: function (data) {
        _data = jQuery.parseJSON(data);
        if (that.callback) that.callback(_data, that.extra);
      },
      error: function () {
        alert("error!");
      },
      async: true
    });
};

this.cargarAnos = function () {
    var _data = "";
    var that = this;

    $.ajax({
        url: this.source,
        data: {
            accion: "cargarAnos"
        },
        success: function (data) {
            _data = jQuery.parseJSON(data);
            if (that.callback) that.callback(_data, that.extra);
        },
        error: function () {
            alert("error!");
        },
        async: true
    });
};

//  this.detalleLiquidacion = function (rut, institucion, tipoLiquidacion, ano, mes) {
//    var _data = "";
//    var that = this;

//    $.ajax({
//      url: this.source,
//      data: {
//        accion: "detalleLiquidacion",
//        rut: rut,
//        institucion: institucion,
//        tipoLiquidacion: tipoLiquidacion,
//        ano: ano,
//        mes: mes
//      },
//      success: function (data) {
//        _data = jQuery.parseJSON(data);
//        if (that.callback) that.callback(_data, that.extra);
//      },
//      error: function () {
//        alert("error!");
//      },
//      async: true
//    });
//};

//this.consultar3Meses = function (fecini_lic) {
//    var _data = "";
//    var that = this;

//    $.ajax({
//        url: this.source,
//        data: {
//            accion: "consultar3Meses",
//            fecini_lic: fecini_lic
//        },
//        success: function (data) {
//            _data = jQuery.parseJSON(data);
//            if (that.callback) that.callback(_data, that.extra);
//        },
//        error: function () {
//            alert("error!");
//        },
//        async: true
//    });
//};
}


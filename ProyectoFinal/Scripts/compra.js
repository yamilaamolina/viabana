/// <reference path="jquery-3.3.1.js" />

//funcion que pasa parámetro a controlador para llamar a vista parcial 
$(document).ready(function () {
    $("#botonVerProductos").click(function () {
        var id = $("#listaProveedores").val();
        var url = $(this).data('url');
        url = url.replace("param-index", id);
        $("#result").load(url);
    });
});

//función que agrega producto a tabla de carga de productos para la compra
$('.btnAgregarProducto').click(function () {
    var fila = $(this).parents('tr');
    var nombre = fila.find('.tdNombre').text();
    var id = fila.find('.tdId').text();
    var precio = fila.find('.tdPrecio').text();
    var cantidad = fila.find('.cantidadProducto').val();
    var insert = '<tr><td>' + nombre
        + '</td><td>' + precio
        + '</td><td>' + cantidad
        + '</td><td>' + precio*cantidad
        + '</td></tr>';
    $(".tablaCargaProductos").append(insert);
});


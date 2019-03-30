/// <reference path="jquery-3.3.1.js" />
/// <reference path="bootstrap.js" />


//funcion que pasa parámetro a controlador para llamar a vista parcial 
$(document).ready(function () {
    $("#botonVerProductos").click(function () {
        var id = $("#listaProveedores").val();
        var url = $(this).data('url');
        url = url.replace("param-index", id);
        $("#result").load(url);
        $(this).attr("disabled", true);
    });
});

//función que agrega producto a tabla de carga de productos para la compra
$('.btnAgregarProducto').click(function () {
    var fila = $(this).parents('tr');
    var nombre = fila.find('.tdNombre').text();
    var id = fila.find('.tdId').text();
    var precio = fila.find('.tdPrecio').text();
    var cantidad = fila.find('.cantidadProducto').val();
    var insert = '<tr><td width="40%">' + nombre
        + '</td><td width="15%">' + precio
        + '</td><td width="15%">' + cantidad
        + '</td><td width="20%">' + precio * cantidad
        + '</td><td width="10%">' + '<span class="glyphicon glyphicon-erase btnEliminarProducto"></span>' +
        '</td></tr>';
    $(".tablaCargaProductos tbody").append(insert);
    var total = $("#totalCompra").val();
    $("#totalCompra").val(parseFloat(total) + parseFloat(precio) * parseInt(cantidad));
});

//función que borra la tabla completa de carga de productos
$("#cancelarCarga").click(function () {
    $("#botonVerProductos").attr("disabled", false);
    $(".tablaCargaProductos tbody tr").remove();
    $("#totalCompra").val(0);
});


//función que elimina producto seleccionado de la tabla de compras
$(".tablaCargaProductos").on('click', 'span.btnEliminarProducto', function () {
    var subtotal = $(this).parents("tr").find("td").eq(3).html();
    var total = $("#totalCompra").val();
    $("#totalCompra").val(parseFloat(total) - parseFloat(subtotal));
    $(this).parent().parent().remove();    
});

//funcion que agrega compra a tablaDeCompra
$("#agregarACompra").click(function () {
    var id = "3";
    var proveedor = $("#listaProveedores").val();
    var monto = $("#totalCompra").val();
    var fecha = "29/03/2019"
    var lista = id + " " + proveedor + " " + monto + " " + fecha;
    alert(lista);
});



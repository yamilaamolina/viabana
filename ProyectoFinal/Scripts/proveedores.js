//agregar proveedor
$("#agregarProveedor").click(function () {
    $("input").val("");
});

//editar o eliminar proveedor
$('.delbtn').on('click', function () {
    var $row = $(this).closest('tr');
    var $columns = $row.find('td');

    $columns.addClass('row-highlight');
    var values = "";

    $.each($columns, function (i, item) {
        switch(i) {
            case 0:
                $("#razonSocial").val(item.innerHTML);
                break;
            case 1:
                $("#cuit").val(item.innerHTML);
                break;
            case 2:
                $("#telefono").val(item.innerHTML);
                break;
            case 3:
                $("#email").val(item.innerHTML);
                break;
            case 4:
                $("#direccion").val(item.innerHTML);
                break;
        }
    });
});

//eliminar proveedor
$('#eliminarProv').on('click', function () {
    $('#confirmarProv').attr("id", "confirmarEliminarProv");
});

//confirmar proveedor
$('#confirmarEliminarProv').on('click', function () {

});

//cancelar proveedor
$('#cancelarProv').on('click', function () {

});

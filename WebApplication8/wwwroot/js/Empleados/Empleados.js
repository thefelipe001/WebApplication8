$(document).ready(function () {
    LoadData();
});
var loading = document.getElementById("container");



function LoadData() {

    $.ajax({
        url: "/Empleados/GetData",
        type: "GET",
        contentType: "application/json;charset=utf-8",  
        dataType: "json",
        success: function (result) {
            filterItems(result.data);
            var html = '';
            $.each(result.data, function (key, item) {
                html += "<tr>"; 
                html += "<th>" + item.empleadoId + "</th>";
                html += "<th>" + item.nombres + "</th>";
                html += "<th>" + item.apellidos + "</th>";
                html += "<th>" + item.email + "</th>";
                html += "<th>" + item.direccion + "</th>";
                html += "<th>" + item.celular + "</th>";
                html += "<th>" + item.nombreDepartamento + "</th>";



                html += "</tr>";
            });
            setTimeout(function () {
                loading.style.display = "none"; 
                $('.tbody').html(html);  

            }, 3000);

        },
        error: function (errormessage) {

        },
        beforeSend: function () {

        },
    });

}
const filterItems = query => {
    return query.filter((el) =>
        el.indexOf(query) > -1
    );
}




   
       //x.style.display = "block";   //mostrar
   
      //  x.style.display = "none";     Ocultar
   
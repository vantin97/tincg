let product = {} || product;

product.drawTable = function () {
    $.ajax({
        url: setting.urlBoot,
        method: "GET",
        dataType: "JSON",
        success: function (data) {
            $('#showproduct').empty();
            $.each(data, function (i, v) {
                $('#showproduct').append(
                   "<div class='col-lg-4 col-md-6 mb-4'>"+
                   "  <div class='card h-100'>"+
                   " <a href='#''><img class='card-img-top' src='"+v.avata+"' alt=></a>"+
                   "    <div class='card-body'>"+
                   " <h4 class='card-title'>"+
                   "<a href='#' >"+v.nameShoe+" </a> </h4>"+
                   "      <h5>"+v.price+"</h5>"+
                   "  <p class='card-text'>"+v.decri+" </div>"+
                   "<div class='card-footer text-center'>"+               
                    "<a href='' class='btn btn-info btn-sm' type='button'  >Buy Shoe</a></div>" 

                );
            });

        }
    })
};

$(document).ready(function(){
    showimg.init();
});
product.init = function (){
    product.drawTable();
}
$(document).ready(function(){
    product.init();
});
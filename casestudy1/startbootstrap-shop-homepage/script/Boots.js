var boots = {} || boots;

boots.drawTable = function(){
    $.ajax({
        url : setting.urlBoot,
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#tbBoots').empty();
            $.each(data, function(i, v){
                $('#tbBoots').append(
                    "<tr>"+
                        "<td>"+ v.id +"</td>"+
                        "<td>"+ v.nameShoe +"</td>"+
                        "<td><img src='"+ v.avata +"' width='50px' height='60px' /></td>"+
                        "<td>"+ v.price +"</td>"+
                        "<td>"+ v.decri +"</td>"+
                        "<td>" +
                            "<a href='javascript:;' title='Edit Boots' onclick='boots.get("+ v.id +")'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:;' title='Remove Boots' onclick='boots.delete("+ v.id +")'><i class='fa fa-trash '></i></a> " +
                        "</td>" +                        
                    "</tr>"
                );
            });
        }
    });
};

boots.openModal = function(){
    boots.reset();
    $('#addEditBoots').modal('show');
};

boots.save = function(){
    if($('#formAddEditBoots').valid()){
        if($('#id').val() == 0){
            var bootsObj = {};
            bootsObj.nameShoe = $('#NameShoe').val();
            bootsObj.avata = $('#Avata').val();
            bootsObj.price =  $('#Price').val();

        $.ajax({
            url : "https://db123456.herokuapp.com/Boots",
            method : "POST",
            dataType : "json",
            contentType : "application/json",
            data : JSON.stringify(bootsObj),
            success : function(data){
                $('#addEditBoots').modal('hide');
                boots.drawTable();
                }
            });
        }
        else{
            var bootsObj = {};
            bootsObj.nameShoe = $('#NameShoe').val();
            bootsObj.avata = $('#Avata').val();
            bootsObj.price =  $('#Price').val();
            bootsObj.id =  $('#id').val();

        $.ajax({
            url : "https://db123456.herokuapp.com/Boots/" +  bootsObj.id,
            method : "PUT",
            dataType : "json",
            contentType : "application/json",
            data : JSON.stringify(bootsObj),
            success : function(data){
                $('#addEditBoots').modal('hide');
                boots.drawTable();
                }
            });
        }        
    }
};

boots.delete = function(id){
    bootbox.confirm({
        title: "Remove boots",
        message: "are you sure?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if(result){
                $.ajax({
                    url : "https://db123456.herokuapp.com/Boots/" + id,
                    method : "DELETE",
                    dataType : "json",
                    success : function(data){
                        boots.drawTable();
                    }

                })
            }
        }
    });
};

boots.get = function(id){
    $.ajax({
        url : "https://db123456.herokuapp.com/Boots/" + id,
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#NameShoe').val(data.nameShoe);
            $('#Avata').val(data.avata);
            $('#Price').val(data.price);
            $('#id').val(data.id);
            var validator = $( "#formAddEditBoots" ).validate();
            validator.resetForm();
            $('#addEditBoots').modal('show');
        }
    });
}

boots.reset = function(){
    $('#NameShoe').val('');
    $('#Avata').val('');
    $('#Price').val('');
    $('#id').val('0');
    var validator = $( "#formAddEditBoots" ).validate();
    validator.resetForm();   
}

boots.initMaterial = function(){
    $.ajax({
        url : "https://db123456.herokuapp.com/Material",
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#Material').empty();
            $.each(data, function(i, v){
                $('#Material').append(
                    "<option value='"+ v.id +"'>"+ v.Name +"</option>"
                );
            });
        }
    });
}

boots.init = function(){
    boots.drawTable();
    boots.initMaterial();
};

$(document).ready(function(){
    boots.init();
});


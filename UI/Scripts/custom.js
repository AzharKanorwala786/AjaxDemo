var CRUD = CRUD || {

    Init: function () {

        $('#btnsave').on('click', function () {
            debugger;
            CRUD.PostData($(this));
        });
        $('#btngetproducts').on('click', function () {
            debugger;
            CRUD.GetData();
        });
    },
    PostData: function (formdata) {
        debugger;
        var form = $("#createProduct").serializeArray();
        var url = formdata.data("url");
        $.ajax({
            type: "POST",
            url: url,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: form,
            cache: false,
            success: function (res) {                
                $("#divContainer").html("");
                $("#divContainer").html(res);
            },
            error: function (res) {
                //alert(res);
            }
        });
    },
    GetData: function ()  {

        $.ajax({
            type: "GET",
            url: "/Default/Index",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            cache: false,
            processData: false,
            success: function (data) {
                alert(data)
            },
            error: function (res) {
                //alert(res);
            }
        });
    },
}

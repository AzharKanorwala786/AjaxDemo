var CRUD = CRUD || {

 Init: function () {

     $('#btnsave').on('click',function () {

         GetData();

   });

  function GetData() {

    Name  =  $("#Name").val(),
    Price =  $("Price").val(),
    Image =  $("Image").val(),
    Category = $("CategoryId").val()

      var Data = JSON.stringify ({

          "Name": Name,
          "Price":Price,
          "Image":Image, 
          "Category":Category
      });

      $.ajax({
          type: "POST",
          url: "/Products/Create",
          dataType: "json",
          contentType: "application/json; charset=utf-8",
          data: Data,
          success: function (res) {
              alert("Product Details Saved Successfully")
          },
          error: function (res) {

              alert(res);
          }
      });

        }
    }
}
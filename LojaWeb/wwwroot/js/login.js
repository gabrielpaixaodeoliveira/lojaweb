
$(document).ready((function () {

    //Edita Procedimento

    $("form").submit(function (e) {
        e.preventDefault();
       var credenciais = {
            login: $("#login").val(),
            senha: $("#senha").val()
        }
        $.ajax({
            url: "/login/Login",
            type: "POST",
            data: credenciais,
            success: function (result) {
                console.log(result)
                window.location.href = '/Home';
            },
            error: function (error) { alert(error.responseText); }
        })
    }

    )
}));
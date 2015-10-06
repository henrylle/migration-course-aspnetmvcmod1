function OnSucessInserir(content) {
    exibirMensagem(content.Titulo, content.Mensagem, function () { redirecionar(content.Url); });
}

function redirecionar(url) {
    location.href = url;
}

function exibirMensagem(titulo, mensagem, callback) {
    $('body').append('<div id="dialogoMensagem" title="Mensagem" style="font-size:75%;"></div>');
    $('#dialogoMensagem').append(mensagem);
    $('#dialogoMensagem').dialog({
        modal: true,
        title: titulo,
        width: 400,
        heigth: 300,
        buttons: {
            Ok: function () {
                $(this).dialog("close");
                $(this).remove();
                if (callback) {
                    callback();
                }
            }
        }
    });
}

function confirmarExclusao() {
    return confirm('Tem certeza que deseja realmente excluir?');
}

function sucessoExclusao(result) {
    exibirMensagem("Sucesso", result.Mensagem, function () { location.href = '/'; });
}

$(document).ready(
    function () {
        $('#dtFundacao').datepicker();

        //Zebrar tabela
        zebrar();



        $.validator.addMethod('date',
            function (value, element, params) {
                if (this.optional(element)) {
                    return true;
                }

                var result = true;
                try {
                    $.datepicker.parseDate('dd/mm/yy', value);
                } catch (e) {
                    result = false;
                }
                return result;
            });
    }
);

function zebrar() {
    $('table th').css('background-color', '#ddbebe');
    $('table tbody tr:even').css('background-color', '#efe3e3');
    $('table tbody tr:odd').css('background-color', 'silver');
}

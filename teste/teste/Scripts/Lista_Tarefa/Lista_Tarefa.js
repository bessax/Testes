(function ($, window, document) {
    "use strict";

    $(function () {
        $(document.body).on('click', '.addTarefa', function () {
            var data = $("Form").serializeArray();
            $("#tarefas").load("/Listas/AddTarefa",data);
            return false;
        });
    });

}(window.jQuery, window, document));



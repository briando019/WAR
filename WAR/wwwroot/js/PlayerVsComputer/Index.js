
    /*var cardNumber = document.getElementById("cardNumber").value;
    var suit = document.getElementById("suit").value;
    var cardImage = document.getElementById("cardImage").value;*/

    $.ajax({
        url: 'PlayerVsComputer/drawNewCard',
        type: 'GET',
        data: {},
        success: function (PartialViewHtml) {
            console.log(PartialViewHtml);
            $("#newCardInHand").html(PartialViewHtml)
        },
        error: function (request,status,error) {
            console.log(request.responseText);
            console.log(error);
            console.log(status);
        }

        })


/*$.ajax({
    type: 'GET',
    url: 'PlayerVsComputerController/drawNewCard',
    data: {},
    success: function (message) {
        
    }

})*/
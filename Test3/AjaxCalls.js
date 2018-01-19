//-----------------------------------------------------------------------
// Call an ajax function on the server
//-----------------------------------------------------------------------
//function myAjaxFunc(successCB, errorCB) {

//    // serialize the object to JSON string
//    // var dataString = JSON.stringify(request);

//    $.ajax({ // ajax call starts
//        url: 'ajaxWebService.asmx/Hadmayot',   // server side web service method
//        //data: dataString,                          // the parameters sent to the server
//        type: 'POST',                              // can be also GET
//        dataType: 'json',                          // expecting JSON datatype from the server
//        contentType: 'application/json; charset = utf-8', // sent to the server
//        success: successCB,                // data.d id the Variable data contains the data we get from serverside
//        error: errorCB
//    }) // end of ajax call
//}

function getHadmayotTitles(successTitlesCB, errorTitlesCB) {
    $.ajax({ // ajax call starts
        url: 'ajaxWebService.asmx/getTitles',   // server side web service method
        //data: dataString,                          // the parameters sent to the server
        type: 'POST',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successTitlesCB,                // data.d id the Variable data contains the data we get from serverside
        error: errorTitlesCB
    }); // end of ajax call
}

function getHadmayaById(request, successHadmayaCB, errorHdamayaCB) {
    var dataString = JSON.stringify(request);

    $.ajax({ // ajax call starts
        url: 'ajaxWebService.asmx/GetHadmayaById',   // server side web service method
        data: dataString,                          // the parameters sent to the server
        type: 'POST',                              // can be also GET
        dataType: 'json',                          // expecting JSON datatype from the server
        contentType: 'application/json; charset = utf-8', // sent to the server
        success: successHadmayaCB,           // data.d id the Variable data contains the data we get from serverside
        error: errorHdamayaCB
    }) // end of ajax call
}
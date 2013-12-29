/* File Created: December 24, 2013 */

$(document).ready(function () {
    $('#confirmation').hide('slow');
    /*Register User Form Start*/
    $('#validateFeedbackForm').validationEngine('attach', { promptPosition: "topLeft" });
    $('#hidePromptFeedbackForm').on('click', function () {
        $('#validateFeedbackForm').validationEngine('hide');
    });
    /*Register User Form Start*/
    $('#validateFeedbackForm').submit(function (e) {
        e.preventDefault();
        var form = $('#validateFeedbackForm');
        var options = {
            //url: '/Home/Contact',//' @Url.Action("CommentForm")',
            url: form.attr('action'),
            type: "POST",
            //dataType: "json",
            //contentType: "application/json; charset=utf-8",
            data: form.serialize(),
            //target:        '#name',   // target element(s) to be updated with server response 
            //beforeSubmit:  showRequest,  // pre-submit callback 
            success: function (result) {
                if (result.Status) {
                    MessageConfirmation();
                }
                //$('#name').val("");
                //$('#email').val("");
                //$('#reason').val("");
                //$('#summary').val("");
                //alert("success ");// + result.Name);
            },  // post-submit callback 
            failure: function (result) {

                alert("Failure ");// + result.Name);
            }
        };
        
        // submit the form 
        $.ajax(options);
        //$(this).ajaxSubmit(options);
        // return false to prevent normal browser submit and page navigation 
        return false;
    });
    function MessageConfirmation() {
        $('#confirmation').show('slow');
        $('#validateFeedbackForm').hide('slow');
    }
});






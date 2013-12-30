/* File Created: December 24, 2013 */
/// <reference path="~/Scripts/jquery-2.0.3.js" />
/// <reference path="~/Scripts/jquery-ui-1.10.3.js" />
/// <reference path="~/js/actions.js" />
$(document).ready(function () {
    $('#confirmation').hide('slow');
    /*Cotact Us Form Validation Start*/
    $('#validateFeedbackForm').validationEngine('attach', { promptPosition: "topLeft" });
    $('#hidePromptFeedbackForm').on('click', function () {
        $('#validateFeedbackForm').validationEngine('hide');
    });
    /*Cotact Us Form Validation End*/

    /*POst Contact Us Ajax Start*/
    PostContactUsForm();
    /*POst Contact Us Ajax End*/
});

function PostContactUsForm() {
    
    $('#validateFeedbackForm').submit(function (e) {
        
        e.preventDefault();
        var contactUsForm = $('#validateFeedbackForm');
        
        if (contactUsForm.validationEngine('validate')) {
            var contactFromBlock = contactUsForm.closest('.block');
            add_loader(contactFromBlock);
            var options = {
                //url: '/Home/Contact',//' @Url.Action("CommentForm")',
                url: contactUsForm.action,
                type: "POST",
                //dataType: "json",
                //contentType: "application/json; charset=utf-8",
                data: contactUsForm.serialize(),
                //target:        '#name',   // target element(s) to be updated with server response 
                //beforeSubmit:  showRequest,  // pre-submit callback 
                success: function(result) {
                    OnPostContactFormSuccess(result, contactFromBlock);
                }, // post-submit callback 
                failure: function(response) {
                    OnPostContactFormFailure(response, contactFromBlock);
                }
            };

            // submit the form 
            $.ajax(options);

        }
        // return false to prevent normal browser submit and page navigation 
        return false;
    });
}

function MessageConfirmation() {
    $('#confirmation').show('slow');
    $('#validateFeedbackForm').hide('slow');
}

function OnPostContactFormSuccess(result, contactFromBlock) {
    if (result.Status) {
        MessageConfirmation();
    }
    remove_loader(contactFromBlock);
}

function OnPostContactFormFailure(response, contactFromBlock) {
    
    var r = jQuery.parseJSON(response.responseText);
    alert("Message: " + r.Message);
    alert("StackTrace: " + r.StackTrace);
    alert("ExceptionType: " + r.ExceptionType);
    remove_loader(contactFromBlock);
}







/* File Created: December 24, 2013 */

$(document).ready(function () {
    /*Register User Form Start*/
    $('#validateRegisterForm').validationEngine('attach', {
         promptPosition : "topRight",
         ajaxFormValidationMethod: 'post'
    });
    $('#hidePromptRegisterForm').on('click', function () {
        $('#validateRegisterForm').validationEngine('hide');
    });
    /*Register User Form End*/
});
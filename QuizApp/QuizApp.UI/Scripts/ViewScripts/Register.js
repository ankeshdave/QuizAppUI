/* File Created: December 24, 2013 */

$(document).ready(function () {
    /*Register User Form Start*/
    $('#validateRegisterForm').validationEngine('attach', {
         promptPosition : "topRight",
         ajaxFormValidationMethod: 'post',
        // Auto-hide prompt
         autoHidePrompt: true,
        // Delay before auto-hide
         autoHideDelay: 3000,
        // Fade out duration while hiding the validations
         fadeDuration: 0.3,
    });
    $('#hidePromptRegisterForm').on('click', function () {
        $('#validateRegisterForm').validationEngine('hide');
    });
    /*Register User Form End*/
});
/* File Created: December 24, 2013 */

$(document).ready(function () {
    /*Register User Form Start*/
    $('#validateRegisterForm').validationEngine('attach', { promptPosition : "topLeft" });
    $('#hidePromptRegisterForm').on('click', function () {
        $('#hidePromptRegisterForm').validationEngine('hide');
    });
    /*Register User Form Start*/
});
/* File Created: December 24, 2013 */

$(document).ready(function () {
    /*Register User Form Start*/
    $('#validateFeedbackForm').validationEngine('attach', { promptPosition: "topLeft" });
    $('#hidePromptFeedbackForm').on('click', function () {
        $('#validateFeedbackForm').validationEngine('hide');
    });
    /*Register User Form Start*/
});
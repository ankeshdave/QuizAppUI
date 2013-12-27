/* File Created: December 23, 2013 */

$(document).ready(function () {

    /*Login Widgets Start*/
    
    // Style Google
    var google = $(".swidget").filter("#Google");

    if (google.length > 0) {
        var anchorStyle = "background: #e04d38 !important; height: 100px; width: 100px";
        var divCssStyle = "font-size: 72px;";
        var iconCssStyle = "ico-google";
        StyleExternalProvider(google, anchorStyle, divCssStyle, iconCssStyle);
    }

    //Style Yahoo
    var yahoo = $(".swidget").filter("#Yahoo");

    if (yahoo.length > 0) {
        anchorStyle = "background: #720e9e !important; height: 100px; width: 100px";
        divCssStyle = "font-size: 72px;";
        iconCssStyle = "ico-yahoo";
        StyleExternalProvider(yahoo, anchorStyle, divCssStyle, iconCssStyle);
    }

    // Add Submit behavior to Widget (anchor Tag)
    var widgets = $(".widgets").find(".swidget");

    widgets.on("click", function (e) {
        // Pervent default Href redirection
        e.preventDefault();
        var form = $(this).closest("form");
        form.submit();
    });

    /*Login Widgets End*/

    /*Login Form Start*/

    //Start Validation
    $('#validateLoginForm').validationEngine('attach', { promptPosition: "topRight" });

    /*Login Form Start*/

    


});

function StyleExternalProvider(anchorElement, anchorStyle, divCssStyle, iconCssClass) {

    anchorElement.attr("style", anchorStyle);
    var innerDiv = anchorElement.find(".value");
    innerDiv.attr("style", divCssStyle);
    innerDiv.children('span').attr("class", iconCssClass);
}
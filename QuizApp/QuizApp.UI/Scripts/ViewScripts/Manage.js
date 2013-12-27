/* File Created: December 23, 2013 */

$(document).ready(function () {

    /*Login Widgets Start*/

    //Style Login Widgets
    var widgets = $("#externalLoginWidgets");
    StyleLoginWidgets(widgets);

    //Add Form to Widgets anchor element
    var widgetAnchors = widgets.find(".swidget");

    widgetAnchors.on("click", function (e) {
        e.preventDefault();
        var form = $(this).closest("form");
        form.submit();
    });

    /*Login Widgets End*/

    /*Table Widgets Start*/

    //Style Tabe Widgets
    var tableWidgets = $("#externalLogintable");
    StyleTableWidgets(tableWidgets);

    /*Table Widgets Ends*/

    /*Change Password Form Start*/

    $('#validateChangePasswordForm').validationEngine('attach', { promptPosition: "topRight" });
    $('#hidePromptChangePasswordForm').on('click', function () {
        $('#validateChangePasswordForm').validationEngine('hide');
    });

    /*Change Password Form End*/

    /*Set Local Password DForms Start*/

    $('#setLocalPasswordFrom').validationEngine('attach', { promptPosition: "topLeft" });
    $('#hidePromptLocalPasswordForm').on('click', function () {
        $('#setLocalPasswordFrom').validationEngine('hide');
    });

    /*Set Local Password DForms Start*/
});

function StyleLoginWidgets(containerElement){
    /// <summary>Style all login Widgets</summary>
    /// <param name="containerElement" type="Object">DOM Element whcih contains all widgets</param>
    var widgets = containerElement.find(".swidget");

    // Style Google
    var google = widgets.filter("#Google");

    if (google.length > 0) {
        var anchorStyle = "background: #e04d38 !important; height: 100px; width: 100px";
        var divCssStyle = "font-size: 72px;";
        var iconCssStyle = "ico-google";
        StyleExternalProvider(google, anchorStyle, divCssStyle, iconCssStyle);
    }

    //Style Yahoo
    var yahoo = widgets.filter("#Yahoo");

    if (yahoo.length > 0) {
        anchorStyle = "background: #720e9e !important; height: 100px; width: 100px";
        divCssStyle = "font-size: 72px;";
        iconCssStyle = "ico-yahoo";
        StyleExternalProvider(yahoo, anchorStyle, divCssStyle, iconCssStyle);
    }
}

function StyleTableWidgets(containerElement) {

    var widgets = containerElement.find(".swidget");

    // Style Google
    var google = widgets.filter("#Google");

    if (google.length > 0) {
        var anchorStyle = "background: #e04d38 !important; height: 48px; width: 48px;min-width: inherit;margin-bottom: auto;margin-right: auto;";
        var divCssStyle = "font-size: 36px;height: 48px;width:48px;line-height: normal;margin-top: auto;";
        var iconCssStyle = "ico-google";
        StyleExternalProvider(google, anchorStyle, divCssStyle, iconCssStyle);
    }

    //Style Yahoo
    var yahoo = widgets.filter("#Yahoo");

    if (yahoo.length > 0) {
        anchorStyle = "background: #720e9e !important; height: 48px; width: 48px;min-width: inherit;margin-bottom: auto;margin-right: auto;";
        divCssStyle = "font-size: 36px;height: 48px;width:48px;line-height: normal;margin-top: auto;";
        iconCssStyle = "ico-yahoo";
        StyleExternalProvider(yahoo, anchorStyle, divCssStyle, iconCssStyle);
    }
}

function StyleExternalProvider(anchorElement, anchorStyle, divCssStyle, iconCssClass) {

    anchorElement.attr("style", anchorStyle);
    var innerDiv = anchorElement.find(".value");
    innerDiv.attr("style", divCssStyle);
    innerDiv.children('span').attr("class", iconCssClass);
}
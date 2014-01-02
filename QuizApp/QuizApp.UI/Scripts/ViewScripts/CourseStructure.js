$(document).ready(function () {
    $("#tree").fancytree({
        source : {
            //"ajax-tree-plain.json"
            lazyload : function (e, data){
                // we can't return values from an event handler, so we
                // pass the result as `data`attribute.
                //              data.result = {url: "unit/ajax-sub2.json"};
                data.result = $.ajax({
                    url : '/Courses/GetTreeData',
                    dataType : "json"
                });
            }
        }
    });
});

//$(function () {
//    var DT = $.ui.fancytree;
//    $.ui.fancytree.debug("Using fancytree " + $.ui.fancytree.version);
//    // attach to all instances
//    $("#tree, #tree3").fancytree({
//        checkbox: true,
//        selectMode: 1,
//        activate: function (e, data) {
//            var node = data.node;
//            $.ui.fancytree.debug("activate: e=", e, ", data=", data);
//            if (!$.isEmptyObject(node.data)) {
//                alert("custom node data: " + JSON.stringify(node.data));
//            }
//        },
//        lazyload: function (e, data) {
//            data.result = { url: "unit/ajax-sub2.json" };
//        }
//    }).bind("fancytreeactivate", function (e, data) {
//        $.ui.fancytree.debug("fancytreeactivate: e=", e, ", data=", data);
//        return false;
//        //          $(this).fancytree("debug", "fancytreeactivate");
//    });
//    var tree = $("div:ui-fancytree").data("fancytree").getTree();
//    DT.debug("Test ':ui-fancytree' expression " + $("div:ui-fancytree").length);

//    /* Load tree from Ajax JSON
//    */
//    $("#tree2").fancytree({
//        source: {
//            url: "ajax-tree-plain.json"
//        },
//        lazyload: function (e, data) {
//            // we can't return values from an event handler, so we
//            // pass the result as `data`attribute.
//            //              data.result = {url: "unit/ajax-sub2.json"};
//            data.result = $.ajax({
//                url: "ajax-sub2.json",
//                dataType: "json"
//            });
//        }
//    });
//    // call methods on multiple instances
//    $("div:ui-fancytree").fancytree("foo", "after init");
//    //
//    $("button").button();
//    $("button#destroy").click(function (e) {
//        $(":ui-fancytree").fancytree("destroy");
//    });
//    $("button#init").click(function (e) {
//        $(".sampletree").fancytree();
//    });
//    $("button#reload").click(function (e) {
//        tree.reload([
//        { title: "node1" },
//        { title: "node2" }
//        ]).done(function () {
//            alert("reloaded");
//        });
//    });
//    $("button#expand").click(function (e) {
//        tree.getNodeByKey("id3").toggleExpand().done(function () {
//            alert("expanded " + this);
//        }).fail(function (errMsg) {
//            alert("failed to expand " + this + ": " + errMsg);
//        });
//    });
//    $("button#setSource").click(function (e) {
//        $(".sampletree").fancytree("option", "source", [
//        { title: "node1" }
//      ]);
//    });
//});

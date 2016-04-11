var filme = [
    "film1","film2","film3"
];

$("#but").click(function () {
    //var indexcur = index;
    var fil = "<li>"+$("#nume").val();
    $("#list").append(fil +"  <button class='remv' >X</button>"+"</li>");
    var fil = "<li>" + $("#nume").val(null);
    $(".remv").click(function(){
        $(this).closest('li').remove();
        

});
});

$("butx").click(function () {
    var fill = $("#nume").val();
    $("li[" + fill + "]").remove();
});



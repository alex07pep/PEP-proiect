
var image = [
    "http://grupwest.ro/chevrolet/images/index/aveo-5d-2010-model-overview-exterior-01.jpg",
    "http://www.chevroletgtt.ro/images/1000x340_spark_exterior_b_03_gge_super-red.jpeg",
    "http://chevrolet-timisoara.ro/images/galerii/1000x340_cruzesw_exterior_01_guf_arctic-blue.jpg",
    "http://www.autotestmagazin.ro/wp-content/uploads/2016/02/designer-la-Ford-23.jpg",
    "http://www.chevrolet-timisoara.ro/images/captiva-5d-2010-model-overview-exterior-04.jpg"
];

var nextBut = document.getElementById("NextB");

var counterN=0;

nextBut.addEventListener('click', function () {
    var poza = document.getElementById("Poza");
    counterN++;
    if (counterN == image.length) {
        counterN = 0;
    }
    
    poza.src = image[counterN];
    

}, false);

var prevBut = document.getElementById("PrevB");

prevBut.addEventListener('click', function () {
    var poza = document.getElementById("Poza");
    counterN--;
    if (counterN < 0) {
        counterN = image.length - 1;
    }

    poza.src = image[counterN];

}, false);

$("#PrevB").css("color", "blue");


var app = angular.module('Lab4', []);

app.controller('MainCtrl', function ($scope) {
    $scope.addEl = '';
    $scope.elements = [{ name: "Blue air", dest: "dest1", status: false }, { name: "tARAS", dest: "2", status: false }, { name: "Wizzard", dest: "ro", status: false }];
    $scope.elements2 = [{ locuri: 50, model: "Bowing 811"}, { locuri:"900", model:"F21" }];
    $scope.addElement = function () {
        $scope.elements.push({ name: $scope.addEl,dest: $scope.addE2, status: false });
        //$scope.elements.name =''
        //$scope.elements.status=false;
    }
    $scope.addElement2 = function () {
        $scope.elements2.push({ locuri: $scope.addE3, model: $scope.addE4});
        //$scope.elements.name =''
        //$scope.elements.status=false;
    }
    $scope.removeElement = function (x) {
        $scope.elements.splice(x, 1);
    }
    //$scope.status = false;
    $scope.checkboxModel = {
        value1: true,
    };




});



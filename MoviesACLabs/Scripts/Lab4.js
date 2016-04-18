var app = angular.module('Lab4', []);

app.controller('MainCtrl', function ($scope) {
    $scope.addEl = '';
    $scope.elements = [{ name: "one", status: false }, { name: "two", status: false }, { name: "three", status: false }];
    $scope.addElement = function () {
        $scope.elements.push({name: $scope.addEl, status: false});
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



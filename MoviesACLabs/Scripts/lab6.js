var app = angular.module('Lab6', []);

app.service("ActorsService", function ($http) {
    this.getActors = function () {
        return $http({
            method: "GET",
            url: "/api/Actors"
        });
    }
    this.postActors = function () {
        return $http({
            method: "POST",
            url: "/api/Actors"
        });
    }
    this.putActors = function () {
        return $http({
            method: "PUT",
            url: "/api/Actors"
        });
    }

});

app.controller('ActorsCtrl', function ($scope, ActorsService) {
    $scope.actorsList = null;
    ActorsService.getActors().then(function (dataResponse) {

        $scope.actorsList = dataResponse.data;
    });
    $scope.UpdateData = function () {
        var data = {
            Name: $scope.Name,
            DateofBirth: $scope.DateofBirth
        };
        $scope.actorsList.push($scope.data);

    };





});

//app.controller('AddCtrl', function ($scope, ActorsService) {

// ActorsService.postActors().then(function (data) {

//$scope.dataResponse.data=data ;
// });

//});




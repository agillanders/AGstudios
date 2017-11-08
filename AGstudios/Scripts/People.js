var app = angular.module('MyApp', []);

app.controller('MainCtrl', ['$scope', '$http',
    function ($scope, $http) {
        $scope.name;

        $http.get("/Rsvp/GetPeople")
            .then(function (response) {
                $scope.person = response.data
            });
    }  
]);
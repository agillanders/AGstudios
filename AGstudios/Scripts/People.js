var app = angular.module('MyApp', []);

app.controller('MainCtrl', ['$scope', '$http', '$window',
    function ($scope, $http, $window) {
        $scope.name;

        $http.get("/Rsvp/GetPeople")
            .then(function (response) {
                $scope.person = response.data
            });

        $scope.confirm = function () {
            $window.alert('Hello!');
        }

        $scope.confirm();
    }
]);
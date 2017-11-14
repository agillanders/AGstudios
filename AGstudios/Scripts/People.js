var app = angular.module('MyApp', []);

app.controller('MainCtrl', ['$scope', '$http', '$window',
    function ($scope, $http, $window) {

        $http.get("/Rsvp/GetPeople")
            .then(function (response) {
                $scope.person = response.data
            });

        $scope.confirm = function (id, confirmed) {
            var data = { PersonID: id, confirmed: confirmed };

            $http.post("/Rsvp/Confirmed", data)
                .then(function (response) {
                    //alert("Saved!");
                });
        }

        $scope.person;

        $scope.reset = function (clickevent) {
            //alert("it's working.");
            var data = $scope.person
            $http.post("/Rsvp/Reset", data)
                .then(function (response) {
                    $scope.refresh();
                });
        }

        $scope.refresh = function () {
            $window.location.reload();
        };

    }
]);


var app = angular.module('MyApp', []);

app.controller('MainCtrl', ['$scope', '$http', '$window',
    function ($scope, $http, $window) {
        $scope.name;

        $http.get("/Rsvp/GetPeople")
            .then(function (response) {
                $scope.person = response.data
            });

        $scope.confirm = function (id, confirmed) {
            //alert(id);
            var data = { PersonID: id, confirmed: confirmed };

            $http.post("/Rsvp/Confirmed", data)
                .then(function (response) {
                    //alert("Saved!");
                });
        }
        
    }
]);


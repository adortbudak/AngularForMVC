angularFormsApp.controller("homeController",
    function ($scope, $location, DataService) {

        DataService.getEmployees().then(function(results) {
            var data = results.data;
        },
        function(results) {
            var data = results.data;
        });

        $scope.showCreateEmployeeForm = function () {
            $location.path('/newEmployeeForm');
        };

        $scope.showUpdateEmployeeForm = function (id) {
            $location.path('/updateEmployeeForm/' + id);
        };
    });
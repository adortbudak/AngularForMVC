angularFormsApp.controller('efController',
    function efController($scope, $window, $routeParams, DataService) {

        if ($routeParams.id)
            $scope.employee = DataService.getEmployee($routeParams.id);
        else
            $scope.employee = {id:0};

        $scope.editableEmployee = angular.copy($scope.employee);

        $scope.departments = [
            "Engineering",
            "Marketing",
            "Finance",
            "Administration"
        ];

        $scope.submitForm = function () {

            if ($scope.editableEmployee.id == 0) {
                DataService.insertEmployee($scope.editableEmployee).then(
                    function(results) {
                        $scope.employee = angular.copy($scope.editableEmployee);
                        $window.history.back();
                    },
                    function(results) {
                        $scope.hasFormError = true;
                        $scope.formErrors = results.statusText;
                    });
            } else {
                DataService.updateEmployee($scope.editableEmployee);
            }


            

        };

        $scope.cancelForm = function() {
            $window.history.back();
        };
    });
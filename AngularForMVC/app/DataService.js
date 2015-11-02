angularFormsApp.factory('DataService',
    function () {
        var getEmployee = function(id) {
            if (id == 123) {
                return {
                    id:123,
                    fullName: "Alper Dortbudak",
                    notes: "Some notes",
                    department: "Engineering",
                    perkCar: true,
                    perkStock: true,
                    perkSixWeeks: true,
                    payrollType: "none"


                };
            }
            return undefined;
        };

        var insertEmployee = function(newEmployee) {
            return true;
        };

        var updateEmployee = function(employee) {
            return true;
        };

        return {
            insertEmployee: insertEmployee,
            updateEmployee: updateEmployee,
            getEmployee:getEmployee
        }

    });
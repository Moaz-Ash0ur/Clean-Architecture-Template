using CleanArchTemp.Domain.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTemp.Domain.Employees
{
    public static class EmployeeErrors
    {
        //excpected error type
        public static Error JobTitleRequired =>
            Error.Validation("Employee_JobTitle_Required", "Employee JobTitle is required");
        
        public static Error EmployeeExists =>
            Error.Conflict("Employee_Email_Exists", "A Employee with this email already exists.");

   
    }
}

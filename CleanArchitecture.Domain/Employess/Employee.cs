using CleanArchTemp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArchTemp.Domain.Employees
{
    public sealed class Employee : AuditableEntity
    {
        public string? JobTitle { get; private set; }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.AppSrv.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int? EmpIdNoZero { get; set; }
        public int? RVEmployeeId { get; set; }
        public string Active { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string FullName { get; set; }
        public string LoginName { get; set; }
        public string SuperLoginName { get; set; }
        public string EMail { get; set; }
        public string Section { get; set; }
        public string Locn { get; set; }
        public string Department { get; set; }
        public string PositionCode { get; set; }
        public string PositionDesc { get; set; }
        public string WorkZone { get; set; }
        public string Building { get; set; }
        public string Phone { get; set; }
        public string GLCode { get; set; }
        public string Status { get; set; }
        public byte[] Picture { get; set; }
        public string AccessiblePositions { get; set; }
        public string AccessibleLogins { get; set; }
        public bool Acting { get; set; }
        public bool Rehire { get; set; }


        public bool EndofEmployment { get; set; }
        public bool AcceptedByHR { get; set; }



        //Boss Information
        [DisplayName("Reports To")]
        [StringLength(50)]
        public string ReportsTo { get; set; }
        public string ReportsToDesc { get; set; }
        public string ReportsToEmpId { get; set; }
        public string ReportsToFirstName { get; set; }
        public string ReportsToLastName { get; set; }
        public string ReportsToPreferredName { get; set; }
        public string ReportsToFullName { get; set; }
        public string ReportsToLogin { get; set; }
        public string ReportsToEMail { get; set; }
        public string ReportsToPhone { get; set; }

        public string ReportsTo2 { get; set; }
        public string ReportsToEmpId2 { get; set; }
        public string ReportsToLogin2 { get; set; }
        public string ReportsToEMail2 { get; set; }
        public string ReportsToPhone2 { get; set; }


        public string ReportsToFirstName2 { get; set; }
        public string ReportsToLastName2 { get; set; }
        public string ReportsToPreferredName2 { get; set; }
        public string ReportsToFullName2 { get; set; }

        public string PositionType { get; set; }

        [DefaultValue(true)]
        public bool HRApproval { get; set; }

        [DefaultValue(true)]
        public bool IsDirectReport { get; set; }
        public string Division { get; set; }

        public string DivisionNum { get; set; }

        //Time and User Id stamp
        public string CreatedUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }

    }
}

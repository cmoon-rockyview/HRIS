using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.TRN
{
    [Table("TrainingRequest", Schema = "TRN")]
    public class TrainingRequest
    {
        public int Id { get; set; }
        public string RequestId { get; set;}
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


        //Mange & ED
        public string MangerEmpId { get; set; }
        public string ManagerFullName { get; set; }
        public string EDEmpId { get; set; }
        public string EDFullName { get; set; }


        //Training Info
        public string TrnName { get; set; }
        public string TrnType { get; set; }
        public string TrnProvider { get; set; }
        public string AchievementType { get; set; }
        public string TrnLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //Trining Options
        public string TrnOption { get; set; }
        public bool DevelopmentGoal { get; set; }
        public bool ReuglarHour { get; set; }
        public bool OutofProvince { get; set; }
        public float TrnHours { get; set; }


        //Details
        public string CoursDetails { get; set; }
        public string RationalForAttending { get; set; }


        //Requestor Info
        public string RequestorLogin { get; set; }
        public DateTime RequestedDate { get; set; }


        //Status
        public string ApprovalStatus { get; set; }
        public string ProgressStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410921896.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    
    {
        public class StudentMetadata
        {
            public int Id{get; set; }
            [Required(ErrorMessage ="請填寫姓名")]
            [Display(Name = "姓名")]
            [StringLength(5,MinimumLength =2,ErrorMessage ="請輸入2~5個字")]
            
            public string name{get; set; }
            [Required(ErrorMessage ="請填寫姓名")]
            [Display(Name ="學號")]
            [StringLength(10,ErrorMessage ="請輸入1~10個字")]

            public string number {get; set; }
            [Required(ErrorMessage ="請填寫Email")]
            [Display(Name ="Email")]
            [EmailAddress]
            public string email{get; set; }

            [Required(ErrorMessage = "必填欄位")]
            [Display(Name = "是否註冊")]

            public bool IsActive{get; set; }
        }
    }
}
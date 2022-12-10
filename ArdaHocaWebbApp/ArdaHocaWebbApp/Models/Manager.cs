using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArdaHocaWebbApp.Models
{
    public class Manager
    {
        public int ID { get; set; }

        public int ManagerTypes_ID { get; set; }
        [ForeignKey("ManagerTypes_ID")]
        public virtual ManagerTypes ManagerTypes { get; set; }


        [Required(ErrorMessage ="Bu Alan Boş Bırakılamaz")]
        [StringLength(50,ErrorMessage ="Bu Alan En Fazla 50 Karakter Alabilir")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Bu Alan En Fazla 50 Karakter Alabilir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        [StringLength(50, ErrorMessage = "Bu Alan En Fazla 50 Karakter Alabilir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        [StringLength(maximumLength:20,MinimumLength =8, ErrorMessage = "Minimum 8 ile 20 Karakter arasında olmalıdır")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        [StringLength(250, ErrorMessage = "Bu Alan En Fazla 250 Karakter Alabilir")]
        public string Mail { get; set; }

        public bool IsActive { get; set; }


    }
}
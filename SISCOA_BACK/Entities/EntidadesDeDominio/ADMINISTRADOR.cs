using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("ADMINISTRADOR_Control", Schema = "USERS")]
    public class ADMINISTRADOR
    {
        [Key]
        public int ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public string BIRTHDAY { get; set; }
    }
}

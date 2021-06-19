using INFRASTRUTUE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MODELS.Entities
{
   public class User:EntityBase
    {
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Email { get; set; } = null;
        public string GitUserName { get; set; } = null;
        public string GitPassword { get; set; } = null;


        //TODO: Get rid of 2 fullname props, 1 that includes title should be enough
        [NotMapped]
        public string FullName
        {
            get => FirstName + (LastName.IsNull() ? string.Empty : " " + LastName);
        }
    }
}

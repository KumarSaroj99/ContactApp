﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactAppFinal.Models
{
    public class Contact
    {
        public virtual Guid ContactId { get; set; } 

        public virtual string FName { get; set; }

        public virtual string LName { get; set; }

        public virtual bool IsActive { get; set; } = true;
        public virtual User User { get; set; }

        public virtual IList<ContactDetail> ContactDetail { get; set; } = new List<ContactDetail>();

        
    }
}
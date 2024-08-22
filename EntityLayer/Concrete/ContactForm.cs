using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactForm : BaseEntity
    {
        public string ContactFormName { get; set; }
        public string ContactFormPhone { get; set; }
        public string ContactFormEmail { get; set; }
        public string ContactFormMessage { get; set; }
    }
}

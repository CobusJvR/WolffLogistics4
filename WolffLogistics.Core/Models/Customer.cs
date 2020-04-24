using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolffLogistics.Core.Models
{
    public class Customer : BaseEntity
    {
        [DisplayName("Acc No")]
        public string AccountNumber { get; set; }
        [DisplayName("Company")]
        public string CompanyName { get; set; }
        [DisplayName("Registration No")]
        public string RegistrationNumber { get; set; }
        [DisplayName("VAT No")]
        public string VatNumber { get; set; }
        [DisplayName("Tel No")]
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}

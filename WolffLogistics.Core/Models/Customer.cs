using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolffLogistics.Core.Models
{
    public class Customer : BaseEntity
    {
        public string AccountNumber { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNumber { get; set; }
        public string VatNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}

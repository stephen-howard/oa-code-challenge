using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerDomainModel
{
  
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {
        // partial class to apply data annotations
        // with ef if data annotations are applied on ef generated classes will be overwritten
    }

    public class CustomerMetaData
    {
        [Required(ErrorMessage="Last Name is Required")]
        [StringLength(15,MinimumLength=3, ErrorMessage = "Last Name can not be more than 15 chars")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "First Name can not be more than 15 chars")]
        public string FirstName { get; set; }

        [StringLength(250,ErrorMessage= "Address can not be more than 250 chars")]
        public string Address { get; set; }

        [Range(0,9999,ErrorMessage="Pin Code must be between 0 to 9999")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "PostalCode must be number(s)")]
        public string PostalCode { get; set; }

        [StringLength(13, ErrorMessage= "ID Number can not be more than 13 chars")]
        public string IDNumber { get; set; }

        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int CustomerID { get; set; }
    }
}

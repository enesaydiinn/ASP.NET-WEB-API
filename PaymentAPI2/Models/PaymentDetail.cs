using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI2.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName="nvarChar(100)")]
        public string CardOwnerName { get; set; }
        [Column(TypeName = "nvarChar(16)")]
        public string CardNumber { get; set; }
        [Column(TypeName = "nvarChar(5)")]
        public string ExpirationDate { get; set; }
        [Column(TypeName = "nvarChar(3)")]
        public string SecurityCode { get; set; }


    }
}

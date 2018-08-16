//using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace App.Mobile.Droid.Models
{
    public class OutputDetail
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public int OutputId { get; set; }
        public string Warehouse { get; set; }
        public string ConcatTrannsaction { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityAvailable { get; set; }
    }
}

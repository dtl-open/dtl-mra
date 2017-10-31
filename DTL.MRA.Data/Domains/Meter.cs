using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTL.MRA.Data.Domains
{
    public class Meter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeterId { get; set; }
        public string SerialId { get; set; }
        public string Provider { get; set; }
        public string Icp { get; set; }

        public List<MeterRead> MeterReads { get; set; }
        public Customer Customer { get; set; }
    }
}

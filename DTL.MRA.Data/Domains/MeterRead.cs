using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTL.MRA.Data.Domains
{
    public class MeterRead
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MeterReadId { get; set; }
        public string MeterNumber { get; set; }
        public int Provider { get; set; }
        public long ReadingTime { get; set; }
        public double Reading { get; set; }

        public Meter Meter { get; set; }
    }
}

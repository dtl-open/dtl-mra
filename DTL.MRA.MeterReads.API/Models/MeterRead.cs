using System;
using System.ComponentModel.DataAnnotations;

namespace DTL.MRA.MeterReads.API.Models
{
    public class MeterRead
    {
        public Guid MeterReadId { get; set; }
        public string MeterNumber { get; set; }
        public int Provider { get; set; }
        public long ReadingTime { get; set; }
        public double Reading { get; set; }
    }
}

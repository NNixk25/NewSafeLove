using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class DiseaseDescriptions
    {
        public string? Disease_Subcription { get; set; } //คำอธิบายโรค
        public string? Disease_Cause { get; set; } //สาเหตุ
        public string? Disease_Treatment { get; set; } //การรักษา
        public string? Disease_Prevention { get; set; } //การป้องกัน
        public string? VideoUrl { get; set; }
    }
}

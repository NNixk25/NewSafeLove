using System;

namespace MauiApp1.Models
{
    public class Disease
    {
        public string Name { get; set; } = "";
        public string? Symptom { get; set; } //อาการ
        public string? Cause { get; set; } //สาเหตุ
        public string? Treatment { get; set; } //การรักษา
        public string? Prevention { get; set; } //การป้องกัน
    }
}
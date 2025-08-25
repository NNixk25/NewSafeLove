using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class CardModel
    {
        public string Title { get; set; } = "";
        public string? Subtitle { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string[] Tags { get; set; } = [];
    }
}

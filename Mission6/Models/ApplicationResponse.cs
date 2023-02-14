using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class ApplicationResponse
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public ushort Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public int LentTo { get; set; }
        public string Notes { get; set; }
    }
}

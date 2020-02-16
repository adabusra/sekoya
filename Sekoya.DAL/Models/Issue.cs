using System;
using System.Collections.Generic;

namespace Sekoya.DAL.Models
{
    public partial class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
    }
}

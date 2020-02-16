using System;
using System.Collections.Generic;

namespace Sekoya.DAL.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public DateTime InsertTime { get; set; }
        public string UserName { get; set; }
    }
}

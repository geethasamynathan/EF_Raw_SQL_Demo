using System;
using System.Collections.Generic;

namespace EF_Raw_SQL_Demo.Models
{
    public partial class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Model.EmployeeModelDTO
{
    public class DemandDTO
    {
        public int Id { get; set; }
        public string DemandType { get; set; }
        public string SubPageId { get; set; }
        public string Description { get; set; }
        public string PageUrL { get; set; }
        public string Icon { get; set; }
    }
}

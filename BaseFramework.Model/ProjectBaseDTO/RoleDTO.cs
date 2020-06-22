﻿using BaseFramework.Model.CompanyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Model.ProjectBaseDTO
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool IsSystemRole { get; set; }

        public  List<UserCompanyDTO> UserCompanies { get; set; }

        public  List<PageDTO> Pages { get; set; }

    }
}

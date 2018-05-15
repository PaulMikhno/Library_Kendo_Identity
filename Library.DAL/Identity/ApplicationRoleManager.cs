﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Library.DAL.Entities;
namespace Library.DAL.Identity
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
       public ApplicationRoleManager(RoleStore<ApplicationRole> store)
         : base(store)
       { }
   }
}

﻿using employee_management_system.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system
{
    //Create a set of default roles and users upon startup
    public static class SeedRolesAndUsers
    {
        public static void Seed(UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager) 
        {
            //create roles before assigning it to a user
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }


        //creating admin user
        private static void SeedUsers(UserManager<Employee> userManager)
        {
            _ = userManager.GetUsersInRoleAsync("Employee").Result;

            if (userManager.FindByNameAsync("admin@email.com").Result == null)
            {
                var user = new Employee
                {
                    UserName = "admin@email.com",
                    Email = "admin@email.com",
                    
                };

                // TODO: change admin default passowrd before launch or have admin change it
                var userCreate = userManager.CreateAsync(user, "Password1!").Result;

                if (userCreate.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }

            
        }

        //creating initial user roles admin and employee where employee isn't an admin
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var newRole = new IdentityRole
                {
                    Name = "Administrator"
                };
                _ = roleManager.CreateAsync(newRole).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var newRole = new IdentityRole
                {
                    Name = "Employee"
                };
                _ = roleManager.CreateAsync(newRole).Result;
            }
        }
    }
}

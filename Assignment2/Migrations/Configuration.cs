namespace Assignment2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Assignment2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Models.VisitorLogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment2.Models.VisitorLogContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Users.AddOrUpdate(u => u.UserID,
            new User()
            {
                UserID = 1,
                Email = "ian@home.com",
                FirstName = "Ian",
                LastName = "Bansenauer",
                LoggedIn = true,
                ProgramID = 3,
                EmailUpdates = false,
                Password = "password"
            },
            new User()
            {
                UserID = 2,
                Email = "Amelia@gmail.com",
                FirstName = "Amelia",
                LastName = "Jarr",
                LoggedIn = false,
                ProgramID = 2,
                EmailUpdates = false,
                Password = "secretword"
            }
            );

            context.Programs.AddOrUpdate(p => p.ProgramID,
            new Program()
            {
                ProgramID = 1,
                ProgramName = "Web Developer Degree"
            },
            new Program()
            {
                ProgramID = 2,
                ProgramName = "Sustainable Practices Degree"
            },
            new Program()
            {
                ProgramID = 3,
                ProgramName = "Mobile Developer Degree"
            },
            new Program()
            {
                ProgramID = 4,
                ProgramName = "Network Technology Degree"
            }
            );
        }
    }
}

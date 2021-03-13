using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ClientLibrary.Models;
using ClientLibrary.Enums;

using Microsoft.EntityFrameworkCore;

namespace ClientAPI.Data
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Client>().HasData(
                new
                {
                    ClientId = Guid.NewGuid().ToString(),
                    Name = "TechMedia",
                    Address = "Manstead House, york Way, W1 6XT",
                    NumberOfUsers = 14,
                    Support = SupportModel.Rolling.ToString()
                },
                  new
                  {
                      ClientId = Guid.NewGuid().ToString(),
                      Name = "DataSolutions",
                      Address = "14 Runway Drive, Pudding Lane, E1 1TT",
                      NumberOfUsers = 8,
                      Support = SupportModel.PayasYouGo.ToString()
                  },
                    new
                    {
                        ClientId = Guid.NewGuid().ToString(),
                        Name = "Infranology",
                        Address = "1-4 Nobal Street, Berks, BK1 8QS",
                        NumberOfUsers = 4,
                        Support = SupportModel.None.ToString()
                    }
                );
        }
    }
}

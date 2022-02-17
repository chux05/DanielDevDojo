using DanielDevDojo.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielDevDojo.Server
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Wakefield",
                    Age = 18,
                    Location = "London"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Lisa",
                    LastName = "Manda",
                    Age = 18,
                    Location = "Dee"
                },
                 new Person
                 {
                     Id = 3,
                     FirstName = "Bob",
                     LastName = "Wakefield",
                     Age = 18,
                     Location = "London"
                 },
                 new Person
                 {
                     Id = 4,
                     FirstName = "Victor",
                     LastName = "Crest",
                     Age = 26,
                     Location = "London"
                 }


        );
        }
    }
}

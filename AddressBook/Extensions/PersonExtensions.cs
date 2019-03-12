using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddressBook.Models;
using AddressBook.ViewModels;

namespace AddressBook.Extensions
{
    public static class PersonExtensions
    {
        public static Person ToModel(this IPersonViewModel personVm)
        {
            return new Person
            {
                Name = personVm.Name,
                Surname = personVm.Surname,
                Age = personVm.Age,
            };
        }
    }
}

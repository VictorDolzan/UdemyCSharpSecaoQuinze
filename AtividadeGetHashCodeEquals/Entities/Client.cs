using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeGetHashCodeEquals.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client()
        {
            
        }       
        public Client(string externalName, string externalEmail)
        {
            Name = externalName;
            Email = externalEmail;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Prog3_2023
{
    internal class Persona
    {
        string _var1 = "tiene";
        string _var2 = "una";
        string _var3 = "string";    
        string _var4 = "diferente";    
        string _var5 = "para";
        string _var6 = "que";    
        string _var7 = "sea";    
        string _var8 = "mas";    
        string _var9 = "pesado";

        public int Id { get; set; } 
        public string Name { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Dni {get; set; }
        public string Telefono { get; set; }    
        public string AlgunDato { get; set; }   
        public string OtroDato { get; set; }    
        public string TipoDato { get;set; } 
        public string ConDiezAlcanza { get; set; }

        public Persona(int id, string name, string firstName, string lastName, string dni, string telefono, string algunDato, string otroDato, string tipoDato, string conDiezAlcanza)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Dni = dni;
            Telefono = telefono;
            AlgunDato = algunDato;
            OtroDato = otroDato;
            TipoDato = tipoDato;
            ConDiezAlcanza = conDiezAlcanza;
        }

    }
}

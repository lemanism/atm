using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Card CreditCard { get; set; }

    public User(string name, string surname, Card card) {
        Name = name;
        Surname = surname;
        CreditCard = card;
    
    }

}


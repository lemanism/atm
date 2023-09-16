using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

public class Card
{

    public string PAN { get; set; }
    public string PIN { get; set; }
    public string CVC { get; set; }
    public string ExpireDate { get; set; }
    public double Balance { get; set; }

    public Card(string pan, string pin, string cvc, string expdate, double bal)
    {
        PAN = pan;
        PIN = pin;
        CVC = cvc;
        ExpireDate = expdate;
        Balance = bal;
    }



}


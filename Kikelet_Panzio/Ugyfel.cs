using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kikelet_Panzio
{
    
    internal class Ugyfel
    {
        string userID;
        string username;
        DateTime birthdate;
        string email;
        bool isVIP;

        public Ugyfel(string userID, string username, DateTime birthdate, string email, bool isVIP)
        {
            UserID = userID;
            Username = username;
            Birthdate = birthdate;
            Email = email;
            IsVIP = isVIP;
        }

        public Ugyfel(string sor)
        {
            string[] adatok = sor.Split(';');
            UserID = adatok[0];
            Username = adatok[1];
            Birthdate = DateTime.Parse(adatok[2]);
            Email = adatok[3];
            IsVIP = bool.Parse(adatok[4]);
        }


        public string UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Email { get => email; set => email = value; }
        public bool IsVIP { get => isVIP; set => isVIP = value; }

        public override string ToString()
        {
            return $"{UserID}, {Username}, {Birthdate}, {Email}, {IsVIP}";
        }
    }
}

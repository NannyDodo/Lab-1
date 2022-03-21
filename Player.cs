using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Player
    {
        char PlayerId;
        char LastName;
        char FirstName;
        char Gender;
        decimal Height;
        decimal Weight;
        char ShirtNumber;
        char Email;
        char CountryCode;
        int TeamId;

        public void set(char PlayerId, char LastName, char FirstName, char Gender, decimal Height,decimal Weight, char ShirtNumber, char Email, char CountryCode, int TeamId)
        {
            this.PlayerId = PlayerId;
            this.LastName = LastName; 
            this.FirstName = FirstName; 
            this.Gender = Gender; 
            this.Height = Height; 
            this.Weight = Weight; 
            this.ShirtNumber = ShirtNumber; 
            this.Email = Email;
            this.CountryCode = CountryCode;
            this.TeamId = TeamId;

              }
    }
}

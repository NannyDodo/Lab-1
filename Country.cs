using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Country
    {
        string countryCode;
        string countryName;

        //todo Сделать через инициализацию
        public void set(string countryCode, string countryName)
        { 
        this.countryCode = countryCode;
        this.countryName = countryName;
        }
     
    }
}

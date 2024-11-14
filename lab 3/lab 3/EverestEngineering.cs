using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class EverestEngineering
    {
        string name;
        string address;
        int totalStudent;
        string principalName;

        public EverestEngineering( string name, string address, int totalStudent, string principalName)
        {
            this.name = name;
            this.address = address;
            this.totalStudent = totalStudent;
            this.principalName = principalName;
        }

        public string writeName()
        {
            return name;
        }
        public string writeAddress()
        {
            return address;
        }
        public string writePrincipalName()
        {
            return principalName;
        }

        public int writeTotalStudent()
        {
            return totalStudent;
        }

        public string introduceString()
        {
            return ("Hello, my name is " + this.writeName() + " and I live in " + this.writeAddress() + ". \nI have " + this.writeTotalStudent() + " number of friends.\nMy principal name is " + this.writePrincipalName());
        }

    }
}

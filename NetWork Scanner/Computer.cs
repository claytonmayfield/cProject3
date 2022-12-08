using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWork_Scanner
{
    internal class Computer
    {

        private readonly string _name;
        private readonly string _ipAddress;
        private int _services;
        private int _services1;
        private int _services2;
        private int _services3;
        private int _services4;
        private int _services5;
        private int _services6;
        private int _services7;
        private int _services8;

        public Computer (string name, string ipAddress, int services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }
        public Computer(string name, string ipAddress, int services, int services1,int services2, int services3, int services4, int services5, int services6, int services7, int services8)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
            _services1 = services1;
            _services2 = services2;
            _services3 = services3;
            _services4 = services4;
            _services5 = services5;
            _services6 = services6;
            _services7 = services7;
            _services8 = services8;

        }
        public Computer(string name, string ipAddress, int services, int services1, int services2)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
            _services1 = services1;
            _services2 = services2;
        }
        public string GetName()
            { return _name; }
        public string GetIpAddress()
            { return _ipAddress; }
        public int GetServices()
            { return _services; }
        public int GetServices1()
        { return _services1; }
        public int GetServices2()
            { return _services2; }
        public int GetServices3()
            { return _services3; }
        public int GetServices4()
            { return _services4; }
        public int GetServices5()
            { return _services5; }
        public int GetServices6()
            { return _services6; }
        public int GetServices7()
            { return _services7; }
        public int GetServices8()
            { return _services8; }







    }
}

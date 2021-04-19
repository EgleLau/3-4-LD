﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD
{
    class Studentas
    {
        private String vardas;
        private String pavarde;
        private List<int> nd;
        private int egzaminas;

        public Studentas()
        {
            Console.WriteLine("Iveskite varda");
            vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde");
            pavarde = Console.ReadLine();
            nd = new List<int>();
        }

        public Studentas(String a, String b)
        {
            vardas = a;
            pavarde = b;
            nd = new List<int>();
        }

        public String getVardas()
        {
            return this.vardas;
        }

        public String getPavarde()
        {
            return this.pavarde;
        }

        public void setEgzaminas(int a)
        {
            if (a > 0 && a <= 10) this.egzaminas = a;
        }

        public int getEgzaminas()
        {
            return this.egzaminas;
        }

        public void setNewPazimys(int a)
        {
            if (a > 0 && a <= 10) this.nd.Add(a);
        }

        public List<int> getND()
        {
            return this.nd;
        }

    }
}

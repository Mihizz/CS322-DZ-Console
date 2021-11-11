using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ_Console
{
    class Posetioc
    {
        private String ime;
        private String prezime;
        private int brojUlaznice;

        public Posetioc(String ime, String prezime, int brojUlaznice)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojUlaznice = brojUlaznice;
        }

        public String getIme() { return ime; }
        public void setIme(String value) { ime = value; }

        public String getPrezime() { return prezime; }
        public void setPrezime(String value) { prezime = value; }

        public int getBrojUlaznice() { return brojUlaznice; }
        public void setBrojUlaznice(int value) { brojUlaznice = value; }

        public void stampanje()
        {
            Console.WriteLine("Ime: " + ime + ", Prezime: " + prezime + ", Broj ulaznice: " + brojUlaznice);
        }
    }
}
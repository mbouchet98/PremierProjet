using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremierProjet
{
    public class Maire
    {
        private string NomMaire;
        private string PrenomMaire;
        private DateTime DateElectionDuMaire;
        private int Mairie;
       

        public Maire(string leNomMaire, string leprenomMaire, DateTime laDateElectionDuMaire, int laMairie)
        {
            NomMaire = leNomMaire;
            PrenomMaire = leprenomMaire;
            DateElectionDuMaire = laDateElectionDuMaire;
            Mairie = laMairie;
        }

        
        public string gsNomMaire
        {
            get
            {
                return NomMaire;
            }
            set
            {
                NomMaire = value;
            }

        }
        public string gsPrenomMaire
        {
            get
            {
                return PrenomMaire;
            }
            set
            {
                PrenomMaire = value;
            }
        }
        public DateTime gsDateElectionDuMaire
        {
            get
            {
                return DateElectionDuMaire;
            }
            set
            {
                DateElectionDuMaire = value;
            }
        }
        public int gsMairie
        {
            get
            {
                return Mairie;
            }
            set
            {
                Mairie = value;
            }
        }

        

    }
}
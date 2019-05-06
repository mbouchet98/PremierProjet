using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremierProjet
{
    public class Mairie
    {
        private int Id;
        private string nom;
        private string adresse;
        private int numEmployer;

        public Mairie(int lId, string leNom, string ladresse)
        {
            Id = lId;
            nom = leNom;
            adresse = ladresse;

        }
        public Mairie(int lId, string leNom, string ladresse, int leNumEmployer)
        {
            Id = lId;
            nom = leNom;
            adresse = ladresse;
            numEmployer = leNumEmployer;
        }

        public string gsNom1
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public int gsId1
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string gsAdresse1
        {
            get
            {
                return adresse; 
            }
            set
            {
                adresse = value;
            }
        }
        
        
        public int gsNumEmployer
        {
            get
            {
                return numEmployer;
            }
            set
            {
                numEmployer = value;
            }
        }
    }


}
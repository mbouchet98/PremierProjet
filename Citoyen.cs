using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremierProjet
{
    public class Citoyen
    {
        private String nom;
        private String prenom;
        private  DateTime DateDeNaissance;
        private String adresse;
        private String email;
        private long numTel;

        public Citoyen(string leNom, string leprenom, DateTime laDateDeNaissance, string ladresse, string lemail, long lenumTel)
        {
            nom = leNom;
            prenom = leprenom;
            DateDeNaissance = laDateDeNaissance;
            adresse = ladresse;
            email = lemail;
            numTel = lenumTel;


        }

        public string gsNom
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
        public string gsPrenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }
        public DateTime gsDateDeNaissance
        {
            get
            {
                return DateDeNaissance;
            }
            set
            {
                DateDeNaissance = value;
            }
        }
        public string gsAdresse
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
        public string sgEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public long gsNumTel
        {
            get
            {
                return numTel;
            }
            set
            {
                numTel = value;
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class Produit
    {
       
        public int Cpu { get; set; }
        public string Nom_Produit { get; set; }

         public Categorie_Produit Categorie { get; set; }
        public string Description { get; set; }

        public double Prix_Unitaire { get; set; }

        //public int Quantite { get; set; }



        public Produit()
        {

        }

        public Produit(int cpu, string nom, Categorie_Produit cat, string des,double pu)
        {
            
            this.Cpu = cpu;
            this.Nom_Produit = nom;
            this.Categorie = cat;
            this.Description = des;
            this.Prix_Unitaire = pu;
            

        }

        public override string ToString()
        {
            return Nom_Produit + " : " + Description + " prix unitaire : " + Prix_Unitaire + " euros";
        }

        public override bool Equals(Object obj)
        {
        return obj is Produit && Cpu == ((Produit)obj).Cpu;
    }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    //public Produit  creerProduit(int cpu, string nom, string des, double pu, int qte)
    //{

    //    FabriqueProduit fabprod = new FabriqueProduit();
    //    Produit prod1 = fabprod.CreerProduit(cpu, nom, des, pu, qte);
    //    return prod1;
        

    //}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldSystemet
{
    public class Studerende
    {
        int _id;
        string _navn;
        string _adresse;
        string _CPR;

        #region ID
        public int ID //Studerende ID
        {
            get 
            { 
                return _id; 
            } 
            private set 
            { 
                if (value < 0)
                {
                    string errMsg = "ID kan ikke være mindre end 1 ";
                    throw new Exception(errMsg);
                }
                else
                {
                    _id = value;
                }
            }

            
        }
        #endregion

        #region Navn
        public string Navn
        {
            get
            {
                return _navn;
            }
            private set
            {
                if (value.Length < 2)
                {
                    string errMsg = "Navn er ikke godkendt";
                    throw new Exception(errMsg);
                }
                else
                {
                    _navn = value;
                }

            }
        }//Studerende Navn
        #endregion

        #region Adresse
        public string Adresse // Studerende Adresse
        { 
            get 
            { 
                return _adresse; 
            }
            private set 
            { 
                _adresse = value; 
            } 
        }
        #endregion

        #region CPRNummer
        public string CPRNummer // Studerende CPR
        {
            get
            {
                return _CPR;
            }
            private set
            {
                if (value.Length < 10)
                {
                    string errMsg = "CPR nummer skal Være 10 nummer ";
                    throw new Exception(errMsg);
                }
                if (value.Length > 10)
                {
                    string errMsg = "CPR nummer skal Være 10 nummer ";
                    throw new Exception(errMsg);
                }
                else
                {
                    _CPR = value;
                }
            }
        }
        #endregion
        public Studerende(int iD, string navn, string addresse, string Cpr )
        {
            //Opgave 1
            ID = iD;
            Navn = navn;
            Adresse = addresse;
            CPRNummer = Cpr;

        }
        public override string ToString()
        {
            return $"ID: {ID}, Navn: {Navn}, Adreese: {Adresse}, CPR: {CPRNummer}";
        }
    }
}

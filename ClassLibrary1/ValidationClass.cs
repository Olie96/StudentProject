using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Breznjak_Student_project
{

    public class ValidationClass
    {
        public bool EnteredOperationVerifier(string operation)  
        {
            return Regex.IsMatch(operation, @"^[\p{L}]+$");
        }// funkcija koja provjerava ispravnost stringa zeljene operacije

        public string ChosenOperation(string operation)   // funkcija za provjeru izabrane operacije
        {
            if (operation.Equals((Operations.OperationDisplay), StringComparison.InvariantCultureIgnoreCase))
                return Operations.OperationDisplay;
            else if (operation.Equals((Operations.OperationEnlist), StringComparison.InvariantCultureIgnoreCase))
                return Operations.OperationEnlist;
            return null;  
        }

        public bool NameSurnameCheck(string nameSurname)
        {
            return Regex.IsMatch(nameSurname, @"^[\p{L}]+$");
        }    // funkcija koja provjerava ispravnost unesenog imena ili prezimena
    }
}

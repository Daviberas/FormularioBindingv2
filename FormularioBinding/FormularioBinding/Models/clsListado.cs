using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FormularioBinding.Models
{
    public class clsListado
    {
        public ObservableCollection<clsPersona> getListado()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();
            
            lista.Add(new clsPersona(1,"David", "Benítez Rasero", new DateTime(1996,1,23),"adfhilaubaelr","666666666"));
            lista.Add(new clsPersona(2,"Makoto", "Naegi", new DateTime(2000, 5, 26), "asfhglaerfgo", "999999999"));
            lista.Add(new clsPersona(3,"Sayaka", "Maizono", new DateTime(2000, 7, 2), "adjklfhbl", "888888888"));
            lista.Add(new clsPersona(4,"Kyouko", "Kirigiri", new DateTime(2000, 4, 15), "dkfhbsdlf", "555555555"));

            return lista;
        }
    }
}
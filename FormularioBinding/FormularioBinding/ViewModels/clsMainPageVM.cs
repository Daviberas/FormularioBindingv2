using FormularioBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioBinding.ViewModels
{
    public class clsMainPageVM
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
            }
        }
        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }
        }

        public clsMainPageVM()
        {
            clsListado lista = new clsListado();
            _listado = lista.getListado();
        }
    }
}

using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoMaui.VM
{
    public class MostrarMisiones : INotifyPropertyChanged
    {
        #region atributos

        private ClsMision misionSelecionada;

        private List<ClsMision> listadoMisiones;

        #endregion

        #region Propiedades

        public List<ClsMision> ListadosMisiones
        {
            get { return listadoMisiones; }
            set
            {
                listadoMisiones = ClsListadoBL.listadoMisionesBL();
            }
        }

        public ClsMision MisionSelecionada
        {
            get { return misionSelecionada; }
            set { 
                misionSelecionada = value;
                NotifyPropertyChanged("MisionSelecionada");
            }
            
        }

        #endregion

        #region Metodos

       

        #endregion


        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion
    }
}

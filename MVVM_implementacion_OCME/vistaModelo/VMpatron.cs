using MvvmGuia.VistaModelo;
using System;
using MVVM_implementacion_OCME.Modelo;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_OCME.vistaModelo
{
    internal class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuario> Listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Alerta(Musuario parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }

        public void Mostrarusuarios()
        {
            Listausuarios = new List<Musuario>
            {
                new Musuario
                {
                    Nombre = "Frank",
                    Imagen = "https://www.flaticon.es/iconos-gratis/pizza"
                },
                new Musuario
                {
                    Nombre = "Juan",
                    Imagen = "https://www.flaticon.es/iconos-gratis/pizza"
                },
                new Musuario
                {
                    Nombre = "Carlos",
                    Imagen = "https://www.flaticon.es/iconos-gratis/pizza"
                }
            };
        }
        #endregion

        #region COMANDOS
        public ICommand Alertacommand => new Command<Musuario>(async (p) => await Alerta(p));
        public ICommand Volvercommand => new Command(Mostrarusuarios);
        #endregion
    }
}
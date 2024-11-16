using MVVM_implementacion_OCME.Modelo;
using MVVM_implementacion_OCME.Vista;
using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_OCME.vistaModelo
{
    internal class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> Listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            
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
       
        public void Mostrarusuarios()
        {
            Listausuarios = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://www.flaticon.es/iconos-gratis/pizza"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a base de datos",
                    Icono = "https://www.flaticon.es/iconos-gratis/pizza"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://www.flaticon.es/iconos-gratis/pizza"
                }
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina = parametros.Pagina;

            if (pagina.Contains("entry, datepicker"))
            {
                // Verifica que Pagina1 hereda de Xamarin.Forms.Page
                await Navigation.PushAsync(new Pagina1());
            }
            else if (pagina.Contains("CollectionView sin enlace"))
            {
                // Verifica que Page2 hereda de Xamarin.Forms.Page
                await Navigation.PushAsync(new Pagina2());
            }
            else if (pagina.Contains("Crud pokemon"))
            {
                // Verifica que Crudpokemon hereda de Xamarin.Forms.Page
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Commands;

using Xamarin.Forms;

namespace MobileXamarin
{
    public partial class MainPage : ContentPage
    {
        public bool _inicioIsVisible { get; set; } = true;
        public bool _finalizacionIsVisible { get; set; } = false;


        public bool toggleFecha { get; set; } = false;
        public DateTime? Contenedor_FechaEntrada { get; set; } = null;

        //public DelegateCommand showHide { get; set; }
        public MainPage()
        {
            InitializeComponent();
            this.labelFechaEntrada.Text = string.Empty;
            this.fechaEntrada.Text = string.Empty;
            //this.fechaEntrada.Text =DateTime.Now.ToString("dd MMM yyyy, HH:ss");
            _inicioIsVisible = true;
            _finalizacionIsVisible = !_inicioIsVisible;
            this.txtBruto.Text = "999";
            this.txtRemito.Text = "R-001";
            this.txtObservaciones.Text = "observacion asd";
            this.txtButton.Text = "Inicio";

            //showHide = new DelegateCommand(() => InicioIsVisible = !InicioIsVisible);
        }

        public bool InicioIsVisible
        {
            get { return _inicioIsVisible; }
            set
            {
                _inicioIsVisible = value;
                //RaisePropertyChanged("InicioVisible"); 
            }
            // set { this.SetProperty(ref this._inicioIsVisible)}        
        }
        public bool FinalizacionIsVisible
        {
            get { return _inicioIsVisible; }
            set
            {
                _inicioIsVisible = value;
                OnPropertyChanged(); 
                //RaisePropertyChanged("InicioVisible"); 
            }
            // set { this.SetProperty(ref this._inicioIsVisible)}        
        }
        private void CargarButtonClicked(object sender, EventArgs e)
        {
            
            toggleFecha = !toggleFecha;

            if (toggleFecha) Contenedor_FechaEntrada = DateTime.Now;
            else Contenedor_FechaEntrada = null;

            if (Contenedor_FechaEntrada is null)
            {
                this.txtButton.Text = "Iniciar";
                this.labelFechaEntrada.Text = string.Empty;
                this.fechaEntrada.Text = string.Empty;
            }
            else
            {
                this.txtButton.Text = "Finalizar";
                this.labelFechaEntrada.Text = "Fecha Entrada : ";
                this.fechaEntrada.Text = DateTime.Now.ToString("dd/MM/yy, HH:ss");
            }

            //if (!ValidaForm()) return;
            //var cm = new ContenedorMovimiento()
            //{
            var EstadoId = (int)EstadoControlCargaEnum.Finalizado;
            //};
            //CargarServiceAgent(cm);
        }
        private void CargarFinalizacionClicked(object sender, EventArgs e)
        {
            //showHide = new DelegateCommand(() => InicioIsVisible = !InicioIsVisible);
            //InicioIsVisible = false;
            //_inicioIsVisible = false;
            //if (!ValidaForm()) return;
            //var cm = new ContenedorMovimiento() { EstadoId = (int)EstadoControlCargaEnum.Finalizado };
            //CargarServiceAgent(cm);

        }
    }
    public enum EstadoControlCargaEnum
    {
        Pendiente = 452,
        Activo = 450,
        Finalizado = 451,

    }
}

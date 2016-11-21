using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Puertas_Lógicas.UserControls
{
    public sealed partial class PuertaAnd : UserControl,INotifyPropertyChanged
    {

        // Using a DependencyProperty as the backing store for entradaA.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty entradaAProperty =
            DependencyProperty.Register("entradaA", typeof(Boolean), typeof(PuertaAnd), new PropertyMetadata(false,new PropertyChangedCallback(cambiaResultado)));

        private static void cambiaResultado(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PuertaAnd pa = (PuertaAnd)d;
            pa.cambiaResultadoOO();
        }

        private void cambiaResultadoOO()
        {
            salida = entradaA && entradaB;
        }


        // Using a DependencyProperty as the backing store for entradaA.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty entradaBProperty =
            DependencyProperty.Register("entradaB", typeof(Boolean), typeof(PuertaAnd), new PropertyMetadata(false, new PropertyChangedCallback(cambiaResultado)));

        private Boolean salida;

        public event PropertyChangedEventHandler PropertyChanged;

        public Boolean entradaA
        {
            get { return (Boolean)GetValue(entradaAProperty); }
            set { SetValue(entradaAProperty, value); }
        }

        public Boolean entradaB
        {
            get { return (Boolean)GetValue(entradaBProperty); }
            set { SetValue(entradaBProperty, value); }
        }

        public Boolean Salida
        {
            get { return (entradaA && entradaB); }
            set {
                salida =value;
                OnPropertyChanged("CambioSalida");

            }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(v));
            }
        }

        public PuertaAnd()
        {
            this.InitializeComponent();
        }
    }
}

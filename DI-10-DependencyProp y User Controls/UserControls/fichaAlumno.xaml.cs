using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace DI_10_DependencyProp_y_User_Controls.UserControls
{
    public sealed partial class fichaAlumno : UserControl
    {


        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NombreProperty =
            DependencyProperty.Register("Nombre", typeof(string), typeof(fichaAlumno), new PropertyMetadata("Defecto"));

        public static readonly DependencyProperty EdadProperty =
            DependencyProperty.Register("Edad", typeof(int), typeof(fichaAlumno), new PropertyMetadata(0));

        public static readonly DependencyProperty ImagenProperty =
            DependencyProperty.Register("Imagen", typeof(ImageSource), typeof(fichaAlumno), new PropertyMetadata(
                new BitmapImage(new Uri("ms-appx://DI_10_DependencyProp_y_User_Controls/Assets/anonimus.jpg", UriKind.RelativeOrAbsolute))));

        public string Nombre
        {
            get { return (string)GetValue(NombreProperty); }
            set { SetValue(NombreProperty, value); }
        }


        public int Edad
        {
            get { return (int)GetValue(EdadProperty); }
            set { SetValue(EdadProperty, value); }
        }

        public ImageSource Imagen
        {
            get { return (ImageSource)GetValue(ImagenProperty); }
            set { SetValue(ImagenProperty, value); }
        }




        public fichaAlumno()
        {
            this.InitializeComponent();
        }
    }
}

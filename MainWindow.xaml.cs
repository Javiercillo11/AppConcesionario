using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace concesionario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Coches> HyundaiTucson = new List<Coches>();
        List<Coches> HyundaiSantaFe = new List<Coches>();
        List<Coches> HyundaiI30 = new List<Coches>();
        List<Coches> Peugeot3008 = new List<Coches>();
        List<Coches> Peugeot5008 = new List<Coches>();
        List<Coches> Peugeot2008 = new List<Coches>();
        List<Coches> KiaSportage = new List<Coches>();
        List<Coches> KiaSeltos = new List<Coches>();
        List<Coches> KiaSorrento = new List<Coches>();
        Extras extras = new Extras("Extra1", "Extra2", "Extra3", "Extra4");
        public MainWindow()
        {
            InitializeComponent();

            Peugeot3008.Add(new Coches("Peugeot", "3008", "Allure", "Gasolina", "15000€", extras));
            Peugeot3008.Add(new Coches("Peugeot", "3008", "Active", "Diesel", "14000€", extras));
            Peugeot3008.Add(new Coches("Peugeot", "3008", "GT-Line", "Gasolina", "20000€", extras));
            Peugeot3008.Add(new Coches("Peugeot", "3008", "GT", "Gasolina", "22000€", extras));

            Peugeot5008.Add(new Coches("Peugeot", "5008", "Allure", "Gasolina", "15000€", extras));
            Peugeot5008.Add(new Coches("Peugeot", "5008", "Active", "Diesel", "14000€", extras));
            Peugeot5008.Add(new Coches("Peugeot", "5008", "GT-Line", "Gasolina", "20000€", extras));
            Peugeot5008.Add(new Coches("Peugeot", "5008", "GT", "Gasolina", "22000€", extras));

            Peugeot2008.Add(new Coches("Peugeot", "2008", "Allure", "Gasolina", "15000€", extras));
            Peugeot2008.Add(new Coches("Peugeot", "2008", "Active", "Diesel", "14000€", extras));
            Peugeot2008.Add(new Coches("Peugeot", "2008", "GT-Line", "Gasolina", "20000€", extras));
            Peugeot2008.Add(new Coches("Peugeot", "2008", "GT", "Gasolina", "22000€", extras));



            HyundaiTucson.Add(new Coches("Hyundai", "Tucson", "Allure", "Gasolina", "15000€", extras));
            HyundaiTucson.Add(new Coches("Hyundai", "Tucson", "Active", "Diesel", "14000€", extras));
            HyundaiTucson.Add(new Coches("Hyundai", "Tucson", "GT-Line", "Gasolina", "20000€", extras));
            HyundaiTucson.Add(new Coches("Hyundai", "Tucson", "GT", "Gasolina", "22000€", extras));

            HyundaiSantaFe.Add(new Coches("Hyundai", "SantaFe", "Allure", "Gasolina", "15000€", extras));
            HyundaiSantaFe.Add(new Coches("Hyundai", "SantaFe", "Active", "Diesel", "14000€", extras));
            HyundaiSantaFe.Add(new Coches("Hyundai", "SantaFe", "GT-Line", "Gasolina", "20000€", extras));
            HyundaiSantaFe.Add(new Coches("Hyundai", "SantaFe", "GT", "Gasolina", "22000€", extras));

            HyundaiI30.Add(new Coches("Hyundai", "I30", "Allure", "Gasolina", "15000€", extras));
            HyundaiI30.Add(new Coches("Hyundai", "I30", "Active", "Diesel", "14000€", extras));
            HyundaiI30.Add(new Coches("Hyundai", "I30", "GT-Line", "Gasolina", "20000€", extras));
            HyundaiI30.Add(new Coches("Hyundai", "I30", "GT", "Gasolina", "22000€", extras));



            KiaSportage.Add(new Coches("Kia", "Sportage", "Allure", "Gasolina", "15000€", extras));
            KiaSportage.Add(new Coches("Kia", "Sportage", "Active", "Diesel", "14000€", extras));
            KiaSportage.Add(new Coches("Kia", "Sportage", "GT-Line", "Gasolina", "20000€", extras));
            KiaSportage.Add(new Coches("Kia", "Sportage", "GT", "Gasolina", "22000€", extras));

            KiaSorrento.Add(new Coches("Kia", "Sorrento", "Allure", "Gasolina", "15000€", extras));
            KiaSorrento.Add(new Coches("Kia", "Sorrento", "Active", "Diesel", "14000€", extras));
            KiaSorrento.Add(new Coches("Kia", "Sorrento", "GT-Line", "Gasolina", "20000€", extras));
            KiaSorrento.Add(new Coches("Kia", "Sorrento", "GT", "Gasolina", "22000€", extras));

            KiaSeltos.Add(new Coches("Kia", "Seltos", "Allure", "Gasolina", "15000€", extras));
            KiaSeltos.Add(new Coches("Kia", "Seltos", "Active", "Diesel", "14000€", extras));
            KiaSeltos.Add(new Coches("Kia", "Seltos", "GT-Line", "Gasolina", "20000€", extras));
            KiaSeltos.Add(new Coches("Kia", "Seltos", "GT", "Gasolina", "22000€", extras));
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Coches cocheSelecion = (Coches)Modelos.SelectedItem;
            if (cocheSelecion != null)
            {
                if (cocheSelecion.Marca == "Peugeot")
                {
                    if (cocheSelecion.Modelo == "3008")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\3008.jpg",UriKind.RelativeOrAbsolute));
            
                    }
                    else if (cocheSelecion.Modelo == "5008")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\5008.jpg", UriKind.RelativeOrAbsolute));

                    }
                    else if (cocheSelecion.Modelo == "2008")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\2008.jpg", UriKind.RelativeOrAbsolute));

                    }
                }
                else if (cocheSelecion.Marca == "Hyundai")
                {
                    if (cocheSelecion.Modelo == "Tucson")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\Tucson.jpg", UriKind.RelativeOrAbsolute));
                        
                    }
                    else if (cocheSelecion.Modelo == "SantaFe")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\Santa Fe.jpg", UriKind.RelativeOrAbsolute));

                    }
                    else if (cocheSelecion.Modelo == "I30")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\i30.jpg", UriKind.RelativeOrAbsolute));
                    }
                }
                else if (cocheSelecion.Marca == "Kia")
                {
                    if (cocheSelecion.Modelo == "Sorrento")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\sorrento.jpg", UriKind.RelativeOrAbsolute));
                    }
                    else if (cocheSelecion.Modelo == "Seltos")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\Seltos.jpg", UriKind.RelativeOrAbsolute));

                    }
                    else if (cocheSelecion.Modelo == "Sportage")
                    {
                        fondo.Source = new BitmapImage(new Uri(@"Resources\sportage.png", UriKind.RelativeOrAbsolute));

                    }
                }
            }
        }


        private void Despegable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (Despegable.SelectedIndex != -1)
            {
                String opcion = Despegable.SelectedItem.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "").TrimEnd();

                if (opcion == "Hyundai Tucson")
                {
                    Modelos.ItemsSource = HyundaiTucson;
                }
                else if (opcion == "Hyundai SantaFe")
                {
                    Modelos.ItemsSource = HyundaiSantaFe;
                }
                else if (opcion == "Hyundai i30")
                {
                    Modelos.ItemsSource = HyundaiI30;
                }
                else if (opcion == "Peugeot 5008")
                {
                    Modelos.ItemsSource = Peugeot5008;
                }
                else if (opcion == "Peugeot 3008")
                {
                    Modelos.ItemsSource = Peugeot3008;
                }
                else if (opcion == "Peugeot 2008")
                {
                    Modelos.ItemsSource = Peugeot2008;
                }
                else if (opcion == "Kia Sportage")
                {
                    Modelos.ItemsSource = KiaSportage;
                }
                else if (opcion == "Kia Seltos")
                {
                    Modelos.ItemsSource = KiaSeltos;
                }
                else if (opcion == "Kia Sorrento")
                {
                    Modelos.ItemsSource = KiaSorrento;
                }
            }

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Despegable.SelectedIndex = -1;
            Modelos.ClearValue(ItemsControl.ItemsSourceProperty);

        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Despegable.SelectedIndex = -1;
            Modelos.ClearValue(ItemsControl.ItemsSourceProperty);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Despegable.SelectedIndex = -1;
            Modelos.ClearValue(ItemsControl.ItemsSourceProperty);
        }

     
    }
 }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cinema
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<Film> Screenings { get; set; }
        public List<Actor> Guild { get; set; } 
        
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Guild = new List<Actor>();  // created
            Actor a = new Actor();
            a.Name = "Frank";
            a.DOB = new DateTime(1965, 11, 1);
            Actor b = new Actor();
            b.Name = "Francis";
            b.DOB = new DateTime(1960, 1, 21);
            Guild.Add(a);
            Guild.Add(b);
            //Guild.Add(new Actor("Brad",DateTime.Parse("5/8/1955")));
            Guild.Add(new Actor() { DOB = DateTime.Parse("3/5/1965"), Name = "Angelina" });
        }

        private void lbxFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }   // end class
}

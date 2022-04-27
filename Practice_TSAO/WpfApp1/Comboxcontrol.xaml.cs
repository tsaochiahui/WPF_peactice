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
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WpfApp1
{
    /// <summary>
    /// Comboxcontrol.xaml 的互動邏輯
    /// </summary>
    public partial class Comboxcontrol : UserControl,INotifyPropertyChanged
    {
        public Comboxcontrol()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }

        public static Person person { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //public class Person
        //{  
        //    public string Name { get; set; }
        //    public string gender 
        //{
        //    set
        //    {
        //        gender = value;
        //        NotifyPropertyChanged("Gender");
        //    }

        //    get { return gender; }
                        
        //}
        //    public int age { get; set; }
        //    public int tel { get; set; }
        //}
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }



        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //comboBoxName.Items.Add("Eric");
            //comboBoxName.Items.Add("Josh");
            //comboBoxName.Items.Add("Ady");
            List<Person> list = new List<Person>();
            list.Add(new Person() {Name= "Eric", Gender="man",Age=18,Tel=123 });
            list.Add(new Person() { Name = "Josh", Gender = "man", Age = 19, Tel = 456 });
            list.Add(new Person() { Name = "Ady", Gender = "man", Age = 20, Tel = 789 });
            comboBoxName.ItemsSource = list;
        }

        private void comboBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gender1 = ((Person)comboBoxName.SelectedItem).Gender;
            int age1 = ((Person)comboBoxName.SelectedItem).Age;
            int tel1 = ((Person)comboBoxName.SelectedItem).Tel;

            gendertext.Text = gender1;
            agetext.Text = age1.ToString();
            teltext.Text = tel1.ToString();



            //person.gender = gender1;
            //person.age = age1;
            //person.tel = tel1;


        }
    }
}

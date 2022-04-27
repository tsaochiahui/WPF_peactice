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
            list.Add(new Person() {Name= "Eric", gender="man",age=18,tel=123 });
            list.Add(new Person() { Name = "Josh", gender = "man", age = 19, tel = 456 });
            list.Add(new Person() { Name = "Ady", gender = "man", age = 20, tel = 789 });
            comboBoxName.ItemsSource = list;
        }

        private void comboBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gender1 = ((Person)comboBoxName.SelectedItem).gender;
            int age1 = ((Person)comboBoxName.SelectedItem).age;
            int tel1 = ((Person)comboBoxName.SelectedItem).tel;

            gendertext.Text = gender1;
            agetext.Text = age1.ToString();
            teltext.Text = tel1.ToString();



            //person.gender = gender1;
            //person.age = age1;
            //person.tel = tel1;


        }
    }
}

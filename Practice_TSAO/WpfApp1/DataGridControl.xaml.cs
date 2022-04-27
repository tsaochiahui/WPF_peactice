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
    /// DataGridControl.xaml 的互動邏輯
    /// </summary>
    public partial class DataGridControl : UserControl,INotifyPropertyChanged
    {

        public static Person person { get; set; }

        public string _gender;

        public int _age;

        public int _tel;



        public DataGridControl()
        {
            InitializeComponent();

            //DataContext =new Person();
            //this.DataContext = this;
        }

        //public string GenderChangetext

        //{
        //    get
        //    {
        //        return _gender;
        //    }
        //    set
        //    {
        //        this._gender = person.gender;
        //        NotifyPropertyChanged();
        //    }
        //}


        public void NotifyPropertyChanged([CallerMemberName] string properName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properName));
        }

        public event PropertyChangedEventHandler PropertyChanged;




        //public class Person
        //{
        //    public string gender { get; set; }
        //    public int age { get; set; }
        //    public int tel { get; set; }
        //}

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //if (person.gender != null)
            //{
            //    Gendertext.Text = person.gender;
            //}
            
            //Agetext.Text = person.age.ToString();
            //Teltext.Text = person.tel.ToString();



        }

    }
}

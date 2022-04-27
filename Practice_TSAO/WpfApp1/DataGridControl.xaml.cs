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

namespace WpfApp1
{
    /// <summary>
    /// DataGridControl.xaml 的互動邏輯
    /// </summary>
    public partial class DataGridControl : UserControl
    {

        public DataGridControl()
        {
            InitializeComponent();
        }

        //public class Person
        //{
        //    public string gender { get; set; }
        //    public int age { get; set; }
        //    public int tel { get; set; }
        //}

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            
            //person.Add(new Person() {gender="man",age=18,tel=123456789 });
            //person.Add(new Person() { gender = "man", age = 18, tel =45612349});

        }
    }
}

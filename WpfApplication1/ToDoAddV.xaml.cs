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
using ToDoApp.BLL;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ToDoAddV.xaml
    /// </summary>
    public partial class ToDoAddV : Page
    {
        ToDoService todoSrv;
        public ToDoAddV()
        {
            InitializeComponent();
            todoSrv = new ToDoService();
            cboxPriority.ItemsSource = Enum.GetValues(typeof(ToDoBO.priorideedid)).Cast<ToDoBO.priorideedid>().ToList(); 

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            lblWarningCaption.Text = "";
            lvlWarningDescription.Text = "";
            lvlWarningPriority.Text = "";


            if (txtPealkiri.Text == "")
            {
                lblWarningCaption.Text = "Pealkiri on tühi";
                return;
            }
            if (txtKirjeldus.Text == "")
            {
                lvlWarningDescription.Text = "Kirjeldus on tühi";
                return;
            }
            if (cboxPriority.SelectedItem == null)
            {
                lvlWarningPriority.Text = "Prioriteet pole valitud";
                return;
            }

            ToDoBO newTodo = new ToDoBO(txtPealkiri.Text, txtKirjeldus.Text, DateTime.Now, (ToDoBO.priorideedid)cboxPriority.SelectedItem, false);
            todoSrv.addToDo(newTodo);


        }
    }
}

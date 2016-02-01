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
    /// Interaction logic for reviewV.xaml
    /// </summary>
    public partial class reviewV : Page
    {
        private ToDoService _todoSrv;
        private List<ToDoBO> _listOfToDos;
        private int countButtonClick = 1; 
        public reviewV()
        {
            InitializeComponent();
            _todoSrv = new ToDoService();
            _listOfToDos = _todoSrv.getUnDoneTasks();
            listToDO.ItemsSource = _listOfToDos;
            listDone.ItemsSource = _todoSrv.getDoneTasks();
        }

        private void refreshWindow() {
            InitializeComponent();
            _todoSrv = new ToDoService();
            _listOfToDos = _todoSrv.getUnDoneTasks();
            listToDO.ItemsSource = _listOfToDos;
            listDone.ItemsSource = _todoSrv.getDoneTasks();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.countButtonClick++;
            List<ToDoBO> sortedToDos= _todoSrv.sortByPriority();
            if (this.countButtonClick % 2 == 0)
            {
                listToDO.ItemsSource = sortedToDos;
            }
            else {
                sortedToDos.Reverse();
                listToDO.ItemsSource = sortedToDos;
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            lblWarningUnselectedItem.Text = "";
            if ((ToDoBO)listToDO.SelectedItem==null) {
                lblWarningUnselectedItem.Text = "ToDo is unselected";
                return;
            }

            ToDoBO selectedToDO= (ToDoBO)listToDO.SelectedItem;
            this._todoSrv.changeStatusToDone(selectedToDO);
            refreshWindow();
        }
    }
}

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
using MVVMLearn.Models;
using MVVMLearn.Infrastructure;
using MVVMLearn.ViewModels;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace MVVMLearn.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameContext.MainWindowFrame = mainFrame;
            mainDataGridView.ItemsSource = DatabaseControl.GetPhonesForView();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow();
            win.Owner = this;
            win.ShowDialog();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Phone p = mainDataGridView.SelectedItem as Phone;
            if (p != null)
            { 
                if (MessageBox.Show("Вы уверены, что хотите удалить объект?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) 
                    == MessageBoxResult.Yes)
                {
                    DatabaseControl.DeletePhone(p);
                    RefreshTable();
                }
            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Phone p = mainDataGridView.SelectedItem as Phone;
            if (p != null)
            {
                EditWindow win = new EditWindow(p);
                win.Owner = this;
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите элемент для изменения");
            }
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            Phone phone = mainDataGridView.SelectedItem as Phone;
            if (phone != null)
            {
                FrameContext.MainWindowFrame.Navigate(new AboutPage(phone));
            }
        }

        public void RefreshTable()
        {
            mainDataGridView.ItemsSource = null;
            mainDataGridView.ItemsSource = DatabaseControl.GetPhonesForView();
        }

        private void mainDataGridView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

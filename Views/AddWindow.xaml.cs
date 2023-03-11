using MVVMLearn.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVMLearn.Views
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();

            companyView.ItemsSource = DatabaseControl.GetCompanies();
        }

        private void AddPhoneButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseControl.AddPhone(new Models.Phone
            {
                Title = titleView.Text,
                CompanyId = (int)companyView.SelectedValue,
                Price = Convert.ToDecimal(priceView.Text)
            });
            (this.Owner as MainWindow).RefreshTable();
            this.Close();
        }
    }
}

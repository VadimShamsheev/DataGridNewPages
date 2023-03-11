using MVVMLearn.Infrastructure;
using MVVMLearn.Models;
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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Phone _tempPhone;
        public EditWindow(Phone phone)
        {
            InitializeComponent();
            _tempPhone = phone;
            companyView.ItemsSource = DatabaseControl.GetCompanies();
            titleView.Text = phone.Title;
            companyView.SelectedValue = phone.CompanyEntity.Id;
            priceView.Text = phone.Price.ToString();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            _tempPhone.Title = titleView.Text;
            _tempPhone.CompanyId = (int)companyView.SelectedValue;
            _tempPhone.Price = Convert.ToDecimal(priceView.Text);
            DatabaseControl.UpdatePhone(_tempPhone);
            (this.Owner as MainWindow).RefreshTable();
            this.Close();
        }
    }
}

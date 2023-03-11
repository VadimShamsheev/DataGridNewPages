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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMLearn.Views
{
    /// <summary>
    /// Логика взаимодействия для AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage(Phone _phone)
        {
            InitializeComponent();

            titlePageView.Text = _phone.Title;
            definitionPageView.Text = _phone.Definition;
            companyPageView.Text = _phone.CompanyEntity.Title;
            pricePageView.Text = _phone.Price.ToString();
            imagePageView.Source = new BitmapImage(new Uri(_phone.ImageSource));
        }

        private void BackArrowButton_Click(object sender, RoutedEventArgs e)
        {
            FrameContext.MainWindowFrame.Navigate(null);
        }
    }
}

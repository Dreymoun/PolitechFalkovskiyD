﻿using PolitechFalkovskiyD.BLL;
using PolitechFalkovskiyD.BLL.Model;
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

namespace PolitechFalkovskiyD.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        ServiceClient service;
        private readonly string path = "C:\\Temp\\Pokitech.db";
        public AuthWindow()
        {
            service = new ServiceClient(path);
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            ClientDTO client = new ClientDTO();
            client.Email = tbxEmail.Text;
            client.Password = pwdPassword.Password;
            var result = service.AuthorizationClient(client);
            //MessageBox.Show(result.ShortName);
            MainWindow mw = new MainWindow();
            mw.Show();

            this.Close();
        }
    }
}

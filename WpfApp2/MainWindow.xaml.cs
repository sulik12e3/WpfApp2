﻿using System;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        easyHiretapesEntities db = new easyHiretapesEntities();
        
        void Update()
        {
            dg.ItemsSource = db.Videotapes.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = Connectdb.db.Videotapes.ToList();
        }

       

        private void add_Click(object sender, RoutedEventArgs e)
        {
             Window1 s = new Window1();
              s.Show();
          
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var currenttapes = dg.SelectedItem as Videotapes;
            db.Videotapes.Remove(currenttapes);
            db.SaveChanges();
            Update();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            Connectdb.db.SaveChanges();
        }
    }
}

﻿using Domain;
using Presentation.Code;
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

namespace ESProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Logic core = new Logic();
            core.DI();
            Dictionary<IFactor, int> configFactors = new Dictionary<IFactor, int>();

            //Значения берутся откуда-то с формы
            configFactors.Add(core.Factors[0], 50);
            core.ConfigFactors(configFactors);
            core.Start();
        }
    }
}

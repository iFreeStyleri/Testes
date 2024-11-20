using System;
using System.Windows;
using System.Windows.Controls;

namespace Testes.Views
{
    public partial class ValueWindow : Window
    {
        public event EventHandler<string> DataEntered;
        public ValueWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            DataEntered?.Invoke(this, TextBox.Text);
        }
    }
}

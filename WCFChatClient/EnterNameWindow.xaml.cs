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
using System.Windows.Shapes;

namespace WCFChatClient
{
    /// <summary>
    /// Interaction logic for EnterNameWindow.xaml
    /// </summary>
    public partial class EnterNameWindow : Window
    {
        public EnterNameWindow()
        {
            InitializeComponent();
        }

        private void CmdJoin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                bool result = ((App)Application.Current).Service.Connect(txtName.Text);
                if (!result)
                    MessageBox.Show("Username is already taken. Please choose another username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    MainWindow mainWindow = new MainWindow();
                    ((App)Application.Current).MainWindow = mainWindow;
                    mainWindow.Show();
                    this.Close();
                }
            }
        }
    }
}

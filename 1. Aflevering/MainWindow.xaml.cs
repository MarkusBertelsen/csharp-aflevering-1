using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _1.Aflevering
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string text;
                var streamReader = new StreamReader(openFileDialog.FileName);
                while((text = streamReader.ReadLine()) != null)
                {
                    string[] values = text.Split(';');
                    User user = new User(int.Parse(values[0]), values[1], int.Parse(values[2]), int.Parse(values[3]));
                    listBox.Items.Add(user);
                }
                listCounter.Content = "Amount of users in list: " + listBox.Items.Count.ToString();
                lastLoadTimer.Content = "Last time users loaded: " + DateTime.Now.ToString();
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User u = listBox.SelectedItem as User;
            idTextBox.DataContext = u;
            nameTextBox.DataContext = u;
            ageTextBox.DataContext = u;
            scoreTextBox.DataContext = u;
        }
    }
}

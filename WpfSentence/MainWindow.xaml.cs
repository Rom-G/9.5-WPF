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
using SplitText;
using ReversWords;
using System.Collections.ObjectModel;

namespace WpfSentence
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> listWords = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            listBoxSplit.ItemsSource = listWords;
        }

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            string sentence = textBoxSplit.Text;
            string[] words = SplitText.Program.SplitText(sentence);
            listWords.Clear();
            foreach (string word in words)
            {
                listWords.Add(word);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && textBoxSplit.IsKeyboardFocused)
            {
                SplitButton_Click((object)sender, e);
            }
            else if (e.Key == Key.Enter && textBoxReverse.IsKeyboardFocused)
            {
                ReverseButton_Click((object)sender, e);
            }
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            string sentence = textBoxReverse.Text;
            string reverseSentence = ReversWords.Program.Reverse(sentence);
            labelReverse.Content = reverseSentence;
        }
    }
}

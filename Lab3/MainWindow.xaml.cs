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




namespace Lab3
{
    /// VARIANT 21(1)

    public partial class MainWindow : Window
    {
        public int RightAnswers = 0;
        public int WrongAnswers = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btTryAgain_Click(object sender, RoutedEventArgs e)
        {
            lblTrue.Visibility = Visibility.Hidden;
            lblFalse.Visibility = Visibility.Hidden;
            rbtAnswer1.IsEnabled = true;
            rbtAnswer2.IsEnabled = true;
            rbtAnswer3.IsEnabled = true;
            rbtAnswer4.IsEnabled = true;
            lblQ.Content = "?";
            int FirstInput = 0;
            int SecondInput = 0;
            lblFirst.Content = Convert.ToString(FirstInput);
            lblSecond.Content = Convert.ToString(SecondInput);
            int Action;
            int FullAnswer = 0;
            int AnotherAnswer1 = 0;
            int AnotherAnswer2 = 0;
            int AnotherAnswer3 = 0;
            Random rnd = new Random();
            Action = rnd.Next(0, 2);
            switch (Action)
            {
                case 0:
                    lblAction.Content = "+";
                    FirstInput = rnd.Next(0, 51);
                    SecondInput = rnd.Next(0, 51);
                    FullAnswer = FirstInput + SecondInput;
                    AnotherAnswer1 = FullAnswer + 1;
                    AnotherAnswer2 = FullAnswer + 2;
                    AnotherAnswer3 = FullAnswer - 1;
                    break;
                case 1:
                    lblAction.Content = "-";
                    FirstInput = rnd.Next(0, 51);
                    SecondInput = rnd.Next(0, 51);
                    FullAnswer = FirstInput - SecondInput;
                    AnotherAnswer1 = FullAnswer + 1;
                    AnotherAnswer2 = FullAnswer + 2;
                    AnotherAnswer3 = FullAnswer - 1;
                    break;
            }
            lblFirst.Content = Convert.ToString(FirstInput);
            lblSecond.Content = Convert.ToString(SecondInput);
            rbtAnswer1.Content = Convert.ToString(AnotherAnswer1);
            rbtAnswer2.Content = Convert.ToString(AnotherAnswer2);
            rbtAnswer3.Content = Convert.ToString(AnotherAnswer3);
            rbtAnswer4.Content = Convert.ToString(FullAnswer);
        }

        private void btCheck_Click(object sender, RoutedEventArgs e)
        {
            if (rbtAnswer4.IsChecked == true)
            {
                lblTrue.Visibility = Visibility.Visible;
                lblQ.Content = rbtAnswer4.Content;
                rbtAnswer4.IsChecked = false;
                RightAnswers++;
                rbtAnswer1.IsEnabled = false;
                rbtAnswer2.IsEnabled = false;
                rbtAnswer3.IsEnabled = false;
                rbtAnswer4.IsEnabled = false;
                lblRightAns.Content = Convert.ToString(RightAnswers);

            }
            else
            {
                lblFalse.Visibility = Visibility.Visible;
                lblQ.Content = rbtAnswer4.Content;
                rbtAnswer1.IsChecked = false;
                rbtAnswer2.IsChecked = false;
                rbtAnswer3.IsChecked = false;
                WrongAnswers++;
                rbtAnswer1.IsEnabled = false;
                rbtAnswer2.IsEnabled = false;
                rbtAnswer3.IsEnabled = false;
                rbtAnswer4.IsEnabled = false;
                lblWrongAns.Content = Convert.ToString(WrongAnswers);

            }
        }
    }
}
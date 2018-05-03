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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;

        //initialized variables for while loop counter and credits 
        int count = 0;
        int credits = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //use a while loop to count the number of courses selected
            while (count < 3)
            {
                choice = (Course)(this.comboBox.SelectedItem);

                    //Output dialog to the Message box indicating the user has registered for the course
                    MessageBox.Show("You have successfully registered for: " + choice);

                    //add the course choice to the listbox
                    this.listBox.Items.Add(choice);

                    //increment the counter in the while loop
                    count++;

                    //multiply the counter variable by 3 to get the number of credits
                    credits = count * 3;

                    //output the number of credits to the Credits textbox
                    this.textBox.Text = Convert.ToString(credits);
                
                //Verify that the choice has not already been selected
                if (listBox.Items.Contains(choice))
                {
                    MessageBox.Show("You are already registered for that course.");
                    return;
                }

                //Check that not more than 3 credits have been registered. If more than 3, exit the loop
                if (count >= 3)
                {
                    break;

                }
                //Close the program
                Application.Current.Shutdown();
            }


        }

    }
}

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
using System.Numerics;

namespace Test
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

        private void rangeChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (rangeChange.SelectedItem == rangeChange.Items[i] && rangeChange.SelectedItem != rangeChange.Items[4])
                {
                    rangeSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (rangeChange.SelectedItem == rangeChange.Items[4])
                {
                    rangeSalaryText.Text = "0";
                }
                
             
            }
            ChangeTotalSalary();

        }

        private void theoryChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (theoryChange.SelectedItem == theoryChange.Items[i] && theoryChange.SelectedItem != theoryChange.Items[5])
                {
                    theorySalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (theoryChange.SelectedItem == theoryChange.Items[5])
                {
                    theorySalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void classChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (classChange.SelectedItem == classChange.Items[i] && classChange.SelectedItem != classChange.Items[5])
                {
                    classSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (classChange.SelectedItem == classChange.Items[5])
                {
                    classSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void stageChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (stageChange.SelectedItem == stageChange.Items[i] && stageChange.SelectedItem != stageChange.Items[4])
                {
                    stageSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (stageChange.SelectedItem == stageChange.Items[4])
                {
                    stageSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void scienceRate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (scienceRateChange.SelectedItem == scienceRateChange.Items[i] && scienceRateChange.SelectedItem != scienceRateChange.Items[9])
                {
                    scienceRateSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (scienceRateChange.SelectedItem == scienceRateChange.Items[4])
                {
                    scienceRateSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void scienceRankChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (scienceRankChange.SelectedItem == scienceRankChange.Items[i] && scienceRankChange.SelectedItem != scienceRankChange.Items[3])
                {
                    scienceRankSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (scienceRankChange.SelectedItem == scienceRankChange.Items[3])
                {
                    scienceRankSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void positionChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (positionChange.SelectedItem == positionChange.Items[i] && positionChange.SelectedItem != positionChange.Items[8])
                {
                    positionSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (positionChange.SelectedItem == positionChange.Items[8])
                {
                    positionSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void specializationChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            for (int i = 0; i <= 8; i++)
            {
                if (specializationChange.SelectedItem == specializationChange.Items[i] && specializationChange.SelectedItem != specializationChange.Items[5])
                {
                    specializationSalaryText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (specializationChange.SelectedItem == specializationChange.Items[0])
                {
                    specializationSalaryText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        private void salary_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (salary.SelectedItem == salary.Items[i] && salary.SelectedItem != salary.Items[4])
                {
                    salaryRankText.Text = ((i + 1) * 5000 + (i + 1) * 5000).ToString();
                }
                else if (salary.SelectedItem == salary.Items[4])
                {
                    salaryRankText.Text = "0";
                }
            }
            ChangeTotalSalary();
        }

        public void ChangeTotalSalary()
        {

            //int totalSalaryText1 = int.Parse(rangeSalaryText.Text + theorySalaryText.Text + classSalaryText.Text + stageSalaryText.Text + scienceRateSalaryText.Text
            //+ scienceRankSalaryText.Text + positionSalaryText.Text + specializationSalaryText.Text + salaryRankText.Text);


            totalSalaryText.Text = (Convert.ToInt32(rangeSalaryText.Text) + Convert.ToInt32(theorySalaryText.Text) + Convert.ToInt32(classSalaryText.Text)
                + Convert.ToInt32(stageSalaryText.Text) + Convert.ToInt32(scienceRateSalaryText.Text) + Convert.ToInt32(scienceRankSalaryText.Text)
                + Convert.ToInt32(positionSalaryText.Text) + Convert.ToInt32(specializationSalaryText.Text) + Convert.ToInt32(salaryRankText.Text)).ToString();
        
        }
    }
}

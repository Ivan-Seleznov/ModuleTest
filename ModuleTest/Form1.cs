using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int knightsCount = Convert.ToInt32(KnightCount.Text);
                int dragonsCount = Convert.ToInt32(DragonsCount.Text);
                int archerCount = Convert.ToInt32(ArcherCount.Text);

                if (knightsCount < 0 || dragonsCount < 0 || archerCount < 0 ) throw new Exception("Count cannot be less then 0");
                
                List<IUnit> units = new List<IUnit>();
                CreateUnits<Knight>(units, knightsCount);
                CreateUnits<Dragon>(units, dragonsCount);
                CreateUnits<Archer>(units, archerCount);

                DisplayUnits(units);

                Army army = new Army(units);

                AverageSpeed.Text = army.CalculateAverageSpeed().ToString();
                TotalGold.Text = army.CalculateTotalGold().ToString();
                TotalFeed.Text = army.CalculateTotalFeed().ToString(); 
                TotalGirls.Text = army.CalculateTotalGirls().ToString();
                TotalArrow.Text = army.CalculateTotalArrows().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено некоректні дані\n" + ex.Message);
            }

        } 
        private void CreateUnits<T>(List<IUnit> units,int count) where T : IUnit , new()
        {
            for (int i = 0; i < count; i++)
            {
                units.Add(new T());
            }
        }
        private void DisplayUnits(List<IUnit> units)
        {
            listBox1.Items.Clear();
            foreach (var item in units)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}

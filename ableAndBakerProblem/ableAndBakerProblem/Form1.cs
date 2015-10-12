using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AForge.Math.Random;
using AForge;
using System.Diagnostics;

namespace ableAndBakerProblem
{
    public partial class MainForm : Form
    {
        private int numOfPeoples = 100;
        int[] arivalTimes = new int[4];
        int[] ableTimes = new int[4];
        int[] bakerTimes = new int[4];
        public MainForm()
        {
            InitializeComponent();
            comboCharts.SelectedIndex = 0;
        }

        private int get_next_inter_arrival()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int interval_time = rnd.Next(1, 101);
            if (interval_time <= 25)
                return arivalTimes[0];
            else if (interval_time <= 65)
                return arivalTimes[1];
            else if (interval_time <= 85)
                return arivalTimes[2];
            else
                return arivalTimes[3];
        }

        private int service_time_generator_able()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int interval_time = rnd.Next(1, 101);
            if (interval_time <= 30)
                return ableTimes[0];
            else if (interval_time <= 58)
                return ableTimes[1];
            else if (interval_time <= 83)
                return ableTimes[2];
            else
                return ableTimes[3];
        }

        private int service_time_generator_baker()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int interval_time = rnd.Next(1, 101);
            if (interval_time <= 35)
                return bakerTimes[0];
            else if (interval_time <= 60)
                return bakerTimes[1];
            else if (interval_time <= 80)
                return bakerTimes[2];
            else
                return bakerTimes[3];
        }

        private void simBtn_Click(object sender, EventArgs e)
        {
            numOfPeoples = int.Parse(txtCustomerNum.Text);
            arivalTimes[0] = int.Parse(txtAr1.Text);
            arivalTimes[1] = int.Parse(txtAr2.Text);
            arivalTimes[2] = int.Parse(txtAr3.Text);
            arivalTimes[3] = int.Parse(txtAr4.Text);
            ableTimes[0] = int.Parse(txtAble1.Text);
            ableTimes[1] = int.Parse(txtAble2.Text);
            ableTimes[2] = int.Parse(txtAble3.Text);
            ableTimes[3] = int.Parse(txtAble4.Text);
            bakerTimes[0] = int.Parse(txtBaker1.Text);
            bakerTimes[1] = int.Parse(txtBaker2.Text);
            bakerTimes[2] = int.Parse(txtBaker3.Text);
            bakerTimes[3] = int.Parse(txtBaker4.Text);
            for (int i = 0; i < numOfPeoples; i++)
            {
                dataGrid.Rows.Add();
                int interval = 0;
                int arrival = 0;
                int able_available_time = 0;
                int baker_available_time = 0;
                string server = "";
                int service_time = 0;
                int time_service_begins = 0;
                int able_service_complete_time = 0;
                int baker_service_complete_time = 0;
                int costumer_delay = 0;
                int time_in_system = 0;
                if (i > 0)
                {
                    dataGrid[0, i].Value = i + 1;
                    interval = get_next_inter_arrival();
                    arrival = int.Parse(dataGrid[2, i - 1].Value.ToString()) + interval;
                    able_available_time = int.Parse(dataGrid[8, i - 1].Value.ToString());
                    baker_available_time = int.Parse(dataGrid[9, i - 1].Value.ToString());
                    if (able_available_time <= arrival || able_available_time <= baker_available_time)
                    {
                        server = "able";
                        service_time = service_time_generator_able();
                        time_service_begins = Math.Max(arrival, int.Parse(dataGrid[8, i - 1].Value.ToString()));
                        able_service_complete_time = service_time + time_service_begins;
                        baker_service_complete_time = int.Parse(dataGrid[9, i - 1].Value.ToString());

                    }
                    else
                    {
                        server = "baker";
                        service_time = service_time_generator_baker();
                        time_service_begins = Math.Max(arrival, int.Parse(dataGrid[9, i - 1].Value.ToString()));
                        baker_service_complete_time = service_time + time_service_begins;
                        able_service_complete_time = int.Parse(dataGrid[8, i - 1].Value.ToString());
                    }
                    costumer_delay = time_service_begins - arrival;
                    time_in_system = costumer_delay + service_time;

                }
                else
                {
                    dataGrid[0, i].Value = i + 1;
                    interval = 0;
                    arrival = 0;
                    able_available_time = 0;
                    baker_available_time = 0;
                    server = "able";
                    service_time = service_time_generator_able();
                    time_service_begins = 0;
                    able_service_complete_time = service_time + time_service_begins;
                    baker_service_complete_time = 0;
                    costumer_delay = 0;
                    time_in_system = costumer_delay + service_time;
                }
                dataGrid[1, i].Value = interval;
                dataGrid[2, i].Value = arrival;
                dataGrid[3, i].Value = able_available_time;
                dataGrid[4, i].Value = baker_available_time;
                dataGrid[5, i].Value = server;
                dataGrid[6, i].Value = service_time;
                dataGrid[7, i].Value = time_service_begins;
                dataGrid[8, i].Value = able_service_complete_time;
                dataGrid[9, i].Value = baker_service_complete_time;
                dataGrid[10, i].Value = costumer_delay;
                dataGrid[11, i].Value = time_in_system;
            }
            drawChart.Enabled = true;
            float total_time_costumers_wait_in_queue = 0;
            float total_number_costumers_wait_in_queue = 0;
            float total_baker_idle_time = 0;
            float total_able_idle_time = 0;
            float total_baker_service_time = 0;
            float total_able_service_time = 0;
            float average_time_between_arrivals = 0;
            float sum_of_intervals = 0;
            float total_time_cotumers_spent_in_system = 0;
            float average_time_costumers_spent_in_system = 0;
            float totalServiceTime = Math.Max(int.Parse(dataGrid[8, numOfPeoples - 1].Value.ToString()), int.Parse(dataGrid[9, numOfPeoples - 1].Value.ToString()));
          

			for (int i = 0; i < numOfPeoples; i++)
            {
                if (int.Parse(dataGrid[10,i].Value.ToString()) != 0)
                {
                    total_time_costumers_wait_in_queue = total_time_costumers_wait_in_queue + int.Parse(dataGrid[10,i].Value.ToString());
                    total_number_costumers_wait_in_queue = total_number_costumers_wait_in_queue + 1;

                }
                if( dataGrid[5,i].Value.ToString() == "baker")
                {
                    total_baker_service_time = total_baker_service_time + int.Parse(dataGrid[6,i].Value.ToString());
                }
                else
                {
                    total_able_service_time = total_able_service_time + int.Parse(dataGrid[6,i].Value.ToString());
                    sum_of_intervals = sum_of_intervals + int.Parse(dataGrid[1,i].Value.ToString());
                    total_time_cotumers_spent_in_system += int.Parse(dataGrid[11, i].Value.ToString());
                }
            }
            lbl0.Text = (total_number_costumers_wait_in_queue / numOfPeoples).ToString();
            label7.Text = total_time_costumers_wait_in_queue.ToString();
            label9.Text = (total_able_service_time / totalServiceTime).ToString();
            label11.Text = (total_baker_service_time / totalServiceTime).ToString();
            label13.Text = (sum_of_intervals / (numOfPeoples - 1)).ToString();
            label15.Text = (total_time_costumers_wait_in_queue / total_number_costumers_wait_in_queue).ToString();
            label17.Text = (total_time_cotumers_spent_in_system / numOfPeoples).ToString();
            label19.Text = (totalServiceTime - total_able_service_time).ToString();
            label21.Text = (totalServiceTime - total_baker_service_time).ToString();






        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            drawChart.Enabled = false;
        }

        private void chart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawChart_Click(object sender, EventArgs e)
        {
            int column;
            if (comboCharts.SelectedIndex == 0)
            {
                column = 10;
                label1.Text = "Delay Time";
            }
            else if (comboCharts.SelectedIndex == 1)
            {
                column = 11;
                label1.Text = "Time in system";
            }
            else
                column = 0;
            SecondResault.Series.Clear();
            SecondResault.ChartAreas[0].AxisY.Maximum = 100;
            Series serie = new Series();
            serie = SecondResault.Series.Add(comboCharts.SelectedIndex == 0 ? "Delay" : "Time in system");
            //serie.Points[0].AxisLabel = "First Point";
            serie.AxisLabel = "mmad";
            //serie.Points[1].AxisLabel = "Second Point";
            Dictionary<string, int> counts = new Dictionary<string, int>();
            for (int i = 0; i < numOfPeoples; i++)
            {
                if (counts.ContainsKey(dataGrid[column, i].Value.ToString()))
                {
                    counts[dataGrid[column, i].Value.ToString()]++;
                }
                else
                {
                    counts[dataGrid[column, i].Value.ToString()] = 1;
                }
            }
            var list = counts.Keys.ToList();
            list.Sort();
            foreach (string item in list)
            {
                serie.Points.AddXY(item, counts[item]);
            }
            ChartPanel.Visible = true;
            statsPanel.Visible = false;
        }

        private void closeChart_Click(object sender, EventArgs e)
        {
            ChartPanel.Visible = false;
            SecondResault.Series.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statsPanel.Visible = false;
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            statsPanel.Visible = true;
        }


    }
}

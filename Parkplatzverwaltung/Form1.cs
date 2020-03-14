using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parkplatzverwaltung
{
    public partial class Parkplatzverwaltung : Form
    {
        bool[] parkinglot = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        int cars = 0;
        string datafile;
        string dataStream;

        public Parkplatzverwaltung()
        {
            InitializeComponent();
            BackColor = Color.Green;
            init();

        }

        private void cmdAddCar_Click(object sender, EventArgs e)
        {
            if(txtCarName.Text != "")
            {
                lboCarPool.Items.Add(txtCarName.Text);
            }else
            {
                MessageBox.Show("Bitte Autonamen eingeben!");
            }
        }

        private void cmdDeleteCar_Click(object sender, EventArgs e)
        {
            if (lboCarPool.SelectedIndex == -1)
            {
                MessageBox.Show("Kein Auto ausgewählt!");
            }
            else
            {

                DialogResult result = MessageBox.Show("Möchten Sie das Auto wirklich löschen?", "Ausgewähltes Auto löschen", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    lboCarPool.Items.RemoveAt(lboCarPool.SelectedIndex);
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Abgrebrochen");
                }
            }
        }

        private void cmdDriveIn_Click(object sender, EventArgs e)
        {
            if(lboCarPool.SelectedIndex == -1)
            {
                MessageBox.Show("Kein Auto ausgewählt!");
            }
            else if(lboParkingLot.Items.Count == 10)
            {
                MessageBox.Show("Parkplatz ist bereits voll!");
            }
            else
            {
                for(int i = 0; i < 10; i++)
                {
                    if(parkinglot[i] == false)
                    {
                        lboParkingLot.Items.Insert(i, lboCarPool.SelectedItem);
                        parkinglot[i] = true;
                        i = 10;
                        cars++;
                    }
                }
                
            }
            if(lboParkingLot.Items.Count == 10)
            {
                BackColor = Color.Red;
               
            }
            if(lboParkingLot.Items.Count > 0)
            {
                cmdDriveOut.Enabled = true;
            }
        }

        private void cmdDriveOut_Click(object sender, EventArgs e)
        {
            if(lboParkingLot.Items.Count == 0)
            {
                MessageBox.Show("Keine Autos mehr am Parkplatz");
            }
            else if(lboParkingLot.SelectedIndex == -1)
            {
                MessageBox.Show("Kein Auto ausgewählt kann nicht ausparken!");
            }
            else
            {
                parkinglot[lboParkingLot.SelectedIndex] = false;
                lboParkingLot.Items.RemoveAt(lboParkingLot.SelectedIndex);
            }

            if(lboParkingLot.Items.Count == 0)
            {
                cmdDriveIn.Enabled = true;
            }
            else if(lboParkingLot.Items.Count < 10)
            {
                BackColor = Color.Green;
            }
        }

        private void cmdDailyEarnings_Click(object sender, EventArgs e)
        {
            int earnings = cars * 10;

            lblEarnings.Text = "Heute wurden: " + earnings + "€ eingenommen";

            dataStream = dataStream + DateTime.Now.ToShortDateString() + "," + earnings + "\n";
            
        }

        private void OpenFile_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdData = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Datei öffnen",

                DefaultExt = "csv",
                Filter = "CSV Datei (*.csv)|*.csv|Alle Dateien (*.*)|*.*",
                FilterIndex = 0,

                CheckFileExists = true,
                CheckPathExists = true,

                Multiselect = false
            };

            if(ofdData.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = ofdData.FileName;
                datafile = ofdData.FileName;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveFun;

namespace LoopBaseCreator
{
    public partial class MainForm : Form
    {
        static string programName = Assembly.GetExecutingAssembly().GetName().Name;
        static string programVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        const string copyright = "© JJR 2018";

        double sampleRateHz = 44100;

        uint nbrSamples = 0;

        public MainForm()
        {
            InitializeComponent();

            lblCopyright.Text = programName + " " + programVersion + " " + copyright;

            cbNoteDuration.Items.Add("1/2");
            cbNoteDuration.Items.Add("1/4");
            cbNoteDuration.Items.Add("1/8");
            cbNoteDuration.SelectedItem = "1/4";

            cbTimeSigBottom.Items.Add("2");
            cbTimeSigBottom.Items.Add("4");
            cbTimeSigBottom.Items.Add("8");
            cbTimeSigBottom.Items.Add("16");
            cbTimeSigBottom.Items.Add("32");
            cbTimeSigBottom.SelectedItem = "4";

            nudBpm.Value = 100;
            nudBpm.Select();
        }

        private void NudBpmEnter(object sender, EventArgs e)
        {
            nudBpm.Select(0, nudBpm.Text.Length);
        }

        private void NudNumberBarsEnter(object sender, EventArgs e)
        {
            nudNumberBars.Select(0, nudNumberBars.Text.Length);
        }

        private void NudBeatsPerBarEnter(object sender, EventArgs e)
        {
            nudTimeSigTop.Select(0, nudTimeSigTop.Text.Length);
        }

        private void CalculateSampleCount()
        {
            // minutes = 1/BPM * beatsPerBar * bars
            // beatsPerBar = timeSig / beatDuration
            // seconds = 60 * minutes
            // sampleCount = sampleRate * seconds

            const int secondsPerMinute = 60;
            double timeSig = (double)nudTimeSigTop.Value / Convert.ToUInt32(cbTimeSigBottom.SelectedItem);
            DataTable dt = new DataTable();
            var beatDuration = dt.Compute(cbNoteDuration.SelectedItem.ToString(), "");
            double beatsPerBar = timeSig / (double)beatDuration;
            decimal numberBars = nudNumberBars.Value;
            double seconds = (beatsPerBar * (double)nudNumberBars.Value * secondsPerMinute) / (double)nudBpm.Value;
            nbrSamples = Convert.ToUInt32(Math.Round(seconds * sampleRateHz));
            lblNbrSamplesValue.Text = nbrSamples.ToString();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            CalculateSampleCount();

            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string beatDuration = "";
            switch (cbNoteDuration.SelectedItem.ToString())
            {
                case "1/2":
                    beatDuration = "half-note";
                    break;
                case "1/4":
                    beatDuration = "quarter-note";
                    break;
                case "1/8":
                    beatDuration = "eighth-note";
                    break;
            }
            saveFileDialog1.FileName = nudBpm.Value.ToString() + "bpm_" + nudNumberBars.Value.ToString() 
                + "bars_" + nudTimeSigTop.Value.ToString() + "-" + cbTimeSigBottom.SelectedItem + "_" +  beatDuration + "-beat.wav";
            saveFileDialog1.Filter = "Wav file|*.wav";
            saveFileDialog1.Title = "Save empty mono loop";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                //System.IO.FileStream fs =
                //   (System.IO.FileStream)saveFileDialog1.OpenFile();

                WaveGenerator wave = new WaveGenerator(nbrSamples);
                wave.Save(saveFileDialog1.FileName);

                //fs.Close();
            }
        }
    }
}

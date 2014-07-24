using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbuilder.ClearContent();
            pbuilder.AppendText(textBox1.Text);
            synthesizer.SpeakAsync(pbuilder);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.Pause();
                button2.Text = "Continue";
            }
            else if (synthesizer.State == SynthesizerState.Paused)
            {
                synthesizer.Resume();
                button2.Text = "Pause";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            synthesizer.Dispose();

        }


    }
}

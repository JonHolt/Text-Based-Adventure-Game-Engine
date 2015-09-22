using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBasedEngine
{
    public partial class Form1 : Form
    {
        //CAUTION: Do not mess with the code in this file unless you
        //unless you are really sure you know what you're doing.
        #region interface
        /// <summary>
        /// Sets the prompt in the textbox to a string value passed in.
        /// </summary>
        /// <param name="prompt">The value to set the prompt to</param>
        public void SetPrompt(string prompt)
        {
            tbPrompt.Text = prompt;
            tbPrompt.Select(0, 0);
        }

        /// <summary>
        /// Adds a new button to the form with the text to be displayed
        /// that will do the action provided.
        /// </summary>
        /// <param name="text">What the button should say</param>
        /// <param name="action">What the button should do</param>
        public void AddChoice(string text, EventHandler action)
        {
            Button btn = new Button();
            btn.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            btn.Top = currentHeight;
            btn.Left = MARGIN;
            btn.Width = tbPrompt.Width;
            btn.Text = text;
            btn.Click += Reset;
            btn.Click += action;
            btn.AutoSize = true;
            

            choices.Add(btn);
            Controls.Add(btn);

            currentHeight += btn.Height + MARGIN;
        }
        #endregion
        #region util
        const int MARGIN = 12;
        List<Button> choices;
        int startingHeight, currentHeight;
        public Form1()
        {
            InitializeComponent();
            choices = new List<Button>();
            startingHeight = tbPrompt.Top + tbPrompt.Height + MARGIN;
            currentHeight = startingHeight;
            GameManager.Start(this);
        }

        private void Reset(object sender, EventArgs e)
        {
            tbPrompt.Clear();
            foreach(Button btn in choices)
            {
                Controls.Remove(btn);
            }
            choices.Clear();
            currentHeight = startingHeight;
        }
        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented. Coming Soon!");
        }
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented. Coming Soon!");
        }
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented. Coming Soon!");
        }
        #endregion
    }
}

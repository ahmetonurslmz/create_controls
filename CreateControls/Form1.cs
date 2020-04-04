using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateControls
{
    public partial class createControls : Form
    {
        public createControls()
        {
            InitializeComponent();
        }

        private void clearAllControls()
        {
            grpControls.Controls.Clear();
        }

        private void clearControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clearAllControls();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void changeVisibilityOfPanel(bool status)
        {
            this.panelNumberOfControls.Visible = status;
        }

        int type;

        private void createControlsByType(int newType)
        {
            /**
             * @summary
             * type 1: textbox
             * type 2: label
             */

            type = newType;
        }

        private void createTextBoxControls_Click(object sender, EventArgs e)
        {
            this.changeVisibilityOfPanel(true);
            this.createControlsByType(1);
        }

        private void createLabelControls_Click(object sender, EventArgs e)
        {
            this.changeVisibilityOfPanel(true);
            this.createControlsByType(2);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.changeVisibilityOfPanel(false);
            int rows = Int32.Parse(txtNumberOfRows.Text);
            int cols = Int32.Parse(txtNumberOfCols.Text);
            this.clearAllControls();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (type == 1)
                    {
                        TextBox textbox = new TextBox();
                        var text = (r + 1) + "x" + (c + 1);
                        textbox.Text = text.ToString();
                        textbox.Top = 20 + (r * 50);
                        textbox.Height = 40;
                        textbox.Width = 40;
                        textbox.Left = 10 + (c * 50);
                        grpControls.Controls.Add(textbox);

                    }
                    else if (type == 2)
                    {
                        Label label = new Label();
                        var text = (r+1) + "x" + (c+1);
                        label.Text = text.ToString();
                        label.Top = 20 + (r * 50);
                        label.Height = 40;
                        label.Width = 40;
                        label.Left = 10 + (c * 50);
                        grpControls.Controls.Add(label);
                    }
                }
            }
        }
    }
}

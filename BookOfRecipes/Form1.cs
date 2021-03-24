using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfRecipes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding(
                "ImageLocation", recipesBindingSource, "images__001", true));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipesDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipesDataSet.recipes);
        }

        private void nextRecipe_Click(object sender, EventArgs e)
        {
            if (comboBoxRecipeName.SelectedIndex == recipesDataSet.Tables["recipes"].Rows.Count - 1)
            {
                var result = MessageBox.Show("There are no further recipes");
                if (result == DialogResult.OK)
                {
                    comboBoxRecipeName.SelectedIndex = 0;
                }
            }
            else
            {
                comboBoxRecipeName.SelectedIndex = comboBoxRecipeName.SelectedIndex + 1;
            }
        }

        private void prevRecipe_Click(object sender, EventArgs e)
        {
            if (comboBoxRecipeName.SelectedIndex < 0)
            {
                var result = MessageBox.Show("There are no further recipes");
                if (result == DialogResult.OK)
                {
                    comboBoxRecipeName.SelectedIndex = recipesDataSet.Tables["recipes"].Rows.Count - 1;
                }
            }
            else
            {
                comboBoxRecipeName.SelectedIndex = comboBoxRecipeName.SelectedIndex - 1;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to be a chef?",
                    "You can see technical information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    textBoxDifficutly.ReadOnly = false;
                    textBoxInstruction.ReadOnly = false;
                    textBoxDescription.ReadOnly = false;
                    textBoxRecipeName.ReadOnly = false;
                    textBoxRecipeName.Visible = true;
                    labelUpdate.Visible = true;
                    textBoxLastUpdate.Visible = true;
                    textBoxLastUpdate.ReadOnly = false;
                    labelUUID.Visible = true;
                    textBoxUUID.Visible = true;
                    textBoxUUID.ReadOnly = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBoxDifficutly.ReadOnly = true;
                    textBoxInstruction.ReadOnly = true;
                    textBoxDescription.ReadOnly = true;
                    textBoxRecipeName.ReadOnly = true;
                    textBoxRecipeName.Visible = false;
                    labelUpdate.Visible = false;
                    textBoxLastUpdate.Visible = false;
                    textBoxLastUpdate.ReadOnly = true;
                    labelUUID.Visible = false;
                    textBoxUUID.Visible = false;
                    textBoxUUID.ReadOnly = true;
                    checkBox1.Checked = false;
                }
            }

            if (checkBox1.Checked == false)
            {
                textBoxDifficutly.ReadOnly = true;
                textBoxInstruction.ReadOnly = true;
                textBoxDescription.ReadOnly = true;
                textBoxRecipeName.ReadOnly = true;
                textBoxRecipeName.Visible = false;
                labelUpdate.Visible = false;
                textBoxLastUpdate.Visible = false;
                textBoxLastUpdate.ReadOnly = true;
                labelUUID.Visible = false;
                textBoxUUID.Visible = false;
                textBoxUUID.ReadOnly = true;
                checkBox1.Checked = false;
            }
        }
    }
}
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
            pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding(
                "ImageLocation", recipesBindingSource, "images__001", true));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipesDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipesDataSet.recipes);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == recipesDataSet.Tables["recipes"].Rows.Count - 1)
            {
                MessageBox.Show("There are no further recipes");
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("There are no further recipes");
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.SelectedIndex - 1;
            }
        }
    }
}


namespace BookOfRecipes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesDataSet = new BookOfRecipes.RecipesDataSet();
            this.recipesTableAdapter = new BookOfRecipes.RecipesDataSetTableAdapters.recipesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.comboBoxRecipeName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDifficutly = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.labelUUID = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.recipesDataSet;
            // 
            // recipesDataSet
            // 
            this.recipesDataSet.DataSetName = "RecipesDataSet";
            this.recipesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 225);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxInstruction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "instructions", true));
            this.textBoxInstruction.Location = new System.Drawing.Point(12, 314);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ReadOnly = true;
            this.textBoxInstruction.Size = new System.Drawing.Size(535, 167);
            this.textBoxInstruction.TabIndex = 4;
            // 
            // comboBoxRecipeName
            // 
            this.comboBoxRecipeName.DataSource = this.recipesBindingSource;
            this.comboBoxRecipeName.DisplayMember = "name";
            this.comboBoxRecipeName.FormattingEnabled = true;
            this.comboBoxRecipeName.Location = new System.Drawing.Point(12, 32);
            this.comboBoxRecipeName.Name = "comboBoxRecipeName";
            this.comboBoxRecipeName.Size = new System.Drawing.Size(535, 21);
            this.comboBoxRecipeName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instruction:";
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.Location = new System.Drawing.Point(262, 9);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(73, 13);
            this.labelRecipeName.TabIndex = 7;
            this.labelRecipeName.Text = "Recipe name:";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(383, 59);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(50, 13);
            this.labelDifficulty.TabIndex = 8;
            this.labelDifficulty.Text = "Difficulty:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(383, 82);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDifficutly
            // 
            this.textBoxDifficutly.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "difficulty", true));
            this.textBoxDifficutly.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxDifficutly.Location = new System.Drawing.Point(439, 56);
            this.textBoxDifficutly.Name = "textBoxDifficutly";
            this.textBoxDifficutly.ReadOnly = true;
            this.textBoxDifficutly.Size = new System.Drawing.Size(33, 20);
            this.textBoxDifficutly.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "description", true));
            this.textBoxDescription.Location = new System.Drawing.Point(383, 98);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(164, 186);
            this.textBoxDescription.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 491);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Chef mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxRecipeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "name", true));
            this.textBoxRecipeName.Location = new System.Drawing.Point(346, 7);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.ReadOnly = true;
            this.textBoxRecipeName.Size = new System.Drawing.Size(201, 20);
            this.textBoxRecipeName.TabIndex = 15;
            this.textBoxRecipeName.Visible = false;
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(110, 491);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(66, 13);
            this.labelUpdate.TabIndex = 16;
            this.labelUpdate.Text = "Last update:";
            this.labelUpdate.Visible = false;
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxLastUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "lastUpdated", true));
            this.textBoxLastUpdate.Location = new System.Drawing.Point(182, 487);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.ReadOnly = true;
            this.textBoxLastUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastUpdate.TabIndex = 17;
            this.textBoxLastUpdate.Visible = false;
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(288, 491);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(37, 13);
            this.labelUUID.TabIndex = 18;
            this.labelUUID.Text = "UUID:";
            this.labelUUID.Visible = false;
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.recipesBindingSource, "name", true));
            this.textBoxUUID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "uuid", true));
            this.textBoxUUID.Location = new System.Drawing.Point(331, 487);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.ReadOnly = true;
            this.textBoxUUID.Size = new System.Drawing.Size(216, 20);
            this.textBoxUUID.TabIndex = 19;
            this.textBoxUUID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 516);
            this.Controls.Add(this.textBoxUUID);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.textBoxLastUpdate);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.textBoxRecipeName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxDifficutly);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelRecipeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRecipeName);
            this.Controls.Add(this.textBoxInstruction);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Book of recipes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RecipesDataSet recipesDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipesDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.ComboBox comboBoxRecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDifficutly;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.TextBox textBoxUUID;
    }
}


namespace namegenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_maxsyllables = new System.Windows.Forms.Label();
            this.textBox_maxsyllables = new System.Windows.Forms.TextBox();
            this.button_generateName = new System.Windows.Forms.Button();
            this.button_generatePlaceName = new System.Windows.Forms.Button();
            this.checkBox_dividesyllables = new System.Windows.Forms.CheckBox();
            this.button_demonname = new System.Windows.Forms.Button();
            this.button_MarkovName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genrate Random Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(763, 43);
            this.textBox1.TabIndex = 1;
            // 
            // label_maxsyllables
            // 
            this.label_maxsyllables.AutoSize = true;
            this.label_maxsyllables.Location = new System.Drawing.Point(13, 68);
            this.label_maxsyllables.Name = "label_maxsyllables";
            this.label_maxsyllables.Size = new System.Drawing.Size(101, 13);
            this.label_maxsyllables.TabIndex = 2;
            this.label_maxsyllables.Text = "Maximum Syllables: ";
            // 
            // textBox_maxsyllables
            // 
            this.textBox_maxsyllables.Location = new System.Drawing.Point(110, 65);
            this.textBox_maxsyllables.Name = "textBox_maxsyllables";
            this.textBox_maxsyllables.Size = new System.Drawing.Size(33, 20);
            this.textBox_maxsyllables.TabIndex = 3;
            // 
            // button_generateName
            // 
            this.button_generateName.Location = new System.Drawing.Point(13, 121);
            this.button_generateName.Name = "button_generateName";
            this.button_generateName.Size = new System.Drawing.Size(144, 23);
            this.button_generateName.TabIndex = 4;
            this.button_generateName.Text = "Generate Name";
            this.button_generateName.UseVisualStyleBackColor = true;
            this.button_generateName.Click += new System.EventHandler(this.button_generateName_Click);
            // 
            // button_generatePlaceName
            // 
            this.button_generatePlaceName.Location = new System.Drawing.Point(13, 151);
            this.button_generatePlaceName.Name = "button_generatePlaceName";
            this.button_generatePlaceName.Size = new System.Drawing.Size(144, 23);
            this.button_generatePlaceName.TabIndex = 5;
            this.button_generatePlaceName.Text = "Generate Place Name";
            this.button_generatePlaceName.UseVisualStyleBackColor = true;
            this.button_generatePlaceName.Click += new System.EventHandler(this.button_generatePlaceName_Click);
            // 
            // checkBox_dividesyllables
            // 
            this.checkBox_dividesyllables.AutoSize = true;
            this.checkBox_dividesyllables.Location = new System.Drawing.Point(161, 68);
            this.checkBox_dividesyllables.Name = "checkBox_dividesyllables";
            this.checkBox_dividesyllables.Size = new System.Drawing.Size(100, 17);
            this.checkBox_dividesyllables.TabIndex = 7;
            this.checkBox_dividesyllables.Text = "Divide Syllables";
            this.checkBox_dividesyllables.UseVisualStyleBackColor = true;
            // 
            // button_demonname
            // 
            this.button_demonname.Location = new System.Drawing.Point(13, 181);
            this.button_demonname.Name = "button_demonname";
            this.button_demonname.Size = new System.Drawing.Size(144, 23);
            this.button_demonname.TabIndex = 8;
            this.button_demonname.Text = "Generate Demon Name";
            this.button_demonname.UseVisualStyleBackColor = true;
            this.button_demonname.Click += new System.EventHandler(this.button_demonname_Click);
            // 
            // button_MarkovName
            // 
            this.button_MarkovName.Location = new System.Drawing.Point(13, 211);
            this.button_MarkovName.Name = "button_MarkovName";
            this.button_MarkovName.Size = new System.Drawing.Size(144, 23);
            this.button_MarkovName.TabIndex = 9;
            this.button_MarkovName.Text = "Generate Markov Name";
            this.button_MarkovName.UseVisualStyleBackColor = true;
            this.button_MarkovName.Click += new System.EventHandler(this.button_MarkovName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 246);
            this.Controls.Add(this.button_MarkovName);
            this.Controls.Add(this.button_demonname);
            this.Controls.Add(this.checkBox_dividesyllables);
            this.Controls.Add(this.button_generatePlaceName);
            this.Controls.Add(this.button_generateName);
            this.Controls.Add(this.textBox_maxsyllables);
            this.Controls.Add(this.label_maxsyllables);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Random Word Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_maxsyllables;
        private System.Windows.Forms.TextBox textBox_maxsyllables;
        private System.Windows.Forms.Button button_generateName;
        private System.Windows.Forms.Button button_generatePlaceName;
        private System.Windows.Forms.CheckBox checkBox_dividesyllables;
        private System.Windows.Forms.Button button_demonname;
        private System.Windows.Forms.Button button_MarkovName;
    }
}


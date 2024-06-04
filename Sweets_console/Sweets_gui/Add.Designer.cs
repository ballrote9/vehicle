namespace Sweets_gui
{
    partial class Add
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.RosyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(260, 209);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Ok_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(339, 209);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Class:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sweets", "Candies", "Chocolates" });
            comboBox1.Location = new Point(13, 32);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(95, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 32);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 76);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 10;
            textBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 13;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 32);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 23);
            textBox3.TabIndex = 12;
            textBox3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 59);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 76);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(103, 23);
            textBox4.TabIndex = 14;
            textBox4.Visible = false;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(425, 257);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            MaximumSize = new Size(581, 306);
            Name = "Add";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add new";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
    }
}
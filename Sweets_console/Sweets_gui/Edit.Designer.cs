namespace Sweets_gui
{
    partial class Edit
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
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 68);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 33;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 85);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(103, 23);
            textBox4.TabIndex = 32;
            textBox4.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 23);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 31;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 42);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 23);
            textBox3.TabIndex = 30;
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 29;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 85);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 28;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 27;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 42);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 26;
            textBox1.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(364, 186);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 45;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.RosyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(285, 186);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 44;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(448, 232);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            MaximumSize = new Size(464, 340);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_form_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}

namespace L1
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
            this.clientsCombo = new System.Windows.Forms.ComboBox();
            this.restrictiiCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.expirarePick = new System.Windows.Forms.DateTimePicker();
            this.motiv_text = new System.Windows.Forms.TextBox();
            this.id_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsCombo
            // 
            this.clientsCombo.FormattingEnabled = true;
            this.clientsCombo.Location = new System.Drawing.Point(19, 37);
            this.clientsCombo.Name = "clientsCombo";
            this.clientsCombo.Size = new System.Drawing.Size(289, 24);
            this.clientsCombo.TabIndex = 2;
            this.clientsCombo.SelectionChangeCommitted += new System.EventHandler(this.clientsCombo_Selectat);
            // 
            // restrictiiCombo
            // 
            this.restrictiiCombo.FormattingEnabled = true;
            this.restrictiiCombo.Location = new System.Drawing.Point(39, 37);
            this.restrictiiCombo.Name = "restrictiiCombo";
            this.restrictiiCombo.Size = new System.Drawing.Size(344, 24);
            this.restrictiiCombo.TabIndex = 3;
            this.restrictiiCombo.SelectedIndexChanged += new System.EventHandler(this.restrictiiCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientsCombo);
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 362);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectează Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.expirarePick);
            this.groupBox2.Controls.Add(this.motiv_text);
            this.groupBox2.Controls.Add(this.id_Text);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.restrictiiCombo);
            this.groupBox2.Location = new System.Drawing.Point(369, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 362);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restricții";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "ȘTERGE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expirarePick
            // 
            this.expirarePick.Location = new System.Drawing.Point(161, 160);
            this.expirarePick.Name = "expirarePick";
            this.expirarePick.Size = new System.Drawing.Size(222, 22);
            this.expirarePick.TabIndex = 9;
            // 
            // motiv_text
            // 
            this.motiv_text.Location = new System.Drawing.Point(161, 123);
            this.motiv_text.Name = "motiv_text";
            this.motiv_text.Size = new System.Drawing.Size(222, 22);
            this.motiv_text.TabIndex = 8;
            // 
            // id_Text
            // 
            this.id_Text.Enabled = false;
            this.id_Text.Location = new System.Drawing.Point(161, 88);
            this.id_Text.Name = "id_Text";
            this.id_Text.Size = new System.Drawing.Size(222, 22);
            this.id_Text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Expirării";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motiv";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "Adaugă";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox id_Text;
        private System.Windows.Forms.TextBox motiv_text;
        private System.Windows.Forms.DateTimePicker expirarePick;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.ComboBox restrictiiCombo;

        private System.Windows.Forms.ComboBox clientsCombo;

        #endregion
    }
}
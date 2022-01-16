
namespace p2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ZonecomboBox2 = new System.Windows.Forms.ComboBox();
            this.push = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Eteindre = new System.Windows.Forms.Button();
            this.allumer = new System.Windows.Forms.Button();
            this.deconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(973, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 791);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ZonecomboBox2);
            this.panel6.Controls.Add(this.push);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 510);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 103);
            this.panel6.TabIndex = 9;
            this.panel6.Visible = false;
            // 
            // ZonecomboBox2
            // 
            this.ZonecomboBox2.FormattingEnabled = true;
            this.ZonecomboBox2.Items.AddRange(new object[] {
            "Zone1",
            "Zone2",
            "Zone3",
            "Zone4",
            "Zone5",
            "Zone6",
            "Zone7"});
            this.ZonecomboBox2.Location = new System.Drawing.Point(83, 14);
            this.ZonecomboBox2.Name = "ZonecomboBox2";
            this.ZonecomboBox2.Size = new System.Drawing.Size(145, 24);
            this.ZonecomboBox2.TabIndex = 10;
            // 
            // push
            // 
            this.push.BackColor = System.Drawing.Color.Teal;
            this.push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push.ForeColor = System.Drawing.Color.White;
            this.push.Location = new System.Drawing.Point(57, 57);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(118, 39);
            this.push.TabIndex = 2;
            this.push.Text = "Push";
            this.push.UseVisualStyleBackColor = false;
            this.push.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zone :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.Eteindre);
            this.panel5.Controls.Add(this.allumer);
            this.panel5.Controls.Add(this.deconnect);
            this.panel5.Controls.Add(this.connect);
            this.panel5.Location = new System.Drawing.Point(6, 619);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 168);
            this.panel5.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Zone1",
            "Zone2",
            "Zone3",
            "Zone4",
            "Zone5",
            "Zone6",
            "Zone7"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Eteindre
            // 
            this.Eteindre.BackColor = System.Drawing.Color.White;
            this.Eteindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eteindre.Enabled = false;
            this.Eteindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eteindre.ForeColor = System.Drawing.Color.White;
            this.Eteindre.Image = global::p2.Properties.Resources.switch_off;
            this.Eteindre.Location = new System.Drawing.Point(119, 107);
            this.Eteindre.Name = "Eteindre";
            this.Eteindre.Size = new System.Drawing.Size(106, 56);
            this.Eteindre.TabIndex = 3;
            this.Eteindre.UseVisualStyleBackColor = false;
            this.Eteindre.Click += new System.EventHandler(this.Eteindre_Click);
            // 
            // allumer
            // 
            this.allumer.BackColor = System.Drawing.Color.White;
            this.allumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.allumer.Enabled = false;
            this.allumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allumer.ForeColor = System.Drawing.Color.White;
            this.allumer.Image = global::p2.Properties.Resources.switch_on;
            this.allumer.Location = new System.Drawing.Point(5, 107);
            this.allumer.Name = "allumer";
            this.allumer.Size = new System.Drawing.Size(108, 56);
            this.allumer.TabIndex = 2;
            this.allumer.UseVisualStyleBackColor = false;
            this.allumer.Click += new System.EventHandler(this.allumer_Click);
            // 
            // deconnect
            // 
            this.deconnect.BackColor = System.Drawing.Color.White;
            this.deconnect.Enabled = false;
            this.deconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deconnect.ForeColor = System.Drawing.Color.White;
            this.deconnect.Image = global::p2.Properties.Resources.unplugged;
            this.deconnect.Location = new System.Drawing.Point(119, 33);
            this.deconnect.Name = "deconnect";
            this.deconnect.Size = new System.Drawing.Size(106, 68);
            this.deconnect.TabIndex = 1;
            this.deconnect.UseVisualStyleBackColor = false;
            this.deconnect.Click += new System.EventHandler(this.deconnect_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.White;
            this.connect.Enabled = false;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Image = global::p2.Properties.Resources.connect;
            this.connect.Location = new System.Drawing.Point(5, 33);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(108, 68);
            this.connect.TabIndex = 0;
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(126, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(113, 35);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.checkBox9);
            this.panel4.Controls.Add(this.checkBox8);
            this.panel4.Controls.Add(this.checkBox7);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Location = new System.Drawing.Point(6, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 379);
            this.panel4.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Image = global::p2.Properties.Resources.door;
            this.checkBox1.Location = new System.Drawing.Point(15, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 85);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "       ";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Image = global::p2.Properties.Resources.smart_tv__1_;
            this.checkBox9.Location = new System.Drawing.Point(115, 94);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(90, 85);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "               ";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Image = global::p2.Properties.Resources.wireless_router__1_;
            this.checkBox8.Location = new System.Drawing.Point(15, 182);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(102, 85);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "                  ";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Image = global::p2.Properties.Resources.ac;
            this.checkBox7.Location = new System.Drawing.Point(15, 282);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(102, 85);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "                  ";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Image = global::p2.Properties.Resources.light_bulb__2_;
            this.checkBox4.Location = new System.Drawing.Point(15, 103);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 53);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "   ";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Image = global::p2.Properties.Resources.fridge__1_;
            this.checkBox2.Location = new System.Drawing.Point(114, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 85);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "        ";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 791);
            this.panel2.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Blue;
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.Enabled = false;
            this.radioButton4.ForeColor = System.Drawing.Color.Blue;
            this.radioButton4.Location = new System.Drawing.Point(585, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Yellow;
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.Enabled = false;
            this.radioButton3.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton3.Location = new System.Drawing.Point(681, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Lime;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.Enabled = false;
            this.radioButton2.ForeColor = System.Drawing.Color.Lime;
            this.radioButton2.Location = new System.Drawing.Point(792, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Red;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton1.Enabled = false;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(870, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Connecter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deconnecter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Allumer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(886, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eteindre";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 737);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::p2.Properties.Resources.exit;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(280, 604);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(82, 80);
            this.panel7.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Eteindre;
        private System.Windows.Forms.Button allumer;
        private System.Windows.Forms.Button deconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ZonecomboBox2;
        private System.Windows.Forms.Panel panel7;
    }
}


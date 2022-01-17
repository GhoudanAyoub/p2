
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
            this.push = new System.Windows.Forms.Button();
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
            this.panel6.Controls.Add(this.push);
            this.panel6.Location = new System.Drawing.Point(3, 564);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 49);
            this.panel6.TabIndex = 9;
            this.panel6.Visible = false;
            // 
            // push
            // 
            this.push.BackColor = System.Drawing.Color.Teal;
            this.push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push.ForeColor = System.Drawing.Color.White;
            this.push.Location = new System.Drawing.Point(59, 3);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(118, 39);
            this.push.TabIndex = 2;
            this.push.Text = "Push";
            this.push.UseVisualStyleBackColor = false;
            this.push.Click += new System.EventHandler(this.button7_Click);
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
            this.checkBox8.Size = new System.Drawing.Size(130, 85);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "                         ";
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
            this.checkBox7.Size = new System.Drawing.Size(114, 85);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "                     ";
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 791);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 782);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::p2.Properties.Resources.exit;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(274, 649);
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
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Panel panel7;
    }
}


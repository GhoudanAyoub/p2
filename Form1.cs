using p2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        HomeService homeService = new HomeService();
        public Form1()
        {
            InitializeComponent();
            initFridge();
            initExitSwitch();
            initCapt();
        }


        Panel myControle;
        Panel b;
        private Control activeControle;
        private Point previousPoint;
        List<Panel> panels = new List<Panel>();
        private static int panelN = 1;
        private CheckBox check;
        private List<home> homeList;

        private void initCapt()
        {
            homeList = homeService.afficher();
            foreach (home item in homeList)
            {
                myControle = new Panel();
                myControle.Location = new Point(item.X,item.Y);
                myControle.Size = new Size(64, 64);
                myControle.Text = (panelN).ToString();
                myControle.Name = item.Name;
                myControle.BackColor = Color.Transparent;
                myControle.Click += b_Click;
                changeIcon(myControle, item.Status);
                myControle.BackgroundImageLayout = ImageLayout.Stretch;
                myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
                myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
                myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
                panel3.Controls.Add(myControle);
                panelN++;
            }
        }
        private void initFridge()
        {
            myControle = new Panel();
            myControle.Location = new Point(530, 480);
            myControle.Size = new Size(64, 64);
            myControle.Text = (panelN).ToString();
            myControle.Name = string.Format("Fridge1");
            myControle.BackColor = Color.Transparent;
            myControle.Click += b_Click;
            myControle.BackgroundImage = Properties.Resources.fridge;
            myControle.BackgroundImageLayout = ImageLayout.Stretch;
            myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
            myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
            myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
            panel3.Controls.Add(myControle);

        }
        private void initExitSwitch()
        {
            panel7.Click += ExitSwitch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelN++;
            myControle = new Panel();
            if (checkBox1.Checked)
            {
                check = checkBox1;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                myControle.Name = string.Format("door {0}", panelN);
            }
            else if (checkBox2.Checked)
            {
                check = checkBox2;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                myControle.Name = string.Format("frigde {0}", panelN);
            }
            else if (checkBox4.Checked)
            {
                check = checkBox4;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false; 
                myControle.Name = string.Format("lamp {0}", panelN);
            }
            else if (checkBox7.Checked)
            {
                check = checkBox7;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                myControle.Name = string.Format("ac {0}", panelN);
            }
            else if (checkBox8.Checked)
            {
                check = checkBox8;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox2.Checked = false;
                checkBox9.Checked = false;
                myControle.Name = string.Format("router {0}", panelN);
            }
            else if (checkBox9.Checked)
            {
                check = checkBox9;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                myControle.Name = string.Format("tv {0}", panelN);
            }
            myControle.Location = new Point(300, 200);
            myControle.Size = new Size(64, 64);
            myControle.Text = (panelN).ToString();
            myControle.BackColor = Color.Transparent;
            myControle.Click += b_Click;
            myControle.BackgroundImage = check.Image;
            myControle.BackgroundImageLayout = ImageLayout.Stretch;
            myControle.MouseDown += new MouseEventHandler(myContrl_MouseDown);
            myControle.MouseMove += new MouseEventHandler(myContrl_MouseMove);
            myControle.MouseUp += new MouseEventHandler(myContrl_MMouseUp);
            panel3.Controls.Add(myControle);
            panels.Add(myControle);
            removeButton.Enabled = true;

        }

        void b_Click(object sender, EventArgs e)
        {
            b = sender as Panel;
            if (b != null)
            {
                bool exist = homeService.AfficherParIndex(int.Parse(b.Text));
                if (exist == false)
                    panel6.Visible = true;
                else
                    checkStatus(b);
            }
        }

        private void checkStatus(Panel b)
        {
            if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("E"))
            {
                deconnect.Enabled = true;
                allumer.Enabled = true;
                Eteindre.Enabled = false;
                connect.Enabled = false;
            }else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("A"))
            {
                Eteindre.Enabled = true;
                deconnect.Enabled = true;
                allumer.Enabled = false;
                connect.Enabled = false;
            }
            else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("D"))
            {
                Eteindre.Enabled = false;
                allumer.Enabled = false;
                deconnect.Enabled = false;
                connect.Enabled = true;
            }
            else if (homeService.AfficherStatus(int.Parse(b.Text)).Contains("C"))
            {
                Eteindre.Enabled = false;
                allumer.Enabled = true;
                connect.Enabled = false;
                deconnect.Enabled = true;
            }
        }

        private void myContrl_MMouseUp(object sender, MouseEventArgs e)
        {
            activeControle = null;
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void myContrl_MouseMove(object sender, MouseEventArgs e)
        {
            if(activeControle==null || activeControle != sender)
            {
                return;
            }
            var location = activeControle.Location;
            location.Offset(e.Location.X - previousPoint.X, e.Location.Y - previousPoint.Y);
            activeControle.Location = location;
        }

        private void myContrl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControle = sender as Control;
            previousPoint = e.Location;
            Cursor = Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(homeService.AfficherParIndex(panelN)==true)homeService.delete(panelN);
            if (panel3.Controls.Count == (homeList.Count()+3) ) removeButton.Enabled = false;
            panel3.Controls.Remove(panels.Last());
            panels.RemoveAt(panelN -(homeList.Count()+2));
            panelN--;
            panel6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Point locationOnForm = myControle.FindForm().PointToClient(myControle.Parent.PointToScreen(myControle.Location));

            DialogResult dialogClose = MessageBox.Show("Do you Want To Add This "+ myControle.Name, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dialogClose == DialogResult.OK)
            {
                homeService.Ajouter(new home(myControle.Name, ZonecomboBox2.Text,"E",panelN , locationOnForm.X-1 , locationOnForm.Y-1));
                panel6.Visible = false;
            }
            else if (dialogClose == DialogResult.Cancel)
            {
                panel3.Controls.Remove(panels.Last());
                panels.RemoveAt(panelN - 2);
                panelN--;
                panel6.Visible = false;
            }
        }

        private void allumer_Click(object sender, EventArgs e)
        {

            DialogResult dialogClose = MessageBox.Show("Do you Want To Turn On This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
            Eteindre.Enabled = true;
            allumer.Enabled = false;
            homeService.Modifier(int.Parse(b.Text), "A");
            changeIcon(b, "A");
            }
           
        }

        private void Eteindre_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Do you Want To Turn Off This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                Eteindre.Enabled = false;
                allumer.Enabled = true;
                homeService.Modifier(int.Parse(b.Text), "E");
                changeIcon(b, "E");
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Do you Want To Connect This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                connect.Enabled = false;
                deconnect.Enabled = true;
                allumer.Enabled = true;
                Eteindre.Enabled = false;
                homeService.Modifier(int.Parse(b.Text), "C");
                changeIcon(b, "C");
            }

        }

        private void deconnect_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Do you Want To Deconnect This !!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                connect.Enabled = true;
                deconnect.Enabled = false;
                allumer.Enabled = false;
                Eteindre.Enabled = false;
                homeService.Modifier(int.Parse(b.Text), "D");
                changeIcon(b, "D");
            }
        }
        private void changeIcon(Panel b,String valeur)
        {
            if (valeur.Contains("A") ){
                if (b.Name.Contains("tv")) b.BackgroundImage = Properties.Resources.smart_tv;
                else if (b.Name.Contains("door") ) b.BackgroundImage = Properties.Resources.door__1_;
                else if (b.Name.Contains("lamp") ) b.BackgroundImage = Properties.Resources.light_bulb;
                else if (b.Name.Contains("router") ) b.BackgroundImage = Properties.Resources.wireless_router;
                else if (b.Name.Contains("ac") ) b.BackgroundImage = Properties.Resources.ac__1_;
            }else
            {

                if (b.Name.Contains("tv")) b.BackgroundImage = Properties.Resources.smart_tv__1_;
                else if (b.Name.Contains("door")) b.BackgroundImage = Properties.Resources.door;
                else if (b.Name.Contains("lamp")) b.BackgroundImage = Properties.Resources.light_bulb__2_;
                else if (b.Name.Contains("router")) b.BackgroundImage = Properties.Resources.wireless_router__1_;
                else if (b.Name.Contains("ac")) b.BackgroundImage = Properties.Resources.ac;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                checkBox2.Checked = false;
                checkBox9.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            checkBox2.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (homeService.checkZoneAllu(comboBox1.Text)) { 
                    connect.Enabled = false; deconnect.Enabled = true;
                Eteindre.Enabled = true;allumer.Enabled = true;
                }
                else
            { 
                connect.Enabled = true; deconnect.Enabled = true;
                Eteindre.Enabled = true; allumer.Enabled = true;
            }
        }
        void  ExitSwitch(object sender, EventArgs e)
        {
            Panel b = (Panel)sender;
            DialogResult dialogClose = MessageBox.Show("Do you Want To Exit Home", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                b.BackgroundImage = Properties.Resources.exit__1_;

                panel3.Controls.Clear();
                panels.Clear();
                if (homeService.killSwitch())
                    this.Close();
            }
        }
}
}

/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ                                    *
**		 BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                          *
**			 BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                                 *
**			            NDP DERSÝ                                           *
**	                                                                        *
**				PROJE NUMARASI………………………………: 1                               *
**				ÖÐRENCÝ ADI………………………………………: Melih Dedeoðlu                  *			            
**                                                                          *
****************************************************************************/



using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ndpproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çember");
            listBox1.Items.Add("Küre");
            listBox1.Items.Add("Dörtgen");
            listBox1.Items.Add("Prizma");
            listBox1.Items.Add("Silindir");
            listBox1.Items.Add("Yüzey");
            listBox1.Items.Add("Ýki boyutlu nokta");
            listBox1.Items.Add("Üç boyutlu nokta");

            listBox2.Items.Add("Çember");
            listBox2.Items.Add("Küre");
            listBox2.Items.Add("Dörtgen");
            listBox2.Items.Add("Prizma");
            listBox2.Items.Add("Silindir");
            listBox2.Items.Add("Ýki boyutlu nokta");
            listBox2.Items.Add("Üç boyutlu nokta");

            comboBox1.Items.Add("X-Y ekseni");
            comboBox1.Items.Add("Y-Z ekseni");
            comboBox1.Items.Add("X-Z ekseni");
        }

        int x1;
        int y1;
        int z1;
        int rEn1;
        int hBoy1;
        int gen1;

        int x2;
        int y2;
        int z2;
        int rEn2;
        int hBoy2;
        int gen2;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                x1 = 0;
            else
                x1 = Convert.ToInt32(textBox1.Text);

            if (textBox2.Text == "")
                y1 = 0;
            else
                y1 = Convert.ToInt32(textBox2.Text);

            if (textBox3.Text == "")
                z1 = 0;
            else
                z1 = Convert.ToInt32(textBox3.Text);

            if (textBox4.Text == "")
                rEn1 = 0;
            else
                rEn1 = Convert.ToInt32(textBox4.Text);

            if (textBox5.Text == "")
                hBoy1 = 0;
            else
                hBoy1 = Convert.ToInt32(textBox5.Text);

            if (textBox6.Text == "")
                gen1 = 0;
            else
                gen1 = Convert.ToInt32(textBox6.Text);

            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                x2 = 0;
            else
                x2 = Convert.ToInt32(textBox7.Text);

            if (textBox8.Text == "")
                y2 = 0;
            else
                y2 = Convert.ToInt32(textBox8.Text);

            if (textBox9.Text == "")
                z2 = 0;
            else
                z2 = Convert.ToInt32(textBox9.Text);

            if (textBox10.Text == "")
                rEn2 = 0;
            else
                rEn2 = Convert.ToInt32(textBox10.Text);

            if (textBox11.Text == "")
                hBoy2 = 0;
            else
                hBoy2 = Convert.ToInt32(textBox11.Text);

            if (textBox12.Text == "")
                gen2 = 0;
            else
                gen2 = Convert.ToInt32(textBox12.Text);

            panel1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            x1 = 0;
            y1 = 0;
            z1 = 0;
            rEn1 = 0;
            hBoy1 = 0;
            gen1 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            panel1.Refresh();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            x2 = 0;
            y2 = 0;
            z2 = 0;
            rEn2 = 0;
            hBoy2 = 0;
            gen2 = 0;
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

            panel1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            label6.Visible = false;

            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = false;
            label12.Visible = false;

            label4.Text = "R/En";
            label5.Text = "H/Boy";
            label10.Text = "R/En";
            label11.Text = "H/Boy";

            label13.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;

            label15.Visible = false;
            label18.Visible = false;


            Graphics g = panel1.CreateGraphics();

            Pen p1 = new Pen(Color.Blue);
            Pen p2 = new Pen(Color.Red);
            Pen p3 = new Pen(Color.Black);

            g.DrawLine(p3, 0, 300, 600, 300);
            g.DrawLine(p3, 300, 0, 300, 600);

            Point ortanokta = new Point(300, 300);

            nokta nokta1 = new nokta();
            nokta nokta2 = new nokta();
            nokta3d nokta3d1 = new nokta3d();
            nokta3d nokta3d2 = new nokta3d();
            cember cember1 = new cember();
            cember cember2 = new cember();
            kure kure1 = new kure();
            kure kure2 = new kure();
            dikdortgen dikdortgen1 = new dikdortgen();
            dikdortgen dikdortgen2 = new dikdortgen();
            prizma prizma1 = new prizma();
            prizma prizma2 = new prizma();
            silindir silindir1 = new silindir();
            silindir silindir2 = new silindir();



            if (listBox1.SelectedIndex == 0) //çember
            {
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                label4.Text = "R";

                cember1.Merkez.X = x1;
                cember1.Merkez.Y = y1;
                cember1.R = rEn1;

                g.DrawEllipse(p1, ortanokta.X + cember1.Merkez.X - cember1.R, ortanokta.Y - cember1.Merkez.Y - cember1.R, 2 * cember1.R, 2 * cember1.R);
            }

            if (listBox2.SelectedIndex == 0) //çember
            {
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                label10.Text = "R";

                cember2.Merkez.X = x2;
                cember2.Merkez.Y = y2;
                cember2.R = rEn2;

                g.DrawEllipse(p2, ortanokta.X + cember2.Merkez.X - cember2.R, ortanokta.Y - cember2.Merkez.Y - cember2.R, 2 * cember2.R, 2 * cember2.R);
            }

            if (listBox1.SelectedIndex == 1) //küre
            {
                textBox5.Enabled = false;
                label4.Text = "R";

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                kure1.Merkez.X = x1;
                kure1.Merkez.Y = y1;
                kure1.Merkez.Z = z1;
                kure1.R = rEn1;

                g.DrawEllipse(p1, ortanokta.X + kure1.Merkez.X - kure1.R - z1 / 2, ortanokta.Y - kure1.Merkez.Y - kure1.R + z1 / 2, 2 * kure1.R, 2 * kure1.R);
                g.DrawEllipse(p1, ortanokta.X + kure1.Merkez.X - kure1.R - z1 / 2, ortanokta.Y - kure1.Merkez.Y - kure1.R / 4 + z1 / 2, 2 * kure1.R, kure1.R / 2);
            }

            if (listBox2.SelectedIndex == 1) //küre
            {
                textBox11.Enabled = false;
                label10.Text = "R";

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                kure2.Merkez.X = x2;
                kure2.Merkez.Y = y2;
                kure2.Merkez.Z = z2;
                kure2.R = rEn2;

                g.DrawEllipse(p2, ortanokta.X + kure2.Merkez.X - kure2.R - z2 / 2, ortanokta.Y - kure2.Merkez.Y - kure2.R + z2 / 2, 2 * kure2.R, 2 * kure2.R);
                g.DrawEllipse(p2, ortanokta.X + kure2.Merkez.X - kure2.R - z2 / 2, ortanokta.Y - kure2.Merkez.Y - kure2.R / 4 + z2 / 2, 2 * kure2.R, kure2.R / 2);
            }

            if (listBox1.SelectedIndex == 2) //dikdörtgen
            {
                textBox3.Enabled = false;
                label4.Text = "En";
                label5.Text = "Boy";

                dikdortgen1.Merkez.X = x1;
                dikdortgen1.Merkez.Y = y1;
                dikdortgen1.En = rEn1;
                dikdortgen1.Boy = hBoy1;

                Rectangle dortgen1 = new Rectangle(ortanokta.X + dikdortgen1.Merkez.X - dikdortgen1.En / 2, ortanokta.Y - dikdortgen1.Merkez.Y - dikdortgen1.Boy / 2, dikdortgen1.En, dikdortgen1.Boy);

                g.DrawRectangle(p1, dortgen1);

            }

            if (listBox2.SelectedIndex == 2) //dikdörtgen
            {
                textBox9.Enabled = false;
                label10.Text = "En";
                label11.Text = "Boy";

                dikdortgen2.Merkez.X = x2;
                dikdortgen2.Merkez.Y = y2;
                dikdortgen2.En = rEn2;
                dikdortgen2.Boy = hBoy2;

                Rectangle dortgen2 = new Rectangle(ortanokta.X + dikdortgen2.Merkez.X - dikdortgen2.En / 2, ortanokta.Y - dikdortgen2.Merkez.Y - dikdortgen2.Boy / 2, dikdortgen2.En, dikdortgen2.Boy);

                g.DrawRectangle(p2, dortgen2);

            }

            if(listBox1.SelectedIndex==3) //prizma
            {
                label4.Text = "En";
                label5.Text = "Boy";
                label6.Visible = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                prizma1.Merkez.X = x1;
                prizma1.Merkez.Y = y1;
                prizma1.Merkez.Z = z1;
                prizma1.En = rEn1;
                prizma1.Boy = hBoy1;
                prizma1.Gen = gen1;

                Rectangle prizma11 = new Rectangle(ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 - prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 + prizma1.Gen / 4, prizma1.En, prizma1.Boy);
                Rectangle prizma12 = new Rectangle(ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 - prizma1.Gen / 4, prizma1.En, prizma1.Boy);

                g.DrawRectangle(p1, prizma11);
                g.DrawRectangle(p1, prizma12);

                g.DrawLine(p1, ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 - prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 - prizma1.Gen / 4);
                g.DrawLine(p1, ortanokta.X + prizma1.Merkez.X + prizma1.En / 2 - prizma1.Merkez.Z / 2 - prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.X + prizma1.Merkez.X + prizma1.En / 2 - prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y - prizma1.Boy / 2 + prizma1.Merkez.Z / 2 - prizma1.Gen / 4);
                g.DrawLine(p1, ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 - prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y + prizma1.Boy / 2 + prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.X + prizma1.Merkez.X - prizma1.En / 2 - prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y + prizma1.Boy / 2 + prizma1.Merkez.Z / 2 - prizma1.Gen / 4);
                g.DrawLine(p1, ortanokta.X + prizma1.Merkez.X + prizma1.En / 2 - prizma1.Merkez.Z / 2 - prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y + prizma1.Boy / 2 + prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.X + prizma1.Merkez.X + prizma1.En / 2 - prizma1.Merkez.Z / 2 + prizma1.Gen / 4, ortanokta.Y - prizma1.Merkez.Y + prizma1.Boy / 2 + prizma1.Merkez.Z / 2 - prizma1.Gen / 4);
            }

            if(listBox2.SelectedIndex==3) //prizma
            {
                label10.Text = "En";
                label11.Text = "Boy";
                label12.Visible = true;
                textBox12.Visible = true;
                textBox12.Enabled = true;

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                prizma2.Merkez.X = x2;
                prizma2.Merkez.Y = y2;
                prizma2.Merkez.Z = z2;
                prizma2.En = rEn2;
                prizma2.Boy = hBoy2;
                prizma2.Gen = gen2;

                Rectangle prizma21 = new Rectangle(ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 - prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 + prizma2.Gen / 4, prizma2.En, prizma2.Boy);
                Rectangle prizma22 = new Rectangle(ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 - prizma2.Gen / 4, prizma2.En, prizma2.Boy);

                g.DrawRectangle(p2, prizma21);
                g.DrawRectangle(p2, prizma22);

                g.DrawLine(p2, ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 - prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 - prizma2.Gen / 4);
                g.DrawLine(p2, ortanokta.X + prizma2.Merkez.X + prizma2.En / 2 - prizma2.Merkez.Z / 2 - prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.X + prizma2.Merkez.X + prizma2.En / 2 - prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y - prizma2.Boy / 2 + prizma2.Merkez.Z / 2 - prizma2.Gen / 4);
                g.DrawLine(p2, ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 - prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y + prizma2.Boy / 2 + prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.X + prizma2.Merkez.X - prizma2.En / 2 - prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y + prizma2.Boy / 2 + prizma2.Merkez.Z / 2 - prizma2.Gen / 4);
                g.DrawLine(p2, ortanokta.X + prizma2.Merkez.X + prizma2.En / 2 - prizma2.Merkez.Z / 2 - prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y + prizma2.Boy / 2 + prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.X + prizma2.Merkez.X + prizma2.En / 2 - prizma2.Merkez.Z / 2 + prizma2.Gen / 4, ortanokta.Y - prizma2.Merkez.Y + prizma2.Boy / 2 + prizma2.Merkez.Z / 2 - prizma2.Gen / 4);
            }

            if(listBox1.SelectedIndex==4) //silindir
            {
                label4.Text = "R";
                label5.Text = "H";

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                silindir1.Merkez.X = x1;
                silindir1.Merkez.Y = y1;
                silindir1.Merkez.Z = z1;
                silindir1.R = rEn1;
                silindir1.H = hBoy1;

                g.DrawEllipse(p1, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 - silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 - silindir1.R / 2 - silindir1.H / 2, 2 * silindir1.R, silindir1.R);
                g.DrawEllipse(p1, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 - silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 - silindir1.R / 2 + silindir1.H / 2, 2 * silindir1.R, silindir1.R);

                g.DrawLine(p1, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 - silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 - silindir1.H / 2, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 - silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 + silindir1.H / 2);
                g.DrawLine(p1, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 + silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 - silindir1.H / 2, ortanokta.X + silindir1.Merkez.X - silindir1.Merkez.Z / 2 + silindir1.R, ortanokta.Y - silindir1.Merkez.Y + silindir1.Merkez.Z / 2 + silindir1.H / 2);

            }

            if (listBox2.SelectedIndex == 4) //silindir
            {
                label10.Text = "R";
                label11.Text = "H";

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                silindir2.Merkez.X = x2;
                silindir2.Merkez.Y = y2;
                silindir2.Merkez.Z = z2;
                silindir2.R = rEn2;
                silindir2.H = hBoy2;

                g.DrawEllipse(p2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 - silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 - silindir2.R / 2 - silindir2.H / 2, 2 * silindir2.R, silindir2.R);
                g.DrawEllipse(p2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 - silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 - silindir2.R / 2 + silindir2.H / 2, 2 * silindir2.R, silindir2.R);
                g.DrawLine(p2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 - silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 - silindir2.H / 2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 - silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 + silindir2.H / 2);
                g.DrawLine(p2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 + silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 - silindir2.H / 2, ortanokta.X + silindir2.Merkez.X - silindir2.Merkez.Z / 2 + silindir2.R, ortanokta.Y - silindir2.Merkez.Y + silindir2.Merkez.Z / 2 + silindir2.H / 2);

            }

            if(listBox1.SelectedIndex==6) //iki boyutlu nokta
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                nokta1.X = x1;
                nokta1.Y = y1;

                g.DrawEllipse(p1, ortanokta.X + nokta1.X, ortanokta.Y - nokta1.Y, 2, 2);
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, ortanokta.X + nokta1.X, ortanokta.Y - nokta1.Y, 2, 2);
            }

            if (listBox2.SelectedIndex == 5) //iki boyutlu nokta
            {
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;

                nokta2.X = x2;
                nokta2.Y = y2;

                g.DrawEllipse(p2, ortanokta.X + nokta2.X, ortanokta.Y - nokta2.Y, 2, 2);
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, ortanokta.X + nokta2.X, ortanokta.Y - nokta2.Y, 2, 2);
            }

            if(listBox1.SelectedIndex==7) //üç boyutlu nokta
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                nokta3d1.X = x1;
                nokta3d1.Y = y1;
                nokta3d1.Z = z1;

                g.DrawEllipse(p1, ortanokta.X + nokta3d1.X-nokta3d1.Z/2, ortanokta.Y - nokta3d1.Y + nokta3d1.Z / 2, 2, 2);
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, ortanokta.X + nokta3d1.X - nokta3d1.Z / 2, ortanokta.Y - nokta3d1.Y + nokta3d1.Z / 2, 2, 2);
            }
            if (listBox2.SelectedIndex == 6) //üç boyutlu nokta
            {
                textBox10.Enabled = false;
                textBox11.Enabled = false;

                float[] cizgidegeri = { 2, 2, 2 };
                p3.DashPattern = cizgidegeri;
                g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                label18.Visible = true;

                nokta3d2.X = x2;
                nokta3d2.Y = y2;
                nokta3d2.Z = z2;

                g.DrawEllipse(p2, ortanokta.X + nokta3d2.X - nokta3d2.Z / 2, ortanokta.Y - nokta3d2.Y + nokta3d2.Z / 2, 2, 2);
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, ortanokta.X + nokta3d2.X - nokta3d2.Z / 2, ortanokta.Y - nokta3d2.Y + nokta3d2.Z / 2, 2, 2);
            }

            if(listBox1.SelectedIndex==5) // yüzey
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                comboBox1.Enabled = true;
                comboBox1.Visible = true;
                label13.Visible = true;


                if (comboBox1.SelectedIndex == 0) // X-Y yüzeyi
                {
                    Brush brush = new SolidBrush(Color.LightBlue);

                    Point[] noktalar = new Point[]
                       {
                    new Point(150,150),
                    new Point(450,150),
                    new Point(450,450),
                    new Point(150,450)
                       };

                    g.FillPolygon(brush, noktalar);

                    g.DrawLine(p3, 0, 300, 600, 300);
                    g.DrawLine(p3, 300, 0, 300, 600);
                    float[] cizgidegeri = { 2, 2, 2 };
                    p3.DashPattern = cizgidegeri;
                    g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                    label18.Visible = true;

                }
                if (comboBox1.SelectedIndex == 1) //Y-Z yüzeyi
                {
                    Brush brush = new SolidBrush(Color.LightBlue);

                    Point[] noktalar = new Point[]
                       {
                    new Point(150,300),
                    new Point(450,0),
                    new Point(450,300),
                    new Point(150,600)
                       };

                    g.FillPolygon(brush, noktalar);

                    g.DrawLine(p3, 0, 300, 600, 300);
                    g.DrawLine(p3, 300, 0, 300, 600);
                    float[] cizgidegeri = { 2, 2, 2 };
                    p3.DashPattern = cizgidegeri;
                    g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                    label18.Visible = true;
                }
                if (comboBox1.SelectedIndex == 2) //X-Z yüzeyi
                {
                    Brush brush = new SolidBrush(Color.LightBlue);

                    Point[] noktalar = new Point[]
                       {
                    new Point(300,150),
                    new Point(600,150),
                    new Point(300,450),
                    new Point(0,450)
                       };

                    g.FillPolygon(brush, noktalar);

                    g.DrawLine(p3, 0, 300, 600, 300);
                    g.DrawLine(p3, 300, 0, 300, 600);
                    float[] cizgidegeri = { 2, 2, 2 };
                    p3.DashPattern = cizgidegeri;
                    g.DrawLine(p3, new Point(600, 0), new Point(0, 600));
                    label18.Visible = true;
                }
            }

            //çizimler bitti



            //çarpýþma denetimleri


            if(listBox1.SelectedIndex==0 && listBox2.SelectedIndex == 0 && cember1.R !=0 && cember2.R !=0) //çember-çember
            {
                float d = (float)Math.Sqrt(Math.Pow(cember1.Merkez.X - cember2.Merkez.X, 2) + Math.Pow(cember1.Merkez.Y - cember2.Merkez.Y, 2));

                if(cember1.R+cember2.R >=d)
                {
                    label15.Visible = true;
                    label15.Text = "Çemberler çarpýþýyor!!!";
                }
            }

            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && kure1.R != 0 && kure2.R != 0) //küre-küre
            {
                float d = (float)Math.Sqrt(Math.Pow(kure1.Merkez.X - kure2.Merkez.X, 2) + Math.Pow(kure1.Merkez.Y - kure2.Merkez.Y, 2)+ Math.Pow(kure1.Merkez.Z - kure2.Merkez.Z, 2));
                
                if (kure1.R + kure2.R >= d)
                {
                    label15.Visible = true;
                    label15.Text = "Küreler çarpýþýyor!!!";
                }
            }

            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 2) //dörtgen-dörtgen
            {
                if(Math.Abs(dikdortgen1.Merkez.X-dikdortgen2.Merkez.X) < (dikdortgen1.En+dikdortgen2.En)/2 && Math.Abs(dikdortgen1.Merkez.Y - dikdortgen2.Merkez.Y) <(dikdortgen1.Boy+dikdortgen2.Boy)/2)
                {
                    label15.Visible = true;
                    label15.Text = "Dikdörtgenler çarpýþýyor!!!";
                }
            }


            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 4 && silindir1.R !=0 && silindir2.R !=0) //silindir-silindir
            {
                double uzaklik = Math.Sqrt(Math.Pow(silindir1.Merkez.X - silindir2.Merkez.X, 2) + Math.Pow(silindir1.Merkez.Y - silindir2.Merkez.Y, 2) + Math.Pow(silindir1.Merkez.Z - silindir2.Merkez.Z, 2));

                if(uzaklik<=(silindir1.R+silindir2.R) && Math.Abs(silindir1.Merkez.Y- silindir2.Merkez.Y) < (silindir1.H + silindir2.H) / 2)
                {
                    label15.Visible = true;
                    label15.Text = "Silindirler çarpýþýyor!!!";
                }


            }

            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 3) //prizma-prizma
            {
                int deltax = Math.Abs(prizma1.Merkez.X - prizma2.Merkez.X);
                int deltay = Math.Abs(prizma1.Merkez.Y - prizma2.Merkez.Y);
                int deltaz = Math.Abs(prizma1.Merkez.Z - prizma2.Merkez.Z);

                if(deltax< (prizma1.En+prizma2.En)/2)
                {
                    if(deltay < (prizma1.Boy + prizma2.Boy) / 2)
                    {
                        if (deltaz < (prizma1.Gen + prizma2.Gen) / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Prizmalar çarpýþýyor!!!";
                        }
                    }
                }

            }

            if(listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)  //küre-prizma
            {
                int deltax = Math.Abs(kure1.Merkez.X - prizma2.Merkez.X);
                int deltay = Math.Abs(kure1.Merkez.Y - prizma2.Merkez.Y);
                int deltaz = Math.Abs(kure1.Merkez.Z - prizma2.Merkez.Z);

                if (deltax < (kure1.R + prizma2.En) / 2)
                {
                    if (deltay < (kure1.R + prizma2.Boy) / 2)
                    {
                        if (deltaz < (kure1.R + prizma2.Gen) / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Küre ve prizma çarpýþýyor!!!";
                        }
                    }
                }
            }

            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)  //prizma-küre
            {
                int deltax = Math.Abs(kure2.Merkez.X - prizma1.Merkez.X);
                int deltay = Math.Abs(kure2.Merkez.Y - prizma1.Merkez.Y);
                int deltaz = Math.Abs(kure2.Merkez.Z - prizma1.Merkez.Z);

                if (deltax < (kure2.R + prizma1.En) / 2)
                {
                    if (deltay < (kure2.R + prizma1.Boy) / 2)
                    {
                        if (deltaz < (kure2.R + prizma1.Gen) / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Prizma ve küre çarpýþýyor!!!";
                        }
                    }
                }
            }

            if(listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2) //çember-dikdörtgen
            {

                double mesafe = Math.Sqrt(Math.Pow((cember1.Merkez.X - dikdortgen2.Merkez.X), 2) + Math.Pow((cember1.Merkez.Y - dikdortgen2.Merkez.Y), 2));
                int deltaX, deltaY;
                deltaX = Math.Abs(cember1.Merkez.X - dikdortgen2.Merkez.X);
                deltaY = Math.Abs(cember1.Merkez.Y - dikdortgen2.Merkez.Y);

                //merkez noktasý dikdörtgenin içinde mi
                if (cember1.Merkez.X >= dikdortgen2.Merkez.X - (dikdortgen2.En / 2) && cember1.Merkez.X <= dikdortgen2.Merkez.X + (dikdortgen2.En / 2) && cember1.Merkez.Y >= dikdortgen2.Merkez.Y - (dikdortgen2.Boy / 2) && cember1.Merkez.Y <= (dikdortgen2.Merkez.Y + (dikdortgen2.Boy / 2)))
                {
                    label15.Visible = true;
                    label15.Text = "Çember ve dikdörtgen çarpýþýyor!!!";
                }
                else
                {
                    if (mesafe * mesafe > (deltaX * deltaX + (dikdortgen2.Boy / 2 + cember1.R) * (dikdortgen2.Boy / 2 + cember1.R)))
                    {

                    }
                    else if (mesafe * mesafe == deltaX * deltaX + (dikdortgen2.Boy / 2 + cember1.R) * (dikdortgen2.Boy / 2 + cember1.R))
                    {
                        if (cember1.Merkez.X >= dikdortgen2.Merkez.X - dikdortgen2.En / 2 && cember1.Merkez.X <= dikdortgen2.Merkez.X + dikdortgen2.En / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Çember ve dikdörtgen çarpýþýyor!!!";
                        }
                    }
                    else if (mesafe * mesafe > deltaY * deltaY + (dikdortgen2.En / 2 + cember1.R) * (dikdortgen2.En / 2 + cember1.R))
                    {

                    }
                    else if (mesafe * mesafe == deltaY * deltaY + (dikdortgen2.En / 2 + cember1.R) * (dikdortgen2.En / 2 + cember1.R))
                    {
                        if (cember1.Merkez.Y >= (dikdortgen2.Merkez.Y - dikdortgen2.Boy / 2) && cember1.Merkez.Y <= (dikdortgen2.Merkez.Y + dikdortgen2.Boy / 2))
                        {
                            label15.Visible = true;
                            label15.Text = "Çember ve dikdörtgen çarpýþýyor!!!";
                        }
                    }
                    else
                    {
                        label15.Visible = true;
                        label15.Text = "Çember ve dikdörtgen çarpýþýyor!!!";
                    }
                }
            }


            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) //dikdörtgen - çember
            {

                double mesafe = Math.Sqrt(Math.Pow((cember2.Merkez.X - dikdortgen1.Merkez.X), 2) + Math.Pow((cember2.Merkez.Y - dikdortgen1.Merkez.Y), 2));
                int deltaX, deltaY;
                deltaX = Math.Abs(cember2.Merkez.X - dikdortgen1.Merkez.X);
                deltaY = Math.Abs(cember2.Merkez.Y - dikdortgen1.Merkez.Y);

                //merkez noktasý dikdörtgenin içinde mi
                if (cember2.Merkez.X >= dikdortgen1.Merkez.X - (dikdortgen1.En / 2) && cember2.Merkez.X <= dikdortgen1.Merkez.X + (dikdortgen1.En / 2) && cember2.Merkez.Y >= dikdortgen1.Merkez.Y - (dikdortgen1.Boy / 2) && cember2.Merkez.Y <= (dikdortgen1.Merkez.Y + (dikdortgen1.Boy / 2)))
                {
                    label15.Visible = true;
                    label15.Text = "Dikdörtgen ve çember çarpýþýyor!!!";
                }
                else
                {
                    if (mesafe * mesafe > (deltaX * deltaX + (dikdortgen1.Boy / 2 + cember2.R) * (dikdortgen1.Boy / 2 + cember2.R)))
                    {

                    }
                    else if (mesafe * mesafe == deltaX * deltaX + (dikdortgen1.Boy / 2 + cember2.R) * (dikdortgen1.Boy / 2 + cember2.R))
                    {
                        if (cember2.Merkez.X >= dikdortgen1.Merkez.X - dikdortgen1.En / 2 && cember2.Merkez.X <= dikdortgen1.Merkez.X + dikdortgen1.En / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Dikdörtgen ve çember çarpýþýyor!!!";
                        }
                    }
                    else if (mesafe * mesafe > deltaY * deltaY + (dikdortgen1.En / 2 + cember2.R) * (dikdortgen1.En / 2 + cember2.R))
                    {

                    }
                    else if (mesafe * mesafe == deltaY * deltaY + (dikdortgen1.En / 2 + cember2.R) * (dikdortgen1.En / 2 + cember2.R))
                    {
                        if (cember2.Merkez.Y >= (dikdortgen1.Merkez.Y - dikdortgen1.Boy / 2) && cember2.Merkez.Y <= (dikdortgen1.Merkez.Y + dikdortgen1.Boy / 2))
                        {
                            label15.Visible = true;
                            label15.Text = "Dikdörtgen ve çember çarpýþýyor!!!";
                        }
                    }
                    else
                    {
                        label15.Visible = true;
                        label15.Text = "Dikdörtgen ve çember çarpýþýyor!!!";
                    }
                }
            }

            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 4 && kure1.R != 0 && silindir2.R != 0) //küre-silindir
            {
                double uzaklik = Math.Sqrt(Math.Pow(kure1.Merkez.X - silindir2.Merkez.X, 2) + Math.Pow(kure1.Merkez.Y - silindir2.Merkez.Y, 2) + Math.Pow(kure1.Merkez.Z - silindir2.Merkez.Z, 2));

                if (uzaklik <= (kure1.R + silindir2.R) && Math.Abs(kure1.Merkez.Y - silindir2.Merkez.Y) < (kure1.R + silindir2.H) / 2)
                {
                    label15.Visible = true;
                    label15.Text = "Küre ve silindir çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && kure2.R != 0 && silindir1.R != 0) //silindir -küre
            {
                double uzaklik = Math.Sqrt(Math.Pow(kure2.Merkez.X - silindir1.Merkez.X, 2) + Math.Pow(kure2.Merkez.Y - silindir1.Merkez.Y, 2) + Math.Pow(kure2.Merkez.Z - silindir1.Merkez.Z, 2));

                if (uzaklik <= (kure2.R + silindir1.R) && Math.Abs(kure2.Merkez.Y - silindir1.Merkez.Y) < (kure2.R + silindir1.H) / 2)
                {
                    label15.Visible = true;
                    label15.Text = "Silindir ve küre çarpýþýyor!!!";
                }
            }

            if(listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex==0 && listBox2.SelectedIndex == 1) //X-Y yüzeyi- küre
            {
                if(kure2.Merkez.Z < 0)
                {

                    if (Math.Sign(kure2.Merkez.Z) != Math.Sign(kure2.Merkez.Z + kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve küre çarpýþýyor!!!";
                    }

                }
                else if(kure2.Merkez.Z>0)
                {
                    if (Math.Sign(kure2.Merkez.Z) != Math.Sign(kure2.Merkez.Z - kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve küre çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Y yüzeyi ve küre çarpýþýyor!!!";
                }

            }


            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) //Y-Z yüzeyi - küre
            {
                if (kure2.Merkez.X < 0)
                {

                    if (Math.Sign(kure2.Merkez.X) != Math.Sign(kure2.Merkez.X + kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve küre çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.X > 0)
                {
                    if (Math.Sign(kure2.Merkez.X) != Math.Sign(kure2.Merkez.X - kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve küre çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "Y-Z yüzeyi ve küre çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) //X-Z yüzeyi - küre
            {
                if (kure2.Merkez.Y < 0)
                {

                    if (Math.Sign(kure2.Merkez.Y) != Math.Sign(kure2.Merkez.Y + kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve küre çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.Y > 0)
                {
                    if (Math.Sign(kure2.Merkez.Y) != Math.Sign(kure2.Merkez.Y - kure2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve küre çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Z yüzeyi ve küre çarpýþýyor!!!";
                }

            }


            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3) //X-Y yüzeyi -prizma
            {
                if (prizma2.Merkez.Z < 0)
                {

                    if (Math.Sign(prizma2.Merkez.Z) != Math.Sign(prizma2.Merkez.Z + prizma2.Gen/2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve prizma çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.Z > 0)
                {
                    if (Math.Sign(prizma2.Merkez.Z) != Math.Sign(prizma2.Merkez.Z - prizma2.Gen / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve prizma çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Y yüzeyi ve prizma çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3) //Y-Z yüzeyi - prizma
            {
                if (prizma2.Merkez.X < 0)
                {

                    if (Math.Sign(prizma2.Merkez.X) != Math.Sign(prizma2.Merkez.X + prizma2.En / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve prizma çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.X > 0)
                {
                    if (Math.Sign(prizma2.Merkez.X) != Math.Sign(prizma2.Merkez.X - prizma2.En / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve prizma çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "Y-Z yüzeyi ve prizma çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3) //X-Z yüzeyi - prizma
            {
                if (prizma2.Merkez.Y < 0)
                {

                    if (Math.Sign(prizma2.Merkez.Y) != Math.Sign(prizma2.Merkez.Y + prizma2. Boy / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve prizma çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.Y > 0)
                {
                    if (Math.Sign(prizma2.Merkez.Y) != Math.Sign(prizma2.Merkez.Y - prizma2.Boy / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve prizma çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Z yüzeyi ve prizma çarpýþýyor!!!";
                }

            }


            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 4) //X-Y yüzeyi - silindir
            {
                if (silindir2.Merkez.Z < 0)
                {

                    if (Math.Sign(silindir2.Merkez.Z) != Math.Sign(silindir2.Merkez.Z + silindir2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve silindir çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.Z > 0)
                {
                    if (Math.Sign(silindir2.Merkez.Z) != Math.Sign(silindir2.Merkez.Z - silindir2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Y yüzeyi ve silindir çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Y yüzeyi ve silindir çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 4) //Y-Z yüzeyi - silindir
            {
                if (silindir2.Merkez.X < 0)
                {

                    if (Math.Sign(silindir2.Merkez.X) != Math.Sign(silindir2.Merkez.X + silindir2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve silindir çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.X > 0)
                {
                    if (Math.Sign(silindir2.Merkez.X) != Math.Sign(silindir2.Merkez.X - silindir2.R))
                    {
                        label15.Visible = true;
                        label15.Text = "Y-Z yüzeyi ve silindir çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "Y-Z yüzeyi ve silindir çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 5 && comboBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 4) //X-Z yüzeyi - silindir
            {
                if (silindir2.Merkez.Y < 0)
                {

                    if (Math.Sign(silindir2.Merkez.Y) != Math.Sign(silindir2.Merkez.Y + silindir2.H/2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve silindir çarpýþýyor!!!";
                    }

                }
                else if (kure2.Merkez.Y > 0)
                {
                    if (Math.Sign(silindir2.Merkez.Y) != Math.Sign(silindir2.Merkez.Y - silindir2.H / 2))
                    {
                        label15.Visible = true;
                        label15.Text = "X-Z yüzeyi ve silindir çarpýþýyor!!!";
                    }
                }
                else
                {
                    label15.Visible = true;
                    label15.Text = "X-Z yüzeyi ve silindir çarpýþýyor!!!";
                }

            }


            if(listBox1.SelectedIndex == 6  && listBox2.SelectedIndex == 0) // nokta-çember
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta1.X - cember2.Merkez.X, 2) + Math.Pow(nokta1.Y - cember2.Merkez.Y, 2));

                if(d<=cember2.R)
                {
                    label15.Visible = true;
                    label15.Text = "Nokta ve çember çarpýþýyor!!!";
                }

            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 5) // çember-nokta
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta2.X - cember1.Merkez.X, 2) + Math.Pow(nokta2.Y - cember1.Merkez.Y, 2));

                if (d <= cember1.R)
                {
                    label15.Visible = true;
                    label15.Text = "Çember ve nokta çarpýþýyor!!!";
                }
            }

            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 1) // nokta-küre
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta3d1.X - kure2.Merkez.X, 2) + Math.Pow(nokta3d1.Y - kure2.Merkez.Y, 2) + Math.Pow(nokta3d1.Z - kure2.Merkez.Z, 2));

                if (d <= kure2.R)
                {
                    label15.Visible = true;
                    label15.Text = "Nokta ve küre çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 6) // küre - nokta
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta3d2.X - kure1.Merkez.X, 2) + Math.Pow(nokta3d2.Y - kure1.Merkez.Y, 2) + Math.Pow(nokta3d2.Z - kure1.Merkez.Z, 2));

                if (d <= kure1.R)
                {
                    label15.Visible = true;
                    label15.Text = "Küre ve nokta çarpýþýyor!!!";
                }

            }

            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 4) // nokta-silindir
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta3d1.X - silindir2.Merkez.X, 2) + Math.Pow(nokta3d1.Y - silindir2.Merkez.Y, 2) + Math.Pow(nokta3d1.Z - silindir2.Merkez.Z, 2));

                if (d <= silindir2.R)
                {
                   if(silindir2.Merkez.Y- silindir2.H/2 <= nokta1.Y && nokta1.Y <= silindir2.Merkez.Y + silindir2.H / 2)
                   {
                        label15.Visible = true;
                        label15.Text = "Nokta ve silindir çarpýþýyor!!!";
                   }

                }
            }

            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 6) // silindir-nokta
            {
                float d = (float)Math.Sqrt(Math.Pow(nokta3d2.X - silindir1.Merkez.X, 2) + Math.Pow(nokta3d2.Y - silindir1.Merkez.Y, 2) + Math.Pow(nokta3d2.Z - silindir1.Merkez.Z, 2));

                if (d <= silindir1.R)
                {
                    if (silindir1.Merkez.Y - silindir1.H / 2 <= nokta3d2.Y && nokta3d2.Y <= silindir1.Merkez.Y + silindir1.H / 2)
                    {
                        label15.Visible = true;
                        label15.Text = "Silindir ve nokta çarpýþýyor!!!";
                    }
                }
            }

            if(listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 2) //nokta- dikdörtgen
            {

                if(dikdortgen2.Merkez.X-dikdortgen2.En/2 <= nokta1.X && nokta1.X <= dikdortgen2.Merkez.X + dikdortgen2.En / 2)
                {
                    if (dikdortgen2.Merkez.Y - dikdortgen2.Boy / 2 <= nokta1.Y && nokta1.Y <= dikdortgen2.Merkez.Y + dikdortgen2.Boy / 2)
                    {
                        label15.Visible = true;
                        label15.Text = "Nokta ve dikdörtgen çarpýþýyor!!!";
                    }
                }
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 5) //dikdörtgen - nokta
            {

                if (dikdortgen1.Merkez.X - dikdortgen1.En / 2 <= nokta2.X && nokta2.X <= dikdortgen1.Merkez.X + dikdortgen1.En / 2)
                {
                    if (dikdortgen1.Merkez.Y - dikdortgen1.Boy / 2 <= nokta2.Y && nokta2.Y <= dikdortgen1.Merkez.Y + dikdortgen1.Boy / 2)
                    {
                        label15.Visible = true;
                        label15.Text = "Dikdörtgen ve nokta çarpýþýyor!!!";
                    }
                }
            }

            if(listBox1.SelectedIndex == 7 && listBox2.SelectedIndex ==3) // nokta-prizma
            {

                if (prizma2.Merkez.X - prizma2.En / 2 <= nokta3d1.X && nokta3d1.X <= prizma2.Merkez.X + prizma2.En / 2)
                {
                    if (prizma2.Merkez.Y - prizma2.Boy / 2 <= nokta3d1.Y && nokta3d1.Y <= prizma2.Merkez.Y + prizma2.Boy / 2)
                    {
                        if (prizma2.Merkez.Z - prizma2.Gen / 2 <= nokta3d1.Z && nokta3d1.Z <= prizma2.Merkez.Z + prizma2.Gen / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Nokta ve prizma çarpýþýyor!!!";
                        }
                    }
                }

            }

            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 6) // prizma-nokta
            {

                if (prizma1.Merkez.X - prizma1.En / 2 <= nokta3d2.X && nokta3d2.X <= prizma1.Merkez.X + prizma1.En / 2)
                {
                    if (prizma1.Merkez.Y - prizma1.Boy / 2 <= nokta3d2.Y && nokta3d2.Y <= prizma1.Merkez.Y + prizma1.Boy / 2)
                    {
                        if (prizma1.Merkez.Z - prizma1.Gen / 2 <= nokta3d2.Z && nokta3d2.Z <= prizma1.Merkez.Z + prizma1.Gen / 2)
                        {
                            label15.Visible = true;
                            label15.Text = "Prizma ve nokta çarpýþýyor!!!";
                        }
                    }
                }

            }

        }
    }
}
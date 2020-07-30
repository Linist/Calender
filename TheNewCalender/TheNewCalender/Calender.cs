using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNewCalender
{



    public partial class Calender : Form
    {

        public Calender()
        {
            InitializeComponent();
        }


        /********************Menubutton********************************/

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        /********************Hidebutton********************************/
        private void button10_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }



        /********************Exitbutton********************************/
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /****************************************************/
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }
        /****************************************************/
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
        }
        /****************************************************/
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FAQ stand for: Faggots Annoying Question");
        }
        /****************************************************/
        private void button4_Click(object sender, EventArgs e)
        {

        }
        /****************************************************/
        private void button3_Click(object sender, EventArgs e)
        {

        }
        /****************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            /*you have to instanziate the object so there will become a emty pocket to run it in you program*/
            Profile newProfile = new Profile();
            newProfile.Show();
        }

        /***********************date picker*****************************/
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = this.textBox1.SelectionStart + 1;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = this.textBox1.SelectionStart - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void flowLayoutPanel2_Click(object sender, PaintEventArgs e)
        {
   
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DateManager newdateManager = new DateManager();
            newdateManager.Show();
        }
        /****************************************************/

    }
    /*
    class MainContent
    {

    }

    class Dates:MainContent
    {

    }

    */
}

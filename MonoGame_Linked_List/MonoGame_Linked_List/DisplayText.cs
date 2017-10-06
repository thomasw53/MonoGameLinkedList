using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGame_Linked_List
{
    public partial class DisplayText : Form
    {
        PopUp post;
        public DisplayText()
        {
            InitializeComponent();
        }

        //Delete
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Reply
        private void button2_Click(object sender, EventArgs e)
        {
            post = new PopUp();
            post.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void setText(String t)
        {
            textBox1.Text = t;
        }
        public void setAuthor(String t)
        {
            label1.Text = t;
        }
    }
}

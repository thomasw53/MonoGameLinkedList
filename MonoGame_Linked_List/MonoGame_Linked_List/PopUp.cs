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
    public partial class PopUp : Form
    {
        DisplayText dis;
        public PopUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Author Label

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Author Text Box

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Post Label

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Post Text Box

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Submit
            dis = new DisplayText();
            dis.setText(textBox2.Text);
            dis.setAuthor(textBox1.Text);
            dis.Show();
            this.Hide();

        }
        private string getAuthor()
        {
            String author = textBox1.Text;
            return author;
        }

        private string getPost()
        {
            String post = textBox2.Text;
            return post;
        }
    }
}

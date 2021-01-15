using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        ArrayList myAL;
        public Form1()
        {
            InitializeComponent();
            myAL = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myAL.Add("strinf");
            myAL.Add(2);
            myAL.Add(Color.Beige);
            for (int i = 0; i < myAL.Count; i++)
            {
                MessageBox.Show(myAL[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myAL.RemoveAt(2);
        }
    }
}

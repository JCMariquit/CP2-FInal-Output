using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label lab1;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}

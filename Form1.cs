using System.Collections;

namespace AW_Pin_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string Calc_linux_pinum(string name)
        {
            string P = name.Substring(1, 1);
            int Start = Convert.ToByte('A');
            int PID = Convert.ToByte(P.ToUpper().ToCharArray()[0]) - Start;
            int ID = int.Parse(name.Substring(2, name.Length - 2));
            if(ID > 33)
            {
                return "���󣬳��������������";
            }
            return (PID * 32 + ID).ToString();
        }

        private string Calc_pinum_linux(int pinum)
        {
            if (pinum > 832)
            {
                return "���󣬳��������������";
            }
            int Start = Convert.ToByte('A');
            int _d = pinum / 32;
            int _y = pinum % 32;
            string P = Convert.ToChar(Start + _d).ToString();
            return "P" + P + _y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.ToUpper().Contains("P"))
                {
                    label2.Text = Calc_linux_pinum(textBox1.Text);
                }
                else
                {
                    label2.Text = Calc_pinum_linux(int.Parse(textBox1.Text));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("����������Ӳ�����źţ�����PC5����Linuxӳ�����źţ����� 69��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
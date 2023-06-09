using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterScissors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Cut_Click(object sender, EventArgs e)
        {

            //문자형 변수 선언
            string InputText = textBox_Input.Text;
            string OutputText = "";


            try
            {
                //정수형 변수 선언
                int front = Convert.ToInt32(textBox_Front.Text);
                int back = Convert.ToInt32(textBox_Back.Text);


                //Remove : 시작값, 종료값을 넣어 문자를 자르는 함수
                OutputText = InputText.Remove(0, front);
                //입력한 문자

                OutputText = OutputText.Remove(OutputText.Length - back, back);

                textBox_Output.Text = OutputText;
            }
            catch (Exception)
            {

                MessageBox.Show("입력하신 문자 또는 자르기 값을 확인해주시기 바랍니다.", "문자가위");
            }
        }

        private void textBox_Front_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_Number(sender, e);
        }

        private void textBox_Back_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_Number(sender, e);
        }

        private void KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}

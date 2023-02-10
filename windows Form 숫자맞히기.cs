using System;
using System.Windows.Forms;

namespace 숫자_맞히기
{
    public partial class Form1 : Form
    {
        //display = 게임 진행 여부와 남은 횟수
        //textBox = 숫자 입력
        //ButtonInput = 숫자 입력 처리(정답과 비교)
        //ButtonStart = 게임 시작

        private int findNumber = 0;//맞힐 숫자
        private int chance = 0;//기회
     
       

        public Form1()
        {
            InitializeComponent();
            hint.Enabled= false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            hint.Enabled = true;

            var rand = new Random();
            findNumber = rand.Next(1, 21);
            chance = 10;
            display.Text = "맞힐 숫자를 입력하세요."; 
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);//텍스트박스의 문자열을 정수로 변환


            if(inputNumber==findNumber)
            {
                display.Text = "승리했습니다!";
                
            }
            else
            {
                chance--;
                
                display.Text = "기회는" + chance + "번 남았습니다.";
                hint.Text = "힌트 : " + (findNumber-3) + "~" + (findNumber+3) + "사이의 값";
               
            }

            if (chance <= 0){
                display.Text = "실패했습니다!"; 
            
            }


        }

        private void hint_Click(object sender, EventArgs e)
        {

        }

       
    }
}


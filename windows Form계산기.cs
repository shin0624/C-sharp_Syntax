using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }


        Operators currentOperator = Operators.None;//초기에는 연산자가 선택되지 않은 상태 -->none으로 초기화
        Boolean operatorChangeFlag = false;//연산벼튼(=) 클릭 여부--> true면 기존 입력된 숫자 저장 후 새로운 숫자를 입력받게
        double firstOperand = 0;
        double secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region 0~9 버튼
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;//true이면 레이블에 출력된 문자를 지우고 다시 지우는 것을 방지
            }
            string strNumber = display.Text += "0";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();//string-->int--->string 문자열을 숫자로 변환-->다시 문자열로 변환한 값을 출력
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            double intNumber = double.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        #endregion
        #region 연산버튼(+, -, x, ÷, =, AC, ., ←)
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);//기존에 입력한 숫자를 저장
            currentOperator = Operators.Add;//덧셈버튼 클릭을 알림
            operatorChangeFlag = true;

        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand= double.Parse(display.Text);//두번째 피연산자 저장
            if(currentOperator== Operators.Add)
            {
                firstOperand += secondOperand;//덧셈버튼 클릭 시 피연1 + 피연2를 피연 1에 저장
                display.Text = firstOperand.ToString();//문자열로 변환 후 레이블에 출력
            }
            else if(currentOperator==Operators.Subtract)
            {
                firstOperand-= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == Operators.Multiply)
            {
                firstOperand*= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == Operators.Divide)
            {
                if(secondOperand ==0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;  
                    display.Text = firstOperand.ToString(); 
                }
            }
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand= 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }
        

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag== true)
            {
                display.Text = "0.";
                operatorChangeFlag = false;
            }
            else if(display.Text.Contains(".") == false)
            {
                display.Text += ".";
            }
            
        }
        

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Substring(0, display.Text.Length - 1);
        }
        #endregion
    }
}

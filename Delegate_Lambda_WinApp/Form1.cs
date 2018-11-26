using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Lambda_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate int InStrOutInt(string name);
        delegate int In2StrOutInt(string name, string id);

        private void button_Delegate1_Click(object sender, EventArgs e)
        {
            InStrOutInt a = new InStrOutInt(GetHeight);  //傳統寫法
            InStrOutInt b = GetWeight;                   //語法糖

            //也可以用lambda來做匿名委派 => 就是明明是一個函式卻沒有取名的意思 => 具名函式就像下面的 GetHeight, GetWeight
            InStrOutInt c = name =>
            {
                return -1;
            };

            //呼叫
            var resultA = a("Tom");  //其實是呼叫 GetHeight    但我透過轉接頭 a 來間接呼叫他
            var resultB = b("Tom");  //其實是呼叫 GetWeight    但我透過轉接頭 b 來間接呼叫他
            var resultC = c("Tom");  //其實是呼叫 一個匿名函式   但我透過轉接頭 c 來間接呼叫他
        }

        static int GetHeight(string name)
        {
            return 180;
        }

        static int GetWeight(string name)
        {
            return 70;
        }

        private void button_Lambda1_Click(object sender, EventArgs e)
        {
            //兩個參數輸入時 lambda 匿名委派這樣寫
            In2StrOutInt func2 = (name, id) =>
            {
                return -2;
            };

            var result = func2("Roger", "0");

            MessageBox.Show(result.ToString());
        }

        private void button_Lambda2_Click(object sender, EventArgs e)
        {
            //用 lambda 寫了一個沒有名子的函式 = 匿名函式
            //輸入 string ( name )，輸出 int，
            //並且把這個沒有名子的函式委派給 tmpFunc (泛型委派)
            Func<string, int> tmpFunc = name =>
            {
                return -3;
            };

            var result = tmpFunc("Tom");  //得-3

            MessageBox.Show(result.ToString());
        }

        private void button_Lambda3_Click(object sender, EventArgs e)
        {
            //沒有輸入參數時這樣寫 => 只寫()
            Func<int> tmpFunc = () => -4;    //當函式主體只有一行時 連{} 還有return 都可以省略

            var result = tmpFunc();          //得-4

            MessageBox.Show(result.ToString());
        }


        delegate int Del(int x);

        private void button_Delegate2Lambda_Click(object sender, EventArgs e)
        {
            //首先定義一個單參數的 delegate


            //以傳統 delegate 的語法來建構 delegate
            Del a1 = delegate (int x) { return x + 2; };

            //去掉 delegate 改成 Lambda 表示式
            Del a2 = (int x) => { return x + 2; };

            //由於大括號裡只有一句陳述式，而且是一個 return 的陳述式,所以可以省略大括號跟 return
            Del a3 = (int x) => x + 2;

            //在 delegate 已經有定義輸入參數的型別，所以在小括號裡的型別可以省略
            Del a4 = (x) => x + 2;

            //由於小括號裡面只有一個輸入參數，所以可以再進一步省略小括號
            Del a5 = x => x + 2;


            var result_a1 = a1(1);
            var result_a2 = a2(1);
            var result_a3 = a3(1);
            var result_a4 = a4(1);
            var result_a5 = a5(1);

            MessageBox.Show(result_a1.ToString() + "\r\n" + result_a2.ToString() + "\r\n" + result_a3.ToString() + "\r\n" + result_a4.ToString() + "\r\n" + result_a5.ToString() + "\r\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;



namespace TRPG_Screen_20221117
{
    public partial class FormCrossover__normal : Form
    {
        public FormCrossover__normal()
        {
            InitializeComponent();
        }
        
        static int count;

        private void FormCrossover_red_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu.FormMoveMenu moveMenu = new Menu.FormMoveMenu();
            // フォームを表示する
            moveMenu.Show();
            Opacity = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {

                { 1001  ,"	いつも通りの登校中。	"},
                { 1002  ,"	あなたは、信号が変わるのを待ちながら\r\nイヤホンから流れるニュースに耳を傾ける。	"},
                { 1003  ,"	「...今日のニュースです。\r\n最近、港では男女2人が事故にあい、\r\n意識不明の重体になる事件が多発しています。」	"},                                
                { 1004  ,"	「被害者の特徴は、...」	"},
                { 1005  ,"	最近は物騒な事件が多い。	"},
                { 1006  ,"	あなたがそう思っていると、信号が赤から青に変わる。	"},
                { 1007  ,"	イヤホンからはすでに気味の悪いニュースから\r\nリクエストだという知らない音楽に変わっている。	"},
                { 1008  ,"	あなたが横断歩道を渡ろうと動き出したとき、	"},
                { 1009  ,"	「ミツケタ」	"},
                { 1010  ,"	ドンッという衝撃があなたを襲う。	"},
                { 1011  ,"	自分は轢かれたのか？"},
                { 1012  ,"	何も状況がつかめないまま、あなたの意識は暗い場所へ沈んでいく。"},

            };

            int b = 1001 + count++;

            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;
                    if(b==1010)
                    {
                        Crossover.FormCrossover_red crossover_red = new Crossover.FormCrossover_red();
                        // フォームを表示する
                        crossover_red.Show();
                        Opacity = 0;
                    }
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossover
{
    public partial class FormCrossover_red : Form
    {
        public FormCrossover_red()
        {
           InitializeComponent();
        }

        static int count;

        private void FormCrossover_red_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TRPG_Screen_20221117.Menu.FormMoveMenu moveMenu = new TRPG_Screen_20221117.Menu.FormMoveMenu();
            // フォームを表示する
            moveMenu.Show();
            Opacity = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {

                { 1001  ,"	いつも通りの登校中。	"},
                { 1002  ,"	あなたは、信号が変わるのを待ちながらイヤホンから流れるニュースに耳を傾ける。	"},
                { 1003  ,"	「...今日のニュースです。最近、港では男女2人が事故にあい、意識不明の重体になる事件が多発しています。被害者の特徴は、...」	"},
                { 1004  ,"	最近は物騒な事件が多い。	"},
                { 1005  ,"	あなたがそう思っていると、信号が赤から青に変わる。	"},
                { 1006  ,"	イヤホンからはすでに気味の悪いニュースからリクエストだという知らない音楽に変わっている。	"},
                { 1007  ,"	あなたが横断歩道を渡ろうと動き出したとき、	"},
                { 1008  ,"	「ミツケタ」	"},
                { 1009  ,"	ドンッという衝撃があなたを襲う。	"},
                { 1010  ,"	自分は轢かれたのか？	"},
                { 1011  ,"	何も状況がつかめないまま、あなたの意識は暗い場所へ沈んでいく。	"},
                { 1012  ,"	完全に沈む前に、あなたは嗅ぎなれない匂いに包み込まれた	"},

            };

            int b = 1010 + count++;

            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    if (b==1012)
                    {
                        TRPG_Screen_20221117.Room.FormStartRoom formStartRoom = new TRPG_Screen_20221117.Room.FormStartRoom();
                        // フォームを表示する
                        formStartRoom.Show();
                        Opacity = 0;
                    }
                }
            }


        }
    
    }
}

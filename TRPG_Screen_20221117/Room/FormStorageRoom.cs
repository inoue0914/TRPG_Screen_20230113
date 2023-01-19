using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPG_Screen_20221117.Room
{
    public partial class FormStorageRoom : Form
    {
        public FormStorageRoom()
        {
            InitializeComponent();

            //キラキラボタン
            button4.Visible = false;
            button3.Visible = false;
            button2.Visible = false;

            //はいいいえ
            button6.Visible = false;
            button7.Visible = false;

            //はいセリフ
            button8.Visible = false;
        }

        static int count;
        static int gomi_count;

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
        {
            //倉庫
            { 4001  ,"	NPCに案内してもらった倉庫の扉を開ける。	"},//成功失敗
            { 4002  ,"	ぎいいい	"},
            { 4003  ,"	そこは、あまり掃除されていないのか身じろぎ一つでほこりが舞うような場所だった。	"},
            { 4005  ,"	『ゲホゲホ、荷物が散乱しているな気を付けろ』	"},
            { 4006  ,"	"},

           //ゴミ箱
            { 4507  ,"	空き瓶やぐしゃぐしゃ用紙などが雑多に捨てられている。	"},
            { 4508  ,"	『言語はわからないが、なぜか読めるな』	"},
           //棚
            { 4509  ,"	所々ささくれが酷い棚。	"},
            { 4510  ,"	鈍く光る鉱石や何に使うかわからないガラクタなどが仕舞われている。	"},
            //壁
            { 4511  ,"	ひんやりとした土壁。	"},
            { 4512  ,"	触るとぼろぼろと土が落ちてくる。この屋敷の古さがわかる。	"},
            //探索終了
            { 4300  ,"	『何かあったか？』	"},//はいいいえ
            { 4305  ,"	『大体は探し終わったんじゃないか？次の部屋行こうぜ。』	"},
            { 4306  ,"	"},
            //成功
            { 4101  ,"	引きちぎられた跡のあるページ。	"},
            { 4102  ,"	捨てられて時間がたっているのかインクが滲んで読みづらい。	"},
            { 4103  ,"	母国語　EDU＊５－30	"},
            { 4104  ,"	名前と思しきところがすべて塗りつぶされているページ。	"},           
            //失敗
            { 4201  ,"	なし	"},
            //はい
            { 4301  ,"	『えっ、そうなのか...何があったんだ？』	"},
            { 4302  ,"	「日記」	"},
            { 4303  ,"	『…中はもう見たのか？』	"},
            { 4304  ,"	『いや、やっぱりいいや。ここから出られそうなこと書いてなかったんだろ？』	"},
            //いいえ
            { 4401  ,"	『そっか、残念だったな』	"},
            { 4402  ,"	NPCは、少しほっとしたような残念そうな顔をしてそう言った。	"},
        };

        private void FormStorageRoom_Load(object sender, EventArgs e)
        {
            label1.Text ="";

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
            int b = 4001 + count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    if (b == 4006)
                    {
                        //キラキラボタン                   
                        //壁
                        button3.Visible = true;
                        //棚
                        button2.Visible = true;

                        //会話ボタン
                        button1.Visible = false;
                 
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //ゴミ箱
            label1.Text = "空き瓶やぐしゃぐしゃ用紙などが雑多に捨てられている。\r\n『言語はわからないが、なぜか読めるな』";
            button4.Visible = false;

            //はいセリフ
            button8.Visible = true;

           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //壁
            label1.Text = "ひんやりとした土壁。\r\n触るとぼろぼろと土が落ちてくる。この屋敷の古さがわかる。";
            button3.Visible = false;

            //ゴミ箱を最後に表示させる
            if (button2.Visible == false) 
            {
                //ゴミ箱
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //棚
            label1.Text = "所々ささくれが酷い棚。\r\n鈍く光る鉱石や何に使うかわからないガラクタなどが仕舞われている。";
            button2.Visible = false;
            //ゴミ箱を最後に表示させる
            if (button3.Visible == false)
            {
                //ゴミ箱
                button4.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //はい
            label1.Text = "『えっ、そうなのか...何があったんだ？』";
            //はいいいえ
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //いいえ
            label1.Text = "『そっか、残念だったな』\r\nNPCは、少しほっとしたような残念そうな顔をしてそう言った。";
            //はいいいえ
            button6.Visible = false;
            button7.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int d = 4300 + gomi_count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == d)
                {
                    label1.Text = c.Value;

                    if (d == 4300)
                    {
                        //はいいいえ
                        button6.Visible = true;
                        button7.Visible = true;

                    }
                }
            }
        }
    }
}

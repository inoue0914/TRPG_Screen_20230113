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
    public partial class FormKitchenRoom : Form
    {
        public FormKitchenRoom()
        {
            InitializeComponent();

            //キラキライベント
            button2.Visible = false;//調理台の棚
            button3.Visible = false;//食器棚
            button4.Visible = false; //調理台
        }

        static int count;

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
        {
            //キッチン
            { 3001  ,"	NPCに案内してもらったキッチンの扉を開ける。	"},
            { 3002  ,"	そこは、よくある古風な作りだったが\r\n大切にしていることがわかる暖かな部屋だった。	"},
            { 3003  ,"		"},
            //調理台
            { 3503  ,"	ひんやりと冷たい調理台。	"},
            { 3504  ,"	謎の調味料が置いてある。	"},
            { 3505  ,"	『植物の知識はないが、スーパーには売ってなさそうだな』	"},
            //調理台の棚
            { 3506  ,"	調理用器具や何に使うのか分からない器具がきれいに整頓されている。	"},//目星　成功3101 失敗3201
            { 3507  ,"	「最近まで生活してたのかな」	"},
            //検索の終了
            { 3508  ,"	『大体は探し終わったんじゃないか？次の部屋行こうぜ。』	"},
            //食器棚
            { 3101  ,"	手書きのレシピ本：使い込まれた革表紙のレシピ本。\r\nところどころ折り目がついている。	"},
            { 3102  ,"	『この料理俺好きなんだよな。作れたりするのか？』	"},//選択肢　はい 3106　いいえ 3202
            { 3103  ,"	艶やかなあめ色の食器棚。	"},
            { 3104  ,"	中には二人分の食器ある。	"},
            { 3105  ,"	『ティーカップのブランドはわからねえが高そうだな』	"},
            //失敗
            { 3201  ,"	なし	"},
            //はい
            { 3106  ,"	はい	"},
            { 3107  ,"	「くるみパンか。結構簡単に作れるよ」	"},
            { 3108  ,"	『・・・家族と食べていた気がするがなんか違和感あるな』	"},
            //いいえ
            { 3202  ,"	いいえ	"},
            { 3202  ,"	「意外に子供っぽいのね」	"},
            { 3203  ,"	『うるせえ』	"},
        };

        private void FormKitchenRoom_Load(object sender, EventArgs e)
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
            int b = 3001 + count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    if (b == 3003)
                    {
                        //キラキライベント
                        button2.Visible = true;//調理台の棚
                        button3.Visible = true;//食器棚
                        button4.Visible = true; //調理台

                    }

                    

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //調理台

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //調理台の棚

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //食器棚

        }
    }
}

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
    public partial class FormStartRoom : Form
    {
        public FormStartRoom()
        {
            InitializeComponent();

            //ダイス
             label2.Visible = false;
             button2.Visible = false;
             label3.Visible = false;
        }

        static int count;
       

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

                { 2001  ,"	あなたは意識が浮上する感覚とともに目を開ける。	"},
                { 2002  ,"	覚醒しきれていない意識の中、\r\nどこか柔らかなものの上に横たわっていることだけがわかるでしょう。	"},
                { 2003  ,"	見知らぬ場所にいきなり飛ばされたことに\r\n得体のしれない現象への恐怖を感じた。（SAN値チェック）	"},
                { 2004  ,"	あなたが体を起こそうとすると\r\n部屋の扉が開き誰かが入ってくる足音がする。	"},
                { 2005  ,"	あなたが身構えていると、	"},
                { 2006  ,"	{NPCの登場}	"},
                { 2007  ,"	驚いた表情で青年がこちらを見つめている。	"},
                { 2008  ,"	「家主…じゃないよな」	"},
                { 2009  ,"	「あんた名前は？」	"},
                { 2010  ,"	（主人公の名前）	"},
                { 2011  ,"	「つゆり、ただの学生だ。あんたは？」	"},
                { 2012  ,"	「私は主人公」	"},
                { 2013  ,"	青年は横たわっている、あなたをめんどくさそうに一瞥する	"},
                { 2014  ,"	「動けないのか？」	"},
                { 2015  ,"	「いえ、少しめまいがしただけ」	"},
                { 2016  ,"	「ここがどこかわかるか？」	"},
                { 2017  ,"	「私も今目覚めたところで…」	"},
                { 2018  ,"	「ここに来た記憶は？」	"},
                { 2019  ,"	「わからないわ」	"},
                { 2020  ,"	「俺と大して変わらないな。おれは隣の部屋で目覚めて、\r\nざっとほかの部屋を見て回ったらあんたをみつけた。」	"},
                { 2021  ,"	「…」	"},
                { 2022  ,"	あなたは力説する彼を無視して立ち上がり部屋を出た	"},
                { 2023  ,"	「おい！むやみに行動するな！！」	"},
                { 2024  ,"	どうやら、｛NPC名｝はあなたより少し前に\r\nこの屋敷で目が覚めたらしくすこし探索してきたようだ。	"},
                { 2025  ,"	『あんたはこれからどうすんの？』	"},
                { 2026  ,"	『あぶねえからついて行ってやるよ』 	"},
                { 2027  ,"	 	"},
            };

            int b = 2001 + count++;

            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;
                    if (b == 2003)
                    {
                        //ダイス
                        label2.Visible = true;
                        button2.Visible = true;
                        label3.Visible = true;
                    }

                    if (b == 2004)
                    {
                        //ダイス
                        label2.Visible = false;
                        button2.Visible = false;
                        label3.Visible = false;
                    }

                    if (b == 2027)
                    {
                        //セリフ
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                        button1.Visible = false;
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();       
            //30基礎値
           int  daisu =  r.Next(0,70) + 30; 
           
            label2.Text = daisu.ToString();

            if (daisu > 30)
            {
                label3.Text = "成功SAN値減少なし";
            }

            else
                label3.Text = "失敗";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

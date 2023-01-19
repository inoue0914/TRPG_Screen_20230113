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
    public partial class FormBedRoom : Form
    {
        public FormBedRoom()
        {
            InitializeComponent();

            //はいいいえ非表示
            button3.Visible = false;
            button6.Visible = false;

            //懐かしいOr何でもない
            button9.Visible = false;
            button8.Visible = false;
       
            //家具イベント
            button7.Visible = false;//棚
            button4.Visible = false;//ベッド
            button2.Visible = false;//机

            //机セリフ
            button12.Visible = false;

           

        }

        static int count_bed;
        static int count_tukue;


        private void FormBedRoom_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu.FormMoveMenu moveMenu = new Menu.FormMoveMenu();
            // フォームを表示する
            moveMenu.Show();
            Opacity = 0;
        }

            Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {
                //幸運 成功 5104 失敗 5204
                { 5001  ,"	NPCに案内してもらった寝室の扉を開ける。	"},
                { 5002  ,"	最初にいた部屋よりも生活感のある部屋だった。	"},
                { 5003  ,"	あなたが部屋に入ると不思議と懐かしさを感じた。	"},
                { 5004  ,"	自分はここに来たことがあるのか？	"},
                { 5005  ,"	｛SANチェック｝	"},
                { 5006  ,"	『ここが俺の目覚めた部屋だ』	"},
                { 5007  ,"	ベットと小さな机の簡素な部屋だが\r\nあなたは懐かしさを感じて、立ち止まった	"},
                { 5008  ,"	『おい？どうした？何かあったのか？』	"},//はい 5101　いいえ 5201
                { 5009  ,"	     	"},             
                //机
                { 5010  ,"	花が飾られている勉強机。（花はキャラ別）	"},
                { 5011  ,"	『この花は、』	"},
                { 5012  ,"	「ツユクサ」	"},
                { 5013  ,"	『知っているのか？』	"},//「懐かしい」5103 --5 「なんでもない」5104 +5
                { 5014  ,"	『なんでかわからないけど、好きなんだよな』	"},
                { 5015  ,"	NPCはそう言って、飾られた花を撫でた。	"},//目星 成功 5105　失敗 5205
                //棚
                { 5516  ,"	子供が使うような本や勉強道具がある。	"},
                { 5517  ,"	勉強道具には相当使い込まれた跡があった。	"},
                //ベッド
                { 5518  ,"	青色のベッド。	"},
                { 5519  ,"  寝心地がよさそうだ。"},
                //終わり
                { 5020  ,"	『大体は探し終わったんじゃないか？次の部屋行こうぜ。』	"},            
               　//はい 
                { 5101  ,"	「なんだか・・・昔来たような」	"},//・成功 1d5 SAN値 プラス5 ・失敗 2d3 SAN値 マイナス5
                //{ 5102  ,"	『お前が来たことあるならやっぱり日本か？\r\nテーマパークか？歴史的な領事館とかか？』	"},
                //いいえ
                { 5201  ,"	「なんでもない」	"},
               // { 5202  ,"	『ビビるから、急に止まるなよ』	"},
                //懐かしい
                { 5103  ,"	「懐かしい」	"},
                //なんでもない
                { 5203  ,"	「なんでもない」	"},
                //幸運成功
                { 5104  ,"	日記を発見した。	"},
                //幸運失敗
                { 5204  ,"	なにかを燃やした跡がある。	"},
                //目星成功
                { 5105  ,"	何枚かページが引きちぎられた跡がある。	"},
                { 5106  ,"	ページの初めは幸せな師弟の生活が書かれている。	"},
                { 5107  ,"	しかし、日記帳の後半になるにつれ中身が\r\nほとんど読み取れないほど字が荒れている。	"},
                { 5108  ,"	この日記の持ち主に何があったのだろうか。	"},
                //目星失敗
                { 5205  ,"	ページが引きちぎられた跡があり、読めなかった。	"},
            }; 

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 5001 + count_bed++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    if (b == 5008)
                    {
                        //はいいいえ表示
                        button3.Visible = true;
                        button6.Visible = true;
                       
                    }

                    if (b == 5009)
                    {
                    button7.Visible = true;
                    button4.Visible = true;
                    button2.Visible = true;
                    button1.Visible = false;
                    

                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //机
            label1.Text = "花が飾られている勉強机。（花はキャラ別）";
            button2.Visible = false;//机
            button12.Visible = true;//机→
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ベッド
            label1.Text = "青色のベッド。\r\n寝心地がよさそうだ。";
            button4.Visible = false;//ベッド
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //はい
            //はいいいえ非表示
            button3.Visible = false;
            button6.Visible = false;
            label1.Text = "	「なんだか・・・昔来たような」	";

        }

            private void button6_Click(object sender, EventArgs e)
        {
            //いいえ
            //はいいいえ非表示
            button3.Visible = false;
            button6.Visible = false;
            label1.Text = "	「なんでもない」	";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //棚
            label1.Text = "子供が使うような本や勉強道具がある。\r\n勉強道具には相当使い込まれた跡があった。";
            button7.Visible = false;//棚
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //なんでもない
            label1.Text = "「なんでもない」";
            button9.Visible = false;
            button8.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //懐かしい
            label1.Text = "「懐かしい」";
            button8.Visible = false;
            button9.Visible = false;
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            //机カウント
            int d = 5011 + count_tukue++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == d)
                {
                    label1.Text = c.Value;

                   

                    if (d == 5013)
                    {
                        //懐かしいOr何でもない
                        button9.Visible = true;
                        button8.Visible = true;
                    }

                    if (d == 5015)
                    {
                        //目星成功失敗
                       
                    }

                }
            }
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

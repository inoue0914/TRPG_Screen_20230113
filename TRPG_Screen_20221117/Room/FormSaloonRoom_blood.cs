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
    public partial class FormSaloonRoom_blood : Form
    {
        public FormSaloonRoom_blood()
        {
            InitializeComponent();

            //セリフ
            pictureBox1.Visible = false;
            button1.Visible = false;
        }

        static int count;

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
        {
            //最終探索 取得物：書斎のカギ
             { 6005  ,"	あなたが広間に出ると初めに通りかかったときと一変していた。	"},
             { 6006  ,"	「どうしてこんなことに、」	"},
             { 6007  ,"	壁や階段などには刃物のようなもので大きく削れたような跡があり、飾られていた花瓶などはただ床を汚す塵と成り下がっている。	"},
             { 6008  ,"	中央にはまだ乾きっていない血だまりが薄暗い広間を照らすろうそくの光でぬらぬらと鈍く浮かび上がっている。	"},
             { 6009  ,"	そして、中央にはまだ乾きっていない血だまりが薄暗い広間でもはっきりと見える。	"},
             { 6010  ,"	恐る恐るその血だまりに近づくと、血だまりの中央に光る物が落ちていることに気づいた。	"},
             { 6011  ,"	(SAN値チェック)	"},
             { 6012  ,"	『それは…書斎のカギ？これがあれば、やっとあの部屋に入れるのか？』	"},
             { 6013  ,"	あなたは手のひらの鍵を見つめる。	"},
             { 6014  ,"		"},
        };
        private void Form5_Load(object sender, EventArgs e)
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
            int b = 6005 + count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //キラキラ
            //セリフ
            pictureBox1.Visible = true;
            button1.Visible = true;

            //キラキラ
            button4.Visible = false;
        }
    }
}

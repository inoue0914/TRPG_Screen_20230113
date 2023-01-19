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
    public partial class FormLibraryRoom : Form
    {
        public FormLibraryRoom()
        {
            InitializeComponent();

        
        }

        static int count;

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
        {
             //書斎 見つかるもの：真相
             { 7001  ,"	あなたが血に濡れた鍵を書斎の鍵穴にさすと、\r\n固く閉じていた扉はすんなりと開く。	"},
             { 7002  ,"	そこは壁一面の本棚と座り午後地のよさそうなソファー。\r\nまるであなたの為に誂たかのような部屋だった。	"},
             { 7003  ,"	拍子抜けしたあなたは躊躇なく書斎に足を入れた。	"},
             { 7004  ,"	その時、	"},
             { 7005  ,"	NPCの纏う空気が変わったのをあなたは感じる。	"},
             { 7006  ,"	『この部屋に入ると幼いころを思い出すなあ』	"},
             { 7007  ,"	『ほら、\r\nこの本とかよく君が文字を教えてくれて時に使っていた本だよ』	"},
             { 7008  ,"	『懐かしいな』	"},
             { 7009  ,"	「なにを言ってるの？」	"},
             { 7010  ,"	『何って忘れたのか？まあ君はわすれぽかったし』	"},
             { 7011  ,"	『でも、これからはずっとここに暮らせるな』	"},
             { 7012  ,"	『なぁ？俺と一緒にここに住まないか？』	"},
             { 7013  ,"	いいえ	"},
             { 7014  ,"	「え、えっと私たちは・・・」	"},
             { 7015  ,"	『・・・また出ていくのか』	"},
             { 7016  ,"	『君って本当に自分勝手だよな』	"},
             { 7017  ,"	『勝手に出て行って、勝手に死んで、\r\n俺のことなんてどうでもいいんだろうな』	"},
             { 7018  ,"	『今度は絶対出さない』	"},
             { 7019  ,"	{STR対抗｝	"},
             { 7020  ,"	{SAN値チェック}	"},
             { 7021  ,"	『君の復活をずっと待っていたんだ』	"},
             { 7022  ,"	『またここで一緒に暮らそう』	"},
             { 7023  ,"	{STR対抗｝	"},
             { 7024  ,"	{SAN値チェック}	"},
             { 7025  ,"	『これ以上手を出させないでくれ』	"},
             { 7026  ,"	『君を傷つけたくないんだ』	"},
             { 7027  ,"	{STR対抗｝	"},
             { 7028  ,"	{SAN値チェック}	"},
             { 7029  ,"	『なぁ、また俺を一人にするのか？』	"},
             { 7030  ,"	『お願いだ。もうどこにも行かないでくれ。』	"},
             //幸運成功
             { 7101   ,"	あなたは、最後の力を振り絞りその手を払う。\r\nぱしんと軽い音がした。	"},
             { 7102  ,"	『そうか。君の意志は固いんだな。』	"},
             { 7103  ,"	あなたはつゆりに手を伸ばそうとした\r\nその時、抗えないほど強い眠気に襲われる。	"},
             { 7104  ,"	『もう時間だ。』	"},
             { 7105  ,"	なすすべもなく、あなたはその場で崩れるように眠ってしまった。	"},
             { 7106  ,"	最後に見た彼の顔はまるで\r\n親を見失った迷子のような悲しげな顔だった。	"},
             //幸運失敗
             { 7201  ,"	あなたは、力なくその場に倒れてしまった。	"},
             { 7202  ,"	力尽きるときツユクサの匂いに包まれた気がした。\r\nそして、つゆりの狂気に濡れた笑い声が、部屋に ただ空虚に響き続けた。	"},
        };

        private void FormLibraryRoom_Load(object sender, EventArgs e)
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
            int b = 7001 + count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                   if (b == 7030)
                   {
                      
                   }


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

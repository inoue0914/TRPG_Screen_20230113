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
    public partial class FormSaloonRoom_normal : Form
    {
        public FormSaloonRoom_normal()
        {
            InitializeComponent();
        }

        static int count;

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
        {
            //大広間（普通の探索）
             { 6001  ,"	薄暗いが壁や飾らせた調度品に品のある大広間。	"},
             { 6002  ,"	玄関ドアを開けようとしても開かない。	"},
             { 6003  ,"	『ドアが開かないな』	"},
             { 6004  ,"	『次の部屋に行こうぜ。』	"},
             { 6005  ,"		"},
        };

        private void button5_Click(object sender, EventArgs e)
        {
            Menu.FormMoveMenu moveMenu = new Menu.FormMoveMenu();
            // フォームを表示する
            moveMenu.Show();
            Opacity = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 6001 + count++;
            foreach (KeyValuePair<int, string> c in myDictionary)
            {
                if (c.Key == b)
                {
                    label1.Text = c.Value;

                    if (b == 6004)
                    {
                        button1.Visible = false;
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                    }
                }
            }
        }
    }

        

}


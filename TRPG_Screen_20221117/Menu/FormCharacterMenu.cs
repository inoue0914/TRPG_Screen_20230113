using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPG_Screen_20221117
{
    public partial class FormCharacterMenu : Form
    {
        public FormCharacterMenu()
        {
            InitializeComponent();
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.button1.BackColor = Color.Red;

        }

        private void FormCharacterMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonItemMenu_Click(object sender, EventArgs e)
        {
            OpenForm(((Button)sender).Text);
        }

        private void buttonMoveMenu_Click(object sender, EventArgs e)
        {
            OpenForm(((Button)sender).Text);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            OpenForm(((Button)sender).Text);
        }

        private void OpenForm(string formName)
        {
            Form frm = new Form();
            //引数より、開くフォームを設定
            switch (formName)
            {
                case "客間":
                    frm = new Room.FormStartRoom();
                    break;
                case "倉庫":
                    frm = new Room.FormStorageRoom();
                    break;
                case "大広間":
                    frm = new Room.FormSaloonRoom_normal();
                    break;
                case "書庫":
                    frm = new Room.FormLibraryRoom();
                    break;
                case "キッチン":
                    frm = new Room.FormKitchenRoom();
                    break;
                case "寝室":
                    frm = new Room.FormBedRoom();
                    break;
                case "キャラ":
                    frm = new FormCharacterMenu();
                    break;
                case "アイテム":
                    frm = new FormItemMenu();
                    break;
                case "移動":
                    frm = new Menu.FormMoveMenu();
                    break;
                case "タイトル":
                    frm = new FormTitle();
                    break;

            }
            //フォームを透明化
            Opacity = 0;

            //選択されたフォームを開く
            frm.ShowDialog();

            //開いたフォームから戻ってきたら
            //メモリを解放する
            //frm.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

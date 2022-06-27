using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameManager
{
    public partial class MainForm : Form
    {
        /*
            생성자 정의
            이니셜라이즈드 이외에 별도의 정의 없음
         */
        public MainForm()
        {
            InitializeComponent();
        }

        /*
            폼 로드시
            1. Infragistics 울트라 버튼 업로드 해줄 것
            2. Back Ground Color를 주도적으로 제어(?)하기 위해 명시적으로 White 선언
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            Infragistics.Win.Misc.UltraButton btn = (Infragistics.Win.Misc.UltraButton)this.btnWordManager;
            this.BackColor = Color.White;
        }

        /*
            단어 관리 클릭 시 WordMainForm으로 이동한다.
         */
        private void btnWordManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordManager.WordMainForm WF = new WordManager.WordMainForm();
            WF.StartPosition = FormStartPosition.Manual;
            WF.Location = new Point(100, 100);
            WF.Show();
        }
    }//Class
}//NameSpace

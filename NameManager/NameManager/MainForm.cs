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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Infragistics.Win.Misc.UltraButton btn = (Infragistics.Win.Misc.UltraButton)this.btnWordManager;
            this.BackColor = Color.White;
        }

        private void btnWordManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordManager.WordMainForm WF = new WordManager.WordMainForm();
            
        }
    }//Class
}//NameSpace

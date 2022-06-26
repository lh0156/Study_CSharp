using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DBConnectionTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {

            //1. Connection 정의
            OracleConnection oraConn = new OracleConnection();
            //2. 사용할 Connection string 설정
            oraConn.ConnectionString = "Data Source=XE;User Id=hr;Password=java1234";

            //3. 사용할 sql을 잘성
            OracleCommand oraCmd = oraConn.CreateCommand();
            oraCmd.CommandText = "SELECT menu FROM tblmenu";
            //4. Oracle Connection을 Open
            oraConn.Open();

            //5. OracleReader를 사용해 Feach해 줌
            OracleDataReader oraDr = oraCmd.ExecuteReader();

            //6. Feach한 데이터 핸들링
            if (oraDr.HasRows)
            {
                while(oraDr.Read())
                {
                    MessageBox.Show("Result : " + oraDr.GetString(0), "Fetch Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("No Rows Found", "Fetch Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //7. 사용한 리소스들을 닫아줌
            oraDr.Close();
            oraConn.Close();
        }
    }
}

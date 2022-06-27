using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameManager.WordManager
{
    public partial class WordMainForm : Form
    {

        public string connstr = DBUtil.DBUtil.connStr;
        public OleDbConnection conn = null;
        public OleDbCommand cmd = null;
        public OleDbDataReader reader = null;
        public DataSet ds;

        public WordMainForm()
        {
            InitializeComponent();
        }

        private void WordMainForm_Load(object sender, EventArgs e)
        {
            var open = "SELECT * FROM tblenumdepartment";
            this.ds = GetRestDataSet(open);
            dgvWordList.DataSource = ds.Tables[0].DefaultView;
        }

        public DataSet GetRestDataSet(string query)
        {
            try
            {
                conn = new OleDbConnection(connstr);
                conn.Open();
                cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblword");
                conn.Close();
                return ds;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("데이터 셋 오류");
                return null;
            } finally
            {
                conn.Close();
            }
        }

    }
}

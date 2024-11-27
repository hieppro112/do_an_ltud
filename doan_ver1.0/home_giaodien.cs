using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan_ver1._0
{
    public partial class home_giaodien : Form
    {
        public home_giaodien(string vaitro)
        {
            InitializeComponent();
            panel_account.Hide();
            //panel_store.Hide();
            quyen_admin(vaitro);
        }
        private void quyen_admin(string vaitro)
        {
            if(vaitro != null)
            {
                if(vaitro != "Admin")
                {
                    table_info_accout.DefaultCellStyle.ForeColor = Color.White;
                    table_info_accout.DefaultCellStyle.BackColor = Color.Black;
                    app_account.Enabled = false;

                }
            }
        }
        SqlConnection connect = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=quanly_cuahang_dienmay;Integrated Security=True;");

        private DataTable loaddl_nhanvien()
        {
            DataTable table = new DataTable();
            try
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand("tp_xemTaiKhoan", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter hienthi = new SqlDataAdapter(cmd);
                hienthi.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return null;
        }
        private void home_giaodien_Load(object sender, EventArgs e)
        {
            table_info_accout.DataSource = loaddl_nhanvien();
            table_info_accout.DefaultCellStyle.ForeColor = Color.Black;
            
        }
        private void table_info_accout_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> l = new List<string>();
            laydl_accout(l);
            Info_people info_People = new Info_people(l);
            info_People.Owner = this;
            info_People.FormClosed += new FormClosedEventHandler(home_giaodien_FormClosed);
            info_People.ShowDialog();
        }

        private void laydl_accout(List<String> list)
        {
            int dong = table_info_accout.CurrentCell.RowIndex;
            for (int i = 0; i < table_info_accout.ColumnCount; i++)
            {
                list.Add(table_info_accout.Rows[dong].Cells[i].Value.ToString());
            }
        }

        private void app_account_Click(object sender, EventArgs e)
        {
            //panel_store.Hide();
            panel_account.Show();
        }
        private void home_giaodien_FormClosed(object sender, FormClosedEventArgs e)
        {
            table_info_accout.DataSource = loaddl_nhanvien();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            FormDangKy dangky = new FormDangKy();
            dangky.Owner = this;
            dangky.FormClosed += new FormClosedEventHandler(home_giaodien_FormClosed);
            dangky.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void app_store_Click(object sender, EventArgs e)
        {
            //panel_store.Show();
        }

        private void s_seach_Click(object sender, EventArgs e)
        {
            //panel_seach.Show();
        }
        private void seach()
        {
            int vitri = cb_seach.SelectedIndex;
            switch (vitri)
            {
                case 0:
                    table_info_accout.DataSource = seach_sql("seach_maTK", "@maTK"); 
                    break;
                case 1:
                    table_info_accout.DataSource = seach_sql("seach_user", "@user");
                    break;

                case 2: 
                    table_info_accout.DataSource = seach_sql("seach_name", "@name");
                    break;
                case 3:
                    table_info_accout.DataSource = seach_sql("seach_email", "@email");
                    break;
                case 4: 
                    table_info_accout.DataSource = seach_sql("seach_vaitro", "@vaitro");
                    break;

                default:
                    MessageBox.Show("erroll");break;
            }
        }
        private DataTable seach_sql(string sql,string data)
        {
            DataTable table = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql,connect);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter a = new SqlParameter(data, txt_seach.Text);
                cmd.Parameters.Add(a);
                cmd.ExecuteNonQuery();

                SqlDataAdapter hienthi = new SqlDataAdapter(cmd);
                hienthi.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return null;
        }

        private void cb_seach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_seach_Click(object sender, EventArgs e)
        {
            seach();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

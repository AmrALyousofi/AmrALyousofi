using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection co = new SqlConnection(@"Data Source=DESKTOP-TKEI1TG\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        
    

        private void my_Button1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل أنت متأكد من عمل نسخة إحياطية للظام ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup files (*.Bak) |*.bac ";
                if (sf.ShowDialog() == DialogResult.OK)
                {

                    cmd = new SqlCommand(" Backup Database school To Disk='" + sf.FileName + "'", co);
                    co.Open();
                    cmd.ExecuteNonQuery();
                    co.Close();

                    MessageBox.Show("تم عمل نسخة احتياطية للنظام", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void my_Button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل أنت متأكد من عمل إستعادة للنسخة الإحياطية للظام ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Backup files (*.Bak) |*.bac";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    co.Open();
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Restore Database school  from Disk='" + op.FileName + "'", co);
                    co.Close();
                    MessageBox.Show("تم إستعادة النسخةالإحتياطية للنظام", "تنويه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



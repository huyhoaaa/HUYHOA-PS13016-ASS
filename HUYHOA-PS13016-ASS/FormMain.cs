using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUYHOA_PS13016_ASS
{
    public partial class FormMain : Form
    {
        //public static int session = 0;
        //public static int profile = 0;
        //public static string mail;
        public FormMain()
        {
            InitializeComponent();
        }            
        //kiểm tra xem 1 form với tên đã hiện thị trong form cha chưa? trả về true đã hiển thị
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren) 
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        
        //hiển thị lên nếu có thì k hiện nữa
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        frmDangNhap dn = new frmDangNhap();
        frmKhachHang kh = new frmKhachHang();
        private void toolStripMenuDangNhap_Click(object sender, EventArgs e)
        {
            dn = new frmDangNhap();
            if (!CheckExistForm("Login"))
            {              
                dn.MdiParent = this;
                dn.Show();               
            }
            else
            {
                ActiveChildForm("Login");
            }
        }   
        
    }
}

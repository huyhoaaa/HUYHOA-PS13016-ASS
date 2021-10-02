using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLiBanHang;
using BUS_QuanLyBanHang;
using System.Net.Mail;
using System.Net;

namespace HUYHOA_PS13016_ASS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }     
        //public string vaitro { set; get; }
        //public string matkhau { get; set; }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();       
        //Chức năng đăng nhập
        private void btDangNhap_Click(object sender, EventArgs e)
        {          
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = txtEmail.Text;
            nv.MatKhau = busNhanVien.encryption(txtMatKhau.Text);
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                //login = true
                
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
            }
            else if (txtEmail.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email hoặc mật khẩu");                
            }
            else
            {
                MessageBox.Show("Sai Email hoặc mật khẩu !!","Thông báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();               
            }           
        }
       

        //button quên mật khẩu
        private void btQuenMatKhau_Click(object sender, EventArgs e)
        {           
            if (txtEmail.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(999, 1000));
                    builder.Append(RandomString(2, false));

                    string matkhaumoi = busNhanVien.encryption(builder.ToString());
                    busNhanVien.TaoMatKhau(txtEmail.Text, matkhaumoi);                                    
                    SendMail(txtEmail.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập Email để phục hồi mật khẩu !!");
                txtEmail.Focus();                
            }
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random rd = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("phamhuyhoalk20@gmail.com","01635592943");

                MailMessage Msg = new MailMessage();
                //sender email address
                Msg.From = new MailAddress("phamhuyhoalk20@gmail.com");
                //Recipient e-mail address
                Msg.To.Add(email);
                //Assign the subject  of out message
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                Msg.Body = "Chào anh/chị. Mật khẩu mới để truy cập phần mềm là: " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Một email phục hồi mật khẩu đã được gửi tới bạn");
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }
}

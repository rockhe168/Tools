using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtripDataBaseDictionary
{
    using System.Threading;

    // 代理实现异步调用以设置lblMessage控件text属性
    delegate void SetTextCallback(string text);

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Thread loginThread = null;


        /// <summary>
        /// 确认环境
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_OK_Click(object sender, EventArgs e)
        {

            if (this.cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show(@"请选择服务器认证方式,哈");
                return;
            }

            if (this.cmbUserType.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(this.txtUsername.Text.Trim()))
                {
                    MessageBox.Show(@"请输入登录用户名，哈");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
                {
                    MessageBox.Show(@"请输入登录密码，哈");
                    return;
                }
                DataBaseConnectionConfig.ConnectionTypeValue = string.Format("uid={0};pwd={1}", this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim());
                GlobalContext.SqlConnectionString = DataBaseConnectionConfig.GetDataBaseConnectionString(string.Empty);
                
            }

            this.loginThread = new Thread(new ThreadStart(this.LoginAction));
            this.loginThread.Start();
        }

        /// <summary>
        /// 登录模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtSqlServerName.Text.Trim()))
            {
                MessageBox.Show(@"请输入有效的服务器名称，哈");
                return;
            }

            if(sender is ComboBox)
            {
                 var ckbUserType= sender as ComboBox;
                 DataBaseConnectionConfig.ServerName = this.txtSqlServerName.Text.Trim();
                 switch (ckbUserType.SelectedIndex)
                 {
                     case 0:
                         this.PL_user.Enabled = false;
                         DataBaseConnectionConfig.ConnectionTypeValue = "integrated security=sspi";
                         GlobalContext.SqlConnectionString = DataBaseConnectionConfig.GetDataBaseConnectionString(string.Empty);
                         break;
                     case 1:
                         this.PL_user.Enabled = true;
                         this.txtUsername.Enabled = true;
                         this.txtPassword.Enabled = true;
                         break;
                    default:
                         break;
                 }
                 
            }           
            
        }


        public void LoginAction()
        {
            try
            {
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Retry;
                this.SetText(ex.Message);
            }
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="text">消息</param>
        private void SetText(string text)
        {
            if (this.lblLogMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblLogMessage.Text = text;
            }
        }
    }
}

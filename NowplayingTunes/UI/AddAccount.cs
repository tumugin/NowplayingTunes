using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace NowplayingTunes
{
    public partial class AddAccount : Form
    {
        public TwitterService service;
        public OAuthRequestToken requestToken;
        public OAuthAccessToken access;

        public AddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Pass your credentials to the service
                service = new TwitterService(Core.Twitter.CONSUMERKEY, Core.Twitter.CONSUMERSECRET);

                // Step 1 - Retrieve an OAuth Request Token
                requestToken = service.GetRequestToken();

                // Step 2 - Redirect to the OAuth Authorization URL
                Uri uri = service.GetAuthorizationUri(requestToken);
                Process.Start(uri.ToString());
                textBox1.Text = uri.ToString();
                button2.Enabled = true;
            }
            catch (Exception ex)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 3 - Exchange the Request Token for an Access Token
                string verifier = textBox2.Text; // <-- This is input into your application by your user
                access = service.GetAccessToken(requestToken, verifier);
                if (access.Token == "?")
                {
                    MessageBox.Show("入力された暗証番号は正しくありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

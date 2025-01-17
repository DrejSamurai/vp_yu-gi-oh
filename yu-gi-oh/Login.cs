﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware.Models;
using Middleware.Models.Meta;
using WMPLib;


namespace yu_gi_oh
{
    public partial class Login : Form
    {
        Thread loadImages = new Thread(new ThreadStart(Middleware.Controllers.YGOController.DownloadAllImages));
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
      
        public Login()
        {
            InitializeComponent();
            loadImages.IsBackground = true;
            player.URL = Application.StartupPath + "\\Yu-Gi-Oh! Theme on Guitar.mp3";
            player.controls.play();
            player.settings.volume = 7;
            player.settings.setMode("loop", true);
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            OAuth oauth = await Middleware.Controllers.AccountController.GetLoginToken(tbUsername.Text, mtbPassword.Text);
            Middleware.Controllers.HttpClientBuilder.SetToken(oauth.access_token);
            this.Hide();
            MainMenu form = new MainMenu();
            loadImages.Start();
            await Middleware.Controllers.YGOController.PreLoadCache();
            form.ShowDialog();
            loadImages.Join();
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if(tbUsername.Text == "")
            {
                ep1.SetError(tbUsername, "Username is needed");             
            }
            else
            {
                ep1.SetError(tbUsername, null);
                e.Cancel = false;
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(mtbPassword.Text == "")
            {
                ep1.SetError(mtbPassword, "Password is needed");
            }
            else
            {
                ep1.SetError(mtbPassword, null);
                e.Cancel = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (player.settings.volume != 0)
            {
                btnMute.BackgroundImage = Properties.Resources.mute;
                player.settings.volume = 0;
            }
            else
            {
                btnMute.BackgroundImage = Properties.Resources.notmute;
                player.settings.volume = 7;
            }
        }
    }
}

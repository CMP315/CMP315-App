﻿using SecureSoftware.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Forms
{
    public partial class DeleteAccountConfirmation : Form
    {
        private MasterAccount User;
        public DeleteAccountConfirmation(MasterAccount user)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        async private void ConfirmDelete_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/users/{this.User._id}";
            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        this.ParentForm.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

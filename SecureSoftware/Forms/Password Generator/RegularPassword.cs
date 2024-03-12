﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace SecureSoftware
{
    public partial class RegularPassword : Form /* eslint-disable-line */
    {
        private readonly RandomNumberGenerator RandomGenerator;
        private HashSet<string> CharacterList;

        private readonly string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private readonly string DIGITS = "01234567890";
        private readonly string SYMBOLS = "!\\\"£$%^&*()_+=-[]'#<>/?¬`{}@";

        private readonly string[] EMOJIS = GetEmojis(",");

        public RegularPassword()
        {
            InitializeComponent();
            RandomGenerator = RandomNumberGenerator.Create();
            CharacterList = new HashSet<string>();
            this.FormBorderStyle = FormBorderStyle.None;

            foreach (char c in UPPERCASE.ToCharArray())
            {
                CharacterList.Add(c.ToString());
            }

            foreach (char c in LOWERCASE.ToCharArray())
            {
                CharacterList.Add(c.ToString());
            }

            foreach (char c in DIGITS.ToCharArray())
            {
                CharacterList.Add(c.ToString());
            }

            foreach (char c in SYMBOLS.ToCharArray())
            {
                CharacterList.Add(c.ToString());
            }
        }

        private void UpdatePasswordBox(object sender, EventArgs e)
        {
            if (CharacterList.Count == 0)
            {
                GeneratedPasswordTextBox.Text = "";
                return;
            }
            GeneratedPasswordTextBox.Text = CreatePassword(PasswordLengthTrackBar.Value);
        }

        private void PasswordLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            if (PasswordLengthTrackBar.Value > 0)
            {
                label3.Text = $"{PasswordLengthTrackBar.Value} characters";
            }
            else
            {
                label3.Text = $"{PasswordLengthTrackBar.Value} character";
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            this.UpdatePasswordBox(sender, e);
        }

        private string CreatePassword(int length)
        {
            Random random = new();
            StringBuilder password = new(1000);
            for (int i = 0; i < length; i++)
            {
                string charSet = CharacterList.ElementAt(RandomNumberGenerator.GetInt32(CharacterList.Count));
                string[] characters = charSet.Split(',');
                password.Append(characters[random.Next(characters.Length)]);
            }

            return password.ToString();
        }
        private static string[] GetEmojis(string separator)
        {
            int start = 0x1F600;
            int end = 0x1F64F;
            int range = end - start + 1;
            string[] emojis = new string[range];

            for (int i = 0; i < range; i++)
            {
                emojis[i] = char.ConvertFromUtf32(start + i);
            }
            return emojis;
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.UpdatePasswordBox(sender, e);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GeneratedPasswordTextBox.Text);
        }

        private void UppercaseCheckbox_Click(object sender, EventArgs e)
        {
            if (UppercaseCheckbox.Checked)
            {
                ManageCharacterList(true, UPPERCASE);
                AvoidSimilarCheckbox.Enabled = true;
            }
            else
            {
                if (!UppercaseCheckbox.Checked && !LowercaseCheckbox.Checked)
                {
                    AvoidSimilarCheckbox.Enabled = false;
                }
                ManageCharacterList(false, UPPERCASE);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void LowercaseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LowercaseCheckbox.Checked)
            {
                ManageCharacterList(true, LOWERCASE);
                AvoidSimilarCheckbox.Enabled = true;
            }
            else
            {
                if (!UppercaseCheckbox.Checked && !LowercaseCheckbox.Checked)
                {
                    AvoidSimilarCheckbox.Enabled = false;
                }
                ManageCharacterList(false, LOWERCASE);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void DigitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DigitsCheckbox.Checked)
            {
                ManageCharacterList(true, DIGITS);
            }
            else
            {
                ManageCharacterList(false, DIGITS);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void SymbolsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SymbolsCheckbox.Checked)
            {
                ManageCharacterList(true, SYMBOLS);
                AvoidAmbigiousCheckbox.Enabled = true;
            }
            else
            {
                ManageCharacterList(false, SYMBOLS);
                AvoidAmbigiousCheckbox.Enabled = false;
                AvoidAmbigiousCheckbox.Checked = false;
            }
            this.UpdatePasswordBox(sender, e);
        }
        private void EmojisCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmojisCheckbox.Checked)
            {
                ManageCharacterList(true, EMOJIS);

            }
            else
            {
                ManageCharacterList(false, EMOJIS);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void AvoidSimilarCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AvoidSimilarCheckbox.Checked)
            {
                if (UppercaseCheckbox.Checked)
                {
                    ManageCharacterList(false, "ILO");
                    UppercaseCheckbox.CheckState = CheckState.Indeterminate;
                }
                if (LowercaseCheckbox.Checked)
                {
                    ManageCharacterList(false, "ilo");
                    LowercaseCheckbox.CheckState = CheckState.Indeterminate;
                }
                UppercaseCheckbox.Enabled = false;
                LowercaseCheckbox.Enabled = false;
            }
            else
            {
                if (UppercaseCheckbox.CheckState == CheckState.Indeterminate)
                {
                    ManageCharacterList(true, "ILO");
                    UppercaseCheckbox.CheckState = CheckState.Checked;
                }
                if (LowercaseCheckbox.CheckState == CheckState.Indeterminate)
                {
                    ManageCharacterList(true, "ilo");
                    LowercaseCheckbox.CheckState = CheckState.Checked;
                }

                LowercaseCheckbox.Enabled = true;
                UppercaseCheckbox.Enabled = true;
            }

            this.UpdatePasswordBox(sender, e);
        }

        private void AvoidAmbigiousCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AvoidAmbigiousCheckbox.Checked)
            {
                ManageCharacterList(false, "\\\"£%^&*()_+=-[]'<>/?¬`{}");
            }
            else if (SymbolsCheckbox.Checked)
            {
                ManageCharacterList(true, "\\\"£%^&*()_+=-[]'<>/?¬`{}");
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void PasswordVisibilityButton_Click(object sender, EventArgs e)
        {
            if (this.PasswordVisibilityButton.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                GeneratedPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                GeneratedPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ManageCharacterList(bool shouldAdd, string stringToArray)
        {
            if (shouldAdd)
            {
                foreach (char c in stringToArray.ToCharArray())
                {
                    CharacterList.Add(c.ToString());
                }
            }
            else
            {
                foreach (char c in stringToArray.ToCharArray())
                {
                    CharacterList.Remove(c.ToString());
                }
            }
        }

        private void ManageCharacterList(bool shouldAdd, string[] stringArray)
        {
            if (shouldAdd)
            {
                foreach (string c in stringArray)
                {
                    CharacterList.Add(c);
                }
            }
            else
            {
                foreach (string c in stringArray)
                {
                    CharacterList.Remove(c);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


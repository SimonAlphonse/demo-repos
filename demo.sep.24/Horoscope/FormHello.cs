using System;
using NameHelper;
using System.Windows.Forms;

namespace Hello
{
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
        }

        private void FormHello_Load(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = string.Empty;
            }
            catch
            {
                // log ex.message
                MessageBox.Show(Constants.ERROR_MESSAGE_DEFAULT, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string message = ValidateInputs();

                if (string.IsNullOrWhiteSpace(message))
                {
                    comboBoxUserName.Enabled = true;

                    Person person;

                    switch (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                    {
                        case false when this.dateTimePickerDob.Value.IsPast():
                            person = new Person(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, dateTimePickerDob.Value);
                            break;
                        case false:
                            person = new Person(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text);
                            break;
                        default:
                            person = new Person(textBoxFirstName.Text, textBoxLastName.Text, dateTimePickerDob.Value);
                            break;
                    };

                    this.radioButtonAdult.Checked = person.IsAdult;
                    this.labelMessage.Text = person.BirthdayMessage;
                    this.comboBoxUserName.DataSource = person.UserNames;
                }
                else
                {
                    MessageBox.Show($"{message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                // log ex.message
                MessageBox.Show(Constants.ERROR_MESSAGE_DEFAULT, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates all the UI elements' values
        /// </summary>
        /// <returns></returns>
        private string ValidateInputs()
        {
            if (!this.textBoxFirstName.Text.IsText(4))
            {
                return $"Invalid first name. Minimum 4 characters.";
            }

            if (!this.textBoxLastName.Text.IsText(1))
            {
                return $"Invalid last name. Minimum 1 character.";
            }

            if (!this.textBoxEmail.Text.IsValidEmail(7))
            {
                return $"Invalid email. minimum 7 characters";
            }

            if (!this.dateTimePickerDob.Value.IsPast())
            {
                return $"Invalid Date of birth. Maximum 120 years";
            }

            return string.Empty;
        }
    }
}
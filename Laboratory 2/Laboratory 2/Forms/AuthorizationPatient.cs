using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Laboratory_2.Forms
{
    public partial class AuthorizationPatient : MaterialForm
    {
        public const string patientSubPath = @"C:\\DataBase\PatientData\";

        public static AuthorizationPatient patRegInst;
        public TextBox fNameTB;
        public TextBox sNameTB;

        FileOperations fileOperations = new FileOperations();
        public AuthorizationPatient()
        {
            InitializeComponent();
            patRegInst = this;
            fNameTB = FirstNameTxtBox;
            sNameTB = SecondNameTxtBox;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void PatientAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainPage.form1Main.Show();
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileOperations.PatientRegistrationFileCreation(patientSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
            Hide();
            var patientForm = new PatientForm();
            patientForm.ShowDialog();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileOperations.CheckFileForExsistence(patientSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
                if (fileOperations.CheckIfGetToGo() == true)
                {
                    Hide();
                    var patientForm = new PatientForm();
                    patientForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
        }
    }
}

using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Laboratory_2.Forms
{
    public partial class AuthorizationNurse : MaterialForm
    {

        public const string nurseSubPath = @"C:\\DataBase\NurseData\";

        public static AuthorizationNurse nurRegInst;
        public TextBox fNameTB;
        public TextBox sNameTB;

        FileOperations fileOperations = new FileOperations();
        public AuthorizationNurse()
        {
            InitializeComponent();
            nurRegInst = this;
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

        private void AuthorizationNurse_Load(object sender, EventArgs e)
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
                fileOperations.PatientRegistrationFileCreation(nurseSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
                Hide();
                var nurseForm = new NurseForm();
                nurseForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileOperations.CheckFileForExsistence(nurseSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
                if (fileOperations.CheckIfGetToGo() == true)
                {
                    Hide();
                    var nurForm = new NurseForm();
                    nurForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
        }
    }
}

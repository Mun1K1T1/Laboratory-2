using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Laboratory_2.Forms
{
    public partial class AuthorizationDoctor : MaterialForm
    {
        public const string docSubPath = @"C:\\DataBase\DocData\";

        public static AuthorizationDoctor docRegInst;
        public TextBox fNameTB;
        public TextBox sNameTB;

        FileOperations fileOperations = new FileOperations();
        public AuthorizationDoctor()
        {
            InitializeComponent();
            docRegInst = this;
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

        private void DoctorAuthorization_Load(object sender, EventArgs e)
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
                fileOperations.DoctorRegistrationFileCreation(docSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
                Hide();
                var doctorForm = new DoctorForm();
                doctorForm.ShowDialog();
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
                fileOperations.CheckFileForExsistence(docSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
                if (fileOperations.CheckIfGetToGo() == true)
                {
                    Hide();
                    var docForm = new DoctorForm();
                    docForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
        }
    }
}

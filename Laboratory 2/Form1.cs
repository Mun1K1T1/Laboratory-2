using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Laboratory_2
{
    public partial class MainPage : MaterialForm
    {
        public static string directPath = @"C:\\DataBase";
        public static string docSubPath = @"C:\\DataBase\DocData\";
        public static string nurseSubPath = @"C:\\DataBase\NurseData\";
        public static string patientSubPath = @"C:\\DataBase\PatientData\";
        public static string treatSubPath = @"C:\\DataBase\TreatmentData\";

        public void DataBaseCreation(string path)
        {
            var database = new DirectoryInfo(path);
            if (!database.Exists)
            {
                database.Create();
            }
        }

        public void DatabaseSubfolders(string docPath, string nursePath, string patientPath, string treatPath)
        {
            var docdata = new DirectoryInfo(docPath);
            if (!docdata.Exists)    docdata.Create();

            var nursedata = new DirectoryInfo(nursePath);
            if (!nursedata.Exists)  nursedata.Create();

            var patientdata = new DirectoryInfo(patientPath);
            if (!patientdata.Exists)    patientdata.Create();

            var treatmentdata = new DirectoryInfo(treatPath);
            if (!treatmentdata.Exists)  treatmentdata.Create();
        }
        //------------------------------------------------------------------------------------------
        string role;
        string sideSubPath;
        //------------------------------------------------------------------------------------------
        public void GetRole(RadioButton radioBtn)
        {
            if(radioBtn.Checked) role = radioBtn.Text;
        }
        public void UserRegistrationRoleObtain(string Role)
        {
            switch (Role)
            {
                case "Patient":
                    var patientForm = new PatientForm();
                    patientForm.Show();
                    Visible = false;
                    sideSubPath = patientSubPath;
                    break;

                case "Doctor":
                    var doctorForm = new DoctorForm();
                    doctorForm.Show();
                    Visible = false;
                    sideSubPath = docSubPath;
                    break;

                case "Nurse":
                    var nurseForm = new NurseForm();
                    nurseForm.Show();
                    Visible = false;
                    sideSubPath = nurseSubPath;
                    break;
            }
        }
        //------------------------------------------------------------------------------------------
        public void UserRegistrationFileCreation(string subpath, string id, string firstName, string secondName)
        {
            var fileWriter = new StreamWriter(subpath + firstName + " " + secondName + ".txt");
            fileWriter.WriteLine(id);
            fileWriter.WriteLine(firstName);
            fileWriter.WriteLine(secondName);
            fileWriter.Close();
        }
        //------------------------------------------------------------------------------------------

        public void UserRegistrationRoleObserve(string Role)
        {
            switch (Role)
            {
                case "Patient":
                    sideSubPath = patientSubPath;
                    break;

                case "Doctor":
                    sideSubPath = docSubPath;
                    break;

                case "Nurse":
                    sideSubPath = nurseSubPath;
                    break;
            }
        }

        public void CheckFileForExsistence(string subpath, string id, string firstName, string secondName)
        {
            if (!File.Exists(subpath + firstName + " " + secondName + ".txt")) return;
            else
            {
                string[] lines = File.ReadAllLines(subpath + firstName + " " + secondName + ".txt");
                long IdToCheck = Convert.ToInt64(id);
                long IdToCheckFrom = Convert.ToInt64(lines[0]);
                if (IdToCheck == IdToCheckFrom) MessageBox.Show("You're welcome");
                else
                {
                    MessageBox.Show("Wrong data");
                    return;
                }
            }
        }

        //##########################################################################################
        public static MainPage instance;
        public TextBox TxtBx1;
        public TextBox TxtBx2;
        public MainPage()
        {
            InitializeComponent();

            instance = this;
            TxtBx1 = FirstNameTxtBox;
            TxtBx2 = SecondNameTxtBox;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseCreation(directPath);
            DatabaseSubfolders(docSubPath, nurseSubPath, patientSubPath, treatSubPath);
        }
        private void SignBtn_Click(object sender, EventArgs e)
        {
            GetRole(PatientRadBtn);
            GetRole(NurseRadBtn);
            GetRole(DoctorRadBtn);

            UserRegistrationRoleObtain(role);
            UserRegistrationFileCreation(sideSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            GetRole(PatientRadBtn);
            GetRole(NurseRadBtn);
            GetRole(DoctorRadBtn);

            UserRegistrationRoleObserve(role);
            CheckFileForExsistence(sideSubPath, IdTxtBox.Text, FirstNameTxtBox.Text, SecondNameTxtBox.Text);
            UserRegistrationRoleObtain(role);
        }

        private void NurseRadBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PatientRadBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

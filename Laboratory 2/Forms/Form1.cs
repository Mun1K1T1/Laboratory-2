using Laboratory_2.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace Laboratory_2
{
    public partial class MainPage : MaterialForm
    {
        public const string directPath = @"C:\\DataBase";
        public const string docSubPath = @"C:\\DataBase\DocData\";
        public const string nurseSubPath = @"C:\\DataBase\NurseData\";
        public const string patientSubPath = @"C:\\DataBase\PatientData\";
        public const string treatSubPath = @"C:\\DataBase\TreatmentData\";

        private readonly IRepository<Doctor> doctorRepository;
        private readonly IRepository<Nurse> nurseRepository;
        private readonly IRepository<Patient> patientRepository;

        //------------------------------------------------------------------------------------------
        string role;
        string sideSubPath;
        //------------------------------------------------------------------------------------------

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
            if (!docdata.Exists) docdata.Create();

            var nursedata = new DirectoryInfo(nursePath);
            if (!nursedata.Exists) nursedata.Create();

            var patientdata = new DirectoryInfo(patientPath);
            if (!patientdata.Exists) patientdata.Create();

            var treatmentdata = new DirectoryInfo(treatPath);
            if (!treatmentdata.Exists) treatmentdata.Create();
        }
        //------------------------------------------------------------------------------------------
        public delegate void ShowMessage(string message);

        public static void Messaging(string message) => MessageBox.Show(message); // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //------------------------------------------------------------------------------------------

        public void GetRole(RadioButton radioBtn)
        {
            if (radioBtn.Checked) role = radioBtn.Text;
        }
        public void UserRegistrationRoleObtain(string Role)
        {
            switch (Role)
            {
                case "Patient":
                    var patientForm = new PatientForm();
                    patientForm.Show();
                    sideSubPath = patientSubPath;
                    break;

                case "Doctor":
                    var doctorForm = new DoctorForm();
                    doctorForm.Show();
                    sideSubPath = docSubPath;
                    break;

                case "Nurse":
                    var nurseForm = new NurseForm();
                    nurseForm.Show();
                    sideSubPath = nurseSubPath;
                    break;
            }
        }
        //------------------------------------------------------------------------------------------
        public void ObjectListCreation(string subpath, string id, string firstName, string secondName)
        {
            switch (subpath)
            {
                case docSubPath:
                    doctorRepository.Add(new Doctor(id, firstName, secondName));
                    break;
                case nurseSubPath:
                    nurseRepository.Add(new Nurse(id, firstName, secondName));
                    break;
                case patientSubPath:
                    patientRepository.Add(new Patient(id, firstName, secondName));
                    break;
            }
        }

        public void UserRegistrationFileCreation(string subpath, string id, string firstName, string secondName)
        {
            var fileWriter = new StreamWriter(subpath + firstName + " " + secondName + ".txt");
            fileWriter.WriteLine(id);
            fileWriter.WriteLine(firstName);
            fileWriter.WriteLine(secondName);
            fileWriter.Close();
            ObjectListCreation(subpath, id, firstName, secondName);
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
            string successfulinput = "You're welcome";
            string wrongInput = "Wrong data";
            if (!File.Exists(subpath + firstName + " " + secondName + ".txt")) return;
            else
            {
                string[] lines = File.ReadAllLines(subpath + firstName + " " + secondName + ".txt");
                long IdToCheck = Convert.ToInt64(id);
                long IdToCheckFrom = Convert.ToInt64(lines[0]);
                if (IdToCheck == IdToCheckFrom)
                {
                    ShowMessage showMessage = null;
                    showMessage += Messaging;
                    showMessage.Invoke(successfulinput);
                }
                else
                {
                    ShowMessage showMessage = null;
                    showMessage += Messaging;
                    showMessage.Invoke(wrongInput);
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

            doctorRepository = new GenericRepository<Doctor>();
            nurseRepository = new GenericRepository<Nurse>();
            patientRepository = new GenericRepository<Patient>();

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

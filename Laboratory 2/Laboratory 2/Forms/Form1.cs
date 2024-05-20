using Laboratory_2.Forms;
using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Laboratory_2
{
    public partial class MainPage : MaterialForm
    {
        public const string directPath = @"C:\\DataBase";
        public const string patientSubPath = @"C:\\DataBase\PatientData\";
        public const string docSubPath = @"C:\\DataBase\DocData\";
        public const string nurseSubPath = @"C:\\DataBase\NurseData\";
        public const string treatSubPath = @"C:\\DataBase\TreatmentData\";

        //------------------------------------------------------------------------------------------
        FileOperations fileOperations = new FileOperations();
        //##########################################################################################
        public static MainPage form1Main = new MainPage();
        public MainPage()
        {
            InitializeComponent();

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
            fileOperations.DataBaseCreation();
            fileOperations.DatabaseSubfolders();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var authorizationPatient = new AuthorizationPatient();
            authorizationPatient.Show();
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var authorizationDoctor = new AuthorizationDoctor();
            authorizationDoctor.Show();
        }

        private void NurseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var authorizationNurse = new AuthorizationNurse();
            authorizationNurse.Show();
        }
    }
}

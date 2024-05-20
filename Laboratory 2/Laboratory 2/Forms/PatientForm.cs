using Laboratory_2.Forms;
using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace Laboratory_2
{
    public partial class PatientForm : MaterialForm
    {
        public PatientForm()
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

        public string patientName;
        public static string patientSubPath = @"C:\\DataBase\PatientData\";
        public static string treatSubPath = @"C:\\DataBase\TreatmentData\";

        FileOperations fileOperations = new FileOperations();

        //------------------------------------------------------------------------------------------
        public void FillTheTreatmentTxtBox(string subPath, string firstName, string secondName)
        {
            string path = (subPath + firstName + " " + secondName + ".txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("This pathient didn't get medical direction!");
            }
            else
                TreatmentTxtBx.Text = File.ReadAllText(path);
        }
        //------------------------------------------------------------------------------------------
        private void PatientForm_Load(object sender, EventArgs e)
        {
            PatientNameTbx.Text = AuthorizationPatient.patRegInst.fNameTB.Text + " " + AuthorizationPatient.patRegInst.sNameTB.Text;
            try
            {
                FillTheTreatmentTxtBox(treatSubPath, AuthorizationPatient.patRegInst.fNameTB.Text, AuthorizationPatient.patRegInst.sNameTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: \n" + ex);
            }
        }

        private void DischargeBtn_Click(object sender, EventArgs e)
        {
            string patientFullName = PatientNameTbx.Text;
            string[] patientNameElements = patientFullName.Split(' ');
            string patientFirstName = patientNameElements[0];
            string patientSecondName = patientNameElements[1];
            fileOperations.DischargePatient(patientSubPath, treatSubPath, patientFirstName, patientSecondName);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainPage.form1Main.Show();
        }
    }
}

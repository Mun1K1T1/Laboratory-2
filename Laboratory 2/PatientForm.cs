using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace Laboratory_2
{
    public partial class PatientForm : MaterialForm
    {

        public static PatientForm instance;
        public PatientForm()
        {
            InitializeComponent();

            instance = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(instance);
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

        //------------------------------------------------------------------------------------------
        public void FillTheTreatmentTxtBox(string subPath, string firstName, string secondName)
        {
            string path = (subPath + firstName + " " + secondName + ".txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("This pathient didn't get medical direction!");
            }
            TreatmentTxtBx.Text = File.ReadAllText(path);

        }
        public void DischargePatient(string patientSubPath, string treatmentSubPath, string firstName, string secondName)
        {
            string patientPath = (patientSubPath + firstName + " " + secondName + ".txt");
            File.Delete(patientPath);
            string theatmentPath = (treatmentSubPath + firstName + " " + secondName + ".txt");
            File.Delete(theatmentPath);
            MessageBox.Show("You have been successfully discharged!");
        }
        //------------------------------------------------------------------------------------------
        private void PatientForm_Load(object sender, EventArgs e)
        {
            patientName = MainPage.instance.TxtBx1.Text + " " + MainPage.instance.TxtBx2.Text;
            PatientNameTbx.Text = patientName;

            string patientFullName = PatientNameTbx.Text;
            string[] patientNameElements = patientFullName.Split(' ');
            string patientFirstName = patientNameElements[0];
            string patientSecondName = patientNameElements[1];

            FillTheTreatmentTxtBox(treatSubPath, patientFirstName, patientSecondName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TreatmentTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void TreatmentsListBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DischargeBtn_Click(object sender, EventArgs e)
        {
            string patientFullName = PatientNameTbx.Text;
            string[] patientNameElements = patientFullName.Split(' ');
            string patientFirstName = patientNameElements[0];
            string patientSecondName = patientNameElements[1];
            DischargePatient(patientSubPath, treatSubPath, patientFirstName, patientSecondName);
        }
    }
}

using Laboratory_2.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;

namespace Laboratory_2
{
    public partial class DoctorForm : MaterialForm
    {
        public static DoctorForm instance;

        public static string patientSubPath = @"C:\\DataBase\PatientData\";
        public static string treatSubPath = @"C:\\DataBase\TreatmentData\";
        //------------------------------------------------------------------------------------------
        private string[] FindPatientsFiles(string patAdress)
        {
            string[] patients = Directory.GetFiles(patAdress);
            return patients;
        }


        string[] patientsNames;
        private string[] GetPatientsNames(string[] patientsPath)
        {
            patientsNames = patientsPath;
            for (int i = 0; i < patientsPath.Length; i++)
            {
                patientsPath[i] = Path.GetFileNameWithoutExtension(patientsPath[i]);
                patientsNames[i] = patientsPath[i];
            }

            return patientsNames;
        }


        private void AddItemsPatientsListview(string patAdress)
        {
            string[] names = GetPatientsNames(FindPatientsFiles(patAdress));
            for (int i = 0; i < names.Length; i++)
            {
                PatientsListBox.Items.Add(names[i]);
            }
        }

        string[] textboxText;
        public string[] ReadTextboxToStringArray()
        {
            string treatmentText = TreatmentTxtBx.Text.ToString();
            textboxText = treatmentText.Split(';');
            return textboxText;
        }

        public void TreatmentCreation(string subpath, string firstName, string secondName, string[] textboxCont)
        {
            var treatment = new StreamWriter(subpath + firstName + " " + secondName + ".txt");
            for (int i = 0; i < textboxCont.Length; i++)
            {
                treatment.Write(textboxCont[i]);
            }
            treatment.Close();

            string message = "Treatment submitted!";
            var treatmentObj = new Treatment(firstName, secondName);
        }

        //------------------------------------------------------------------------------------------
        public DoctorForm()
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

        public string doctorName;

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            doctorName = MainPage.instance.TxtBx1.Text + " " + MainPage.instance.TxtBx2.Text;
            DocNameTbx.Text = doctorName;

            AddItemsPatientsListview(patientSubPath);

        }

         private void PatientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string patientFullName = PatientsListBox.SelectedItem.ToString();
            string[] patientNameElements = patientFullName.Split(' ');
            PatientFirstNameTxb.Text = patientNameElements[0];
            PatientSecNameTxb.Text = patientNameElements[1];
        }

        private void TreatmentSubmissionBtn_Click(object sender, EventArgs e)
        {
            TreatmentCreation(treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text, ReadTextboxToStringArray());
        }
    }
}

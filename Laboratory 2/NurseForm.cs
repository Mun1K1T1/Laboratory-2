using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Laboratory_2
{
    public partial class NurseForm : MaterialForm
    {
        public NurseForm()
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
            MessageBox.Show("Pathient has been successfully discharged!");
        }

        public void PerformTreatment(string patientSubPath, string treatmentSubPath, string firstName, string secondName)
        {
            string patientPath = (patientSubPath + firstName + " " + secondName + ".txt");
            File.Delete(patientPath);
            string theatmentPath = (treatmentSubPath + firstName + " " + secondName + ".txt");
            File.Delete(theatmentPath);
            MessageBox.Show("Treatment has been successfully performed and pathient has been discharged!");
        }

        //------------------------------------------------------------------------------------------
        public string nurseName;
        private void NurseForm_Load(object sender, EventArgs e)
        {
            nurseName = MainPage.instance.TxtBx1.Text + " " + MainPage.instance.TxtBx2.Text;
            NurNameTbx.Text = nurseName;

            AddItemsPatientsListview(patientSubPath);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PatientSecNameTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientFirstNameTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DocNameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PatientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string patientFullName = PatientsListBox.SelectedItem.ToString();
            string[] patientNameElements = patientFullName.Split(' ');
            PatientFirstNameTxb.Text = patientNameElements[0];
            PatientSecNameTxb.Text = patientNameElements[1];

            FillTheTreatmentTxtBox(treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text);
        }

        private void TreatmentTxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            DischargePatient(patientSubPath, treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            PerformTreatment(patientSubPath, treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text);
        }
    }
}

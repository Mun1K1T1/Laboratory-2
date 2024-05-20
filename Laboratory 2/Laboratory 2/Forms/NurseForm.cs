using Laboratory_2.Forms;
using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

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

        FileOperations fileOperations = new FileOperations();
        //------------------------------------------------------------------------------------------
        private void AddItemsPatientsListview(string patAdress)
        {
            string[] names = fileOperations.GetPatientsNames(fileOperations.FindPatientsFiles(patAdress));
            for (int i = 0; i < names.Length; i++)
            {
                PatientsListBox.Items.Add(names[i]);
            }
        }

        //------------------------------------------------------------------------------------------
        private void NurseForm_Load(object sender, EventArgs e)
        {
            NurNameTbx.Text = AuthorizationNurse.nurRegInst.fNameTB.Text + " " + AuthorizationNurse.nurRegInst.sNameTB.Text;

            AddItemsPatientsListview(patientSubPath);
        }

        private void PatientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string patientFullName = PatientsListBox.SelectedItem.ToString();
            string[] patientNameElements = patientFullName.Split(' ');
            PatientFirstNameTxb.Text = patientNameElements[0];
            PatientSecNameTxb.Text = patientNameElements[1];

            string[] treatmentContext = fileOperations.FillTheTreatment(treatSubPath, patientNameElements[0], patientNameElements[1]);

            TreatmentTxtBx.Clear();

            if (treatmentContext != null)
            {
                foreach (string element in treatmentContext)
                {
                    TreatmentTxtBx.AppendText(element + Environment.NewLine);
                }
            }
            else
            {
                TreatmentTxtBx.Text = "No treatment content available.";
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            fileOperations.DischargePatient(patientSubPath, treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text);
            PatientsListBox.Items.Clear();
            TreatmentTxtBx.Text = String.Empty;
            AddItemsPatientsListview(patientSubPath);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            fileOperations.PerformTreatment(patientSubPath, treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text);
            PatientsListBox.Items.Clear();
            TreatmentTxtBx.Text = String.Empty;
            AddItemsPatientsListview(patientSubPath);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainPage.form1Main.Show();
        }
    }
}

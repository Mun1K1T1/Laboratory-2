using Laboratory_2.Forms;
using Laboratory_2.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Laboratory_2
{
    public partial class DoctorForm : MaterialForm
    {

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


        public string[] ReadTextboxToStringArray()
        {
            string treatmentText = TreatmentTxtBx.Text.ToString();
            string[] textboxText = treatmentText.Split('\n');
            return textboxText;
        }
        //------------------------------------------------------------------------------------------
        public DoctorForm()
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



        private void DoctorForm_Load(object sender, EventArgs e) //-------------------------------------------------------------------------------------------------!!!!!!!!!!!!!!!!!!!!!!!!
        {
            DocNameTbx.Text = AuthorizationDoctor.docRegInst.fNameTB.Text + " " + AuthorizationDoctor.docRegInst.sNameTB.Text;

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
            try
            {
                fileOperations.TreatmentFileCreation(treatSubPath, PatientFirstNameTxb.Text, PatientSecNameTxb.Text, ReadTextboxToStringArray());
                MessageBox.Show("Treatment submitted successfully!");
                TreatmentTxtBx.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred - \n" + ex);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainPage.form1Main.Show();
        }
    }
}

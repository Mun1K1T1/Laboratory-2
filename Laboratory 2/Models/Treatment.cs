using System.Windows.Forms;

namespace Laboratory_2.Models
{

    internal class Treatment
    {
        public string PatientFirstName { get; set; }
        public string PatientSecondName { get; set; }

        public Treatment(string patientFirstName, string patientSecondName)
        {
            PatientFirstName = patientFirstName;
            PatientSecondName = patientSecondName;
        }
    }
}

using System.Windows.Forms;

namespace Laboratory_2.Models
{
    public interface IWasCreated
    {
        void MessageAboutBeingCreated(string message);
    } 

    internal class Treatment : IWasCreated
    {
        public string PatientFirstName { get; set; }
        public string PatientSecondName { get; set; }

        public Treatment(string patientFirstName, string patientSecondName) 
        {
            PatientFirstName = patientFirstName;
            PatientSecondName = patientSecondName;
        }

        public void MessageAboutBeingCreated(string message)
        {
            MessageBox.Show(message);
        }
    }
}

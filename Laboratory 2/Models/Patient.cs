namespace Laboratory_2.Models
{
    internal class Patient : Person
    {
        public string _assignedTreatment;

        public string AssignedTreatmentName { get; set; }
        public Patient(string id, string firstName, string secondName, string assignedTreatmentName) : base(id, firstName, secondName)
        {
            AssignedTreatmentName = assignedTreatmentName;
        }
    }
}

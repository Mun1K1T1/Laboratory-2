namespace Laboratory_2.Models
{
    internal class Treatment
    {
        private string _treatmentName;
        private string _leadingDoctor;
        private string _assignedStaffMember;
        private string _patientName;

        public string TreatmentName { get; set; }
        public string LeadingDoctor { get; set; }
        public string AssignedStaffMember { get; set; }
        public string PatientName { get; set; }

        public Treatment(string treatmentName, string leadingDoctor, string assignedStaffMember, string patientName) 
        {
            _treatmentName = treatmentName;
            _leadingDoctor = leadingDoctor;
            _assignedStaffMember = assignedStaffMember;
            _patientName = patientName;
        }
    }
}

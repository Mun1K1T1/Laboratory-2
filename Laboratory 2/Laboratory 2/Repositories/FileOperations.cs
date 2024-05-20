﻿using Laboratory_2.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace Laboratory_2.Repositories
{
    internal class FileOperations
    {
        public const string directPath = @"C:\\DataBase";
        public const string docSubPath = @"C:\\DataBase\DocData\";
        public const string nurseSubPath = @"C:\\DataBase\NurseData\";
        public const string patientSubPath = @"C:\\DataBase\PatientData\";
        public const string treatSubPath = @"C:\\DataBase\TreatmentData\";


        private readonly IRepository<Doctor> doctorRepository;
        private readonly IRepository<Nurse> nurseRepository;
        private readonly IRepository<Patient> patientRepository;
        //-----------------------------------------------------------------------------------------------------------------------------------

        public void DataBaseCreation()
        {
            var database = new DirectoryInfo(directPath);
            if (!database.Exists)
            {
                database.Create();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void DatabaseSubfolders()
        {
            var docdata = new DirectoryInfo(docSubPath);
            if (!docdata.Exists) docdata.Create();

            var nursedata = new DirectoryInfo(nurseSubPath);
            if (!nursedata.Exists) nursedata.Create();

            var patientdata = new DirectoryInfo(patientSubPath);
            if (!patientdata.Exists) patientdata.Create();

            var treatmentdata = new DirectoryInfo(treatSubPath);
            if (!treatmentdata.Exists) treatmentdata.Create();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void DoctorObjectListCreation(string id, string firstName, string secondName)
        {
            doctorRepository.Add(new Doctor(id, firstName, secondName));
        }

        public void PatientObjectListCreation(string id, string firstName, string secondName)
        {
            patientRepository.Add(new Patient(id, firstName, secondName));
        }

        public void NurseObjectListCreation(string id, string firstName, string secondName)
        {
            nurseRepository.Add(new Nurse(id, firstName, secondName));
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        public void PatientRegistrationFileCreation(string subpath, string id, string firstName, string secondName)
        {
            try
            {
                var user = new Patient(id, firstName, secondName);
                string jsonObj = JsonConvert.SerializeObject(user);
                File.WriteAllText(Path.Combine(subpath, $"{firstName} {secondName}.json"), jsonObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Didn't secceed in filling a file - " + ex);
            }
        }

        public void DoctorRegistrationFileCreation(string subpath, string id, string firstName, string secondName)
        {
            try
            {
                var user = new Doctor(id, firstName, secondName);
                string jsonObj = JsonConvert.SerializeObject(user);
                File.WriteAllText(Path.Combine(subpath, $"{firstName} {secondName}.json"), jsonObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Didn't secceed in filling a file - " + ex);
            }
        }

        public void NurseRegistrationFileCreation(string subpath, string id, string firstName, string secondName)
        {
            try
            {
                var user = new Nurse(id, firstName, secondName);
                string jsonObj = JsonConvert.SerializeObject(user);
                File.WriteAllText(Path.Combine(subpath, $"{firstName} {secondName}.json"), jsonObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Didn't secceed in filling a file - " + ex);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public string ReadJsonFromFile(string subpath, string firstName, string secondName)
        {
            string generalPath = subpath + firstName + " " + secondName + ".json";
            try
            {
                return File.ReadAllText(generalPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to read JSON file: " + ex);
                return null;
            }
        }
        public string GetUserId(string jsonContent)
        {
            try
            {
                dynamic jsonObj = JObject.Parse(jsonContent);
                return jsonObj.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get id from JSON: " + ex);
                return null;
            }
        }
        public string[] GetUserTreatmentContent(string jsonContent)
        {
            try
            {
                dynamic jsonObj = JObject.Parse(jsonContent);
                JArray treatmentContentArray = jsonObj.TreatmentContent;
                return treatmentContentArray.ToObject<string[]>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get id from JSON: " + ex);
                return null;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public bool IdInput(int idToCheck, int userId)
        {
            bool access;
            if (idToCheck == userId)
            {
                access = true;
                MessageBox.Show("You successfully signed in!");
            }
            else
            {
                access = false;
                MessageBox.Show("Wrong id input");
            }

            return access;
        }

        public bool mainFuncBoolean;
        public void CheckFileForExsistence(string subpath, string id, string firstName, string secondName)
        {
            int ID = Convert.ToInt32(id);
            string generalPath = subpath + firstName + " " + secondName + ".json";
            string jsonContent = ReadJsonFromFile(subpath, firstName, secondName);
            try
            {
                if (!File.Exists(generalPath))
                {
                    MessageBox.Show("You need to sign up at first!");
                    mainFuncBoolean = false;
                }

                int jsonId = Convert.ToInt32(GetUserId(jsonContent));

                bool idCheck = IdInput(jsonId, ID);
                if (idCheck == true)
                {

                    mainFuncBoolean = true;
                }
                if (idCheck == false)
                {

                    mainFuncBoolean = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Didn't succeed - " + ex);
                mainFuncBoolean = false;
            }
        }

        public bool CheckIfGetToGo()
        {
            bool toGo = mainFuncBoolean;
            if (toGo == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public string[] FindPatientsFiles(string patAdress)
        {
            string[] patients = Directory.GetFiles(patAdress);
            return patients;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        string[] patientsNames;
        public string[] GetPatientsNames(string[] patientsPath)
        {
            patientsNames = patientsPath;
            for (int i = 0; i < patientsPath.Length; i++)
            {
                patientsPath[i] = Path.GetFileNameWithoutExtension(patientsPath[i]);
                patientsNames[i] = patientsPath[i];
            }

            return patientsNames;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public void TreatmentFileCreation(string subpath, string patientFirstName, string patientSecondName, string[] textboxContent)
        {
            try
            {
                var treatment = new Treatment(patientFirstName, patientSecondName, textboxContent);
                string jsonObj = JsonConvert.SerializeObject(treatment);
                File.WriteAllText(Path.Combine(subpath, $"{patientFirstName} {patientSecondName}.json"), jsonObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Didn't secceed in filling a file - " + ex);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public string[] FillTheTreatment(string subpath, string firstName, string secondName)
        {
            string jsonContent = ReadJsonFromFile(subpath, firstName, secondName);
            return GetUserTreatmentContent(jsonContent);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        public void DischargePatient(string patientSubPath, string treatmentSubPath, string firstName, string secondName)
        {
            string patientPath = patientSubPath + firstName + " " + secondName + ".json";
            string treatmentPath = treatmentSubPath + firstName + " " + secondName + ".json";

            if (File.Exists(patientPath))
            {
                File.Delete(patientPath);
                File.Delete(treatmentPath);
                MessageBox.Show("Patient has been successfully discharged!");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void PerformTreatment(string patientSubPath, string treatmentSubPath, string firstName, string secondName)
        {
            string patientFilePath = (patientSubPath + firstName + " " + secondName + ".json");
            File.Delete(patientFilePath);
            string theatmentFilePath = (treatmentSubPath + firstName + " " + secondName + ".json");
            File.Delete(theatmentFilePath);
            MessageBox.Show("Treatment has been successfully performed and pathient has been discharged!");
        }
    }
}
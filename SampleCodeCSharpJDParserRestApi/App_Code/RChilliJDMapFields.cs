using System;
using System.Collections.Generic;
using System.Web;
namespace RChilli
{
    public class Error
    {
        public int errorcode { get; set; }
        public string errormsg { get; set; }
    }
    public class ErrorClass
    {
        public Error error { get; set; }
    }
    public class JobProfile
    {
        public string Title { get; set; }
        public string Alias { get; set; }
        public string RelatedSkills { get; set; }
    }

    public class JobLocation
    {
        public string Location { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string IsoCountryCode { get; set; }
        public object ZipCode { get; set; }
    }

    public class ExperienceRequired
    {
        public string MinimumYearsExperience { get; set; }
        public string MaximumYearsExperience { get; set; }
    }

    public class SalaryOffered
    {
        public string MinAmount { get; set; }
        public string MaxAmount { get; set; }
        public string Currency { get; set; }
        public string Units { get; set; }
        public string Text { get; set; }
    }

    public class BillRate
    {
        public string MinAmount { get; set; }
        public string MaxAmount { get; set; }
        public string Currency { get; set; }
        public string Units { get; set; }
        public string Text { get; set; }
    }

    public class PreferredDemographic
    {
        public string Nationality { get; set; }
        public string Visa { get; set; }
        public string AgeLimit { get; set; }
        public string Others { get; set; }
    }

    public class Qualifications
    {
        public List<object> Preferred { get; set; }
        public List<object> Required { get; set; }
    }

    public class Certifications
    {
        public List<object> Preferred { get; set; }
        public List<object> Required { get; set; }
    }

    public class Preferred
    {
        public string Skill { get; set; }
        public string Type { get; set; }
        public string Alias { get; set; }
    }

    public class Required
    {
        public string Skill { get; set; }
        public string Type { get; set; }
        public string Alias { get; set; }
    }

    public class Skills
    {
        public List<Preferred> Preferred { get; set; }
        public List<Required> Required { get; set; }
    }

    public class JDParsedData
    {
        public string FileName { get; set; }
        public string ParsingDate { get; set; }
        public JobProfile JobProfile { get; set; }
        public string Organization { get; set; }
        public string StaffingAgency { get; set; }
        public string AboutOrganization { get; set; }
        public JobLocation JobLocation { get; set; }
        public string JobCode { get; set; }
        public string JobType { get; set; }
        public object JobShift { get; set; }
        public string IsManagementJob { get; set; }
        public string IndustryType { get; set; }
        public string ExcecutiveType { get; set; }
        public string PostedOnDate { get; set; }
        public string ClosingDate { get; set; }
        public ExperienceRequired ExperienceRequired { get; set; }
        public string ContractDuration { get; set; }
        public string HasContract { get; set; }
        public SalaryOffered SalaryOffered { get; set; }
        public BillRate BillRate { get; set; }
        public string NoticePeriod { get; set; }
        public string NoOfOpenings { get; set; }
        public string Relocation { get; set; }
        public string Languages { get; set; }
        public PreferredDemographic PreferredDemographic { get; set; }
        public List<string> Domains { get; set; }
        public Qualifications Qualifications { get; set; }
        public Certifications Certifications { get; set; }
        public Skills Skills { get; set; }
        public string Responsibilities { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPersonName { get; set; }
        public string WebSite { get; set; }
        public string InterviewType { get; set; }
        public string InterviewDate { get; set; }
        public string InterviewTime { get; set; }
        public string InterviewLocation { get; set; }
        public string TypeOfSource { get; set; }
        public string JobDescription { get; set; }
        public string JDHtmlData { get; set; }
    }

    public class RChilliJDMapFields
    {
        public JDParsedData JDParsedData { get; set; }
    }

}
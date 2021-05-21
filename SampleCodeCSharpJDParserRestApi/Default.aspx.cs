using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RChilli;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
             
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
       JDParser parser = new JDParser();
       String OutPutJson = "";
       if (FileUpload1.HasFile)
       {
           String filePath=Server.MapPath("JDs/")+FileUpload1.FileName;
           FileUpload1.SaveAs(filePath);

           OutPutJson = parser.ParserJD(parser.EncodeFileToBase64(filePath), FileUpload1.FileName, "SubuserId As per agreement");
       }
       else if (!JDText.Text.Equals(""))
       {
           OutPutJson = parser.ParserJDText(parser.EncodeTo64(JDText.Text), "SubuserId As per agreement");
       }
       else
       {
           JDJson.Text = "Please enter text or select a jd file to parse.";
       }

     
        StringBuilder sb= new StringBuilder();
        

        if (OutPutJson.Contains("\"error\":"))
        {
            ErrorClass errorObj = JsonConvert.DeserializeObject<ErrorClass>(OutPutJson);
            Error error = errorObj.error;
            sb.Append("FileName : " + error.errorcode+"<br/>");
            sb.Append("FileName : " + error.errormsg+"<br/>");

        }
        else
        {
            RChilliJDMapFields obj = JsonConvert.DeserializeObject<RChilliJDMapFields>(OutPutJson);
            JDParsedData jdParsedData = obj.JDParsedData;
            

             sb.Append("FileName : " + jdParsedData.FileName+"<br/>");
             sb.Append("ParsingDate : " + jdParsedData.ParsingDate + "<br/>");
             sb.Append("<b>JobProfile: </b><br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Title: " + jdParsedData.JobProfile.Title + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Alias : " + jdParsedData.JobProfile.Alias + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;RelatedSkills : " + jdParsedData.JobProfile.RelatedSkills + "<br/>");

             sb.Append("Organization : " + jdParsedData.Organization+"<br/>");
             sb.Append("StaffingAgency : " + jdParsedData.StaffingAgency + "<br/>");
             sb.Append("AboutOrganization : " + jdParsedData.AboutOrganization + "<br/>");

             sb.Append("<b>JobLocation: </b><br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Location : " + jdParsedData.JobLocation.Location + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;City: " + jdParsedData.JobLocation.City + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;State: " + jdParsedData.JobLocation.State + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Country: " + jdParsedData.JobLocation.Country + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;IsoCountryCode: " + jdParsedData.JobLocation.IsoCountryCode + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;ZipCode: " + jdParsedData.JobLocation.ZipCode + "<br/>");

             sb.Append("IsManagementJob : " + jdParsedData.IsManagementJob + "<br/>");
             sb.Append("JobCode : " + jdParsedData.JobCode+"<br/>");
             sb.Append("JobType : " + jdParsedData.JobType+"<br/>");
             sb.Append("JobShift : " + jdParsedData.JobShift + "<br/>");

             sb.Append("ExcecutiveType : " + jdParsedData.ExcecutiveType + "<br/>");
             sb.Append("IndustryType : " + jdParsedData.IndustryType+"<br/>");
             sb.Append("PostedOnDate : " + jdParsedData.PostedOnDate+"<br/>");
             sb.Append("ClosingDate : " + jdParsedData.ClosingDate + "<br/>");
             sb.Append("ContractDuration : " + jdParsedData.ContractDuration + "<br/>");
             sb.Append("HasContract : " + jdParsedData.HasContract + "<br/>");

             sb.Append("MinExperienceRequired : " + jdParsedData.ExperienceRequired.MinimumYearsExperience+"<br/>");
             sb.Append("MaxExperienceRequired : " + jdParsedData.ExperienceRequired.MaximumYearsExperience + "<br/>");

             sb.Append("<b>SalaryOffered: </b><br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;SalaryOffered : " + jdParsedData.SalaryOffered.Text + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;MinAmount : " + jdParsedData.SalaryOffered.MinAmount + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;MaxAmount : " + jdParsedData.SalaryOffered.MaxAmount + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Currency : " + jdParsedData.SalaryOffered.Currency + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Units : " + jdParsedData.SalaryOffered.Units + "<br/>");

             sb.Append("<b>BillRate: </b><br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;BillRate : " + jdParsedData.BillRate.Text + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;MinAmount : " + jdParsedData.BillRate.MinAmount + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;MaxAmount : " + jdParsedData.BillRate.MaxAmount + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Currency : " + jdParsedData.BillRate.Currency + "<br/>");
             sb.Append("&nbsp;&nbsp;&nbsp;Units : " + jdParsedData.BillRate.Units + "<br/>");


             sb.Append("Languages : " + jdParsedData.Languages + "<br/>");
             sb.Append("NoticePeriod : " + jdParsedData.NoticePeriod+"<br/>");
             sb.Append("NoOfOpenings : " + jdParsedData.NoOfOpenings+"<br/>");
             sb.Append("Relocation : " + jdParsedData.Relocation+"<br/>");
             sb.Append("ContactEmail : " + jdParsedData.ContactEmail+"<br/>");
             sb.Append("ContactPhone : " + jdParsedData.ContactPhone+"<br/>");
             sb.Append("ContactPersonName : " + jdParsedData.ContactPersonName+"<br/>");
             sb.Append("WebSite : " + jdParsedData.WebSite+"<br/>");

             sb.Append("Nationality : " + jdParsedData.PreferredDemographic.Nationality + "<br/>");
             sb.Append("Visa : " + jdParsedData.PreferredDemographic.Visa + "<br/>");
             sb.Append("AgeLimit : " + jdParsedData.PreferredDemographic.AgeLimit + "<br/>");
             sb.Append("Others : " + jdParsedData.PreferredDemographic.Others + "<br/>");

             sb.Append("InterviewType : " + jdParsedData.InterviewType+"<br/>");
             sb.Append("InterviewDate : " + jdParsedData.InterviewDate+"<br/>");
             sb.Append("InterviewTime : " + jdParsedData.InterviewTime+"<br/>");
             sb.Append("InterviewLocation : " + jdParsedData.InterviewLocation+"<br/>");
             sb.Append("Responsibilities : " + jdParsedData.Responsibilities + "<br/>");
             sb.Append("Duties : " + jdParsedData.Duties + "<br/>");
             sb.Append("JobDescription : <textarea rows='5' cols='50'> " + jdParsedData.JobDescription + "</textarea><br/>");
             sb.Append("JDHtmlData : <textarea rows='5' cols='50'>" + jdParsedData.JDHtmlData + "</textarea><br/>");
             Skills skills = jdParsedData.Skills;
             String temp = "";
             foreach (RChilli.Required reqskill in skills.Required)
             {

                 temp += "<tr><td>" + reqskill.Skill + "</td><td>" + reqskill.Type + "</td><td>" + reqskill.Alias + "</td></tr>";

             }

             sb.Append("<b>Skills <sub>required</sub> </b><br/>");
             sb.Append("<table>" + temp + "</table>");

             temp = "";

             foreach (Preferred prefskill in skills.Preferred)
             {
                 temp += "<tr><td>" + prefskill.Skill + "</td><td>" + prefskill.Type + "</td><td>" + prefskill.Alias + "</td></tr>";
             }

             sb.Append("<b>Skills <sub>required</sub> </b><br/>");
             sb.Append("<table>" + temp + "</table>");

             Qualifications quals = jdParsedData.Qualifications;
             temp = "";
             foreach (string prefQual in quals.Preferred)
             {
                 temp += prefQual + ",";
             }

             sb.Append("Qualification<sub>preferred</sub> : " + temp+"<br/>");
             temp = "";
             foreach (string reqQuals in quals.Required)
             {
                 temp += reqQuals + ",";
             }

             sb.Append("Qualification<sub>required</sub> : " + temp+"<br/>");

             Certifications certis = jdParsedData.Certifications;
             temp = "";
             foreach (string prefCerti in certis.Preferred)
             {
                 temp += prefCerti + ",";
             }

             sb.Append("Certification<sub>preferred</sub> : " + temp+"<br/>");
             temp = "";
             foreach (string reqCerti in certis.Required)
             {
                 temp += reqCerti + ",";
             }

             sb.Append("Certification<sub>required</sub> : " + temp+"<br/>");


        }

        JDJson.Text = OutPutJson;
        Literal1.Text=sb.ToString();

        
    }
}
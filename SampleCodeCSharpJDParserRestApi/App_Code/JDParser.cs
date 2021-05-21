using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using System.Configuration;
/// <summary>
/// Summary description for JDParser
/// </summary>
public class JDParser
{
    String serviceUrl = ConfigurationManager.AppSettings["ServiceUrl"].ToString();
    String apiKey = ConfigurationManager.AppSettings["UserKey"].ToString();
    String version = ConfigurationManager.AppSettings["Version"].ToString();

    public String ParserJDText(String base64Text, String subUserId)
	{
        String strRequest = "{"
                            + "\"base64text\":\"" + base64Text + "\","
                            + "\"userkey\":\"" + apiKey + "\","
                            + "\"version\":\"" + version + "\","
                            + "\"subuserid\":\"" + subUserId + "\","
                        + "}";

            return CallApi(strRequest,"/ParseJDText");
        
	}
    public String ParserJD(String fileBase64Data,String fileName, String subUserId)
    {
        String strRequest = "{"
                            + "\"filedata\":\"" + fileBase64Data + "\","
                             + "\"filename\":\"" + fileName + "\","
                            + "\"userkey\":\"" + apiKey + "\","
                            + "\"version\":\"" + version + "\","
                            + "\"subuserid\":\"" + subUserId + "\","
                        + "}";

        return CallApi(strRequest, "/ParseJD");

    }

  String CallApi(String strRequest,String method)
  {
      try{
             byte[] byteArray = Encoding.UTF8.GetBytes(strRequest);
             HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(serviceUrl + method);
                httpRequest.Credentials = CredentialCache.DefaultCredentials;
                httpRequest.Method = "POST";
                
                httpRequest.ContentType = "application/json;charset=\"utf-8\"";
                
                httpRequest.ContentLength = byteArray.Length;
                httpRequest.Timeout = 300000;
                Stream dataStream = httpRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string ack = streamReader.ReadToEnd();
              ack=  HttpUtility.HtmlDecode(ack);
              return ack;


            }
            catch (Exception ex)
            {
                return "{\"error\":{\"errorcode\":\"5555\", \"errormsg\":\"" + ex.Message +"\"}}";

            }
  }
    public string EncodeTo64(string toEncode)
    {
        byte[] toEncodeAsBytes
              = System.Text.UTF8Encoding.UTF8.GetBytes(toEncode);
        string returnValue
              = System.Convert.ToBase64String(toEncodeAsBytes);
        return returnValue;
    }
    public String EncodeFileToBase64(String filePath)
    {
        Byte[] bytes = File.ReadAllBytes(filePath);

        return Convert.ToBase64String(bytes);
    }
}
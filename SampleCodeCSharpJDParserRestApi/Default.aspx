<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="vkbeautify.js"></script>
<style type="text/css">
body
{
	width:100%;
	height:100%;
	background:#312F30;
	
}


	#container
	{
		width:80%;
		height:90%;
		border:2px solid #9e9c9c;
		box-shadow:0 0 10px black;
		border-radius:5px;
		margin-left:9%;	
		background:white;	
	}
	#content
	{
		min-height:500px;

		padding:10px;
	}
	#top
	{
		border-bottom:2px solid #037291;
		box-shadow:0 0 10px black;
		border-radius:5px;
		padding:10px;
		background:#037291;
		color:white;
		text-shadow:0 0 5px white;
		
	}
	#bottom
	{
		border-top:2px solid #037291;
		border-radius:5px;
		padding:10px;
		color:black;
		font-size:bolder;
	}
	input[type="password"],textarea
	{
		border:1px solid #9e9c9c;
		border-radius:5px;
		
	}
	
	input[type="password"]
	{
		height:25px;
	}
	
		
		
	
	
</style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="container">
	 	<div id="top">
	<center>	<h2>RChilli JdParser</h2></center> 
	 	</div>
	 	<div id="content">
	 	
	 	
	 			<center>
	 				<table>
	 					<tr>
	 						<td><b>Enter JD Text</b></td>
	 						<td>
                                 <asp:TextBox ID="JDText" TextMode="MultiLine" Rows="15" Columns="70"  runat="server"></asp:TextBox>
                               </td> 
	 					</tr>
                        <tr>
	 						<td colspan="2"> OR </td> 
	 					</tr>
                        <tr>
	 						<td><b>select File</b></td>
	 						<td>
                                 <asp:FileUpload ID="FileUpload1" runat="server" />
                                </td> 
	 					</tr>
	 					<tr>
	 						<td> </td>
	 						<td>
                                 <asp:Button ID="Submit" runat="server" Text="ParseJD" onclick="Submit_Click" />
                            </td> 
	 					</tr>
	 					<tr>
	 						<td><b>Output:-</b></td>
	 						<td></td> 
	 					</tr>
	 					<tr>
	 						<td colspan="2">
                             <asp:TextBox ID="JDJson" TextMode="MultiLine" Rows="15" Columns="90"  runat="server"></asp:TextBox>
							
							</td>
	 					</tr>

                        <tr>
	 						<td colspan="2">
                                 <asp:Literal ID="Literal1" runat="server"></asp:Literal>
							
							</td>
	 					</tr>
	 				
	 				</table>
	 			
	 			</center>
	 			</form>
	 	</div>
	 	<div id="bottom">
	 	@JdParser Demo sample code(Csharp)
	 	</div>
	 
	 </div>
	 
	 <script type="text/javascript">

	  
	 </script>
    </form>
</body>
</html>

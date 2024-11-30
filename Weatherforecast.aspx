<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weatherforecast.aspx.cs" Inherits="Weatherapp.Weatherforecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    body{
        font-family:Arial;
        font-size:16pt;
    }
    table{
        border:1px solid #ccc;
        border-collapse:collapse;
    }
    table th{
        background-color:#F7F7F7;
        color:#333;
        font-weight:bold;
    }
    table th, table td{
        padding:5px;
        border:1px solid #ccc;
    }
    table,table table td{
        border:0px solid #ccc;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
 <asp:Button ID="Button1" runat="server" Text="Get Weather Information" OnClick="Button1_Click" />
 <hr />
 <table id="tblweather" runat="server" border="0" cellpadding="0" cellspacing="0" visible="false">
     <tr>
         <th colspan="2">Weather Information</th>
     </tr>
     
     <tr>
         <td>
             <asp:Label ID="lblcitycountry" runat="server" ></asp:Label>
             
             Main:
             <asp:Label ID="lblmain" runat="server" ></asp:Label>
             Weather:
             <asp:Label ID="lbldescription" runat="server" ></asp:Label>
             Humidity:
             <asp:Label ID="lblhumidity" runat="server" ></asp:Label>
             Wind Speed:
             <asp:Label ID="lblwind" runat="server" ></asp:Label>
         </td>
     </tr>
     <tr>
         <td>
             Temperature:(Min:
             <asp:Label ID="lbltempmin" runat="server" ></asp:Label>
             Max:
             <asp:Label ID="lbltempmax" runat="server" ></asp:Label>
             Geo Coords-Longitude:
             <asp:Label ID="lbllong" runat="server" ></asp:Label>
             Latitude:
             <asp:Label ID="lbllati" runat="server" Text="Label"></asp:Label>
         </td>
     </tr>
 </table>
    </form>
</body>
</html>

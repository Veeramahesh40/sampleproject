<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <body>
  <form id="form1" runat="server">  
        <div>  
            
           <asp:HyperLink ID="HyperLink" runat="server" Text="LinkedIN" Font-Size="Medium" NavigateUrl="https://www.linkedin.com/in/veeramahesh-reddy-a0b4b320a/"></asp:HyperLink>
            <br />
            <br />
            
            <h2>Select your favorite computer brands:</h2>
            <p>
                <asp:CheckBox ID="apple" runat="server" Text="Apple" />
            </p>
            <p>
                <asp:CheckBox ID="dell" runat="server" Text="Dell" />
            </p>
            <p>
                <asp:CheckBox ID="lenevo" runat="server" Text="Lenovo" />
            </p>
            <p>
                <asp:CheckBox ID="acer" runat="server" Text="Acer" />
            </p>
            <p>
                <asp:CheckBox ID="sony" runat="server" Text="Sony" />
            </p>
            <p>
                <asp:CheckBox ID="wipro" runat="server" Text="Wipro" />
            </p>
            <p>
                <asp:Button ID="Button5" runat="server" Text="Submit" OnClick="Cookie_Click" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Please select your choice." ForeColor="Red" />
            </p>
            
            <asp:Label ID="labelId" runat="server">User Name</asp:Label>  
<asp:TextBox ID="UserName" runat="server" ToolTip="Enter User Name"></asp:TextBox>  

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  

            <p>
                <asp:RadioButton ID="Button1" runat="server" Text="Male" GroupName="Gender" />
                <asp:RadioButton ID="Button2" runat="server" Text="Female" GroupName="Gender" />
                <asp:RadioButton ID="Button3" runat="server" Text="Trans" GroupName="Gender" />
            &nbsp;&nbsp;&nbsp;  
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />  
            </p>
            <h2>Select Courses</h2>
            <p>
                   
            <asp:CheckBox ID="CheckBox1" runat="server" Text="J2SE" />  
            <asp:CheckBox ID="CheckBox2" runat="server" Text="J2EE" />  
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Spring" />  
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="CheckButton" />  
            </p>
            <p>
                <asp:Calendar ID="CalenderID" runat="server" OnSelectionChanged="Calenderclick" DayStyle-BackColor="#3399ff" DayHeaderStyle-BackColor="WindowFrame" DayHeaderStyle-ForeColor="#99ff66" ></asp:Calendar>
            &nbsp;&nbsp;&nbsp;
            </p>
        </div>  
      <p>
     <asp:Label ID="userInput" runat="server" Text=""></asp:Label>  
     <asp:Label ID="Showdate" runat="server" Text=""></asp:Label>
        <asp:Label ID="Check" runat="server" Text=""></asp:Label>
      </p>
        <p>
            &nbsp;</p>
      <h2>Browse to Upload File</h2>
      <p>
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" /> 
      &nbsp;&nbsp;  
            <asp:Button ID="File" runat="server" Text="Upload File" OnClick="FileUpload_Click" />  
        &nbsp;  
           <asp:Label runat="server" ID="FileUploadStatus" Text="" ForeColor="Red"></asp:Label> 
      </p>
        <p>  
            &nbsp;</p>       
       <p>  
     <asp:Button ID="Download" runat="server" Text="Downloadfile" OnClick="Download_File" />  
 &nbsp;  
     <asp:Label runat="server" ID="Label1" Text="" ForeColor="Red"></asp:Label> 
 </p>
    </form>  
        <p>  
            &nbsp;</p> 
          <p>  
              &nbsp;</p> 
</body>
</html>

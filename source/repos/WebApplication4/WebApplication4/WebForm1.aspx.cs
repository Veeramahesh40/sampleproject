using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the cookie "computer" exists and its expiration date
            if (Request.Cookies["computer"] != null)
            {
                // If the cookie exists, retrieve and display its values
                Label2.Text = "Your choices: ";

                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["apple"] + " ";
                if (Request.Cookies["computer"]["dell"] != null)
                    Label2.Text += Request.Cookies["computer"]["dell"] + " ";
                if (Request.Cookies["computer"]["lenevo"] != null)
                    Label2.Text += Request.Cookies["computer"]["lenevo"] + " ";
                if (Request.Cookies["computer"]["acer"] != null)
                    Label2.Text += Request.Cookies["computer"]["acer"] + " ";
                if (Request.Cookies["computer"]["sony"] != null)
                    Label2.Text += Request.Cookies["computer"]["sony"] + " ";
                if (Request.Cookies["computer"]["wipro"] != null)
                    Label2.Text += Request.Cookies["computer"]["wipro"] + " ";
            }
            else
            {
                Label2.Text = "Please select your choice.";
            }
        }
        protected void Cookie_Click(object sender, EventArgs e)
        {
            // Initialize the cookie for storing selected choices
            HttpCookie cookie = new HttpCookie("computer");

            // Check each checkbox and add the selected choices to the cookie
            if (apple.Checked)
                cookie["apple"] = "apple";
            if (dell.Checked)
                cookie["dell"] = "dell";
            if (lenevo.Checked)
                cookie["lenevo"] = "lenevo";
            if (acer.Checked)
                cookie["acer"] = "acer";
            if (sony.Checked)
                cookie["sony"] = "sony";
            if (wipro.Checked)
                cookie["wipro"] = "wipro";

            // Set the cookie expiration to 7 days
            cookie.Expires = DateTime.Now.AddDays(7);

            // Add the cookie to the response
            Response.Cookies.Add(cookie);

            // Refresh the page to display the updated choices
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            userInput.Text = "";

            if (Button1.Checked)
            {
                userInput.Text = "your gender is : " + Button1.Text;
            }
            else if (Button2.Checked)
            {
                userInput.Text = "your gender is : " + Button2.Text;
            }
            else
            {
                userInput.Text = "your gender is : " + Button3.Text;
            }
        }

        protected void Calenderclick(object sender, EventArgs e)
        {
            Showdate.Text = "Your selected : " + CalenderID.SelectedDate.ToString("M");
        }
        protected void CheckButton(object sender, EventArgs e)
        {
            var message = "";
            if (CheckBox1.Checked)
            {
                message = CheckBox1.Text + " ";
            }
            if (CheckBox2.Checked)
            {
                message += CheckBox2.Text + " ";
            }
            if (CheckBox3.Checked)
            {
                message += CheckBox3.Text;
            }
            Check.Text = message;

        }
        protected void FileUpload_Click(object sender, EventArgs e)
        {
            if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
            {
                var count = 0;
                foreach (HttpPostedFile uploadedFile in FileUpload1.PostedFiles)
                {
                    string fn = System.IO.Path.GetFileName(uploadedFile.FileName);
                    string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                    try
                    {
                        uploadedFile.SaveAs(SaveLocation);
                        count++;
                    }
                    catch (Exception ex)
                    {
                        FileUploadStatus.Text = "Error: " + ex.Message;
                    }
                }
                if (count > 0)
                {
                    FileUploadStatus.Text = count + " files has been uploaded.";
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select a file to upload.";
            }
           

        }
        protected void Download_File(object sender, EventArgs e)
        {
            string filePath = "D:\\Mahesh\\abc.txt";
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                // Clear Rsponse reference  
                Response.Clear();
                // Add header by specifying file name  
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                // Add header for content length  
                Response.AddHeader("Content-Length", file.Length.ToString());
                // Specify content type  
                Response.ContentType = "text/plain";
                // Clearing flush  
                Response.Flush();
                // Transimiting file  
                Response.TransmitFile(file.FullName);
                Response.End();
            }
            else Label1.Text = "Requested file is not available to download";
        }


    }
}
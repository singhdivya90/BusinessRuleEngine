public class Email
{
    private readonly string _toEmail= "";
    private readonly string _subject="";

    public Email(string toEmail,string subject)
    {
        _toEmail = toEmail;
        _subject = subject;
    }
    
    public void SendEmail()
    {
        //Get all details that needed to send email from config file like From Email and Password etc
        //Send Email Code
    }
}
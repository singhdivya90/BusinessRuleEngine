using System;
public class MembershipRule : IBusinessRule
{
    private readonly string  _paymentType ="";
    
    public MembershipRule(string paymentType)
    {
        _paymentType = paymentType;
        
    }
    public string Action()
    {      
        string result = "";
        string toEmail = "xyz@email.com"; //get all email details from configuration file
        string subject = "Membership Activation";//get all email details from configuration file
        if(_paymentType == Convert.ToString(PaymentType.Membership))
        {
            //Membership activation code block

            //Send Email Code
            Email email = new Email(toEmail,subject);
            email.SendEmail();
            result= Constant.MemberShipResult;
        }
        return result;
    }
}
using System;
public class UpgradeMembershipRule : IBusinessRule
{
    private readonly string  _paymentType ="";
    
    public UpgradeMembershipRule(string paymentType)
    {
        _paymentType = paymentType;
        
    }
    public string Action()
    {      
        string result = "";
        string toEmail = "xyz@email.com"; //get all email details from configuration file
        string subject = "Membership Activation";//get all email details from configuration file
        if(_paymentType == Convert.ToString(PaymentType.UpgradeMembership))
        {
            //Upgrade Membership code block

            //Send Email Code
            Email email = new Email(toEmail,subject);
            email.SendEmail();
            result= Constant.UpgradeMemberShipResult;
        }
        return result;
    }
}
using System;
public class PhysicalProductRule : IBusinessRule
{
    private readonly string  _paymentType ="";
    
    public PhysicalProductRule(string paymentType)
    {
        _paymentType = paymentType;
        
    }
    public string Action()
    {      
        string result = "";
        if(_paymentType == Convert.ToString(PaymentType.PhysicalProduct))
        {
            int commisionAmount = 500; //set from configuartion file
            string commisionType = "Commision for Physical Product";//set from configuartion file
            //Generate a Packing Slip for Shipping Code block

            //Generate a Commision Payment to Agent Code BLock
            CommisionPayment commision = new CommisionPayment(commisionAmount,commisionType);
            commision.GenerateCommision();
            result =  Constant.PhysicalProductResult;
        }
        return result;
    }
}
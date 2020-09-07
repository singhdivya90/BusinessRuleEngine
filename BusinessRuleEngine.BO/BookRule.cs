
using System;
public class BookRule : IBusinessRule
{
    private readonly string  _paymentType ="";
    
    public BookRule(string paymentType)
    {
        _paymentType = paymentType;
        
    }
    public string Action()
    {   
        string result = "";
        if(_paymentType == Enum.GetName(typeof(PaymentType), Convert.ToInt32(PaymentType.Book)))
        {
            Console.WriteLine("HEllo");
            int commisionAmount = 400; //set from configuartion file
            string commisionType = "Commision for Book";//set from configuartion file
            //Create a Duplicate packing slip for Royality Department Code Block.

            //Generate a Commision Payment to Agent Code BLock
            CommisionPayment commision = new CommisionPayment(commisionAmount,commisionType);
            commision.GenerateCommision();
            result =  Constant.BookResult;
        }
        return result;

    }

}
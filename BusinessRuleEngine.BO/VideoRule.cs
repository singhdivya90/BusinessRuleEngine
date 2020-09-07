using System;

public class VideoRule : IBusinessRule
{
    private readonly string  _paymentType ="";
    
    public VideoRule(string paymentType)
    {
        _paymentType = paymentType;
        
    }
    public string Action()
    {      
        string result = "";
        if(_paymentType == Convert.ToString(PaymentType.LearningToSkiVideo))
        {
            //add a free "First Aid" video to the Packing slip code

            result = Constant.VideoResult;
        }
        return result;
    }
}
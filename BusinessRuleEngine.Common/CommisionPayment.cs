public class CommisionPayment
{
    private readonly int _commisionAmount= 0;
    private readonly string _commisionType="";

    public CommisionPayment(int commisionAmount,string commisionType)
    {
        _commisionAmount = commisionAmount;
        _commisionType = commisionType;
    }
    
    public void GenerateCommision()
    {
        //Generate Commision Code
    }
}
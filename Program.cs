using System;
using System.Collections.Generic;
namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Payment Type");
            string paymentType = Console.ReadLine();
            var rules = new List<IBusinessRule>
            {
                new PhysicalProductRule(paymentType),
                new BookRule(paymentType),
                new MembershipRule(paymentType),
                new UpgradeMembershipRule(paymentType),
                new VideoRule(paymentType)
            };
            rules.ForEach(rule =>
            {
                var result = rule.Action();
                
                if (!string.IsNullOrWhiteSpace(result))
                    Console.WriteLine(result);

                 
            });
            
        }
    }
}

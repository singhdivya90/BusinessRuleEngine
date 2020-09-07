using System;
using Xunit;

namespace BusinessRuleEngine.Tests
{
    public class BusinessRuleEngineTests
    {
        [Fact]
        public void BookRuleTest()
        {
            BookRule bookRule = new BookRule("Book");
            Assert.Equal(bookRule.Action, Constant.BookResult);
        }
        [Fact]
        public void MembershipRuleTest()
        {
            MembershipRule membershipRule = new MembershipRule("Membership");
            Assert.Equal(membershipRule.Action, Constant.MemberShipResult);
        }
        [Fact]
        public void UpgradeMembershipRuleTest()
        {
            UpgradeMembershipRule upgradeMembershipRule = new UpgradeMembershipRule("UpgradeMembership");
            Assert.Equal(upgradeMembershipRule.Action, Constant.UpgradeMemberShipResult);
        }
        [Fact]
        public void PhysicalProductRuleTest()
        {
            PhysicalProductRule physicalProductRule = new PhysicalProductRule("PhysicalProduct");
            Assert.Equal(physicalProductRule.Action, Constant.PhysicalProductResult);
        }
        [Fact]
        public void VideoRuleTest()
        {
            VideoRule videoRule = new VideoRule("LearningToSkiVideo");
            Assert.Equal(videoRule.Action, Constant.VideoResult);
        }
    }
}

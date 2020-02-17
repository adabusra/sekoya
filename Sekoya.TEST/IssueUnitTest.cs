using Sekoya.BLL.Repository;
using Sekoya.DAL;
using System;
using Xunit;

namespace Sekoya.TEST
{
    public class IssueUnitTest
    {
        [Fact]
        public void IssueSaveControl()
        {
            IssueBusiness businessIssue = new IssueBusiness();
            businessIssue.InsertIssue(new Issue().GetMockIssue());
            object model = businessIssue.FindIssue(new Issue().GetMockIssue().Id);
            Assert.NotNull(model);
            businessIssue.DeleteIssue(model as Issue);
        }
    }

}

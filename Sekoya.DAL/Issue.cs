using System;
using System.Collections.Generic;

namespace Sekoya.DAL
{
    public partial class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }

        public Issue GetMockIssue()
        {
            Issue issue = new Issue();
            issue.Id = 54;
            issue.Title = "Sakaryaspor";
            issue.Contents = "Hello everyone!";
            return issue;
        }
    }
}

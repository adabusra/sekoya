using Sekoya.DAL;
using Sekoya.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.BLL.Repository
{
    public class IssueBusiness : GenericBusiness<Issue>
    {
        public void InsertIssue(Issue model)
        {
            IssueRepository.Instance.Insert(model);
        }
        public void DeleteIssue(Issue model)
        {
            IssueRepository.Instance.Delete(model);
        }
        public Issue FindIssue(int id)
        {
            return IssueRepository.Instance.Find(id);
        }
    }
}

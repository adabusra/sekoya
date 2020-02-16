using Sekoya.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.DAL.Repository
{
    
    public class IssueRepository : GenericRepository<Issue>
    {
        static private IssueRepository _instance = null;
        static public IssueRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IssueRepository();
                }
                return _instance;
            }
        }
    }
}

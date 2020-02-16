using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.DAL.RepositoryLog
{
    public interface ILogger
    {
        void Add(string message, object obj);
    }
}

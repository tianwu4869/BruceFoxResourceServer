using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Core;

namespace BF.Abstractions
{
    public interface IUnitOfWork
    {
        IGenericRepository<Tasks> TaskRepository { get; }
        void Save();
    }
}

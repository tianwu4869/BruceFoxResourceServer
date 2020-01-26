using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BF.Abstractions;
using BF.Core;

namespace BF.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private BruceFoxContext Context;
        private IGenericRepository<Tasks> _TaskRepository;

        public UnitOfWork(BruceFoxContext bruceFoxContext)
        {
            Context = bruceFoxContext;
        }

        public IGenericRepository<Tasks> TaskRepository
        {
            get { return _TaskRepository ?? (_TaskRepository = new GenericRepository<Tasks>(Context)); }
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}

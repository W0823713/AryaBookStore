using System;
using System.Collections.Generic;
using System.Text;

namespace AryaBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork
    {
        ICategoryRepository Category { get;  }
        ISP_Call SP_Call { get; }
    }
}

﻿using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public interface IControlRepository : IGenericRepository<TSISCOA_Control>
    {
        //Task<IEnumerable<TSISCOA_Control>> GetControlesByOficina(int id);
    }
}

﻿using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IColourDal:IEntityRepository<Colour>
    {
    }
}

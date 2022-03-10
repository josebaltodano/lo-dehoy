using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IActivoModel: IActivoModel<Activo>
    {

        Activo GetById(int id);

 

    }
}

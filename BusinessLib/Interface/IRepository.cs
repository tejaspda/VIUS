using System;
using System.Collections.Generic;
using System.Text;
using BusinessLib.Entity;

namespace BusinessLib.Interface
{
    public interface IRepository
    {
         IList<ClassEntity> GetAllSample();
          ClassEntity GetSample(int id);

    }

    
}

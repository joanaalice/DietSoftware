using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IEntityCRUD<T>
    {
        Response Insert(T item);
        Response Update(T item);
        Response Delete(int id);
        QueryResponse<T> GetAll();
        SingleResponse<T> GetById(int id);
    }
}

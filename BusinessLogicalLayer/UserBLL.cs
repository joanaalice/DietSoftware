using BusinessLogicalLayer.Interfaces;
using Common;
using Entities;
using System;

namespace BusinessLogicalLayer
{
    public class UserBLL : IUserService
    {
        public Response Insert(User item)
        {
            throw new NotImplementedException();
        }

        public Response Update(User item)
        {
            throw new NotImplementedException();
        }

        public Response Delete(int id)
        {
            /*
            User user = new User();
            user.ID = id;

            using (DietDB db = new DietDB())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            return ResponseMessage.CreateSuccessResponse();
            */
        }

        public QueryResponse<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<User> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

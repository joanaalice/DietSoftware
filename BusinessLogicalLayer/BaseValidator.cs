using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicalLayer
{
    public class BaseValidator<T>
    {
        private List<string> Errors = new List<string>();

        public void AddError(string error)
        {
            if (error != "")
            {
                Errors.Add(error);
            }
        }

        public Response CheckError()
        {
            Response response = new Response();
            if (Errors.Count != 0)
            {
                StringBuilder StringBuilder = new StringBuilder();
                foreach (var item in Errors)
                {
                    StringBuilder.AppendLine(item);
                }
                response.Message = StringBuilder.ToString();
                response.Success = false;
                return response;
            }
            response.Success = true;
            return response;
        }

        public virtual Response Validate(T item)
        {
            Response response = new Response();
            this.Errors.Clear();
            return response;
        }
    }
}

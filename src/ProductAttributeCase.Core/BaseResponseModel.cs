using System;

namespace ProductAttributeCase.Core
{
    public class BaseResponseModel
    {

        public StatusCodes StatusCodes { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
    }

    public enum StatusCodes
    {
        Ok = 200,
        Error = 500,
        //.....
    }
    public class BaseResponseModel<T> : BaseResponseModel where T : new()
    {
        public T Data { get; set; }
    }
    public class BaseResponseModel<T, TFiltering> : BaseResponseModel where TFiltering : IFiltering where T : new()
    {
        public T Data { get; set; }
        public TFiltering Filtering { get; set; }
    }

    public interface IFiltering
    {
        //.....
    }
}

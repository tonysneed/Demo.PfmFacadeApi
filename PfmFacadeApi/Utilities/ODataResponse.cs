using System.Collections.Generic;

namespace PfmFacadeApi.Utilities
{
    public class ODataResponse<T>
    {
        public List<T> Value { get; set; }
    }
}
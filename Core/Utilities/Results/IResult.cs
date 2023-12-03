using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // for voids
    public interface IResult
    {
        bool Succeeded { get; }
        string Message { get; }
    }
}

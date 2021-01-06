using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.SampleApi.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}

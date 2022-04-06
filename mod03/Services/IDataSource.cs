using System.Collections.Generic;

namespace mod03.Services
{
    public interface IDataSource
    {
        List<string> getRecords();
    }
}
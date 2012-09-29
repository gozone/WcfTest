using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServiceContracts
{
    [ServiceContract]
    public interface IMainService
    {
        [OperationContract]
        string HelloMethod(string userName);        
    }
}

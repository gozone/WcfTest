using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceContracts;

namespace ServiceHostApplication
{
    public class MainServiceImplementation : IMainService
    {

        #region IMainService Members

        public string HelloMethod(string userName)
        {
            return "Hello " + userName + "!";
        }

        #endregion
    }
}

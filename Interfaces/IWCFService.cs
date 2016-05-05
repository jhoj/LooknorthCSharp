using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interfaces
{
    [ServiceContract]
    public interface IWCFService
    {
        [OperationContract]
        void SendOilData(float oilUsage);
        [OperationContract]
        void SendMachineData(int machineId);
    }
}

using System.ServiceModel;

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

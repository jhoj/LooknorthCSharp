using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService" in both code and config file together.
    public class WCFService : IWCFService
    {
        public void SendMachineData(int machineId)
        {
            using (looknorthEntities1 database = new looknorthEntities1())
            {
                products_active productsActive = (from p in database.products_active
                                                 where p.m_id == machineId
                                                 select p).FirstOrDefault();

                Console.WriteLine("Machine Id: {0}, \nProduct Id: {1}", productsActive.m_id, productsActive.p_id);
            }
        }

        public void SendOilData(float oilUsage)
        {
            throw new NotImplementedException();
        }
    }
}

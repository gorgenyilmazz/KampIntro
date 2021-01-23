using System;
using System.Collections.Generic;

namespace OOP3
{
    //interface onu implementt eden siniflarin referansini tutabilir.
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(mortgageCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager,vehicleCreditManager };
            //applicationManager.DoCreditInforming(credits);




        }
    }
}

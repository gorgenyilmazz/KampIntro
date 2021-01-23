using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void DoApplication(ICreditManager creditManager,List<ILoggerService>  loggerServices) 
        {
            //Basvuran bilgilerini degerlendirme
            //gercek sistemlerde hem db ye hem sms ile loglanir.
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }

        public void DoCreditInforming(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

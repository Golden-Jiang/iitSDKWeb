using static iit.Data.iitData;

namespace iitDataWeb
{
    public class AccountData
    {
        public class Customer
        {
            public CallServiceClass CallService {  get; set; }
            public TeleAccountClass TeleAccount {  get; set; }
            public Customer()
            {
                CallService = new CallServiceClass();
                TeleAccount = new TeleAccountClass();   
            }
        }
    }
}

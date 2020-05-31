namespace SageModeBankOOP
{
    class Bank
    {
        private int _TotalAccountsRegistered { get; set; }
        public string Name { get; set; }
        public Account[] Accounts { get; set; }

        public Bank(string name)
        {
            Name = name;
            Accounts = new Account[100];
            _TotalAccountsRegistered = 0;
        }

        public void Register(string username, string password)
        {
            Accounts[_TotalAccountsRegistered] = new Account
            {
                Id = _TotalAccountsRegistered,
                Username = username,
                Password = password,
                Balance = 0
            };
            _TotalAccountsRegistered++;
        }

        public bool Login(string username, string password)
        {
            return false;
        }

        public bool IsAccountExist(string username)
        {
            foreach (Account account in Accounts)
            {
                if (account != null && account.Username == username)
                    return true;
            }
            return false;
        }
    }
}
namespace MyCompany.Infrastucture
{
    public class AppConfig
    {
        public TinyMCE TinyMce { get; set; } = new TinyMCE();
        public Company MyCompany { get; set; } = new Company();
        public Db DataBase { get; set; } = new Db();

        public class TinyMCE
        {
            public string? APIKey { get; set; }
        }

        public class Company
        {
            public string? CompanyName { get; set; }
            public string? CompanyPhone { get; set; }
            public string? CompanyPhoneShort { get; set; }
            public string? CompanyEmail { get; set; }
        }

        public class Db
        {
            public string? ConnectionString =
                "Data Source=(local); Database=MyCompany; Persist Security Info=False; User ID='sa'; Password='sa'; MultipleActiveResultSets=True; Trusted_Connection=False; TrustServerCertificate=True;";
        }
    }
}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDatabasesResponseBodyDatabases Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesDatabase : TeaModel {
                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseAccounts Accounts { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseAccounts : TeaModel {
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public List<DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccount> Account { get; set; }
                    public class DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccount : TeaModel {
                        [NameInMap("AccountName")]
                        [Validation(Required=false)]
                        public string AccountName { get; set; }

                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        [NameInMap("AccountStatus")]
                        [Validation(Required=false)]
                        public string AccountStatus { get; set; }

                        [NameInMap("PrivilegeStatus")]
                        [Validation(Required=false)]
                        public string PrivilegeStatus { get; set; }

                    }

                }

                [NameInMap("CharacterSetName")]
                [Validation(Required=false)]
                public string CharacterSetName { get; set; }

                [NameInMap("DBDescription")]
                [Validation(Required=false)]
                public string DBDescription { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DBStatus")]
                [Validation(Required=false)]
                public string DBStatus { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

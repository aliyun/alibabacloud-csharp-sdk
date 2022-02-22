// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDatabasesResponseBodyResult Result { get; set; }
        public class DescribeDatabasesResponseBodyResult : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyResultDatabases> Databases { get; set; }
            public class DescribeDatabasesResponseBodyResultDatabases : TeaModel {
                public List<DescribeDatabasesResponseBodyResultDatabasesAccounts> Accounts { get; set; }
                public class DescribeDatabasesResponseBodyResultDatabasesAccounts : TeaModel {
                    public string Account { get; set; }
                    public string AccountPrivilege { get; set; }
                    public string AccountPrivilegeDetail { get; set; }
                }
                public string CharacterSetName { get; set; }
                public string DBDescription { get; set; }
                public string DBInstanceId { get; set; }
                public string DBName { get; set; }
                public string DBStatus { get; set; }
                public string Engine { get; set; }
            }
        };

    }

}

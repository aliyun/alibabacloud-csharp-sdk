// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeRdsAccountsResponseBody : TeaModel {
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
        public DescribeRdsAccountsResponseBodyResult Result { get; set; }
        public class DescribeRdsAccountsResponseBodyResult : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeRdsAccountsResponseBodyResultAccounts> Accounts { get; set; }
            public class DescribeRdsAccountsResponseBodyResultAccounts : TeaModel {
                public string AccountDescription { get; set; }
                public string AccountName { get; set; }
                public string AccountStatus { get; set; }
                public string AccountType { get; set; }
                public string DBInstanceId { get; set; }
                public List<DescribeRdsAccountsResponseBodyResultAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
                public class DescribeRdsAccountsResponseBodyResultAccountsDatabasePrivileges : TeaModel {
                    public string AccountPrivilege { get; set; }
                    public string AccountPrivilegeDetail { get; set; }
                    public string DBName { get; set; }
                }
                public string PrivExceeded { get; set; }
            }
        };

    }

}

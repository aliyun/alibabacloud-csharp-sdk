// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<DescribeAccountsResponseBodyAccounts> Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("AccountDescription")]
            [Validation(Required=false)]
            public string AccountDescription { get; set; }

            [NameInMap("AccountLockState")]
            [Validation(Required=false)]
            public string AccountLockState { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("AccountPassword")]
            [Validation(Required=false)]
            public string AccountPassword { get; set; }

            [NameInMap("AccountPasswordValidTime")]
            [Validation(Required=false)]
            public string AccountPasswordValidTime { get; set; }

            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("DatabasePrivileges")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
            public class DescribeAccountsResponseBodyAccountsDatabasePrivileges : TeaModel {
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

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

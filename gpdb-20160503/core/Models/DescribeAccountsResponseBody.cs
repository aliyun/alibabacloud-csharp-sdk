// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("DBInstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDBInstanceAccount> DBInstanceAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountsDBInstanceAccount : TeaModel {
                /// <summary>
                /// The description of the account.
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// The name of the account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The state of the account.
                /// 
                /// *   **0**: The account is being created.
                /// *   **1**: The account is in use.
                /// *   **3**: The account is being deleted.
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The queried database accounts.
        /// </summary>
        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccountList AccountList { get; set; }
        public class DescribeAccountsResponseBodyAccountList : TeaModel {
            [NameInMap("DBAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountListDBAccount> DBAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountListDBAccount : TeaModel {
                /// <summary>
                /// The description of the database account.
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// The name of the database account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The status of the database account. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Available**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// The type of the database account. Valid values:
                /// 
                /// *   **Normal**: standard account.
                /// *   **Super**: privileged account.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The ID of the Resource Access Management (RAM) user.
                /// </summary>
                [NameInMap("RamUsers")]
                [Validation(Required=false)]
                public string RamUsers { get; set; }

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

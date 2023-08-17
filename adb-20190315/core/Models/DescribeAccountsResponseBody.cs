// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The list of database accounts.
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
                /// The status of the account.
                /// 
                /// *   Creating: The account is being created.
                /// *   Available: The account is available.
                /// *   Deleting: The account is being deleted.
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// *   Normal: standard account
                /// *   Super: privileged account
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

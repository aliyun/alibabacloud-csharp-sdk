// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The username of the account.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeAccountsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// The description of the account.
                /// 
                /// > This parameter is returned only after you configure the description of the account by calling the [ModifyAccountDescription](~~468391~~) operation.
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
                /// *   **Unavailable**
                /// *   **Available**
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// The role of the account. Valid values:
                /// 
                /// *   **db**: shard
                /// *   **cs**: Configserver
                /// *   **mongos**: mongos
                /// *   **logic:** sharded cluster instance
                /// *   **normal:** replica set instance
                /// </summary>
                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                /// <summary>
                /// The name of the instance to which the account belongs.
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

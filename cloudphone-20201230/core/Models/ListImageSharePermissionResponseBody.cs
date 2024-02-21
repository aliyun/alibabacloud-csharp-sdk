// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListImageSharePermissionResponseBody : TeaModel {
        /// <summary>
        /// The list of Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class ListImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListImageSharePermissionResponseBodyAccountsAccount> Account { get; set; }
            public class ListImageSharePermissionResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

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

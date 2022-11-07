// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListImageSharePermissionResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class ListImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListImageSharePermissionResponseBodyAccountsAccount> Account { get; set; }
            public class ListImageSharePermissionResponseBodyAccountsAccount : TeaModel {
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

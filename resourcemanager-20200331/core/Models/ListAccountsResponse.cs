// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAccountsResponse : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=true)]
        public ListAccountsResponseAccounts Accounts { get; set; }
        public class ListAccountsResponseAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=true)]
            public List<ListAccountsResponseAccountsAccount> Account { get; set; }
            public class ListAccountsResponseAccountsAccount : TeaModel {
                public string Status { get; set; }
                public string ModifyTime { get; set; }
                public string JoinMethod { get; set; }
                public string ResourceDirectoryId { get; set; }
                public string Type { get; set; }
                public string AccountId { get; set; }
                public string DisplayName { get; set; }
                public string JoinTime { get; set; }
                public string FolderId { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAccountsForParentResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=true)]
        public ListAccountsForParentResponseAccounts Accounts { get; set; }
        public class ListAccountsForParentResponseAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=true)]
            public List<ListAccountsForParentResponseAccountsAccount> Account { get; set; }
            public class ListAccountsForParentResponseAccountsAccount : TeaModel {
                public string ResourceDirectoryId { get; set; }
                public string AccountId { get; set; }
                public string DisplayName { get; set; }
                public string FolderId { get; set; }
                public string JoinMethod { get; set; }
                public string JoinTime { get; set; }
                public string ModifyTime { get; set; }
                public string Type { get; set; }
                public string Status { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAccountsForParentResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListAccountsForParentResponseBodyAccounts Accounts { get; set; }
        public class ListAccountsForParentResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListAccountsForParentResponseBodyAccountsAccount> Account { get; set; }
            public class ListAccountsForParentResponseBodyAccountsAccount : TeaModel {
                public string AccountId { get; set; }
                public string DisplayName { get; set; }
                public string FolderId { get; set; }
                public string JoinMethod { get; set; }
                public string JoinTime { get; set; }
                public string ModifyTime { get; set; }
                public string ResourceDirectoryId { get; set; }
                public string Status { get; set; }
                public ListAccountsForParentResponseBodyAccountsAccountTags Tags { get; set; }
                public class ListAccountsForParentResponseBodyAccountsAccountTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListAccountsForParentResponseBodyAccountsAccountTagsTag> Tag { get; set; }
                    public class ListAccountsForParentResponseBodyAccountsAccountTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

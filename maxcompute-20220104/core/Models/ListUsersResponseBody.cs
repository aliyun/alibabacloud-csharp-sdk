// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataUsers> Users { get; set; }
            public class ListUsersResponseBodyDataUsers : TeaModel {
                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("accountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("accountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

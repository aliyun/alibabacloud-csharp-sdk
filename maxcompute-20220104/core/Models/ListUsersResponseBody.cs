// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The users.
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataUsers> Users { get; set; }
            public class ListUsersResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The username of the account.
                /// </summary>
                [NameInMap("accountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The type of the account.
                /// </summary>
                [NameInMap("accountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The display name.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

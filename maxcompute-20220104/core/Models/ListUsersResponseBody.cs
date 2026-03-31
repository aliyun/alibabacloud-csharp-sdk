// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The users.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataUsers> Users { get; set; }
            public class ListUsersResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>167835629082</para>
                /// </summary>
                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The username of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bob@</para>
                /// </summary>
                [NameInMap("accountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The type of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("accountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bob</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1567253789</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dd4816687424611405643e3730</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserListResponseBodyResult Result { get; set; }
        public class QueryUserListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryUserListResponseBodyResultData> Data { get; set; }
            public class QueryUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1355********</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AdminUser")]
                [Validation(Required=false)]
                public bool? AdminUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthAdminUser")]
                [Validation(Required=false)]
                public bool? AuthAdminUser { get; set; }

                [NameInMap("JoinedDate")]
                [Validation(Required=false)]
                public long? JoinedDate { get; set; }

                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public long? LastLoginTime { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public List<long?> RoleIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

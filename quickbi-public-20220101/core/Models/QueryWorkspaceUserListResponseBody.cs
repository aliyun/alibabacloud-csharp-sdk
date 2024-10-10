// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceUserListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorkspaceUserListResponseBodyResult Result { get; set; }
        public class QueryWorkspaceUserListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorkspaceUserListResponseBodyResultData> Data { get; set; }
            public class QueryWorkspaceUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16020915****8429</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pop****@aliyunid.test</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public QueryWorkspaceUserListResponseBodyResultDataRole Role { get; set; }
                public class QueryWorkspaceUserListResponseBodyResultDataRole : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>role_workspace_admin</para>
                    /// </summary>
                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public long? RoleId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

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

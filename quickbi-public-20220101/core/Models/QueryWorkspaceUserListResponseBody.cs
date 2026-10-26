// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the paginated result of the member list, with detailed information about the members stored in the Data parameter of the response.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorkspaceUserListResponseBodyResult Result { get; set; }
        public class QueryWorkspaceUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Information about the workspace members.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorkspaceUserListResponseBodyResultData> Data { get; set; }
            public class QueryWorkspaceUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16020915****8429</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyunid.test</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>Preset role information for the workspace member.</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public QueryWorkspaceUserListResponseBodyResultDataRole Role { get; set; }
                public class QueryWorkspaceUserListResponseBodyResultDataRole : TeaModel {
                    /// <summary>
                    /// <para>Code corresponding to the preset role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>role_workspace_admin</para>
                    /// </summary>
                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    /// <summary>
                    /// <para>Preset role ID. Possible values:</para>
                    /// <list type="bullet">
                    /// <item><description>25: Workspace Administrator</description></item>
                    /// <item><description>26: Workspace Developer</description></item>
                    /// <item><description>27: Workspace Analyst</description></item>
                    /// <item><description>30: Workspace Viewer</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public long? RoleId { get; set; }

                    /// <summary>
                    /// <para>Name of the preset role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <para>Quick BI user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Number of rows per page as set in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

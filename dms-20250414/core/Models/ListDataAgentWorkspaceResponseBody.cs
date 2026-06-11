// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentWorkspaceResponseBodyData Data { get; set; }
        public class ListDataAgentWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the workspaces.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListDataAgentWorkspaceResponseBodyDataContent> Content { get; set; }
            public class ListDataAgentWorkspaceResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The creation time of the workspace, provided as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1765960516</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator\&quot;s user ID (UID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>20282*****7591</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The description of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>space for test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IsSessionShareEnabled")]
                [Validation(Required=false)]
                public bool? IsSessionShareEnabled { get; set; }

                /// <summary>
                /// <para>The last modification time of the workspace, provided as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1765961516</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the user\&quot;s role in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The number of members in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("TotalMember")]
                [Validation(Required=false)]
                public long? TotalMember { get; set; }

                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20923*****7291</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspaceTest</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

                /// <summary>
                /// <para>The status of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("WorkspaceStatus")]
                [Validation(Required=false)]
                public string WorkspaceStatus { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of workspaces on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nu use</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no use</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D2-*****-A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

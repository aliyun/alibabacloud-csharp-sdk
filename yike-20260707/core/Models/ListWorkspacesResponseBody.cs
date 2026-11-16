// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of workspaces that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of workspaces on the current page.</para>
        /// </summary>
        [NameInMap("WorkspaceList")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaceList> WorkspaceList { get; set; }
        public class ListWorkspacesResponseBodyWorkspaceList : TeaModel {
            /// <summary>
            /// <para>The workspace code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c40***</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in UTC and follows the ISO 8601 standard, ending with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07T02:21:36Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the default project for the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_061716****</para>
            /// </summary>
            [NameInMap("DefaultProjectId")]
            [Validation(Required=false)]
            public string DefaultProjectId { get; set; }

            /// <summary>
            /// <para>The workspace status. Valid values: Online (enabled) and Offline (disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Video Production Workspace</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The current number of users in the workspace, returned as a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public string UserCount { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws_zna577pdximv***</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>Page size
        /// Default value:
        ///     50
        /// Maximum value:
        ///     50</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Pagination Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>List of workspaces</para>
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11T08:21:58Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Workspace description</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Workspace display name</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace-test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Last modified time</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-11T08:21:58Z</para>
            /// </summary>
            [NameInMap("lastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// <para>Region ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Log Service project name</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls-project-test-001</para>
            /// </summary>
            [NameInMap("slsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>Workspace name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace-test-001</para>
            /// </summary>
            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

    }

}

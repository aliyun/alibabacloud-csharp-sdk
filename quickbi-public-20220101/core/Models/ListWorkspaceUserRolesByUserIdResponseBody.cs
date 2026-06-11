// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWorkspaceUserRolesByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E***************F67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of all workspace role information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListWorkspaceUserRolesByUserIdResponseBodyResult> Result { get; set; }
        public class ListWorkspaceUserRolesByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The workspace role information.</para>
            /// </summary>
            [NameInMap("RoleModel")]
            [Validation(Required=false)]
            public ListWorkspaceUserRolesByUserIdResponseBodyResultRoleModel RoleModel { get; set; }
            public class ListWorkspaceUserRolesByUserIdResponseBodyResultRoleModel : TeaModel {
                /// <summary>
                /// <para>The code that corresponds to the preset workspace role. This parameter is not returned for custom roles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34637***35</para>
                /// </summary>
                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// <para>The workspace role ID. This includes, but is not limited to, the following preset workspace roles:</para>
                /// <list type="bullet">
                /// <item><description><para>25: Workspace Admin (preset role)</para>
                /// </description></item>
                /// <item><description><para>26: Workspace Developer (preset role)</para>
                /// </description></item>
                /// <item><description><para>27: Workspace Analyst (preset role)</para>
                /// </description></item>
                /// <item><description><para>30: Workspace Viewer (preset role)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>111111111</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The name of the workspace role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-admin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9337d121-a78f-4c1b-a8bc-f81de117****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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

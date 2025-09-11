// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWorkspaceUserRolesByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DC4E***************F67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListWorkspaceUserRolesByUserIdResponseBodyResult> Result { get; set; }
        public class ListWorkspaceUserRolesByUserIdResponseBodyResult : TeaModel {
            [NameInMap("RoleModel")]
            [Validation(Required=false)]
            public ListWorkspaceUserRolesByUserIdResponseBodyResultRoleModel RoleModel { get; set; }
            public class ListWorkspaceUserRolesByUserIdResponseBodyResultRoleModel : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>34637***35</para>
                /// </summary>
                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111111111</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>arms-admin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9337d121-a78f-4c1b-a8bc-f81de117****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

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

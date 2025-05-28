// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserRoleInfoInWorkspaceResponseBody : TeaModel {
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
        /// <para>Preset space role information of the user.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserRoleInfoInWorkspaceResponseBodyResult Result { get; set; }
        public class QueryUserRoleInfoInWorkspaceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Preset role code.</para>
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
            /// <item><description>25: Space Administrator</description></item>
            /// <item><description>26: Space Developer</description></item>
            /// <item><description>27: Space Analyst</description></item>
            /// <item><description>30: Space Viewer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// <para>Preset role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded.</description></item>
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

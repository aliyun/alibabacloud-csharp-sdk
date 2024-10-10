// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserRoleInfoInWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserRoleInfoInWorkspaceResponseBodyResult Result { get; set; }
        public class QueryUserRoleInfoInWorkspaceResponseBodyResult : TeaModel {
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

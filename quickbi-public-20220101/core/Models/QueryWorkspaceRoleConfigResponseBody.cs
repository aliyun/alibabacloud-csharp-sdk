// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceRoleConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorkspaceRoleConfigResponseBodyResult Result { get; set; }
        public class QueryWorkspaceRoleConfigResponseBodyResult : TeaModel {
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<QueryWorkspaceRoleConfigResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class QueryWorkspaceRoleConfigResponseBodyResultAuthConfigList : TeaModel {
                [NameInMap("ActionAuthKeys")]
                [Validation(Required=false)]
                public List<string> ActionAuthKeys { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>portal_create</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSystemRole")]
            [Validation(Required=false)]
            public bool? IsSystemRole { get; set; }

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

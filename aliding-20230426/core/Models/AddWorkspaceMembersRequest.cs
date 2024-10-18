// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddWorkspaceMembersRequest : TeaModel {
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddWorkspaceMembersRequestMembers> Members { get; set; }
        public class AddWorkspaceMembersRequestMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EDITOR</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddWorkspaceMembersRequestTenantContext TenantContext { get; set; }
        public class AddWorkspaceMembersRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

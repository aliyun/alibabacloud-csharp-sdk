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
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddWorkspaceMembersRequestTenantContext TenantContext { get; set; }
        public class AddWorkspaceMembersRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

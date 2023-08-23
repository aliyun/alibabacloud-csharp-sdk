// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DeleteWorkspaceMembersRequest : TeaModel {
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<DeleteWorkspaceMembersRequestMembers> Members { get; set; }
        public class DeleteWorkspaceMembersRequestMembers : TeaModel {
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public DeleteWorkspaceMembersRequestTenantContext TenantContext { get; set; }
        public class DeleteWorkspaceMembersRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Workspace : TeaModel {
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<Member> Members { get; set; }

        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<Quota> Quotas { get; set; }

        [NameInMap("TotalResources")]
        [Validation(Required=false)]
        public Resources TotalResources { get; set; }

        [NameInMap("WorkspaceAdmins")]
        [Validation(Required=false)]
        public List<Member> WorkspaceAdmins { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}

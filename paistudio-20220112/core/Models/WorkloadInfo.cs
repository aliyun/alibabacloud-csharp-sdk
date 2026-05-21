// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkloadInfo : TeaModel {
        [NameInMap("IsScheduled")]
        [Validation(Required=false)]
        public string IsScheduled { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("QueueMetas")]
        [Validation(Required=false)]
        public List<QueueMeta> QueueMetas { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("WorkloadCreatedTime")]
        [Validation(Required=false)]
        public string WorkloadCreatedTime { get; set; }

        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        [NameInMap("WorkloadStatus")]
        [Validation(Required=false)]
        public string WorkloadStatus { get; set; }

        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}

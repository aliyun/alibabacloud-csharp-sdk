// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QueueInfo : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        [NameInMap("GmtDequeuedTime")]
        [Validation(Required=false)]
        public string GmtDequeuedTime { get; set; }

        [NameInMap("GmtEnqueuedTime")]
        [Validation(Required=false)]
        public string GmtEnqueuedTime { get; set; }

        [NameInMap("GmtPositionModifiedTime")]
        [Validation(Required=false)]
        public string GmtPositionModifiedTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ResourceAmount Resource { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QueueMeta : TeaModel {
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
        public string Position { get; set; }

        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ResourceAmount Resource { get; set; }

        [NameInMap("ScheduledResource")]
        [Validation(Required=false)]
        public string ScheduledResource { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

    }

}

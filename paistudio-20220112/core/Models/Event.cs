// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Event : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("Function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("TriggerTenantId")]
        [Validation(Required=false)]
        public string TriggerTenantId { get; set; }

        [NameInMap("TriggerTime")]
        [Validation(Required=false)]
        public string TriggerTime { get; set; }

        [NameInMap("TriggerUserId")]
        [Validation(Required=false)]
        public string TriggerUserId { get; set; }

        [NameInMap("TriggeredBy")]
        [Validation(Required=false)]
        public string TriggeredBy { get; set; }

    }

}

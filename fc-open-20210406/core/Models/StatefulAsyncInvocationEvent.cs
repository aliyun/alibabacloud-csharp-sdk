// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class StatefulAsyncInvocationEvent : TeaModel {
        [NameInMap("eventDetail")]
        [Validation(Required=false)]
        public string EventDetail { get; set; }

        [NameInMap("eventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}

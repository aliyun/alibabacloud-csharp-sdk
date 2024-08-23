// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240501.Models
{
    public class AISearchV2ResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public AISearchV2ResponseBodyHeader Header { get; set; }
        public class AISearchV2ResponseBodyHeader : TeaModel {
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

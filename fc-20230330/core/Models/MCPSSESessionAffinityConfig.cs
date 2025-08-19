// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MCPSSESessionAffinityConfig : TeaModel {
        [NameInMap("sessionConcurrencyPerInstance")]
        [Validation(Required=false)]
        public long? SessionConcurrencyPerInstance { get; set; }

        [NameInMap("sseEndpointPath")]
        [Validation(Required=false)]
        public string SseEndpointPath { get; set; }

    }

}

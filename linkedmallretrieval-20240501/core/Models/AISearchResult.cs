// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240501.Models
{
    public class AISearchResult : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public EventHeader Header { get; set; }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

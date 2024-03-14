// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class SearchTracesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceInfos")]
        [Validation(Required=false)]
        public List<SearchTracesResponseBodyTraceInfos> TraceInfos { get; set; }
        public class SearchTracesResponseBodyTraceInfos : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

    }

}

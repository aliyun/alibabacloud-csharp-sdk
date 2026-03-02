// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class TraceInfoDetailResult : TeaModel {
        [NameInMap("traceDetails")]
        [Validation(Required=false)]
        public List<TraceInfoDetailResultTraceDetails> TraceDetails { get; set; }
        public class TraceInfoDetailResultTraceDetails : TeaModel {
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("haveStack")]
            [Validation(Required=false)]
            public bool? HaveStack { get; set; }

            [NameInMap("logEventList")]
            [Validation(Required=false)]
            public List<TraceSpansLogEventList> LogEventList { get; set; }

            [NameInMap("operationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            [NameInMap("parentSpanId")]
            [Validation(Required=false)]
            public string ParentSpanId { get; set; }

            [NameInMap("resultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("rpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("rpcType")]
            [Validation(Required=false)]
            public long? RpcType { get; set; }

            [NameInMap("rpcTypeName")]
            [Validation(Required=false)]
            public string RpcTypeName { get; set; }

            [NameInMap("serviceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("spanId")]
            [Validation(Required=false)]
            public string SpanId { get; set; }

            [NameInMap("tagEntryList")]
            [Validation(Required=false)]
            public List<TagEntry> TagEntryList { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

    }

}

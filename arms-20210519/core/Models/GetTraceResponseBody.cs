// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class GetTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Spans")]
        [Validation(Required=false)]
        public List<GetTraceResponseBodySpans> Spans { get; set; }
        public class GetTraceResponseBodySpans : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("HaveStack")]
            [Validation(Required=false)]
            public bool? HaveStack { get; set; }

            [NameInMap("LogEventList")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansLogEventList> LogEventList { get; set; }
            public class GetTraceResponseBodySpansLogEventList : TeaModel {
                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodySpansLogEventListTagEntryList> TagEntryList { get; set; }
                public class GetTraceResponseBodySpansLogEventListTagEntryList : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            [NameInMap("ParentSpanId")]
            [Validation(Required=false)]
            public string ParentSpanId { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("RpcType")]
            [Validation(Required=false)]
            public int? RpcType { get; set; }

            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SpanId")]
            [Validation(Required=false)]
            public string SpanId { get; set; }

            [NameInMap("TagEntryList")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansTagEntryList> TagEntryList { get; set; }
            public class GetTraceResponseBodySpansTagEntryList : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

    }

}

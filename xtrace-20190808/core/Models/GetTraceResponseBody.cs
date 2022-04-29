// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Spans")]
        [Validation(Required=false)]
        public GetTraceResponseBodySpans Spans { get; set; }
        public class GetTraceResponseBodySpans : TeaModel {
            [NameInMap("Span")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansSpan> Span { get; set; }
            public class GetTraceResponseBodySpansSpan : TeaModel {
                public long? Duration { get; set; }
                public bool? HaveStack { get; set; }
                public GetTraceResponseBodySpansSpanLogEventList LogEventList { get; set; }
                public class GetTraceResponseBodySpansSpanLogEventList : TeaModel {
                    [NameInMap("LogEvent")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodySpansSpanLogEventListLogEvent> LogEvent { get; set; }
                    public class GetTraceResponseBodySpansSpanLogEventListLogEvent : TeaModel {
                        [NameInMap("TagEntryList")]
                        [Validation(Required=false)]
                        public GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryList TagEntryList { get; set; }
                        public class GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryList : TeaModel {
                            [NameInMap("TagEntry")]
                            [Validation(Required=false)]
                            public List<GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryListTagEntry> TagEntry { get; set; }
                            public class GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryListTagEntry : TeaModel {
                                public string Key { get; set; }
                                public string Value { get; set; }
                            }
                        };

                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                    }

                }
                public string OperationName { get; set; }
                public string ParentSpanId { get; set; }
                public string ResultCode { get; set; }
                public string RpcId { get; set; }
                public string ServiceIp { get; set; }
                public string ServiceName { get; set; }
                public string SpanId { get; set; }
                public GetTraceResponseBodySpansSpanTagEntryList TagEntryList { get; set; }
                public class GetTraceResponseBodySpansSpanTagEntryList : TeaModel {
                    [NameInMap("TagEntry")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodySpansSpanTagEntryListTagEntry> TagEntry { get; set; }
                    public class GetTraceResponseBodySpansSpanTagEntryListTagEntry : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public long? Timestamp { get; set; }
                public string TraceID { get; set; }
            }
        };

    }

}

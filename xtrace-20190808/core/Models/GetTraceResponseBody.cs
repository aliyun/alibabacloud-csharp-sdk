// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the trace.
        /// </summary>
        [NameInMap("Spans")]
        [Validation(Required=false)]
        public GetTraceResponseBodySpans Spans { get; set; }
        public class GetTraceResponseBodySpans : TeaModel {
            [NameInMap("Span")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansSpan> Span { get; set; }
            public class GetTraceResponseBodySpansSpan : TeaModel {
                /// <summary>
                /// The time used to call the trace. Unit: milliseconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// Indicates whether the span has child spans. Valid values:
                /// 
                /// - true: The span has child spans. 
                /// - false: The span has no child spans.
                /// </summary>
                [NameInMap("HaveStack")]
                [Validation(Required=false)]
                public bool? HaveStack { get; set; }

                /// <summary>
                /// The log events in the trace.
                /// </summary>
                [NameInMap("LogEventList")]
                [Validation(Required=false)]
                public GetTraceResponseBodySpansSpanLogEventList LogEventList { get; set; }
                public class GetTraceResponseBodySpansSpanLogEventList : TeaModel {
                    [NameInMap("LogEvent")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodySpansSpanLogEventListLogEvent> LogEvent { get; set; }
                    public class GetTraceResponseBodySpansSpanLogEventListLogEvent : TeaModel {
                        /// <summary>
                        /// The tags in the log event.
                        /// </summary>
                        [NameInMap("TagEntryList")]
                        [Validation(Required=false)]
                        public GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryList TagEntryList { get; set; }
                        public class GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryList : TeaModel {
                            [NameInMap("TagEntry")]
                            [Validation(Required=false)]
                            public List<GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryListTagEntry> TagEntry { get; set; }
                            public class GetTraceResponseBodySpansSpanLogEventListLogEventTagEntryListTagEntry : TeaModel {
                                /// <summary>
                                /// The tag key in the log event.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The tag value in the log event.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// The timestamp when the log event was generated.
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                    }

                }

                /// <summary>
                /// The name of the span.
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                /// <summary>
                /// The ID of the parent span.
                /// </summary>
                [NameInMap("ParentSpanId")]
                [Validation(Required=false)]
                public string ParentSpanId { get; set; }

                /// <summary>
                /// The status code.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                /// <summary>
                /// The parent-child and sibling relationship between spans. For example, span 1.1 is the parent of span 1.1.1, and span 1.1.2 and span 1.1.1 are siblings.
                /// </summary>
                [NameInMap("RpcId")]
                [Validation(Required=false)]
                public string RpcId { get; set; }

                /// <summary>
                /// The IP address of the server where the span resides.
                /// </summary>
                [NameInMap("ServiceIp")]
                [Validation(Required=false)]
                public string ServiceIp { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// Span ID.
                /// </summary>
                [NameInMap("SpanId")]
                [Validation(Required=false)]
                public string SpanId { get; set; }

                /// <summary>
                /// The tags in the span.
                /// </summary>
                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public GetTraceResponseBodySpansSpanTagEntryList TagEntryList { get; set; }
                public class GetTraceResponseBodySpansSpanTagEntryList : TeaModel {
                    [NameInMap("TagEntry")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodySpansSpanTagEntryListTagEntry> TagEntry { get; set; }
                    public class GetTraceResponseBodySpansSpanTagEntryListTagEntry : TeaModel {
                        /// <summary>
                        /// The tag key in the span.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value in the span.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The timestamp when the span was generated. Unit: microseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The unique ID of the trace.
                /// </summary>
                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The spans that are contained in the trace.</para>
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
                /// <para>The duration of the span. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>Indicates whether the span has child spans. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HaveStack")]
                [Validation(Required=false)]
                public bool? HaveStack { get; set; }

                /// <summary>
                /// <para>The log events.</para>
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
                        /// <para>The tags.</para>
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
                                /// <para>The tag key of the log event.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>logLevel</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The tag value of the log event.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Warning</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The timestamp when the log event was generated. Unit: microseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1583683202047000</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the span.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api</para>
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                /// <summary>
                /// <para>The ID of the parent span.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fec891bb8f8XXX</para>
                /// </summary>
                [NameInMap("ParentSpanId")]
                [Validation(Required=false)]
                public string ParentSpanId { get; set; }

                /// <summary>
                /// <para>The response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                /// <summary>
                /// <para>The parent-child and sibling relationship between spans. For example, span 1.1 is the parent of span 1.1.1, and span 1.1.2 and span 1.1.1 are siblings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1</para>
                /// </summary>
                [NameInMap("RpcId")]
                [Validation(Required=false)]
                public string RpcId { get; set; }

                /// <summary>
                /// <para>The IP address of the server on which the span resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XXX.XXX</para>
                /// </summary>
                [NameInMap("ServiceIp")]
                [Validation(Required=false)]
                public string ServiceIp { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>server1</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The span ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fec891bb8f8XXX</para>
                /// </summary>
                [NameInMap("SpanId")]
                [Validation(Required=false)]
                public string SpanId { get; set; }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The tag key of the span.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>logLevel</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the span.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Warning</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The timestamp when the span was generated. Unit: microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1689845513298000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The trace ID, which is the unique identifier of the trace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1c6881aab84191a4****</para>
                /// </summary>
                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

        }

    }

}

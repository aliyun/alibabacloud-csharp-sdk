// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A9AEA84-7186-4D8D-B498-4585C6A2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the trace.</para>
        /// </summary>
        [NameInMap("Spans")]
        [Validation(Required=false)]
        public List<GetTraceResponseBodySpans> Spans { get; set; }
        public class GetTraceResponseBodySpans : TeaModel {
            /// <summary>
            /// <para>The child spans of the current span.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

            /// <summary>
            /// <para>The amount of time consumed by the trace. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Indicates whether a method stack was provided.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: A method stack was provided.</description></item>
            /// <item><description><c>false</c>: No method stack was provided.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HaveStack")]
            [Validation(Required=false)]
            public bool? HaveStack { get; set; }

            /// <summary>
            /// <para>The log events in the trace.</para>
            /// </summary>
            [NameInMap("LogEventList")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansLogEventList> LogEventList { get; set; }
            public class GetTraceResponseBodySpansLogEventList : TeaModel {
                /// <summary>
                /// <para>The tags of the trace.</para>
                /// </summary>
                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodySpansLogEventListTagEntryList> TagEntryList { get; set; }
                public class GetTraceResponseBodySpansLogEventListTagEntryList : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>http.status.code</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the log event was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590388651</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The name of the traced span.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/demo</para>
            /// </summary>
            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            /// <summary>
            /// <para>The ID of the parent span.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("ParentSpanId")]
            [Validation(Required=false)]
            public string ParentSpanId { get; set; }

            /// <summary>
            /// <para>The status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The ID of the RPC mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// <para>The type of the remote procedure call (RPC) mode.</para>
            /// <list type="bullet">
            /// <item><description>0: HTTP entry</description></item>
            /// <item><description>25: HTTP call</description></item>
            /// <item><description>1: High-speed Service Framework (HSF) call</description></item>
            /// <item><description>2: HSF provision</description></item>
            /// <item><description>40: on-premises API call</description></item>
            /// <item><description>60: MySQL call</description></item>
            /// <item><description>62: Oracle call</description></item>
            /// <item><description>63: PostgreSQL call</description></item>
            /// <item><description>70: Redis call</description></item>
            /// <item><description>4: Taobao Distributed Data Layer (TDDL) call</description></item>
            /// <item><description>5: Tair call</description></item>
            /// <item><description>13: MetaQ message sending</description></item>
            /// <item><description>252: MetaQ message receiving</description></item>
            /// <item><description>3: notification sending</description></item>
            /// <item><description>254: notification receiving</description></item>
            /// <item><description>7: Apache Dubbo call</description></item>
            /// <item><description>8: Apache Dubbo provision</description></item>
            /// <item><description>19: SOFARPC call</description></item>
            /// <item><description>18: SOFARPC provision</description></item>
            /// <item><description>11: Distributed Service Framework (DSF) call</description></item>
            /// <item><description>12: DSF provision</description></item>
            /// <item><description>\-1: unknown call</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RpcType")]
            [Validation(Required=false)]
            public int? RpcType { get; set; }

            /// <summary>
            /// <para>The IP address of the host where the application resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.XX.XX</para>
            /// </summary>
            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-demo</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The span ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("SpanId")]
            [Validation(Required=false)]
            public string SpanId { get; set; }

            /// <summary>
            /// <para>The tags of the trace.</para>
            /// </summary>
            [NameInMap("TagEntryList")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodySpansTagEntryList> TagEntryList { get; set; }
            public class GetTraceResponseBodySpansTagEntryList : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http.status.code</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The timestamp generated when the span was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590388651</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac14001a15954493811405707d****</para>
            /// </summary>
            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

    }

}

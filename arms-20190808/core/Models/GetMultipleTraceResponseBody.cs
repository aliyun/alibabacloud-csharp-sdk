// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetMultipleTraceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of traces.</para>
        /// </summary>
        [NameInMap("MultiCallChainInfos")]
        [Validation(Required=false)]
        public List<GetMultipleTraceResponseBodyMultiCallChainInfos> MultiCallChainInfos { get; set; }
        public class GetMultipleTraceResponseBodyMultiCallChainInfos : TeaModel {
            /// <summary>
            /// <para>The details of the trace.</para>
            /// </summary>
            [NameInMap("Spans")]
            [Validation(Required=false)]
            public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpans> Spans { get; set; }
            public class GetMultipleTraceResponseBodyMultiCallChainInfosSpans : TeaModel {
                /// <summary>
                /// <para>The amount of time consumed by the trace. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("HaveStack")]
                [Validation(Required=false)]
                public bool? HaveStack { get; set; }

                /// <summary>
                /// <para>The log events in the trace.</para>
                /// </summary>
                [NameInMap("LogEventList")]
                [Validation(Required=false)]
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList> LogEventList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList : TeaModel {
                    /// <summary>
                    /// <para>The tags of the trace.</para>
                    /// </summary>
                    [NameInMap("TagEntryList")]
                    [Validation(Required=false)]
                    public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList> TagEntryList { get; set; }
                    public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList : TeaModel {
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
                    /// <para>The time when the log was generated. The value is a timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1595174501747</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <para>The name of the traced span.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/demo/queryNotExistDB/11</para>
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
                /// <para>The status code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                /// <summary>
                /// <para>RPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
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
                /// <para>0</para>
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
                /// <para>arms-k8s-demo-subcomponent</para>
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
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList> TagEntryList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList : TeaModel {
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
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1595174501747</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The trace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ac1400a115951745017447033d****</para>
                /// </summary>
                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac1400a115951745017447033d****</para>
            /// </summary>
            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2983BEF7-4A0D-47A2-94A2-8E9C5E63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

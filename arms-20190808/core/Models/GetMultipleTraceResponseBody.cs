// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetMultipleTraceResponseBody : TeaModel {
        /// <summary>
        /// The details of traces.
        /// </summary>
        [NameInMap("MultiCallChainInfos")]
        [Validation(Required=false)]
        public List<GetMultipleTraceResponseBodyMultiCallChainInfos> MultiCallChainInfos { get; set; }
        public class GetMultipleTraceResponseBodyMultiCallChainInfos : TeaModel {
            /// <summary>
            /// The details of the trace.
            /// </summary>
            [NameInMap("Spans")]
            [Validation(Required=false)]
            public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpans> Spans { get; set; }
            public class GetMultipleTraceResponseBodyMultiCallChainInfosSpans : TeaModel {
                /// <summary>
                /// The amount of time consumed by the trace. Unit: milliseconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// Indicates whether a method stack was provided.
                /// 
                /// *   `true`: A method stack was provided.
                /// *   `false`: No method stack was provided.
                /// </summary>
                [NameInMap("HaveStack")]
                [Validation(Required=false)]
                public bool? HaveStack { get; set; }

                /// <summary>
                /// The log events in the trace.
                /// </summary>
                [NameInMap("LogEventList")]
                [Validation(Required=false)]
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList> LogEventList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList : TeaModel {
                    /// <summary>
                    /// The tags of the trace.
                    /// </summary>
                    [NameInMap("TagEntryList")]
                    [Validation(Required=false)]
                    public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList> TagEntryList { get; set; }
                    public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The time when the log was generated. The value is a timestamp.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// The name of the traced span.
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
                /// The status code returned.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                /// <summary>
                /// RPC ID
                /// </summary>
                [NameInMap("RpcId")]
                [Validation(Required=false)]
                public string RpcId { get; set; }

                /// <summary>
                /// The type of the remote procedure call (RPC) mode.
                /// 
                /// *   0: HTTP entry
                /// *   25: HTTP call
                /// *   1: High-speed Service Framework (HSF) call
                /// *   2: HSF provision
                /// *   40: on-premises API call
                /// *   60: MySQL call
                /// *   62: Oracle call
                /// *   63: PostgreSQL call
                /// *   70: Redis call
                /// *   4: Taobao Distributed Data Layer (TDDL) call
                /// *   5: Tair call
                /// *   13: MetaQ message sending
                /// *   252: MetaQ message receiving
                /// *   3: notification sending
                /// *   254: notification receiving
                /// *   7: Apache Dubbo call
                /// *   8: Apache Dubbo provision
                /// *   19: SOFARPC call
                /// *   18: SOFARPC provision
                /// *   11: Distributed Service Framework (DSF) call
                /// *   12: DSF provision
                /// *   \-1: unknown call
                /// </summary>
                [NameInMap("RpcType")]
                [Validation(Required=false)]
                public int? RpcType { get; set; }

                /// <summary>
                /// The IP address of the host where the application resides.
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
                /// The span ID.
                /// </summary>
                [NameInMap("SpanId")]
                [Validation(Required=false)]
                public string SpanId { get; set; }

                /// <summary>
                /// The tags of the trace.
                /// </summary>
                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList> TagEntryList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList : TeaModel {
                    /// <summary>
                    /// The key of the tag.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The timestamp.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The trace ID.
                /// </summary>
                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

            /// <summary>
            /// The trace ID.
            /// </summary>
            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the trace.
        /// </summary>
        [NameInMap("Spans")]
        [Validation(Required=false)]
        public List<GetTraceResponseBodySpans> Spans { get; set; }
        public class GetTraceResponseBodySpans : TeaModel {
            /// <summary>
            /// The child spans of the current span.
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

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
            public List<GetTraceResponseBodySpansLogEventList> LogEventList { get; set; }
            public class GetTraceResponseBodySpansLogEventList : TeaModel {
                /// <summary>
                /// The tags of the trace.
                /// </summary>
                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodySpansLogEventListTagEntryList> TagEntryList { get; set; }
                public class GetTraceResponseBodySpansLogEventListTagEntryList : TeaModel {
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
                /// The timestamp when the log event was generated.
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
            /// The status code.
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// The ID of the RPC mode.
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// The type of the remote procedure call (RPC) mode.
            /// 
            /// - 0 http
            /// - 25 http_client
            /// - 1 hsf_client
            /// - 2 hsf
            /// - 40 local
            /// - 41 async
            /// - 52 DB2
            /// - 53 Informix
            /// - 54 SequoiaDB
            /// - 55 Gbase
            /// - 56 GaussDB
            /// - 57 KingBase
            /// - 58 infuxdb
            /// - 59 clickhouse
            /// - 60 mysql
            /// - 61 mysql
            /// - 62 oracle
            /// - 63 postgresql
            /// - 64 mongodb
            /// - 65 ppas
            /// - 66 sqlserver
            /// - 67 mariadb
            /// - 68 dmdb
            /// - 69 oceanbase
            /// - 70 redis
            /// - 71 memcached
            /// - 72 elasticsearch
            /// - 73 kudu
            /// - 4 tddl
            /// - 5 tair
            /// - 13 mq_client
            /// - 252 mq
            /// - 23 kafka_client
            /// - 256 kafka
            /// - 3 notify_client
            /// - 254 notify
            /// - 7 dubbo_client
            /// - 8 dubbo
            /// - 11 dsf_client
            /// - 12 dsf
            /// - 9 grpc
            /// - 10 grpc_client
            /// - 16 thrift
            /// - 17 thrift_client
            /// - 18 sofa
            /// - 19 sofa_client
            /// - -1 unknown
            /// - 98 user_method
            /// - 100 root
            /// - 101 client
            /// - 102 server
            /// - 103 producer
            /// - 104 consumer
            /// - 105 db
            /// - 106 xtrace_other
            /// - 1301 schedulerx
            /// - 1302 XXL_Job
            /// - 1303 Spring_Scheduled
            /// - 1304 Quartz
            /// - 1305 ElasticJob
            /// - 1308 Jdk_Timer
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
            public List<GetTraceResponseBodySpansTagEntryList> TagEntryList { get; set; }
            public class GetTraceResponseBodySpansTagEntryList : TeaModel {
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
            /// The timestamp generated when the span was generated.
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

    }

}

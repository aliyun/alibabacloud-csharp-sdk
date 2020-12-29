// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetMultipleTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MultiCallChainInfos")]
        [Validation(Required=false)]
        public List<GetMultipleTraceResponseBodyMultiCallChainInfos> MultiCallChainInfos { get; set; }
        public class GetMultipleTraceResponseBodyMultiCallChainInfos : TeaModel {
            [NameInMap("Spans")]
            [Validation(Required=false)]
            public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpans> Spans { get; set; }
            public class GetMultipleTraceResponseBodyMultiCallChainInfosSpans : TeaModel {
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("RpcType")]
                [Validation(Required=false)]
                public int? RpcType { get; set; }

                [NameInMap("TagEntryList")]
                [Validation(Required=false)]
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList> TagEntryList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansTagEntryList : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("LogEventList")]
                [Validation(Required=false)]
                public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList> LogEventList { get; set; }
                public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventList : TeaModel {
                    [NameInMap("TagEntryList")]
                    [Validation(Required=false)]
                    public List<GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList> TagEntryList { get; set; }
                    public class GetMultipleTraceResponseBodyMultiCallChainInfosSpansLogEventListTagEntryList : TeaModel {
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

                [NameInMap("HaveStack")]
                [Validation(Required=false)]
                public bool? HaveStack { get; set; }

                [NameInMap("ServiceIp")]
                [Validation(Required=false)]
                public string ServiceIp { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("RpcId")]
                [Validation(Required=false)]
                public string RpcId { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

    }

}

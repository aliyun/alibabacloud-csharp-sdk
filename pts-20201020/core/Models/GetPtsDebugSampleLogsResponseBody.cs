// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsDebugSampleLogsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SamplingLogs")]
        [Validation(Required=false)]
        public List<GetPtsDebugSampleLogsResponseBodySamplingLogs> SamplingLogs { get; set; }
        public class GetPtsDebugSampleLogsResponseBodySamplingLogs : TeaModel {
            [NameInMap("ChainId")]
            [Validation(Required=false)]
            public string ChainId { get; set; }

            [NameInMap("ChainName")]
            [Validation(Required=false)]
            public string ChainName { get; set; }

            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public string CheckResult { get; set; }

            [NameInMap("ExportConfig")]
            [Validation(Required=false)]
            public string ExportConfig { get; set; }

            [NameInMap("ExportContent")]
            [Validation(Required=false)]
            public string ExportContent { get; set; }

            [NameInMap("HttpRequestBody")]
            [Validation(Required=false)]
            public string HttpRequestBody { get; set; }

            [NameInMap("HttpRequestHeaders")]
            [Validation(Required=false)]
            public string HttpRequestHeaders { get; set; }

            [NameInMap("HttpRequestMethod")]
            [Validation(Required=false)]
            public string HttpRequestMethod { get; set; }

            [NameInMap("HttpRequestUrl")]
            [Validation(Required=false)]
            public string HttpRequestUrl { get; set; }

            [NameInMap("HttpResponseBody")]
            [Validation(Required=false)]
            public string HttpResponseBody { get; set; }

            [NameInMap("HttpResponseFailMsg")]
            [Validation(Required=false)]
            public string HttpResponseFailMsg { get; set; }

            [NameInMap("HttpResponseHeaders")]
            [Validation(Required=false)]
            public string HttpResponseHeaders { get; set; }

            [NameInMap("HttpResponseStatus")]
            [Validation(Required=false)]
            public string HttpResponseStatus { get; set; }

            [NameInMap("HttpStartTime")]
            [Validation(Required=false)]
            public long? HttpStartTime { get; set; }

            [NameInMap("HttpTiming")]
            [Validation(Required=false)]
            public string HttpTiming { get; set; }

            [NameInMap("ImportContent")]
            [Validation(Required=false)]
            public string ImportContent { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("Rt")]
            [Validation(Required=false)]
            public string Rt { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

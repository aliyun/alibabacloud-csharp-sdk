// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class QueryRequestLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestLogs")]
        [Validation(Required=false)]
        public QueryRequestLogsResponseBodyRequestLogs RequestLogs { get; set; }
        public class QueryRequestLogsResponseBodyRequestLogs : TeaModel {
            [NameInMap("RequestLog")]
            [Validation(Required=false)]
            public List<QueryRequestLogsResponseBodyRequestLogsRequestLog> RequestLog { get; set; }
            public class QueryRequestLogsResponseBodyRequestLogsRequestLog : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public int? ClientIp { get; set; }

                [NameInMap("ClientNonce")]
                [Validation(Required=false)]
                public string ClientNonce { get; set; }

                [NameInMap("ConsumerAppId")]
                [Validation(Required=false)]
                public string ConsumerAppId { get; set; }

                [NameInMap("ConsumerAppKey")]
                [Validation(Required=false)]
                public string ConsumerAppKey { get; set; }

                [NameInMap("CustomTraceId")]
                [Validation(Required=false)]
                public string CustomTraceId { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Exception")]
                [Validation(Required=false)]
                public string Exception { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("HttpPath")]
                [Validation(Required=false)]
                public string HttpPath { get; set; }

                [NameInMap("InitialRequestId")]
                [Validation(Required=false)]
                public string InitialRequestId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("JwtClaims")]
                [Validation(Required=false)]
                public string JwtClaims { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public string RequestBody { get; set; }

                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public string RequestHeaders { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("RequestProtocol")]
                [Validation(Required=false)]
                public string RequestProtocol { get; set; }

                [NameInMap("RequestQueryString")]
                [Validation(Required=false)]
                public string RequestQueryString { get; set; }

                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public string RequestSize { get; set; }

                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                [NameInMap("ResponseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                [NameInMap("ResponseHeaders")]
                [Validation(Required=false)]
                public string ResponseHeaders { get; set; }

                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public string ResponseSize { get; set; }

                [NameInMap("ServiceLatency")]
                [Validation(Required=false)]
                public string ServiceLatency { get; set; }

                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public string TotalLatency { get; set; }

                [NameInMap("plugin")]
                [Validation(Required=false)]
                public string Plugin { get; set; }

            }

        }

    }

}

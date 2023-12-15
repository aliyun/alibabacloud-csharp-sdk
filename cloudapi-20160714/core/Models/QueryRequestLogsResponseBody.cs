// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class QueryRequestLogsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The request logs.
        /// </summary>
        [NameInMap("RequestLogs")]
        [Validation(Required=false)]
        public QueryRequestLogsResponseBodyRequestLogs RequestLogs { get; set; }
        public class QueryRequestLogsResponseBodyRequestLogs : TeaModel {
            [NameInMap("RequestLog")]
            [Validation(Required=false)]
            public List<QueryRequestLogsResponseBodyRequestLogsRequestLog> RequestLog { get; set; }
            public class QueryRequestLogsResponseBodyRequestLogsRequestLog : TeaModel {
                /// <summary>
                /// The API ID.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The API name.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The time when API Gateway finished forwarding the request to the backend service.
                /// </summary>
                [NameInMap("BackendRequestEnd")]
                [Validation(Required=false)]
                public long? BackendRequestEnd { get; set; }

                /// <summary>
                /// The time when API Gateway started to forward the request to the backend service.
                /// </summary>
                [NameInMap("BackendRequestStart")]
                [Validation(Required=false)]
                public long? BackendRequestStart { get; set; }

                /// <summary>
                /// The time when API Gateway finished receiving the response from the backend service.
                /// </summary>
                [NameInMap("BackendResponseEnd")]
                [Validation(Required=false)]
                public long? BackendResponseEnd { get; set; }

                /// <summary>
                /// The time when API Gateway started to receive the response from the backend service.
                /// </summary>
                [NameInMap("BackendResponseStart")]
                [Validation(Required=false)]
                public long? BackendResponseStart { get; set; }

                /// <summary>
                /// The IP address of the client that sends the request.
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// The X-Ca-Nonce header included in the request from the client.
                /// </summary>
                [NameInMap("ClientNonce")]
                [Validation(Required=false)]
                public string ClientNonce { get; set; }

                /// <summary>
                /// The application ID that is used by the caller.
                /// </summary>
                [NameInMap("ConsumerAppId")]
                [Validation(Required=false)]
                public string ConsumerAppId { get; set; }

                /// <summary>
                /// The App Key that is used by the caller.
                /// </summary>
                [NameInMap("ConsumerAppKey")]
                [Validation(Required=false)]
                public string ConsumerAppKey { get; set; }

                /// <summary>
                /// The custom trace ID.
                /// </summary>
                [NameInMap("CustomTraceId")]
                [Validation(Required=false)]
                public string CustomTraceId { get; set; }

                /// <summary>
                /// The requested domain name in the request.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The error code that is returned.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned if the call fails.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The specific error message returned by the backend service.
                /// </summary>
                [NameInMap("Exception")]
                [Validation(Required=false)]
                public string Exception { get; set; }

                /// <summary>
                /// The time when API Gateway finished receiving the request.
                /// </summary>
                [NameInMap("FrontRequestEnd")]
                [Validation(Required=false)]
                public long? FrontRequestEnd { get; set; }

                /// <summary>
                /// The time when API Gateway started to receive the request.
                /// </summary>
                [NameInMap("FrontRequestStart")]
                [Validation(Required=false)]
                public long? FrontRequestStart { get; set; }

                /// <summary>
                /// The time when API Gateway finished forwarding the response to the client.
                /// </summary>
                [NameInMap("FrontResponseEnd")]
                [Validation(Required=false)]
                public long? FrontResponseEnd { get; set; }

                /// <summary>
                /// The time when API Gateway started to forward the response to the client.
                /// </summary>
                [NameInMap("FrontResponseStart")]
                [Validation(Required=false)]
                public long? FrontResponseStart { get; set; }

                /// <summary>
                /// The ID of the API group to which the API belongs.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the API group to which the API belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The HTTP method that is used to send the request.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The path of the request.
                /// </summary>
                [NameInMap("HttpPath")]
                [Validation(Required=false)]
                public string HttpPath { get; set; }

                /// <summary>
                /// The initial request ID when API Gateway calls an API. For example, if API-1 calls API-2, the initialRequestId parameter in the log of API-2 indicates the ID of the request from API-1.
                /// </summary>
                [NameInMap("InitialRequestId")]
                [Validation(Required=false)]
                public string InitialRequestId { get; set; }

                /// <summary>
                /// The ID of the API Gateway instance to which the API belongs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The JSON web token (JWT) claims. The claims can be configured at the group level.
                /// </summary>
                [NameInMap("JwtClaims")]
                [Validation(Required=false)]
                public string JwtClaims { get; set; }

                /// <summary>
                /// The region in which the instance resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The request body. A request body cannot exceed 1,024 bytes in size.
                /// </summary>
                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public string RequestBody { get; set; }

                /// <summary>
                /// The request headers.
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public string RequestHeaders { get; set; }

                /// <summary>
                /// The request ID.
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// The protocol used by the client to send the request. Valid values: HTTP, HTTPS, and WS.
                /// </summary>
                [NameInMap("RequestProtocol")]
                [Validation(Required=false)]
                public string RequestProtocol { get; set; }

                /// <summary>
                /// The query string for the request.
                /// </summary>
                [NameInMap("RequestQueryString")]
                [Validation(Required=false)]
                public string RequestQueryString { get; set; }

                /// <summary>
                /// The size of the request. Unit: bytes.
                /// </summary>
                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public string RequestSize { get; set; }

                /// <summary>
                /// The request time, in UTC.
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// The response body. A response body cannot exceed 1,024 bytes in size.
                /// </summary>
                [NameInMap("ResponseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                /// <summary>
                /// The headers in the API response.
                /// </summary>
                [NameInMap("ResponseHeaders")]
                [Validation(Required=false)]
                public string ResponseHeaders { get; set; }

                /// <summary>
                /// The size of returned data. Unit: bytes.
                /// </summary>
                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public string ResponseSize { get; set; }

                /// <summary>
                /// The total time consumed to access the backend resources. The total time includes the time consumed to request a connection to the resources, the time consumed to establish the connection, and the time consumed to call the backend service. Unit: milliseconds.
                /// </summary>
                [NameInMap("ServiceLatency")]
                [Validation(Required=false)]
                public string ServiceLatency { get; set; }

                /// <summary>
                /// The ID of the API environment.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// The name of the API environment.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// The status code returned.
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// The total time consumed by the request. Unit: milliseconds.
                /// </summary>
                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public string TotalLatency { get; set; }

                /// <summary>
                /// The plug-in hit by the request and the relevant context.
                /// </summary>
                [NameInMap("plugin")]
                [Validation(Required=false)]
                public string Plugin { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class QueryRequestLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE5722A6-AE78-4741-A9B0-6C81********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request logs.</para>
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
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4b83229ebcab4ecd88956fb3********</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApiName</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIPROOM_VIPROOM</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The time when API Gateway finished forwarding the request to the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224969</para>
                /// </summary>
                [NameInMap("BackendRequestEnd")]
                [Validation(Required=false)]
                public long? BackendRequestEnd { get; set; }

                /// <summary>
                /// <para>The time when API Gateway started to forward the request to the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224969</para>
                /// </summary>
                [NameInMap("BackendRequestStart")]
                [Validation(Required=false)]
                public long? BackendRequestStart { get; set; }

                /// <summary>
                /// <para>The time when API Gateway finished receiving the response from the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224989</para>
                /// </summary>
                [NameInMap("BackendResponseEnd")]
                [Validation(Required=false)]
                public long? BackendResponseEnd { get; set; }

                /// <summary>
                /// <para>The time when API Gateway started to receive the response from the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224989</para>
                /// </summary>
                [NameInMap("BackendResponseStart")]
                [Validation(Required=false)]
                public long? BackendResponseStart { get; set; }

                /// <summary>
                /// <para>The IP address of the client that sends the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21.237.XXX.XXX</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The X-Ca-Nonce header included in the request from the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d43df9db-3b05-4cd6-888a-1c0b********</para>
                /// </summary>
                [NameInMap("ClientNonce")]
                [Validation(Required=false)]
                public string ClientNonce { get; set; }

                /// <summary>
                /// <para>The application ID that is used by the caller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11096****</para>
                /// </summary>
                [NameInMap("ConsumerAppId")]
                [Validation(Required=false)]
                public string ConsumerAppId { get; set; }

                /// <summary>
                /// <para>The App Key that is used by the caller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20412****</para>
                /// </summary>
                [NameInMap("ConsumerAppKey")]
                [Validation(Required=false)]
                public string ConsumerAppKey { get; set; }

                /// <summary>
                /// <para>The custom trace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95657ED9-2F6F-426F-BD99-79C8********</para>
                /// </summary>
                [NameInMap("CustomTraceId")]
                [Validation(Required=false)]
                public string CustomTraceId { get; set; }

                /// <summary>
                /// <para>The requested domain name in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360bdd88695c48ae8085c7f2********-ap-southeast-1.alicloudapi.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The error code that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X500ER</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned if the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Backend service connect failed <c>Timeout connecting to [/1XX.20.0.XX:8080]</c></para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The specific error message returned by the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error msg</para>
                /// </summary>
                [NameInMap("Exception")]
                [Validation(Required=false)]
                public string Exception { get; set; }

                /// <summary>
                /// <para>The time when API Gateway finished receiving the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224968</para>
                /// </summary>
                [NameInMap("FrontRequestEnd")]
                [Validation(Required=false)]
                public long? FrontRequestEnd { get; set; }

                /// <summary>
                /// <para>The time when API Gateway started to receive the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224968</para>
                /// </summary>
                [NameInMap("FrontRequestStart")]
                [Validation(Required=false)]
                public long? FrontRequestStart { get; set; }

                /// <summary>
                /// <para>The time when API Gateway finished forwarding the response to the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224989</para>
                /// </summary>
                [NameInMap("FrontResponseEnd")]
                [Validation(Required=false)]
                public long? FrontResponseEnd { get; set; }

                /// <summary>
                /// <para>The time when API Gateway started to forward the response to the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731487224989</para>
                /// </summary>
                [NameInMap("FrontResponseStart")]
                [Validation(Required=false)]
                public long? FrontResponseStart { get; set; }

                /// <summary>
                /// <para>The ID of the API group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dc024277fe6c4cada79ba0bd6********</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GroupName</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The HTTP method that is used to send the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The path of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/testPath</para>
                /// </summary>
                [NameInMap("HttpPath")]
                [Validation(Required=false)]
                public string HttpPath { get; set; }

                /// <summary>
                /// <para>The initial request ID when API Gateway calls an API. For example, if API-1 calls API-2, the initialRequestId parameter in the log of API-2 indicates the ID of the request from API-1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95657ED9-2F6F-426F-BD99-79C8********</para>
                /// </summary>
                [NameInMap("InitialRequestId")]
                [Validation(Required=false)]
                public string InitialRequestId { get; set; }

                /// <summary>
                /// <para>The ID of the API Gateway instance to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apigateway-bj-ab2b********</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The JSON web token (JWT) claims. The claims can be configured at the group level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("JwtClaims")]
                [Validation(Required=false)]
                public string JwtClaims { get; set; }

                /// <summary>
                /// <para>The region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The request body. A request body cannot exceed 1,024 bytes in size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param=paramName</para>
                /// </summary>
                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public string RequestBody { get; set; }

                /// <summary>
                /// <para>The request headers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>content-type: application/x-www-form-urlencoded</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public string RequestHeaders { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95657ED9-2F6F-426F-BD99-79C8********</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The protocol used by the client to send the request. Valid values: HTTP, HTTPS, and WS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("RequestProtocol")]
                [Validation(Required=false)]
                public string RequestProtocol { get; set; }

                /// <summary>
                /// <para>The query string for the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username=name</para>
                /// </summary>
                [NameInMap("RequestQueryString")]
                [Validation(Required=false)]
                public string RequestQueryString { get; set; }

                /// <summary>
                /// <para>The size of the request. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1923</para>
                /// </summary>
                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public string RequestSize { get; set; }

                /// <summary>
                /// <para>The request time, in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-29T03:59:59Z</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// <para>The response body. A response body cannot exceed 1,024 bytes in size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param=paramName</para>
                /// </summary>
                [NameInMap("ResponseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                /// <summary>
                /// <para>The headers in the API response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>content-type: application/x-www-form-urlencoded</para>
                /// </summary>
                [NameInMap("ResponseHeaders")]
                [Validation(Required=false)]
                public string ResponseHeaders { get; set; }

                /// <summary>
                /// <para>The size of returned data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23441</para>
                /// </summary>
                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public string ResponseSize { get; set; }

                /// <summary>
                /// <para>The total time consumed to access the backend resources. The total time includes the time consumed to request a connection to the resources, the time consumed to establish the connection, and the time consumed to call the backend service. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>324</para>
                /// </summary>
                [NameInMap("ServiceLatency")]
                [Validation(Required=false)]
                public string ServiceLatency { get; set; }

                /// <summary>
                /// <para>The ID of the API environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8a305b7f10334052a52d9156********</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// <para>The name of the API environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// <para>The status code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>The total time consumed by the request. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1345</para>
                /// </summary>
                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public string TotalLatency { get; set; }

                /// <summary>
                /// <para>The plug-in hit by the request and the relevant context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("plugin")]
                [Validation(Required=false)]
                public string Plugin { get; set; }

            }

        }

    }

}

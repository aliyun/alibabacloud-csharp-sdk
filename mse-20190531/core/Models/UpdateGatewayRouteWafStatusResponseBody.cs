// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteWafStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateGatewayRouteWafStatusResponseBodyData Data { get; set; }
        public class UpdateGatewayRouteWafStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration for cross-origin resource sharing (CORS).</para>
            /// </summary>
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataCors Cors { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataCors : TeaModel {
                /// <summary>
                /// <para>The credentials allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public bool? AllowCredentials { get; set; }

                /// <summary>
                /// <para>The headers allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                /// <summary>
                /// <para>The methods allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                /// <summary>
                /// <para>The origins allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowOrigins")]
                [Validation(Required=false)]
                public string AllowOrigins { get; set; }

                /// <summary>
                /// <para>The response headers.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>The unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

            }

            /// <summary>
            /// <para>The default service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultServiceId")]
            [Validation(Required=false)]
            public long? DefaultServiceId { get; set; }

            /// <summary>
            /// <para>The default service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultServiceName")]
            [Validation(Required=false)]
            public string DefaultServiceName { get; set; }

            /// <summary>
            /// <para>The destination service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Single</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The information about service mocking.</para>
            /// </summary>
            [NameInMap("DirectResponse")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse : TeaModel {
                /// <summary>
                /// <para>The mock return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;key\&quot;:\&quot;h68d13466.sqa.eu95\&quot;,\&quot;dims\&quot;:\&quot;groupName=All}]</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>The return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

            }

            /// <summary>
            /// <para>The domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// <para>The list of domain IDs.</para>
            /// </summary>
            [NameInMap("DomainIdList")]
            [Validation(Required=false)]
            public List<long?> DomainIdList { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nbhamster.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The domain names.</para>
            /// </summary>
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            /// <summary>
            /// <para>Indicates whether WAF is activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <para>The ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-7ea3da97b96543e19f6c597cd4a9****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-26T09:52:41.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-24T06:08:29.230+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The information about the rewrite policy.</para>
            /// </summary>
            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The HTTP request path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/client</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The path type of the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("PathType")]
                [Validation(Required=false)]
                public string PathType { get; set; }

                /// <summary>
                /// <para>The matching pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The HTTP status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The replacement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Substitution")]
                [Validation(Required=false)]
                public string Substitution { get; set; }

            }

            /// <summary>
            /// <para>The header settings.</para>
            /// </summary>
            [NameInMap("HeaderOp")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp : TeaModel {
                /// <summary>
                /// <para>The policy.</para>
                /// </summary>
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
                    /// <summary>
                    /// <para>The request or response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Response</para>
                    /// </summary>
                    [NameInMap("DirectionType")]
                    [Validation(Required=false)]
                    public string DirectionType { get; set; }

                    /// <summary>
                    /// <para>The header key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>debug</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The operation type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Add</para>
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// <para>The header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The matching rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;PathPredicates\&quot;:{\&quot;Path\&quot;:\&quot;/metas\&quot;,\&quot;Type\&quot;:\&quot;PRE\&quot;,\&quot;IgnoreCase\&quot;:false}}</para>
            /// </summary>
            [NameInMap("Predicates")]
            [Validation(Required=false)]
            public string Predicates { get; set; }

            /// <summary>
            /// <para>The configuration of the redirection.</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRedirect Redirect { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRedirect : TeaModel {
                /// <summary>
                /// <para>The response code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ww.al.c</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The retry configuration.</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRetry Retry { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRetry : TeaModel {
                /// <summary>
                /// <para>The number of retries allowed for a request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                /// <summary>
                /// <para>The HTTP status code.</para>
                /// </summary>
                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                /// <summary>
                /// <para>The retry condition.</para>
                /// </summary>
                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

                /// <summary>
                /// <para>The retry status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The sequence number of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// <para>The information about route matching.</para>
            /// </summary>
            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// <para>The information about matching based on request headers.</para>
                /// </summary>
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
                    /// <summary>
                    /// <para>The key of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alibo</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The information about method matching.</para>
                /// </summary>
                [NameInMap("MethodPredicates")]
                [Validation(Required=false)]
                public List<string> MethodPredicates { get; set; }

                /// <summary>
                /// <para>The information about route matching.</para>
                /// </summary>
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether case sensitivity is ignored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreCase")]
                    [Validation(Required=false)]
                    public bool? IgnoreCase { get; set; }

                    /// <summary>
                    /// <para>The path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/zookeeper/mmgw/unlogined/common.getBu</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The parameter matching rules.</para>
                /// </summary>
                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instanceId</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about services.</para>
            /// </summary>
            [NameInMap("RouteServices")]
            [Validation(Required=false)]
            public List<UpdateGatewayRouteWafStatusResponseBodyDataRouteServices> RouteServices { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRouteServices : TeaModel {
                /// <summary>
                /// <para>The name of the group to which the service belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-aixue-gray</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>The ID of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>547</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b-service</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The source type of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>K8s</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The version of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The information about services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Percent\&quot;:100,\&quot;ServiceId\&quot;:126}]</para>
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            /// <summary>
            /// <para>The status of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The timeout configuration.</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataTimeout Timeout { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataTimeout : TeaModel {
                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>The unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7466566F-F30F-4A29-965D-3E0AF21D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The code used to synchronize with the success field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayConfigResponseBodyData Data { get; set; }
        public class GetGatewayConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom log format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;requestMetadata&quot;:[],&quot;responseHeaders&quot;:[],&quot;requestHeaders&quot;:[&quot;x-test&quot;],&quot;responseMetadata&quot;:[]}</para>
            /// </summary>
            [NameInMap("AccessLogHeader")]
            [Validation(Required=false)]
            public string AccessLogHeader { get; set; }

            /// <summary>
            /// <para>The buffer size for a single gateway connection. Configuring this parameter affects throughput and gateway memory usage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32768</para>
            /// </summary>
            [NameInMap("DownstreamConnectionBufferLimits")]
            [Validation(Required=false)]
            public int? DownstreamConnectionBufferLimits { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent streams on a single connection when the client uses HTTP/2. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DownstreamHttp2MaxConcurrentStream")]
            [Validation(Required=false)]
            public int? DownstreamHttp2MaxConcurrentStream { get; set; }

            /// <summary>
            /// <para>The idle timeout period for connections from the client to the gateway. Unit: seconds. If no request is received within the specified period, the gateway disconnects the connection. Valid values: 0 to 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("DownstreamIdleTime")]
            [Validation(Required=false)]
            public int? DownstreamIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable custom authentication configuration push for self-managed authentication services. When enabled, changes to authentication rules do not cause connection interruptions. This feature is applicable to WebSocket and online business scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableCustomAuthConfigPush")]
            [Validation(Required=false)]
            public string EnableCustomAuthConfigPush { get; set; }

            /// <summary>
            /// <para>Specifies whether to generate a request ID in the request header for request tracking. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableGenerateRequestId")]
            [Validation(Required=false)]
            public bool? EnableGenerateRequestId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Gzip compression for requests and responses. Enabling this feature reduces gateway traffic but increases gateway CPU consumption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableGzip")]
            [Validation(Required=false)]
            public bool? EnableGzip { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Gzip hardware acceleration.</para>
            /// </summary>
            [NameInMap("EnableGzipHardwareAccelerate")]
            [Validation(Required=false)]
            public bool? EnableGzipHardwareAccelerate { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable hardware acceleration. This configuration fails if the region does not support hardware acceleration at the underlying layer or if hardware acceleration was not specified during purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableHardwareAccelerate")]
            [Validation(Required=false)]
            public bool? EnableHardwareAccelerate { get; set; }

            /// <summary>
            /// <para>Specifies whether to use HTTP/2 during negotiation between the server and the client. This parameter takes effect at the request level. Changes take effect after 1 to 2 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableHttp2")]
            [Validation(Required=false)]
            public bool? EnableHttp2 { get; set; }

            /// <summary>
            /// <para>Specifies whether the HTTP/3 protocol is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableHttp3")]
            [Validation(Required=false)]
            public bool? EnableHttp3 { get; set; }

            /// <summary>
            /// <para>The tag filtering configuration for Kubernetes service source workloads.</para>
            /// </summary>
            [NameInMap("EnableK8sSourceWorkloadFilter")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataEnableK8sSourceWorkloadFilter EnableK8sSourceWorkloadFilter { get; set; }
            public class GetGatewayConfigResponseBodyDataEnableK8sSourceWorkloadFilter : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable tag filtering for Kubernetes service source workloads.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The tag filtering method. Valid values: EQUAL (matches the specified tag) and NOT_EQUAL (excludes the specified tag).</para>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("FilterOpt")]
                [Validation(Required=false)]
                public string FilterOpt { get; set; }

                /// <summary>
                /// <para>The tag key used to filter Kubernetes workloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("LabelKey")]
                [Validation(Required=false)]
                public string LabelKey { get; set; }

                /// <summary>
                /// <para>The tag value used to filter Kubernetes workloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public string LabelValue { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the PROXY protocol. If the gateway ingress traffic is routed through a Network Load Balancer (NLB) and this feature is disabled, the real IP address of the client cannot be obtained. Enabling this feature does not affect non-PROXY protocol requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// <para>Specifies whether to merge consecutive slashes in a request URL. For example, if this feature is enabled, the extra slash in <c>www.a.com//b</c> is merged, making it equivalent to <c>www.a.com/b</c>. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSlashMerge")]
            [Validation(Required=false)]
            public bool? EnableSlashMerge { get; set; }

            /// <summary>
            /// <para>Specifies whether WAF is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <para>The configuration for trusted X-Forwarded-For source CIDR blocks.</para>
            /// </summary>
            [NameInMap("EnableXffTrustedCidrs")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataEnableXffTrustedCidrs EnableXffTrustedCidrs { get; set; }
            public class GetGatewayConfigResponseBodyDataEnableXffTrustedCidrs : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable the configuration for trusted X-Forwarded-For source CIDR blocks.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The list of trusted source IP addresses or CIDR blocks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("IpListContent")]
                [Validation(Required=false)]
                public string IpListContent { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The initial connection-level window size negotiated between the gateway and the client when HTTP/2 is used. Unit: bytes. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("InitialConnectionWindowSize")]
            [Validation(Required=false)]
            public int? InitialConnectionWindowSize { get; set; }

            /// <summary>
            /// <para>The initial stream window size negotiated between the gateway and the client when HTTP/2 is used. Unit: bytes. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65535</para>
            /// </summary>
            [NameInMap("InitialStreamWindowSize")]
            [Validation(Required=false)]
            public int? InitialStreamWindowSize { get; set; }

            /// <summary>
            /// <para>The keep-alive time in the Keep-Alive response header. Unit: seconds. If this parameter is set to 0, the response header is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeepaliveHeaderTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveHeaderTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether lightweight metric collection is enabled.</para>
            /// </summary>
            [NameInMap("LiteMetrics")]
            [Validation(Required=false)]
            public bool? LiteMetrics { get; set; }

            /// <summary>
            /// <para>Not available for use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("LogFilterConfig")]
            [Validation(Required=false)]
            public string LogFilterConfig { get; set; }

            /// <summary>
            /// <para>The log collection configuration for request and response headers and bodies. The content is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;request&quot;:{&quot;headers&quot;:{&quot;enabled&quot;:true}}}</para>
            /// </summary>
            [NameInMap("LogRequestResponseConfig")]
            [Validation(Required=false)]
            public string LogRequestResponseConfig { get; set; }

            /// <summary>
            /// <para>The list of unsupported configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;EnableProxyProtocol,EnableCustomAuthConfigPush&quot;</para>
            /// </summary>
            [NameInMap("NoSupportedConfigList")]
            [Validation(Required=false)]
            public string NoSupportedConfigList { get; set; }

            /// <summary>
            /// <para>The action to take when a URI path contains escaped slashes such as %2F, %2f, %5C, or %5c. Default value: KEEP_UNCHANGED. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>KEEP_UNCHANGED</para>
            /// </description></item>
            /// <item><description><para>REJECT_REQUEST</para>
            /// </description></item>
            /// <item><description><para>UNESCAPE_AND_REDIRECT</para>
            /// </description></item>
            /// <item><description><para>UNESCAPE_AND_FORWARD</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_UNCHANGED</para>
            /// </summary>
            [NameInMap("PathWithEscapedSlashes")]
            [Validation(Required=false)]
            public string PathWithEscapedSlashes { get; set; }

            /// <summary>
            /// <para>Specifies whether to preserve the request ID passed by the client.</para>
            /// </summary>
            [NameInMap("PreserveExternalRequestID")]
            [Validation(Required=false)]
            public bool? PreserveExternalRequestID { get; set; }

            /// <summary>
            /// <para>Specifies whether to preserve the original case of request and response headers. In HTTP/1.1, headers are case-insensitive. To ensure compatibility with HTTP/2, headers are converted to lowercase by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreserveHeaderFormat")]
            [Validation(Required=false)]
            public bool? PreserveHeaderFormat { get; set; }

            /// <summary>
            /// <para>The log delivery information.</para>
            /// </summary>
            [NameInMap("SlsConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataSlsConfigDetails SlsConfigDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataSlsConfigDetails : TeaModel {
                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>Not available for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Not available for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Not available for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Specifies whether log delivery is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogOn")]
                [Validation(Required=false)]
                public bool? LogOn { get; set; }

                /// <summary>
                /// <para>The destination Logstore for log delivery. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>mse_gw_access_log: Nginx Ingress compatibility is disabled.</para>
                /// </description></item>
                /// <item><description><para>nginx-ingress: Nginx Ingress compatibility is enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mse_gw_access_log</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>Specifies whether Nginx Ingress compatibility is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NginxCompatible")]
                [Validation(Required=false)]
                public bool? NginxCompatible { get; set; }

                /// <summary>
                /// <para>The destination Simple Log Service project for log delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the gateway supports Web Application Firewall (WAF).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportWaf")]
            [Validation(Required=false)]
            public bool? SupportWaf { get; set; }

            /// <summary>
            /// <para>The default idle timeout period for upstream connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UpstreamIdleTimeout")]
            [Validation(Required=false)]
            public int? UpstreamIdleTimeout { get; set; }

            /// <summary>
            /// <para>The keep-alive time maintained for WebSocket connections when connections must be closed during gateway instance upgrades or restarts. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("WebsocketTermGracePeriod")]
            [Validation(Required=false)]
            public int? WebsocketTermGracePeriod { get; set; }

            /// <summary>
            /// <para>The number of trusted proxies in front of the gateway. This parameter affects whether the gateway uses request headers such as X-Forwarded-For and X-Request-ID generated by the client. This parameter takes effect at the request level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("XffTrustedNum")]
            [Validation(Required=false)]
            public int? XffTrustedNum { get; set; }

            /// <summary>
            /// <para>The Tracing Analysis information.</para>
            /// </summary>
            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataXtraceDetails : TeaModel {
                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The time when the Tracing Analysis information was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-12T09:39:07.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the Tracing Analysis information was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-12T09:39:07.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the Tracing Analysis information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The sampling rate (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                /// <summary>
                /// <para>The SkyWalking service ID for self-managed SkyWalking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>333</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>The SkyWalking service port for self-managed SkyWalking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8888</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public string ServicePort { get; set; }

                /// <summary>
                /// <para>Specifies whether Tracing Analysis is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

                /// <summary>
                /// <para>The Tracing Analysis type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>XTRACE: Managed Service for OpenTelemetry with the Zipkin Tracing Analysis protocol.</para>
                /// </description></item>
                /// <item><description><para>SKYWALKING: Self-managed SkyWalking.</para>
                /// </description></item>
                /// <item><description><para>OPENTELEMETRY: Managed Service for OpenTelemetry with the OpenTelemetry Tracing Analysis protocol.</para>
                /// </description></item>
                /// <item><description><para>OTSKYWALKING: Managed Service for OpenTelemetry with the SkyWalking Tracing Analysis protocol.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OPENTELEMETRY</para>
                /// </summary>
                [NameInMap("TraceType")]
                [Validation(Required=false)]
                public string TraceType { get; set; }

            }

            /// <summary>
            /// <para>The compression algorithm used when compression is enabled. Valid values: brotli and gzip. If this parameter is set and EnableGzip is disabled, EnableGzip is automatically enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;gzip&quot;]</para>
            /// </summary>
            [NameInMap("ZipAlgorithm")]
            [Validation(Required=false)]
            public string ZipAlgorithm { get; set; }

        }

        /// <summary>
        /// <para>This field is not used. Ignore this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>This field is not used. Ignore this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6092602-C357-4750-89D9-E572FBEA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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

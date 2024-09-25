// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayConfigResponseBodyData Data { get; set; }
        public class GetGatewayConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;requestMetadata&quot;:[],&quot;responseHeaders&quot;:[],&quot;requestHeaders&quot;:[&quot;x-test&quot;],&quot;responseMetadata&quot;:[]}</para>
            /// </summary>
            [NameInMap("AccessLogHeader")]
            [Validation(Required=false)]
            public string AccessLogHeader { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32768</para>
            /// </summary>
            [NameInMap("DownstreamConnectionBufferLimits")]
            [Validation(Required=false)]
            public int? DownstreamConnectionBufferLimits { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DownstreamHttp2MaxConcurrentStream")]
            [Validation(Required=false)]
            public int? DownstreamHttp2MaxConcurrentStream { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("DownstreamIdleTime")]
            [Validation(Required=false)]
            public int? DownstreamIdleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableCustomAuthConfigPush")]
            [Validation(Required=false)]
            public string EnableCustomAuthConfigPush { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableGenerateRequestId")]
            [Validation(Required=false)]
            public bool? EnableGenerateRequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableGzip")]
            [Validation(Required=false)]
            public bool? EnableGzip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableHardwareAccelerate")]
            [Validation(Required=false)]
            public bool? EnableHardwareAccelerate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableHttp2")]
            [Validation(Required=false)]
            public bool? EnableHttp2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableHttp3")]
            [Validation(Required=false)]
            public bool? EnableHttp3 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSlashMerge")]
            [Validation(Required=false)]
            public bool? EnableSlashMerge { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("InitialConnectionWindowSize")]
            [Validation(Required=false)]
            public int? InitialConnectionWindowSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65535</para>
            /// </summary>
            [NameInMap("InitialStreamWindowSize")]
            [Validation(Required=false)]
            public int? InitialStreamWindowSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeepaliveHeaderTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveHeaderTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("LogFilterConfig")]
            [Validation(Required=false)]
            public string LogFilterConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;EnableProxyProtocol,EnableCustomAuthConfigPush&quot;</para>
            /// </summary>
            [NameInMap("NoSupportedConfigList")]
            [Validation(Required=false)]
            public string NoSupportedConfigList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>KEEP_UNCHANGED</para>
            /// </summary>
            [NameInMap("PathWithEscapedSlashes")]
            [Validation(Required=false)]
            public string PathWithEscapedSlashes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreserveHeaderFormat")]
            [Validation(Required=false)]
            public bool? PreserveHeaderFormat { get; set; }

            [NameInMap("SlsConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataSlsConfigDetails SlsConfigDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataSlsConfigDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogOn")]
                [Validation(Required=false)]
                public bool? LogOn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mse_gw_access_log</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NginxCompatible")]
                [Validation(Required=false)]
                public bool? NginxCompatible { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportWaf")]
            [Validation(Required=false)]
            public bool? SupportWaf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UpstreamIdleTimeout")]
            [Validation(Required=false)]
            public int? UpstreamIdleTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("WebsocketTermGracePeriod")]
            [Validation(Required=false)]
            public int? WebsocketTermGracePeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("XffTrustedNum")]
            [Validation(Required=false)]
            public int? XffTrustedNum { get; set; }

            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataXtraceDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-61f465fa2dd044069e2208c4912*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-12T09:39:07.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-12T09:39:07.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>333</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8888</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public string ServicePort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPENTELEMETRY</para>
                /// </summary>
                [NameInMap("TraceType")]
                [Validation(Required=false)]
                public string TraceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;gzip&quot;]</para>
            /// </summary>
            [NameInMap("ZipAlgorithm")]
            [Validation(Required=false)]
            public string ZipAlgorithm { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F6092602-C357-4750-89D9-E572FBEA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

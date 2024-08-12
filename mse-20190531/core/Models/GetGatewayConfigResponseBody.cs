// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayConfigResponseBodyData Data { get; set; }
        public class GetGatewayConfigResponseBodyData : TeaModel {
            [NameInMap("AccessLogHeader")]
            [Validation(Required=false)]
            public string AccessLogHeader { get; set; }

            [NameInMap("DownstreamConnectionBufferLimits")]
            [Validation(Required=false)]
            public int? DownstreamConnectionBufferLimits { get; set; }

            [NameInMap("DownstreamHttp2MaxConcurrentStream")]
            [Validation(Required=false)]
            public int? DownstreamHttp2MaxConcurrentStream { get; set; }

            [NameInMap("DownstreamIdleTime")]
            [Validation(Required=false)]
            public int? DownstreamIdleTime { get; set; }

            [NameInMap("EnableCustomAuthConfigPush")]
            [Validation(Required=false)]
            public string EnableCustomAuthConfigPush { get; set; }

            [NameInMap("EnableGenerateRequestId")]
            [Validation(Required=false)]
            public bool? EnableGenerateRequestId { get; set; }

            [NameInMap("EnableGzip")]
            [Validation(Required=false)]
            public bool? EnableGzip { get; set; }

            [NameInMap("EnableHardwareAccelerate")]
            [Validation(Required=false)]
            public bool? EnableHardwareAccelerate { get; set; }

            [NameInMap("EnableHttp2")]
            [Validation(Required=false)]
            public bool? EnableHttp2 { get; set; }

            [NameInMap("EnableHttp3")]
            [Validation(Required=false)]
            public bool? EnableHttp3 { get; set; }

            [NameInMap("EnableProxyProtocol")]
            [Validation(Required=false)]
            public bool? EnableProxyProtocol { get; set; }

            [NameInMap("EnableSlashMerge")]
            [Validation(Required=false)]
            public bool? EnableSlashMerge { get; set; }

            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            [NameInMap("InitialConnectionWindowSize")]
            [Validation(Required=false)]
            public int? InitialConnectionWindowSize { get; set; }

            [NameInMap("InitialStreamWindowSize")]
            [Validation(Required=false)]
            public int? InitialStreamWindowSize { get; set; }

            [NameInMap("KeepaliveHeaderTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveHeaderTimeout { get; set; }

            [NameInMap("LogFilterConfig")]
            [Validation(Required=false)]
            public string LogFilterConfig { get; set; }

            [NameInMap("NoSupportedConfigList")]
            [Validation(Required=false)]
            public string NoSupportedConfigList { get; set; }

            [NameInMap("PathWithEscapedSlashes")]
            [Validation(Required=false)]
            public string PathWithEscapedSlashes { get; set; }

            [NameInMap("PreserveHeaderFormat")]
            [Validation(Required=false)]
            public bool? PreserveHeaderFormat { get; set; }

            [NameInMap("SlsConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataSlsConfigDetails SlsConfigDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataSlsConfigDetails : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LogOn")]
                [Validation(Required=false)]
                public bool? LogOn { get; set; }

                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                [NameInMap("NginxCompatible")]
                [Validation(Required=false)]
                public bool? NginxCompatible { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("SupportWaf")]
            [Validation(Required=false)]
            public bool? SupportWaf { get; set; }

            [NameInMap("UpstreamIdleTimeout")]
            [Validation(Required=false)]
            public int? UpstreamIdleTimeout { get; set; }

            [NameInMap("WebsocketTermGracePeriod")]
            [Validation(Required=false)]
            public int? WebsocketTermGracePeriod { get; set; }

            [NameInMap("XffTrustedNum")]
            [Validation(Required=false)]
            public int? XffTrustedNum { get; set; }

            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayConfigResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayConfigResponseBodyDataXtraceDetails : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public string ServicePort { get; set; }

                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

                [NameInMap("TraceType")]
                [Validation(Required=false)]
                public string TraceType { get; set; }

            }

            [NameInMap("ZipAlgorithm")]
            [Validation(Required=false)]
            public string ZipAlgorithm { get; set; }

        }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

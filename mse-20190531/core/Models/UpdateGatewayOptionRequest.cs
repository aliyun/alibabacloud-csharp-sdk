// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayOptionRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// The detailed configurations of the gateway.
        /// 
        /// *   **TraceDetails**: the sampling description of Tracing Analysis. Content: TraceEnabled specifies whether to activate Tracing Analysis. Sample specifies the sampling rate of Tracing Analysis.
        /// *   **LogConfigDetails**: the description of Log Service. Content: LogEnabled specifies whether to activate Log Service. ProjectName specifies the Log Service project to which logs are delivered. LogStoreName specifies the name of the Logstore.
        /// *   **EnableHardwareAcceleration**: specifies whether to enable hardware acceleration.
        /// *   **DisableHttp2Alpn**: specifies whether to disable the HTTP/2 protocol.
        /// *   **EnableWaf**: specifies whether to activate Web Application Firewall (WAF).
        /// </summary>
        [NameInMap("GatewayOption")]
        [Validation(Required=false)]
        public GatewayOption GatewayOption { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}

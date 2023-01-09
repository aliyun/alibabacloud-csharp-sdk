// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayOptionResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The value 200 indicates that the request is successfully processed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The detailed configurations of the gateway.
        /// 
        /// *   **TraceDetails**: the sampling description of Tracing Analysis. Content: TraceEnabled indicates whether Tracing Analysis is activated. Sample indicates the sampling rate of Tracing Analysis.
        /// *   **LogConfigDetails**: the description of Log Service. Content: LogEnabled indicates whether Log Service is activated. ProjectName indicates the Log Service project to which logs are delivered. LogStoreName indicates the name of the Logstore.
        /// *   **EnableHardwareAcceleration**: indicates whether hardware acceleration is enabled.
        /// *   **DisableHttp2Alpn**: indicates whether the HTTP/2 protocol is disabled.
        /// *   **EnableWaf**: indicates whether Web Application Firewall (WAF) is enabled.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GatewayOption Data { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// 
        /// *   If the request is successful, a success message is returned.
        /// *   If the request fails, an error message is returned, such as the "TaskId not found" message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

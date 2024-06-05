// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerLogConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to record custom headers in the access log. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// > You can set this parameter to **true** only if the access log feature is enabled by specifying **AccessLogEnabled**.
        /// </summary>
        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        /// <summary>
        /// The configuration information about the Xtrace feature.
        /// </summary>
        [NameInMap("AccessLogTracingConfig")]
        [Validation(Required=false)]
        public UpdateListenerLogConfigRequestAccessLogTracingConfig AccessLogTracingConfig { get; set; }
        public class UpdateListenerLogConfigRequestAccessLogTracingConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable the Xtrace feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > You can set this parameter to **true** only if the access log feature is enabled by specifying **AccessLogEnabled**.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TracingEnabled")]
            [Validation(Required=false)]
            public bool? TracingEnabled { get; set; }

            /// <summary>
            /// The sampling rate of the Xtrace feature.
            /// 
            /// Valid values: **1 to 10000**.
            /// 
            /// > This parameter takes effect only if you set **TracingEnabled** to **true**.
            /// </summary>
            [NameInMap("TracingSample")]
            [Validation(Required=false)]
            public int? TracingSample { get; set; }

            /// <summary>
            /// The type of Xtrace. Set the value to **Zipkin**.
            /// 
            /// > This parameter takes effect only if you set **TracingEnabled** to **true**.
            /// </summary>
            [NameInMap("TracingType")]
            [Validation(Required=false)]
            public string TracingType { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: (default): performs a dry run and performs the actual request. If the request passes the dry run, a **2xx HTTP** status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the Application Load Balancer (ALB) listener.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}

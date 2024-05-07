// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateIntegrationResponseBody : TeaModel {
        /// <summary>
        /// The returned information about the alert integration.
        /// </summary>
        [NameInMap("Integration")]
        [Validation(Required=false)]
        public CreateIntegrationResponseBodyIntegration Integration { get; set; }
        public class CreateIntegrationResponseBodyIntegration : TeaModel {
            /// <summary>
            /// Indicates whether alert events are automatically cleared. Default value: true. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("AutoRecover")]
            [Validation(Required=false)]
            public bool? AutoRecover { get; set; }

            /// <summary>
            /// The description of the alert integration.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the alert integration.
            /// </summary>
            [NameInMap("IntegrationId")]
            [Validation(Required=false)]
            public long? IntegrationId { get; set; }

            /// <summary>
            /// The name of the alert integration.
            /// </summary>
            [NameInMap("IntegrationName")]
            [Validation(Required=false)]
            public string IntegrationName { get; set; }

            /// <summary>
            /// The service of the alert integration. Valid values:
            /// 
            /// *   CLOUD_MONITOR: CloudMonitor
            /// *   LOG_SERVICE: Log Service
            /// </summary>
            [NameInMap("IntegrationProductType")]
            [Validation(Required=false)]
            public string IntegrationProductType { get; set; }

            /// <summary>
            /// The period of time within which alert events are automatically cleared. Unit: seconds. Default value: 300.
            /// </summary>
            [NameInMap("RecoverTime")]
            [Validation(Required=false)]
            public long? RecoverTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

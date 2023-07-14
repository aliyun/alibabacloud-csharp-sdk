// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateIntegrationResponseBody : TeaModel {
        /// <summary>
        /// The Information about the alert integration.
        /// </summary>
        [NameInMap("Integration")]
        [Validation(Required=false)]
        public UpdateIntegrationResponseBodyIntegration Integration { get; set; }
        public class UpdateIntegrationResponseBodyIntegration : TeaModel {
            /// <summary>
            /// The endpoint of the alert integration.
            /// </summary>
            [NameInMap("ApiEndpoint")]
            [Validation(Required=false)]
            public string ApiEndpoint { get; set; }

            /// <summary>
            /// Indicates whether alert events are automatically cleared. Valid values:
            /// 
            /// *   true (default)
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
            /// The fields whose values are deduplicated.
            /// </summary>
            [NameInMap("DuplicateKey")]
            [Validation(Required=false)]
            public string DuplicateKey { get; set; }

            /// <summary>
            /// The extended mapped fields of the alert source.
            /// </summary>
            [NameInMap("ExtendedFieldRedefineRules")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendedFieldRedefineRules { get; set; }

            /// <summary>
            /// The predefined mapped fields of the alert source.
            /// </summary>
            [NameInMap("FieldRedefineRules")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> FieldRedefineRules { get; set; }

            /// <summary>
            /// The field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
            /// 
            /// > Only Log Service supports this parameter.
            /// </summary>
            [NameInMap("InitiativeRecoverField")]
            [Validation(Required=false)]
            public string InitiativeRecoverField { get; set; }

            /// <summary>
            /// The value of the field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
            /// 
            /// > Only Log Service supports this parameter.
            /// </summary>
            [NameInMap("InitiativeRecoverValue")]
            [Validation(Required=false)]
            public string InitiativeRecoverValue { get; set; }

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
            /// The activity of the alert integration
            /// </summary>
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }

            /// <summary>
            /// The time when alert events are automatically cleared. Unit: seconds. Default value: 300.
            /// </summary>
            [NameInMap("RecoverTime")]
            [Validation(Required=false)]
            public long? RecoverTime { get; set; }

            /// <summary>
            /// The authentication token of the alert integration.
            /// </summary>
            [NameInMap("ShortToken")]
            [Validation(Required=false)]
            public string ShortToken { get; set; }

            /// <summary>
            /// The total number of alert events and the number of abnormal alert events in the last hour.
            /// </summary>
            [NameInMap("Stat")]
            [Validation(Required=false)]
            public List<long?> Stat { get; set; }

            /// <summary>
            /// Indicates whether the alert integration is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public bool? State { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

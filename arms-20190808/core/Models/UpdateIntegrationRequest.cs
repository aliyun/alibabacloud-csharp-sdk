// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateIntegrationRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically clear alert events. Valid values:
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
        /// The extended mapped fields are mapped to the fields of ARMS alerts. For more information, see the description of the ExtendedFieldRedefineRules parameter.
        /// </summary>
        [NameInMap("ExtendedFieldRedefineRules")]
        [Validation(Required=false)]
        public string ExtendedFieldRedefineRules { get; set; }

        /// <summary>
        /// The predefined mapped fields are mapped to the fields of ARMS alerts. The predefined mapped fields were generated when the alert integration was created. For more information, see the description of the FieldRedefineRules parameter.
        /// </summary>
        [NameInMap("FieldRedefineRules")]
        [Validation(Required=false)]
        public string FieldRedefineRules { get; set; }

        /// <summary>
        /// The field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
        /// 
        /// > Only the Log Service alert integration supports the parameter.
        /// </summary>
        [NameInMap("InitiativeRecoverField")]
        [Validation(Required=false)]
        public string InitiativeRecoverField { get; set; }

        /// <summary>
        /// The value of the field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
        /// 
        /// > Only the Log Service alert integration supports the parameter.
        /// </summary>
        [NameInMap("InitiativeRecoverValue")]
        [Validation(Required=false)]
        public string InitiativeRecoverValue { get; set; }

        /// <summary>
        /// The ID of the alert integration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntegrationId")]
        [Validation(Required=false)]
        public long? IntegrationId { get; set; }

        /// <summary>
        /// The name of the alert integration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntegrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// The service of the alert integration. Valid values:
        /// 
        /// *   CLOUD_MONITOR: CloudMonitor
        /// *   LOG_SERVICE: Log Service
        /// 
        /// This parameter is required.
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
        /// The period of time within which alert events are automatically cleared. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("RecoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// The total number of alert events and the number of abnormal alert events in the last hour.
        /// </summary>
        [NameInMap("Stat")]
        [Validation(Required=false)]
        public string Stat { get; set; }

        /// <summary>
        /// Indicates whether the alert integration was enabled. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public bool? State { get; set; }

    }

}

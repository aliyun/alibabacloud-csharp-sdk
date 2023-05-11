// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateRuleActionRequest : TeaModel {
        /// <summary>
        /// The configurations of the rule action. You must specify a JSON string. The configurations vary based on the types of rule actions. For more information about required syntax and examples, see the following tables.
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// Specifies whether the rule action forwards error operation data. Error operation data is generated when the rules engine failed to forward data from the IoT Platform topic to the destination cloud service. A data forwarding failure indicates that forwarding retries also fail. Valid values:
        /// 
        /// *   **true**: forwards error operation data.
        /// *   **false**: forwards normal data instead of error operation data.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("ErrorActionFlag")]
        [Validation(Required=false)]
        public bool? ErrorActionFlag { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the rule for which you want to create an action. You can log on to the IoT Platform console, and choose **Rules** > **Data Forwarding** to view the rule ID. You can also call the [ListRule](~~69486~~) operation and view the rule ID in the response.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The type of the rule action. Valid values:
        /// 
        /// *   **REPUBLISH**: forwards topic data that is processed by the rules engine to another IoT Platform topic.
        /// *   **AMQP**: forwards data to an AMQP consumer group.
        /// *   **MNS**: forwards data that is processed by the rules engine to Message Service (MNS).
        /// *   **FC**: forwards topic data that is processed by the rules engine to Function Compute for event computing.
        /// *   **OTS**: forwards data that is processed by the rules engine to OTS for NoSQL data storage.
        /// 
        /// >  If you set the **DataType** parameter to **BINARY**, rules are created in the binary format. These rules cannot be used to forward data to Tablestore.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

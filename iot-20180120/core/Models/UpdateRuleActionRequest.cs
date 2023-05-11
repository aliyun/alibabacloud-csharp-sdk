// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateRuleActionRequest : TeaModel {
        /// <summary>
        /// The ID of the rule action to be modified.
        /// 
        /// After you call the [CreateRuleAction](~~69586~~) operation to create a rule action, the rule action ID is returned. You can call the [ListRuleActions](~~69517~~) operation to view the rule action ID.
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public long? ActionId { get; set; }

        /// <summary>
        /// The configurations of the rule action. The configurations for different rule action types are different. For more information about the configurations for different rule action types, see [CreateRuleAction](~~69586~~).
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

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
        /// The type of the rule action. Valid values:
        /// 
        /// *   **MNS**: forwards topic data that is processed by the rules engine to MNS.
        /// *   **FC**: forwards topic data that is processed by the rules engine to Function Compute for event computing.
        /// *   **REPUBLISH**: forwards topic data that is processed by the rules engine to another IoT Platform topic.
        /// *   **AMQP**: forwards data to an AMQP consumer group.
        /// *   **OTS**: forwards topic data that is processed by the rules engine to Tablestore for NoSQL data storage.
        /// 
        /// > *   If you set the **DataType** parameter to **BINARY**, rules are created in the binary format. These rules cannot be used to forward data to Tablestore.
        /// >*   Destination Alibaba Cloud services that are supported by the rules engine vary based on regions. For more information about the regions and destination cloud services that are supported by the rules engine, see [Regions and zones](~~85669~~).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

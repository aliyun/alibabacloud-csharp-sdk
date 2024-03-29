// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateTriggerRequest : TeaModel {
        /// <summary>
        /// The description of the trigger.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The role that is used by the event source such as Object Storage Service (OSS) to invoke the function. For more information, see [Overview](~~53102~~).
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// The version or alias of the service.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the event source for the trigger.
        /// </summary>
        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// The configurations of the trigger. The configurations vary based on the trigger type. For more information about the format, see the following topics:
        /// 
        /// *   Object Storage Service (OSS) trigger: [OSSTriggerConfig](~~415697~~).
        /// *   Simple Log Service trigger: [LogTriggerConfig](~~415694~~).
        /// *   Time trigger: [TimeTriggerConfig](~~415712~~).
        /// *   HTTP trigger: [HTTPTriggerConfig](~~415685~~).
        /// *   Tablestore trigger: Specify the **SourceArn** parameter and leave this parameter empty.
        /// *   Alibaba Cloud CDN event trigger: [CDNEventsTriggerConfig](~~415674~~).
        /// *   Message Service (MNS) topic trigger: [MnsTopicTriggerConfig](~~415695~~).
        /// *   EventBridge triggers: [EventBridgeTriggerConfig](~~2508622~~).
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// The name of the trigger. The name contains only letters, digits, hyphens (-), and underscores (\_). The name must be 1 to 128 characters in length and cannot start with a digit or hyphen (-).
        /// </summary>
        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The type of the trigger. Valid values:
        /// 
        /// *   **oss**: OSS event trigger. For more information, see [Overview](~~62922~~).
        /// *   **log**: Simple Log Service trigger. For more information, see [Overview](~~84386~~).
        /// *   **timer**: time trigger. For more information, see [Overview](~~68172~~).
        /// *   **http**: HTTP trigger. For more information, see [Overview](~~71229~~).
        /// *   **tablestore**: Tablestore trigger. For more information, see [Overview](~~100092~~).
        /// *   **cdn_events**: CDN event trigger. For more information, see [Overview](~~73333~~).
        /// *   **mns_topic**: MNS topic trigger. For more information, see [Overview](~~97032~~).
        /// *   **eventbridge**: EventBridge triggers.
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}

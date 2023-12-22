// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateTriggerRequest : TeaModel {
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
        /// The configurations of the trigger. The configurations vary based on the trigger type. For more information about the format, see the following topics:
        /// 
        /// *   Object Storage Service (OSS) trigger: [OSSTriggerConfig](~~415697~~).
        /// *   Simple Log Service trigger: [LogTriggerConfig](~~415694~~).
        /// *   Time trigger: [TimeTriggerConfig](~~415712~~).
        /// *   HTTP trigger: [HTTPTriggerConfig](~~415685~~).
        /// *   Tablestore trigger: Specify the **SourceArn** parameter and leave this parameter empty.
        /// *   Alibaba Cloud CDN event trigger: [CDNEventsTriggerConfig](~~415674~~).
        /// *   MNS topic trigger: [MnsTopicTriggerConfig](~~415695~~).
        /// *   EventBridge triggers: [EventBridgeTriggerConfig](~~2508622~~).
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

    }

}

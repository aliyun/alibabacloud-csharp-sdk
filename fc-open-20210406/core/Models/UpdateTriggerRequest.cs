// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateTriggerRequest : TeaModel {
        /// <summary>
        /// The ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The version or alias of the service.
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// The configurations of the trigger. The configurations vary based on the trigger type. For more information about the format, see the following topics:
        /// 
        /// *   OSS trigger: [OSSTriggerConfig](~~struct:OSSTriggerConfig~~).
        /// *   Log Service trigger: [LogTriggerConfig](~~struct:LogTriggerConfig~~).
        /// *   Time trigger: [TimeTriggerConfig](~~struct:TimeTriggerConfig~~).
        /// *   HTTP trigger: [HTTPTriggerConfig](~~struct:HTTPTriggerConfig~~).
        /// *   Tablestore trigger: Specify the **SourceArn** parameter and leave this parameter empty.
        /// *   Alibaba Cloud CDN event trigger: [CDNEventsTriggerConfig](~~struct:CDNEventsTriggerConfig~~).
        /// *   MNS topic trigger: [MnsTopicTriggerConfig](~~struct:MnsTopicTriggerConfig~~).
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// The description of the trigger.
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

    }

}

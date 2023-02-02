// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicCreateRequest : TeaModel {
        /// <summary>
        /// The ID of the instance in which you want to create the topic.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the message. Valid values:
        /// 
        /// *   **0**: normal messages
        /// *   **1**: partitionally ordered messages
        /// *   **2**: globally ordered messages
        /// *   **4**: transactional messages
        /// *   **5**: scheduled or delayed messages
        /// 
        /// For more information about message types, see [Message types](~~155952~~).
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public int? MessageType { get; set; }

        /// <summary>
        /// The description of the topic that you want to create.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The name of the topic that you want to create. The name must meet the following rules:
        /// 
        /// *   The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
        /// *   The topic name cannot start with CID or GID because CID and GID are reserved prefixes for group IDs.
        /// *   If the Message Queue for Apache RocketMQ instance in which you want to create the topic uses a namespace, the topic name must be unique in the instance. The topic name cannot be the same as an existing topic name or a group ID in the instance. The topic name can be the same as a topic name or a group ID in another instance that uses a different namespace. For example, if Instance A and Instance B use different namespaces, a topic name in Instance A can be the same as a topic name or a group ID in Instance B.
        /// *   If the instance in which you want to create the topic does not use a namespace, the topic name must be globally unique across instances and regions. The topic name cannot be the same as an existing topic name or group ID in Message Queue for Apache RocketMQ instances that belong to your Alibaba Cloud account.
        /// 
        /// >  To check whether an instance uses a namespace, log on to the Message Queue for Apache RocketMQ console, go to the **Instance Details** page, and then view the value of the Namespace field in the **Basic Information** section.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

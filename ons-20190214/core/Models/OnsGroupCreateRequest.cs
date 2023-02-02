// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupCreateRequest : TeaModel {
        /// <summary>
        /// The ID of the consumer group that you want to create. Specify the group ID based on the following rules:
        /// 
        /// *   The group ID must be 2 to 64 characters in length and can contain only letters, digits, hyphens (-), and underscores (\_).
        /// *   If the Message Queue for Apache RocketMQ instance in which you want to create the consumer group uses a namespace, the group ID must be unique in the instance. The group ID cannot be the same as an existing group ID or a topic name in the instance. The group ID can be the same as a group ID or a topic name in another instance that uses a different namespace. For example, if Instance A and Instance B use different namespaces, a group ID in Instance A can be the same as a group ID or a topic name in Instance B.
        /// *   If the instance does not use a namespace, the group ID must be globally unique across instances and regions. The group ID cannot be the same as an existing group ID or topic name in Message Queue for Apache RocketMQ instances that belong to your Alibaba Cloud account.
        /// 
        /// > 
        /// 
        /// *   After the consumer group is created, the group ID cannot be changed.
        /// 
        /// *   To check whether an instance uses a namespace, log on to the Message Queue for Apache RocketMQ console, go to the **Instance Details** page, and then view the value of the Namespace field in the **Basic Information** section.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The protocol over which clients in the consumer group communicate with the Message Queue for Apache RocketMQ broker. All clients in a consumer group communicate with the Message Queue for Apache RocketMQ broker over the same protocol. You must create different groups for TCP clients and HTTP clients. Valid values:
        /// 
        /// *   **tcp**: Clients in the consumer group consume messages over TCP. This is the default value.
        /// *   **http**: Clients in the consumer group consume messages over HTTP.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the instance in which you want to create the consumer group.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The description of the consumer group.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

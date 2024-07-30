// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// The log cleanup policy that is used for the topic. This parameter is available only when LocalTopic is set to true. Valid values:
        /// 
        /// *   false: The topic uses the default log cleanup policy.
        /// *   true: The topic uses the log compaction policy.
        /// </summary>
        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        /// <summary>
        /// The additional configurations.
        /// 
        /// *   The value must be in JSON format.
        /// *   Set Key to **replications**. This value specifies the number of replicas of the topic. The value must be an integer that ranges from 1 to 3.
        /// *   You can configure this parameter only if you set **LocalTopic** to **true** or specify **Open Source Edition (Local Disk)** as the instance edition.****
        /// 
        /// >  If you specify replications in this parameter, **ReplicationFactor** does not take effect.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of storage that the topic uses. Valid values:
        /// 
        /// *   false: The topic uses cloud storage.
        /// *   true: The topic uses local storage.
        /// </summary>
        [NameInMap("LocalTopic")]
        [Validation(Required=false)]
        public bool? LocalTopic { get; set; }

        /// <summary>
        /// The minimum number of in-sync replicas (ISRs).
        /// 
        /// *   This parameter is available only when **LocalTopic** is set to **true**, or the instance is of the **Open Source Edition (Local Disk)**.****
        /// *   The value of this parameter must be smaller than the value of ReplicationFactor.
        /// *   Valid values: 1 to 3.
        /// </summary>
        [NameInMap("MinInsyncReplicas")]
        [Validation(Required=false)]
        public long? MinInsyncReplicas { get; set; }

        /// <summary>
        /// The number of partitions in the topic.
        /// 
        /// *   Valid values: 1 to 360.
        /// *   In the ApsaraMQ for Kafka console, you can view the number of partitions that the system recommends based on the specifications of the instance. We recommend that you specify the number that is recommended by the system as the value of this parameter to reduce the risk of data skew.
        /// 
        /// Default values:
        /// 
        /// *   ApsaraMQ for Kafka V2 instance: 12
        /// *   ApsaraMQ for Kafka V3 instance: 3
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public string PartitionNum { get; set; }

        /// <summary>
        /// The region ID of the instance in which you want to create a topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The description of the topic.
        /// 
        /// *   The description can contain only letters, digits, hyphens (-), and underscores (_).
        /// *   The description must be 3 to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The number of replicas for the topic.
        /// 
        /// *   This parameter is available only when **LocalTopic** is set to **true**, or the instance is of the **Open Source Edition (Local Disk)**.****
        /// *   Valid values: 1 to 3.
        /// 
        /// > If you set this parameter to **1**, data loss may occur. Exercise caution when you configure this parameter.
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public long? ReplicationFactor { get; set; }

        /// <summary>
        /// The tags that you want to add to the topic.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// *   If you do not specify this parameter, the keys of all tags are matched.
            /// *   The tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `aliyun` or `acs:`.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// *   You can leave this parameter empty.
            /// *   The tag value must be 1 to 128 characters in length and cannot contain http:// or https://. The tag value cannot start with aliyun or acs:.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The topic name.
        /// 
        /// *   The name can contain only letters, digits, hyphens (-), and underscores (_).
        /// *   The name must be 3 to 64 characters in length. If the name that you specify contains more than 64 characters, the system automatically truncates the name.
        /// *   After a topic is created, you cannot change the name of the topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

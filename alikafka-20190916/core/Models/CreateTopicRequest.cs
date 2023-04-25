// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// The number of replicas for the topic.
        /// 
        /// *   This parameter is available only when the **LocalTopic** parameter is set to **true**\<props="local_disk">, or the **edition of the instance** is **Open Source Edition (Local Disk)**.
        /// *   Valid values: 1 to 3.
        /// 
        /// > If you set this parameter to **1**, the risk of data loss increases. Exercise caution when you configure this parameter.
        /// </summary>
        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        /// <summary>
        /// The status code returned. The status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The region ID of the instance in which you want to create a topic.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Additional configurations.
        /// 
        /// *   The value of this parameter must be in JSON format.
        /// *   The key must be **replications**. The value specifies the number of replicas for the topic. The value must be an integer that ranges from 1 to 3.
        /// *   This parameter is available only when the **LocalTopic** parameter is set to **true**\<props="local_disk">, or the **edition of the instance** is **Open Source Edition (Local Disk)**.
        /// 
        /// > If you configure this parameter, the **ReplicationFactor** parameter does not take effect.
        /// </summary>
        [NameInMap("LocalTopic")]
        [Validation(Required=false)]
        public bool? LocalTopic { get; set; }

        /// <summary>
        /// The value of tag N to add to the resource.
        /// 
        /// *   Valid values of N: 1 to 20.
        /// *   This parameter can be left empty.
        /// *   A tag value can be 1 to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
        /// </summary>
        [NameInMap("MinInsyncReplicas")]
        [Validation(Required=false)]
        public long? MinInsyncReplicas { get; set; }

        /// <summary>
        /// The minimum number of in-sync replicas (ISRs).
        /// 
        /// *   This parameter is available only when the **LocalTopic** parameter is set to **true**\<props="local_disk">, or the **edition of the instance** is **Open Source Edition (Local Disk)**.
        /// *   The value of this parameter must be smaller than the value of the ReplicationFactor parameter.
        /// *   Valid values: 1 to 3.
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public string PartitionNum { get; set; }

        /// <summary>
        /// Specifies whether the topic uses local storage. Valid values:
        /// 
        /// *   false: The topic uses cloud storage.
        /// *   true: The topic uses local storage.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of partitions in the topic.
        /// 
        /// *   Valid values: 1 to 360.
        /// *   In the Message Queue for Apache Kafka console, you can view the number of partitions that the system recommends based on the specification of the instance. We recommend that you specify the number that is recommended by the system as the value of this parameter to reduce the risk of data skew.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The key of tag N to add to the resource.
        /// 
        /// *   Valid values of N: 1 to 20.
        /// *   If this parameter is left empty, the keys of all tags are matched.
        /// *   A tag key can be up to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public long? ReplicationFactor { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The log cleanup policy that is used for the topic. This parameter is available only when the LocalTopic parameter is set to true. Valid values:
        /// 
        /// *   false: The topic uses the delete policy.
        /// *   true: The topic uses the compact policy.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

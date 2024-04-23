// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateTopicConfigRequest : TeaModel {
        /// <summary>
        /// The key of the topic configuration.
        /// 
        /// *   ApsaraMQ for Kafka V2 instances allow you to modify configurations only for topics that use local storage.
        /// *   ApsaraMQ for Kafka V3 instances allow you to modify configurations for all topics.
        /// *   The following keys are supported by `local topic` of ApsaraMQ for Kafka V2 instances: retention.ms, retention.bytes, and replications.
        /// *   The following keys are supported by ApsaraMQ for Kafka V3 instances: retention.hours and max.message.bytes.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The topic name.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// The value of the topic configuration.
        /// 
        /// *   `retention.hours` specifies the message retention period. Value type: string. Valid values: 24 to 8760.
        /// *   `max.message.bytes` specifies the maximum size of a sent message. Value type: string. Valid values: 1048576 to 10485760.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

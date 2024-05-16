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
        /// 
        /// This parameter is required.
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
        /// The ID of the region where the instance resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The topic name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// The configuration item that you want to update for the topic. The following configuration items are supported by ApsaraMQ for Kafka V3 instances:
        /// 
        /// *   `retention.hours` specifies the message retention period. Value type: string. Valid values: 24 to 8760.
        /// *   `max.message.bytes` specifies the maximum size of a sent message. Value type: string. Valid values: 1048576 to 10485760.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

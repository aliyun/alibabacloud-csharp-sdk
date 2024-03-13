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
        /// *   Valid values: retention.hours, max.message.bytes, and replications.
        /// *   retention.hours specifies the message retention period.
        /// *   max.message.bytes specifies the maximum size of a sent message.
        /// *   replications specifies the number of topic replicas.
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
        /// *   retention.hours specifies the message retention period. The value is a string. Valid values: 24 to 8760.
        /// *   max.message.bytes specifies the maximum size of a sent message. The value is a string. Valid values: 1048576 to 10485760.
        /// *   replications specifies the number of topic replicas. The value is a string. Valid values: 1 to 3.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

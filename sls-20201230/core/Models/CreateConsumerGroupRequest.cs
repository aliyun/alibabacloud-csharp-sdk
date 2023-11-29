// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// The name of the consumer group. The name must be unique in a project.
        /// </summary>
        [NameInMap("consumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Specifies whether to consume data in sequence. Valid values:
        /// 
        /// *   true
        /// 
        ///     *   In a shard, data is consumed in ascending order based on the value of the \*\*\__tag\_\_:\__receive_time\_\_\*\* field.
        ///     *   If a shard is split, data in the original shard is consumed first. Then, data in the new shards is consumed at the same time.
        ///     *   If shards are merged, data in the original shards is consumed first. Then, data in the new shard is consumed.
        /// 
        /// *   false Data in all shards is consumed at the same time. If a new shard is generated after a shard is split or after shards are merged, data in the new shard is immediately consumed.
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public bool? Order { get; set; }

        /// <summary>
        /// The timeout period. If the server does not receive heartbeats from a consumer within the timeout period, the server deletes the consumer. Unit: seconds.
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}

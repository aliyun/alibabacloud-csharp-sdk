// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceHARequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the data shard. You can call the [DescribeRoleZoneInfo](https://help.aliyun.com/document_detail/190794.html) operation to obtain the value of the CustinsId parameter. Separate multiple data shard IDs with commas (,). `all` indicates that all data shards are specified.
        /// 
        /// > This parameter is available and required only for read/write splitting and cluster instances.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The time when to perform the switchover. Default value: 0. Valid values:
        /// 
        /// *   **0**: immediately performs the switchover.
        /// *   **1**: performs the switchover during the maintenance window.
        /// 
        /// > You can call the [ModifyInstanceMaintainTime](https://help.aliyun.com/document_detail/61000.html) operation to modify the maintenance window of an ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public int? SwitchMode { get; set; }

        /// <summary>
        /// The switching mode. Valid values:
        /// 
        /// *   **AvailablePriority**: prioritizes the availability and performs a switchover immediately without considering the latency of data synchronization between the master and replica nodes. This may cause data loss.
        /// *   **ReliabilityPriority**: prioritizes the reliability and performs a switchover after no latency of data synchronization between the master and replica nodes exists. This ensures data integrity. This mode may cause a switchover failure in scenarios that involve a large volume of data writes and persistent latency of data synchronization.
        /// 
        /// > You must evaluate the requirements for data and services based on your business scenarios and then select a switching mode.
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

    }

}

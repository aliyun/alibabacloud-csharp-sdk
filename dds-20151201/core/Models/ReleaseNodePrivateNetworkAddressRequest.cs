// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ReleaseNodePrivateNetworkAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the sharded cluster instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The network type of the internal endpoint. Valid values:
        /// 
        /// *   **VPC**: virtual private cloud (VPC).
        /// *   **Classic**: classic network.
        /// 
        /// >  You can call the [DescribeShardingNetworkAddress](~~62135~~) operation to query the network type of the internal endpoint.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The ID of the shard or Configserver node.
        /// 
        /// >  You can call the [DescribeDBInstanceAttribute](~~62010~~) operation to query the ID of the shard or Configserver node.
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

    }

}

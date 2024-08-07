// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ReleasePublicNetworkAddressRequest : TeaModel {
        /// <summary>
        /// The public endpoint type. Valid values:
        /// 
        /// *   **SRV**
        /// *   **Normal**
        /// 
        /// >  This parameter is valid only when you want to release an SRV endpoint.
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  If you set this parameter to the ID of a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the mongos, shard, or Configserver node in the sharded cluster instance.
        /// 
        /// > *   This parameter is valid only if you set the **DBInstanceId** parameter to the ID of a sharded cluster instance.
        /// > *   You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/62010.html) operation to view the ID of the mongos, shard, or Configserver node.
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

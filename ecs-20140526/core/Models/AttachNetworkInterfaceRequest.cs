// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachNetworkInterfaceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 网卡指定的物理网卡索引。
        /// 
        /// >NetworkCardIndex 取值与实例规格族有关。如果实例规格不支持NetworkCard则不能指定；如果支持，取值请参见[实例规格族](~~25378~~)。
        /// </summary>
        [NameInMap("NetworkCardIndex")]
        [Validation(Required=false)]
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the trunk ENI.
        /// 
        /// > This parameter is unavailable for use.
        /// </summary>
        [NameInMap("TrunkNetworkInstanceId")]
        [Validation(Required=false)]
        public string TrunkNetworkInstanceId { get; set; }

        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("WaitForNetworkConfigurationReady")]
        [Validation(Required=false)]
        public bool? WaitForNetworkConfigurationReady { get; set; }

    }

}

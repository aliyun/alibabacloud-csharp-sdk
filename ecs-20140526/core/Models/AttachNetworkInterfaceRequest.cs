// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachNetworkInterfaceRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The index of the network interface controller (NIC).
        /// 
        /// > The value of this parameter varies based on the instance family of the specified instance. If the instance type of the specified instance does not support NICs, leave this parameter empty. If the instance type of the specified instance supports NICs, set this parameter to a valid value. For information about the valid values of this parameter, see [Instance families](https://help.aliyun.com/document_detail/25378.html).
        /// </summary>
        [NameInMap("NetworkCardIndex")]
        [Validation(Required=false)]
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// 
        /// This parameter is required.
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
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("TrunkNetworkInstanceId")]
        [Validation(Required=false)]
        public string TrunkNetworkInstanceId { get; set; }

        /// <summary>
        /// > This parameter is no longer supported.
        /// </summary>
        [NameInMap("WaitForNetworkConfigurationReady")]
        [Validation(Required=false)]
        public bool? WaitForNetworkConfigurationReady { get; set; }

    }

}

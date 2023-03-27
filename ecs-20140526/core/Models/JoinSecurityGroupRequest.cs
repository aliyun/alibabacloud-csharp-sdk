// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class JoinSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > If this parameter is specified, the `NetworkInterfaceId` parameter cannot be specified.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// 
        /// > If this parameter is specified, the `InstanceId` parameter cannot be specified.
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
        /// The region ID of the instance or ENI. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// 
        /// *   You do not need to specify a region ID when you add an instance to a security group.
        /// *   You must specify a region ID when you add an ENI to a security group.
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
        /// The ID of the security group to which you want to add the instance or ENI. You can call the [DescribeSecurityGroups](~~25556~~) operation to query available security groups.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}

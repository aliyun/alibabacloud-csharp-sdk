// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class UnassociateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The allocation ID of the EIP.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>This parameter is optional because the system automatically determines the instance ID from the provided <c>AllocationId</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the associated instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>EcsInstance</c>: An ECS instance. This is the default.</description></item>
        /// <item><description><c>SlbInstance</c>: A Classic Load Balancer (CLB) instance.</description></item>
        /// <item><description><c>Nat</c>: A NAT gateway.</description></item>
        /// <item><description><c>HaVip</c>: A high-availability virtual IP address (HaVip).</description></item>
        /// <item><description><c>NetworkInterface</c>: A secondary elastic network interface.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the EIP is located. To get the latest list of regions, call the <c>DescribeRegions</c> operation.</para>
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

    }

}

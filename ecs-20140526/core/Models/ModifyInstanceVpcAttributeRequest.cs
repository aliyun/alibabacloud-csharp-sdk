// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceVpcAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The new private IP address of the instance.
        /// 
        /// >  The `PrivateIpAddress` value depends on the `VSwitchId` value. The specified IP address must be within the CIDR block of the specified vSwitch.
        /// 
        /// By default, if this parameter is not specified, a private IP address is randomly assigned from the CIDR block of the specified vSwitch.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of security group N to which the instance belongs after the VPC is changed. This parameter is required only when the `VpcId` parameter is specified.
        /// 
        /// *   The specified security groups must be of the same type.
        /// *   You can specify one or more security groups. The valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see [Limits](~~25412~~).
        /// *   The specified security groups must belong to the VPC specified by the `VpcId` parameter.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// The vSwitch ID of the instance.
        /// 
        /// *   If this parameter is set to the ID of the current vSwitch, the vSwitch of the instance remains unchanged.
        /// *   If this parameter is set to the ID of a different vSwitch and the `VpcId` parameter is not specified, the new vSwitch must belong to the same zone and VPC as the current vSwitch.
        /// *   If the `VpcId` parameter is specified, the vSwitch specified by this parameter must belong to the specified VPC and to the same zone as the current vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the new VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceVpcAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>When you call this operation, the ECS instance must be in the <b>Stopped</b> (<c>Stopped</c>) state. For other restrictions on the instance, read the <b>Operation description</b> section carefully.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1iudwa5b1tqag1****</para>
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
        /// <para>The new private IP address.</para>
        /// <remarks>
        /// <para>The PrivateIpAddress parameter depends on VSwitchId. The specified IP address must be within the CIDR block of the vSwitch.</para>
        /// </remarks>
        /// <para>Default value: If this parameter is not specified, an IP address is randomly assigned from the CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
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
        /// <para>The list of security group IDs that the instance joins after the VPC is modified. This parameter is required only when the VpcId parameter is specified.</para>
        /// <list type="bullet">
        /// <item><description>The VPC of the security group must match the target VPC.</description></item>
        /// <item><description>Specifies the list of security groups that the instance joins after the modification. You can specify one or more security groups. The number of security groups is subject to the limit on the number of security groups that an instance can join. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
        /// <item><description>All security groups in the list must be of the same type.</description></item>
        /// <item><description>Switching between security group types is supported.
        ///     When an ECS instance switches between security group types, make sure that you understand the differences in the security group rule configurations of the two security group types to avoid affecting the instance network. For more information, see <a href="https://help.aliyun.com/document_detail/25387.html">Security group overview</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-o6w9l8bc8dgmkw87****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description>If the specified ID is the current vSwitch of the instance, the vSwitch of the instance remains unchanged.</description></item>
        /// <item><description>If the specified ID is a new vSwitch and the VpcId parameter is not specified, the new and original vSwitches must belong to the same zone and the same VPC.</description></item>
        /// <item><description>If the VpcId parameter is specified, the vSwitch ID specified in this parameter must belong to the VpcId and must be in the same zone as the original vSwitch.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn3tw12****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The target VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

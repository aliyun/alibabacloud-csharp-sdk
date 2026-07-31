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
        /// <para>When you call this operation, the ECS instance must be in the <b>Stopped</b> state. For other restrictions on the instance, carefully read the <b>operation description</b> section.</para>
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
        /// <para>The <c>PrivateIpAddress</c> parameter depends on <c>VSwitchId</c>. The specified IP address must be within the CIDR block of the vSwitch.</para>
        /// </remarks>
        /// <para>Default value: If this parameter is not specified, a private IP address is randomly assigned from the CIDR block of the vSwitch.</para>
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
        /// <para>The IDs of the security groups to which the instance is added after the VPC is changed. This parameter is required only when the <c>VpcId</c> parameter is specified.</para>
        /// <list type="bullet">
        /// <item><description>The security groups must belong to the destination VPC.</description></item>
        /// <item><description>You can specify one or more security groups. The number of security groups is subject to the limits on the number of security groups to which an instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
        /// <item><description>All security groups in the list must be of the same type.</description></item>
        /// <item><description>Switching between security group types is supported. When you switch an ECS instance between security group types, make sure that you understand the differences in security group rule configurations between the two types to avoid impacts on instance networking. For more information, see <a href="https://help.aliyun.com/document_detail/25387.html">Security group overview</a>.</description></item>
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
        /// <item><description>If the specified ID is the current vSwitch of the instance, the vSwitch remains unchanged.</description></item>
        /// <item><description>If the specified ID is a new vSwitch and the <c>VpcId</c> parameter is empty, the new and old vSwitches must belong to the same zone and the same VPC.</description></item>
        /// <item><description>If the <c>VpcId</c> parameter is not empty, the vSwitch specified by this parameter must belong to the specified VPC and must be in the same zone as the original vSwitch.</description></item>
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
        /// <para>The ID of the destination VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

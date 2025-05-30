// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceVpcAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// <remarks>
        /// <para> When you call this operation, the ECS instance must be in the <b>Stopped</b> (<c>Stopped</c>) state. For other limits on the ECS instance, see the <b>Usage notes</b> section of this topic.</para>
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
        /// <para>The new private IP address of the ECS instance.</para>
        /// <remarks>
        /// <para> The value of <c>PrivateIpAddress</c> depends on the value of <c>VSwitchId</c>. The specified IP address must be within the CIDR block of the specified vSwitch.</para>
        /// </remarks>
        /// <para>By default, if this parameter is empty, a private IP address is randomly assigned from the CIDR block of the specified vSwitch.</para>
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
        /// <para>The IDs of new security groups to which the ECS instance belongs after the VPC is changed. This parameter is required only if <c>VpcId</c> is specified.</para>
        /// <list type="bullet">
        /// <item><description>The security groups that you specify must belong to the new VPC.</description></item>
        /// <item><description>You can specify one or more security groups. The valid values of N vary based on the maximum number of security groups to which an ECS instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
        /// <item><description>The specified security groups must be of the same type.</description></item>
        /// <item><description>You can switch the ECS instance to security groups of a different type. To ensure network connectivity, we recommend that you understand the differences in rule configurations of the two security group types before you switch the ECS instance to security groups of a different type. For more information, see <a href="https://help.aliyun.com/document_detail/25387.html">Overview of security groups</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-o6w9l8bc8dgmkw87****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the new vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to the ID of the current vSwitch, the vSwitch of the ECS instance remains unchanged.</description></item>
        /// <item><description>If you set this parameter to the ID of a different vSwitch and leave <c>VpcId</c> empty, the new vSwitch must belong to the same zone and VPC as the current vSwitch.</description></item>
        /// <item><description>If you specify <c>VpcId</c>, the vSwitch specified by this parameter must belong to the specified VPC and the same zone as the current vSwitch.</description></item>
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
        /// <para>The ID of the new VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

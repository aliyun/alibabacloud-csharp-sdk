// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the lifecycle (epoch) of an instance manually added to the scaling group is managed by the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Managed. The lifecycle (epoch) of the instance is managed by Auto Scaling, which is consistent with that of instances automatically created in the scaling group. The instance is automatically released when it is removed from the scaling group, excluding instances removed when you invoke the DetachInstances operation.</description></item>
        /// <item><description>false: Unmanaged. The instance is not released when it is removed from the scaling group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to instances manually added to the scaling group, not to instances created within the scaling group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Entrusted")]
        [Validation(Required=false)]
        public bool? Entrusted { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp109k5j3dum1ce6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the scaling group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}

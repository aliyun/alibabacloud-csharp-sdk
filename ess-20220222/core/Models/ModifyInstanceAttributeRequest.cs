// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the scaling group to manage the lifecycles of the manually added ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: allows the scaling group to manage the lifecycles of the manually added ECS instances. The scaling group manages the lifecycles of manually added instances and automatically created instances in the same manner. In this case, Auto Scaling releases the instances when they are removed from the scaling group. This rule does not apply to instances that are removed by calling the DetachInstances operation.</description></item>
        /// <item><description>false: does not allow the scaling group to manage the lifecycles of the manually added ECS instances. In this case, Auto Scaling does not release the instances when they are removed from the scaling group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify this parameter only for ECS instances that are manually added to the scaling group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Entrusted")]
        [Validation(Required=false)]
        public bool? Entrusted { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp109k5j3dum1ce6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
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

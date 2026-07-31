// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteAutoProvisioningGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the auto provisioning group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-bpuf6jel2bbl62wh13****</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the auto provisioning group resides.</para>
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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the instances in the auto-provisioning group when the group is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Releases the instances auto provisioning group.</description></item>
        /// <item><description>false: The instances auto provisioning group continue to run.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value of this parameter is inherited from the TerminateInstances parameter that you specified when you called the CreateAutoProvisioningGroup operation to create the auto-provisioning group. You can also set the TerminateInstances parameter to a new value when you call this operation to delete the auto-provisioning group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TerminateInstances")]
        [Validation(Required=false)]
        public bool? TerminateInstances { get; set; }

    }

}

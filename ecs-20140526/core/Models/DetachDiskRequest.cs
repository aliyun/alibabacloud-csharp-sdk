// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// <para>The Settings for the automatic release property when uninstalling a system disk or data disk. Specifies whether the system disk or data disk is released when the ECS instance is released.</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released.</description></item>
        /// <item><description>false: The disk is not released. The disk is retained and transformed to a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter cannot be configured for disks that have the multi-attach attribute enabled.</description></item>
        /// <item><description>If you uninstall a data disk, the default value is <c>false</c>.</description></item>
        /// <item><description>If the disk to be uninstalled is an elastic ephemeral disk, you must set the <c>DeleteWithInstance</c> parameter to <c>true</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the disk to be detached.</para>
        /// <list type="bullet">
        /// <item><description><para>The disk must be attached to an instance and be in the In Use (<c>In_use</c>) state.</para>
        /// </description></item>
        /// <item><description><para>When you detach a data disk, the instance to which the disk is attached must be in the Running (<c>Running</c>) or Stopped (<c>Stopped</c>) state.</para>
        /// </description></item>
        /// <item><description><para>When you detach a system disk, the instance to which the disk is attached must be in the Stopped (<c>Stopped</c>) state.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The ECS instance ID to which the disk to be uninstalled is attached.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

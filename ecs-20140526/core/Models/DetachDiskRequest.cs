// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to release the system cloud disk or data cloud disk when the ECS instance is released. This parameter sets the automatic release attribute when you unmount a system cloud disk or data cloud disk.</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released.</description></item>
        /// <item><description>false: The disk is not released. The cloud disk is converted to a pay-as-you-go data cloud disk and is retained.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter cannot be set for cloud disks that have the multi-attach feature enabled.</description></item>
        /// <item><description>If you unmount a data cloud disk, the default value is <c>false</c>.</description></item>
        /// <item><description>If the disk to be unmounted is an elastic ephemeral disk, you must set the <c>DeleteWithInstance</c> parameter to <c>true</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the disk to be unmounted.</para>
        /// <list type="bullet">
        /// <item><description><para>The disk must be mounted to an instance and be in the In Use (<c>In_use</c>) state.</para>
        /// </description></item>
        /// <item><description><para>When you unmount a data cloud disk, the instance to which the disk is mounted must be in the Running (<c>Running</c>) or Stopped (<c>Stopped</c>) state.</para>
        /// </description></item>
        /// <item><description><para>When you unmount a system cloud disk, the instance to which the disk is mounted must be in the Stopped (<c>Stopped</c>) state.</para>
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
        /// <para>The instance ID of the ECS instance to which the disk to be uninstalled is attached.</para>
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

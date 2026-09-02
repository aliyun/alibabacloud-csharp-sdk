// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to configure the automatic release attribute when detaching a system disk or data disk. This attribute determines whether the system disk or data disk is released together with the ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released together with the instance.</description></item>
        /// <item><description>false: The disk is not released together with the instance. The disk is retained as a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: true</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Disks with the multi-attach feature enabled do not support this parameter.</description></item>
        /// <item><description>If the disk to be detached is a data disk, the default value is <c>false</c>.</description></item>
        /// <item><description>If the disk to be detached is an <c>elastic ephemeral disk</c>, you must set <c>DeleteWithInstance</c> to <c>true</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the disk that you want to detach.</para>
        /// <list type="bullet">
        /// <item><description><para>The disk must be attached to an instance and in the In Use (<c>In_use</c>) state.</para>
        /// </description></item>
        /// <item><description><para>To detach a data disk, the instance to which the disk is attached must be in the Running (<c>Running</c>) or Stopped (<c>Stopped</c>) state.</para>
        /// </description></item>
        /// <item><description><para>To detach a system disk, the instance to which the disk is attached must be in the Stopped (<c>Stopped</c>) state.</para>
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
        /// <para>The instance ID of the ECS instance from which you want to uninstall the disk that is attached to it.</para>
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

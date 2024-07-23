// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to release the system disk or data disk when the instance from which you want to detach the disk is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the disk when the instance is released.</description></item>
        /// <item><description>false: does not release the disk when the instance is released. The disk is retained as a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify this parameter for disks for which the multi-attach feature is enabled.</description></item>
        /// <item><description>If a data disk is to be detached, the default value is <c>false</c>.</description></item>
        /// <item><description>If you want to detach an <c>elastic ephemeral disk</c>, you must set <c>DeleteWithInstance</c> to <c>true</c>.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance from which you want to detach the disk.</para>
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

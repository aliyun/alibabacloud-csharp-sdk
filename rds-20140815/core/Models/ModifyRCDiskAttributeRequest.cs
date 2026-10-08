// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCDiskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature for cloud disks that support burst. Valid values:</para>
        /// <para>true: Enabled.
        /// false: Disabled.
        /// Note
        /// An error is returned if you pass any value for cloud disks that do not support the burst feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the cloud disk when the associated instance is released. Default value: null, which indicates that the current value is not changed.</para>
        /// <para>Cloud disks that have the multi-attach feature enabled do not support this parameter.</para>
        /// <para>An error is returned if you set DeleteWithInstance to false in the following cases:</para>
        /// <para>The category of the cloud disk is local disk (ephemeral).
        /// The category of the cloud disk is basic cloud disk (cloud) and the cloud disk is not detachable (Portable=false).
        /// Warning
        /// If you set DeleteWithInstance to false and the ECS instance to which the cloud disk is attached is security-locked with &quot;LockReason&quot; : &quot;security&quot; in OperationLocks, the DeleteWithInstance attribute of the cloud disk is ignored and the cloud disk is released together with the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The description of the cloud disk. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk whose attributes you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcd-wz9c8isqly8637zw****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The name of the cloud disk. The name must be 2 to 128 characters in length and can contain Unicode characters under the letter category (including letters from various languages, Chinese characters, and digits). The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDisk</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

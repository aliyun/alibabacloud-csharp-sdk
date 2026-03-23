// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCDiskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the burst (performance burst) feature for disks that support it. Valid values:</para>
        /// <para>true: Enabled.
        /// false: No.
        /// Note
        /// If you specify any value for a disk that does not support the burst feature, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is released when its associated instance is released. Default value: none, which means the current setting remains unchanged.</para>
        /// <para>This parameter cannot be set for disks with the multi-attach feature enabled.</para>
        /// <para>An error occurs if you set DeleteWithInstance to false in either of the following cases:</para>
        /// <list type="bullet">
        /// <item><description>The disk category is local disk (ephemeral).</description></item>
        /// <item><description>The disk category is basic disk (cloud) and the disk is non-portable (Portable=false).</description></item>
        /// </list>
        /// <para>Warning
        /// If you set DeleteWithInstance to false, but the ECS instance to which the disk is attached is security locked (indicated by &quot;LockReason&quot;: &quot;security&quot; in OperationLocks), the disk will be released together with the instance regardless of the DeleteWithInstance setting when the instance is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The description of the disk. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the disk whose property you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcd-wz9c8isqly8637zw****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Disk name. The name must be 2 to 128 characters in length and can contain characters from the letter categorization in Unicode (including English letters, Chinese characters, and digits). It can also include colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDisk</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to obtain valid region IDs.</para>
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

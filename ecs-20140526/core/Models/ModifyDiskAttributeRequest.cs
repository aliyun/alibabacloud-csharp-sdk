// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature for disks that support this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>An error is returned if you specify this parameter for a disk that does not support the performance burst feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the automatic snapshots of the disk when the disk is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: null, which indicates that the current value is not changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the disk along with the instance. Default value: null, which indicates that the current value is not changed.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;This parameter is not supported for disks that have the multi-attach feature enabled.</para>
        /// <para>An error is returned if you set DeleteWithInstance to <c>false</c> in either of the following cases: </para>
        /// <list type="bullet">
        /// <item><description>The category of the disk is local disk (ephemeral).  </description></item>
        /// <item><description>The category of the disk is basic disk (cloud) and the disk is not detachable (Portable=false).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: If you set DeleteWithInstance to false and the ECS instance to which the disk is attached is security-locked with &quot;LockReason&quot; : &quot;security&quot; in OperationLocks, the DeleteWithInstance attribute is ignored and the disk is released along with the instance..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The description of the disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the disk whose attributes you want to modify.</para>
        /// <remarks>
        /// <para>The DiskId and DiskIds.N parameters cannot be specified at the same time. Specify one of them as needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1famypsnar20bv****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The IDs of the disks whose attributes you want to modify. Valid values of N: 0 to 100.</para>
        /// <remarks>
        /// <para>The DiskId and DiskIds.N parameters cannot be specified at the same time. Specify one of them as needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1famypsnar20bv****</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length and can contain letters, digits, and characters categorized as letter in Unicode, including Chinese characters. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic snapshot policy for the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>Default value: null, which indicates that the current value is not changed.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. The automatic snapshot policy is enabled by default for disks after they are created. You only need to associate an automatic snapshot policy with the disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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

    }

}

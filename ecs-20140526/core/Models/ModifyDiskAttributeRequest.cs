// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature for a disk that supports this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
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
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: null. A null value indicates that the current value is not changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether the disk is released along with the instance. Default value: null. A value of null indicates that the current value remains unchanged.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;This parameter is not supported for disks that have the multi-attach feature enabled.</para>
        /// <para>An error is returned if you set the <c>DeleteWithInstance</c> parameter to <c>false</c> in either of the following scenarios: </para>
        /// <list type="bullet">
        /// <item><description>The disk category is local disk (ephemeral).  </description></item>
        /// <item><description>The disk category is basic disk (cloud) and the disk is not detachable (Portable=false).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: If you configure the disk not to be released with the instance (DeleteWithInstance=false), the disk is still released along with the instance if the ECS instance to which the disk is attached is locked for security reasons and the OperationLocks parameter indicates a lock status of &quot;LockReason&quot;:&quot;security&quot;. In this case, the DeleteWithInstance attribute of the disk is ignored.</para>
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
        /// <para>You cannot specify both the DiskId and DiskIds.N parameters. Specify one of them based on your requirements.</para>
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
        /// <para>You cannot specify both the DiskId and DiskIds.N parameters. Specify one of them based on your requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1famypsnar20bv****</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length and can contain letters and digits in Unicode. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic snapshot policy feature for the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: null. A null value indicates that the current value is not changed.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. The automatic snapshot policy feature is enabled by default for newly created disks. You only need to apply an automatic snapshot policy to the disk.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

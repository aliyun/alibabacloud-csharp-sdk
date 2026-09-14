// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The new disk type. This parameter is valid only when you migrate a disk between different dedicated block storage clusters. Only cloud_essd (standard SSD) is supported.</para>
        /// <para>Default value: empty, which indicates that the disk type is not changed (no Upgrade/Downgrade) during migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The disk ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp131n0q38u3a4zi****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks whether the required parameters are specified, the request format is valid, business limits are met, and ECS inventory is sufficient. If the check fails, the corresponding error is returned. If the check passes, the error code DryRunOperation is returned.</description></item>
        /// <item><description>false: performs a normal request. After the check passes, a 2XX HTTP status code is returned and the disk migration starts immediately.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The new ESSD performance level of the standard SSD. This parameter is valid only when you migrate a disk between different dedicated block storage clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: maximum random read/write IOPS of 10,000 for a single disk.</description></item>
        /// <item><description>PL1: maximum random read/write IOPS of 50,000 for a single disk.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the performance level is not changed during migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The dedicated block storage cluster ID.</para>
        /// <list type="bullet">
        /// <item><description>If you migrate the disk to a dedicated block storage cluster, you must specify <c>StorageClusterId</c>.</description></item>
        /// <item><description>If you migrate the disk to a public block storage cluster, <c>StorageClusterId</c> must be empty.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the disk is migrated to a public block storage cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-cn-c4d2uea****</para>
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

    }

}

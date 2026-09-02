// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The new disk type. This parameter takes effect only when you migrate a disk between different dedicated block storage clusters. Currently, only cloud_essd (enterprise SSD) is supported.</para>
        /// <para>Default value: empty, which indicates that the disk type is not changed.</para>
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
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, a 2XX HTTP status code is returned and the disk is migrated.</description></item>
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
        /// <para>The performance level (PL) of the enterprise SSD. This parameter takes effect only when you migrate a disk between different dedicated block storage clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A maximum of 10,000 random read/write IOPS per disk.</description></item>
        /// <item><description>PL1: A maximum of 50,000 random read/write IOPS per disk.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the performance level (PL) is not changed.</para>
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
        /// <item><description>To migrate a disk to a dedicated block storage cluster, you must specify StorageClusterId.</description></item>
        /// <item><description>To migrate a disk to a public cloud block storage cluster, StorageClusterId must be empty.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the disk is migrated to a public cloud block storage cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-cn-c4d2uea****</para>
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

    }

}

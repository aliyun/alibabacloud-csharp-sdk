// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The new disk category. This parameter is valid only during migration between different dedicated block storage clusters. Currently, only cloud_essd (ESSD) is supported.</para>
        /// <para>Default value: empty, which indicates that the disk category is not changed.</para>
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a precheck request. The check items include whether required parameters are specified, the request format, business limits, and ECS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: sends a normal request. If the check succeeds, a 2xx HTTP status code is returned and the disk is directly migrated.</description></item>
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
        /// <para>The new ESSD performance level. This parameter is valid only during migration between different dedicated block storage clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the performance level is not changed.</para>
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
        /// <para>The ID of the dedicated block storage cluster. Before migrating a disk into a dedicated block storage cluster, you must purchase and create the cluster, and ensure that the disk and the destination cluster are in the same zone.</para>
        /// <list type="bullet">
        /// <item><description>When migrating a disk to a dedicated block storage cluster, you must specify <c>StorageClusterId</c>.</description></item>
        /// <item><description>When migrating a disk to a public cloud block storage cluster, <c>StorageClusterId</c> must be empty.</description></item>
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

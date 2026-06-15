// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The new category of the disk. This parameter is valid only when you migrate a disk between different dedicated block storage clusters. The only valid value is <c>cloud_essd</c> (ESSD disk).</para>
        /// <para>Default value: An empty string. If you leave this parameter empty, the category of the disk remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp131n0q38u3a4zi****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Performs a dry run. The system checks the request for required parameters, format, service limits, and inventory. The system returns an error if the check fails, or the <c>DryRunOperation</c> error code if the check succeeds.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Sends the request. If the request passes the check, the system returns a 2xx HTTP status code and migrates the disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
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
        /// <para>The new performance level of the ESSD disk. This parameter is valid only when you migrate a disk between different dedicated block storage clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PL0</c>: A maximum of 10,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para><c>PL1</c>: A maximum of 50,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: An empty string. If you leave this parameter empty, the performance level of the disk remains unchanged.</para>
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
        /// <para>The ID of the dedicated block storage cluster.</para>
        /// <list type="bullet">
        /// <item><description><para>To migrate the disk to a dedicated block storage cluster, specify <c>StorageClusterId</c>.</para>
        /// </description></item>
        /// <item><description><para>To migrate the disk to a public cloud block storage cluster, leave <c>StorageClusterId</c> empty.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: An empty string. If you leave this parameter empty, the disk is migrated to a public cloud block storage cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-cn-c4d2uea****</para>
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

    }

}

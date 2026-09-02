// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// <para>The new type of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud_essd: enterprise SSD (ESSD).</para>
        /// </description></item>
        /// <item><description><para>cloud_auto: ESSD AutoPL disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_ssd: standard SSD.
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// </description></item>
        /// <item><description><para>cloud_essd_entry: ESSD Entry disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_efficiency: ultra disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that the disk type is not changed.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The valid values above are listed in descending order of disk performance. If the specified disk is a subscription disk, you cannot downgrade the disk type.</description></item>
        /// </list>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>ESSD Entry disks can be changed only to enterprise SSDs (ESSDs) or ESSD AutoPL disks. For more information, see <a href="https://help.aliyun.com/document_detail/161980.html">Change the disk type</a>.</description></item>
        /// </list>
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
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether RAM users are granted permissions, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para>false: performs a dry run and performs the actual request. If the check succeeds, a 2XX HTTP status code is returned and the disk type or ESSD performance level is changed.</para>
        /// </description></item>
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
        /// <para>The disk performance control parameters.</para>
        /// </summary>
        [NameInMap("PerformanceControlOptions")]
        [Validation(Required=false)]
        public ModifyDiskSpecRequestPerformanceControlOptions PerformanceControlOptions { get; set; }
        public class ModifyDiskSpecRequestPerformanceControlOptions : TeaModel {
            /// <summary>
            /// <para>The target IOPS of the disk. Only the IOPS of disks in a dedicated storage cluster can be modified.</para>
            /// <para>Valid values: 900 to the maximum IOPS per disk, in increments of 100.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/25382.html">Disk performance</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("IOPS")]
            [Validation(Required=false)]
            public int? IOPS { get; set; }

            /// <summary>
            /// <para>Resets the disk performance. Only disks in a dedicated storage cluster are supported.</para>
            /// <para>If this parameter is set, the PerformanceControlOptions.IOPS and PerformanceControlOptions.Throughput parameters do not take effect.</para>
            /// <para>Currently, only the value All is supported, which resets the disk IOPS and throughput to their initial values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Recover")]
            [Validation(Required=false)]
            public string Recover { get; set; }

            /// <summary>
            /// <para>The target throughput of the disk. Only the throughput of disks in a dedicated storage cluster can be modified. Unit: MB/s.</para>
            /// <para>Valid values: 60 to the maximum throughput per disk.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/25382.html">Disk performance</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Throughput")]
            [Validation(Required=false)]
            public int? Throughput { get; set; }

        }

        /// <summary>
        /// <para>The new performance level (PL) of an ESSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL2</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the provisioned read/write IOPS of an ESSD AutoPL disk.</para>
        /// <para>Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
        /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <remarks>
        /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned performance of an ESSD AutoPL disk</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

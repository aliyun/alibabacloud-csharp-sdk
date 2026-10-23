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
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// <para>Changes the category of a disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud_essd: enterprise SSD.</para>
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
        /// <para>Default value: null, which indicates that no specification change is performed on the disk.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The preceding valid values are listed in descending order of disk performance. If the specified disk is a subscription disk, you cannot downgrade the disk category.</description></item>
        /// </list>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>ESSD Entry disks can only be changed to enterprise SSDs or ESSD AutoPL disks. For more information, see <a href="https://help.aliyun.com/document_detail/161980.html">Change the category of a disk</a>.</description></item>
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request is prechecked. The system checks whether required parameters are specified, the request format is valid, the business limits are met, and the ECS inventory is sufficient. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para>false: The request is sent. If the request passes the precheck, a 2xx HTTP status code is returned and the disk category or ESSD performance level is directly changed.</para>
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
            /// <para>The target IOPS of the disk. You can only modify the IOPS of disks in a dedicated block storage cluster.</para>
            /// <para>Valid values: 900 to the maximum IOPS of a single disk. Step size: 100.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/25382.html">Disk performance</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("IOPS")]
            [Validation(Required=false)]
            public int? IOPS { get; set; }

            /// <summary>
            /// <para>Resets the disk performance. This parameter is supported only for disks in a dedicated block storage cluster.</para>
            /// <para>After this parameter is specified, the PerformanceControlOptions.IOPS and PerformanceControlOptions.Throughput parameters do not take effect.</para>
            /// <para>Currently, you can only set this parameter to All, which resets the disk IOPS and throughput to their initial values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Recover")]
            [Validation(Required=false)]
            public string Recover { get; set; }

            /// <summary>
            /// <para>The target throughput of the disk. Unit: MB/s. You can only modify the throughput of disks in a dedicated block storage cluster.</para>
            /// <para>Valid values: 60 to the maximum throughput of a single disk.</para>
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
        /// <para>Modifies the performance level (PL) of an enterprise SSD. Valid values:</para>
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
        /// <para>The provisioned read and write IOPS of the ESSD AutoPL disk.</para>
        /// <para>Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
        /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <remarks>
        /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned information of an ESSD AutoPL disk</a>.</para>
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

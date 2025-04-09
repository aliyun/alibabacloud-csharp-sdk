// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature. You must make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: true. If your account balance is insufficient, you can set AutoPay to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. You must specify this parameter only when the data disk uses the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The auto-renewal cycle is one month for a monthly subscription. The auto-renewal cycle is one year for a yearly subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The disk description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category of the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b> (default): basic disk</description></item>
        /// <item><description><b>cloud_efficiency</b>: ultra disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: ESSD.</description></item>
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL disk</description></item>
        /// <item><description><b>cloud_essd_entry</b>: ESSD Entry disk</description></item>
        /// <item><description><b>elastic_ephemeral_disk_standard</b>: standard elastic ephemeral disk</description></item>
        /// <item><description><b>elastic_ephemeral_disk_premium</b>: premium elastic ephemeral disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The disk name. The name must be 2 to 128 characters in length and can contain letters and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZStack-Hybrid-Test-ECS-Instance</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The billing method. Set the value to <b>Postpaid</b>, which specifies the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rc-v28c6k3jupp61m2t****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the disk if the disk is an ESSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL0</b>: A single ESSD delivers up to 10,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL1</b> (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL2</b>: A single ESSD delivers up to 100,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL3</b>: A single ESSD delivers up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>For information about ESSD PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The disk size. Unit: GiB. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud</b>: 5 to 2000.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_efficiency</b>: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_ssd</b>: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_essd</b>: depend on the value of PerformanceLevel.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if PerformanceLevel is set to PL0: 1 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL1: 20 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL2: 461 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL3: 1261 to 65536</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_auto</b>: 1 to 65536.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_essd_entry</b>: 10 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>elastic_ephemeral_disk_standard</b>: 64 to 8192.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>elastic_ephemeral_disk_premium</b>: 64 to 8192.</para>
        /// </description></item>
        /// </list>
        /// <para>If <c>SnapshotId</c> is specified, the following limits apply to <c>SnapshotId</c> and <c>Size</c>:</para>
        /// <list type="bullet">
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is larger than the value of <c>Size</c>, the size of the created disk is equal to the size of the snapshot.</description></item>
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is smaller than the value of <c>Size</c>, the size of the created disk is equal to the value of <c>Size</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The snapshot that you want to use to create the disk. Snapshots that were created on or before July 15, 2013 cannot be used to create disks. The following limits apply to <c>SnapshotId</c> and <c>Size</c>:</para>
        /// <list type="bullet">
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is larger than the value of <c>Size</c>, the size of the created disk is equal to the specified snapshot size.</description></item>
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is smaller than the value of <c>Size</c>, the size of the created disk is equal to the value of <c>Size</c>.</description></item>
        /// <item><description>You cannot create elastic ephemeral disks from snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rcds-umtnkvevqbu****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

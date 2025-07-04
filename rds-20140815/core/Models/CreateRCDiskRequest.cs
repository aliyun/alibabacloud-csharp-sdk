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
        /// <item><description><b>true</b> (default): enables automatic payment. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: does not automatically complete the payment. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If your account balance is insufficient, you can set the parameter to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.</para>
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
        /// <para>The disk description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The data disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: ESSD</description></item>
        /// <item><description><b>cloud_auto</b> (default): Premium ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZStack-Hybrid-Test-ECS-Instance</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go Pay-as-you-go disks do not require to be attached. You can also attach the pay-as-you-go disk to an instance of any billing method based on your business requirements.</description></item>
        /// <item><description><b>Prepaid</b>: subscription Subscription disks must be attached to a subscription instance. Set <b>InstanceId</b> to the ID of a subscription instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which you want to attach the disk. If you set <b>InstanceChargeType</b> to <b>Prepaid</b>, you must set InstanceId to the ID of a subscription instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-v28c6k3jupp61m2t****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL0</b>: A single ESSD delivers up to 10,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL1: An ESSD delivers up to 50,000 random read/write IOPS.</b></description></item>
        /// <item><description><b>PL2</b>: A single ESSD delivers up to 100,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL3</b>: A single ESSD delivers up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>For information about ESSD PLs, see <a href="https://help.aliyun.com/document_detail/2859916.html">ESSDs</a>.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The disk size. Unit: GiB. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_efficiency</b>: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_ssd</b>: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values if you set DiskCategory to <b>cloud_auto</b>: 1 to 65536.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_essd: depending on the value of <b>PerformanceLevel</b>.****</para>
        /// <list type="bullet">
        /// <item><description>Valid values if PerformanceLevel is set to PL0: 1 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL1: 20 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL2: 461 to 65536</description></item>
        /// <item><description>Valid values if PerformanceLevel is set to PL3: 1261 to 65536</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>If <b>SnapshotId</b> is specified and the size of the corresponding snapshot is greater than the <b>Size</b> value, the size of the created disk is the same as that of the snapshot. If the snapshot size is less than the <b>Size</b> value, the size of the created disk is equal to the <b>Size</b> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The snapshot that you want to use to create the disk.</para>
        /// <list type="bullet">
        /// <item><description>The snapshots of RDS Custom instances and the non-shared snapshots of ECS instances are supported.</description></item>
        /// <item><description>If the size of the snapshot specified by <b>SnapshotId</b> is greater than the value of <b>Size</b>, the size of the created disk is equal to the specified snapshot size. If the snapshot size is less than the <b>Size</b> value, the size of the created disk is equal to the <b>Size</b> value.</description></item>
        /// <item><description>You cannot create elastic ephemeral disks from snapshots.</description></item>
        /// <item><description>Snapshots that were created on or before July 15, 2013 cannot be used to create disks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rcds-umtnkvevqbu****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRCDiskRequestTag> Tag { get; set; }
        public class CreateRCDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can create N tag keys at a time. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can query N values at a time. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required if you do not specify <b>InstanceId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

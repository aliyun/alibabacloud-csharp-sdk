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
        /// <item><description><b>false</b>: generates an order without charging.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If your payment method has insufficient balance, set this parameter to false. An unpaid order is generated, and you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is valid only when you create a subscription data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you purchase the cloud disk on a monthly basis, the auto-renewal epoch is one month.
        ///  If you purchase the cloud disk on a yearly basis, the auto-renewal epoch is one year.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The description of the cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category of the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: ESSD.</description></item>
        /// <item><description><b>cloud_auto</b> (default): premium performance disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The name of the cloud disk. The name must be 2 to 128 characters in length and can contain characters that are categorized as letter in Unicode, including Chinese characters, English letters, and digits. The name can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDisk</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go. Cloud disks with this billing method do not need to be mounted to an instance. You can also mount them to an instance of any billing method during creation as needed.</description></item>
        /// <item><description><b>Prepaid</b>: subscription. Cloud disks with this billing method must be mounted to a subscription instance. You must specify the <b>InstanceId</b> (instance ID) of a subscription instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance to which the cloud disk is attached. If <b>InstanceChargeType</b> is set to <b>Prepaid</b> (subscription), you must specify instance ID of a subscription instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-v28c6k3jupp61m2t****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL0</b>: A single cloud disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL1</b> (default): A single cloud disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL2</b>: A single cloud disk can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL3</b>: A single cloud disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/2859916.html">ESSD cloud disk</a>.</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The capacity size. Unit: GiB. You must specify a value for this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: 20 to 32,768.</description></item>
        /// <item><description><b>cloud_ssd</b>: 20 to 32,768.</description></item>
        /// <item><description><b>cloud_auto</b>: 1 to 65,536.</description></item>
        /// <item><description><b>cloud_essd</b>: The valid value range depends on the value of <b>PerformanceLevel</b>.<list type="bullet">
        /// <item><description>PL0: 1 to 65,536.</description></item>
        /// <item><description>PL1: 20 to 65,536.</description></item>
        /// <item><description>PL2: 461 to 65,536.</description></item>
        /// <item><description>PL3: 1,261 to 65,536.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>If <b>SnapshotId</b> is specified and the capacity of the corresponding snapshot is greater than the value of <b>Size</b>, snapshot size of the created cloud disk is the same as the snapshot capacity. If the snapshot capacity is less than the value of <b>Size</b>, snapshot size of the created cloud disk is the value of <b>Size</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The snapshot that is used to create the cloud disk.</para>
        /// <list type="bullet">
        /// <item><description>RDS Custom snapshots and ECS snapshots (non-shared type) are supported.</description></item>
        /// <item><description>If the capacity of the snapshot specified by <b>SnapshotId</b> is greater than the value of <b>Size</b>, snapshot size of the created cloud disk is the same as the snapshot capacity. If the snapshot capacity is less than the value of <b>Size</b>, snapshot size of the created cloud disk is the value of <b>Size</b>.</description></item>
        /// <item><description>Creating elastic ephemeral disks from snapshots is not supported.</description></item>
        /// <item><description>Snapshots created on or before July 15, 2013 cannot be used to create cloud disks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rcds-umtnkvevqbu****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRCDiskRequestTag> Tag { get; set; }
        public class CreateRCDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to N tag keys at a time. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can specify up to N tag values at a time. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string.</para>
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
        /// <para>This parameter is required if the <b>InstanceId</b> parameter (the instance ID of the instance to which the cloud disk is mounted) is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

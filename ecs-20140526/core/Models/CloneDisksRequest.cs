// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CloneDisksRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CloneDisksRequestArn> Arn { get; set; }
        public class CloneDisksRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature for the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the feature.</description></item>
        /// <item><description>false: disables the feature.<remarks>
        /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/essd-autopl-disks">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a parameter value from your client to ensure that the value is unique across different requests. The ClientToken parameter only supports ASCII characters and can be up to 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The destination zone of the new disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// <para>The type of the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: standard SSD.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// <item><description>cloud_regional_disk_auto: zone-redundant enterprise SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Disk type restrictions for cloud disk cloning:</para>
        /// <list type="bullet">
        /// <item><description>A non-zone-redundant cloud disk can only be cloned to a non-zone-redundant type.</description></item>
        /// <item><description>A zone-redundant cloud disk can only be cloned to a zone-redundant type.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length. It can contain letters in the Unicode Letter category (including English and Chinese characters) and ASCII digits (0 to 9). It can also contain colons (:), underscores (_), periods (.), and hyphens (-). It must start with a letter in the Unicode Letter category.</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request and does not perform the actual operation. The check items include whether the AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default): sends a normal request. After the check succeeds, the 2XX HTTP status code is returned and the actual operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the new disk is an encrypted cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The KMS key ID used by the new disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-szz67b2f696f4wh9yeg5d</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-attach attribute for the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled: disables the attribute.</description></item>
        /// <item><description>Enabled: enables the attribute. Currently, only standard SSDs support the Settings of <c>Enabled</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The Settings of the performance level for a standard SSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If DiskCategory is set to cloud_essd, the PerformanceLevel parameter is required.</para>
        /// </remarks>
        /// <para>For more information about how to select the performance level of an enterprise SSD, see <a href="https://help.aliyun.com/document_detail/122389.html">enterprise SSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read and write IOPS of the ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the capacity is less than or equal to 3 GiB, provisioned performance is not supported.</description></item>
        /// <item><description>If the capacity is greater than or equal to 4 GiB, the valid values are 0 to min{(1,000 IOPS/GiB × Capacity - Baseline IOPS), 50,000}.</description></item>
        /// </list>
        /// <para>Baseline performance = max{min{1,800 + 50 × Capacity, 50,000}, 3,000}.</para>
        /// <remarks>
        /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/essd-autopl-disks">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The access mode of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadOnly</para>
        /// </summary>
        [NameInMap("ReadWriteMode")]
        [Validation(Required=false)]
        public string ReadWriteMode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://www.alibabacloud.com/help/en/ecs/api-regions-describeregions">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the disk belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp199lyny9b3****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The capacity of the new disk. Unit: GiB. You must specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: The valid values vary by performance level.<list type="bullet">
        /// <item><description>PL0: 1 to 65,536.</description></item>
        /// <item><description>PL1: 20 to 65,536.</description></item>
        /// <item><description>PL2: 461 to 65,536.</description></item>
        /// <item><description>PL3: 1,261 to 65,536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>cloud_auto: 1 to 65,536.</description></item>
        /// <item><description>cloud_essd_entry: 10 to 32,768.</description></item>
        /// <item><description>cloud_regional_disk_auto: 10 to 65,536.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ID of the source disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1d6tsvznfghy7y****</para>
        /// </summary>
        [NameInMap("SourceDiskId")]
        [Validation(Required=false)]
        public string SourceDiskId { get; set; }

        /// <summary>
        /// <para>The list of tag information for the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CloneDisksRequestTag> Tag { get; set; }
        public class CloneDisksRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the disk. Valid values of N: 1 to 20. If you specify Tag.N.Key, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk. Valid values of N: 1 to 20. If you specify Tag.N.Value, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

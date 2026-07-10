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
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CloneDisksRequestArn> Arn { get; set; }
        public class CloneDisksRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
        /// <item><description>true: enables the performance burst feature.</description></item>
        /// <item><description>false: does not enable the performance burst feature.<remarks>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The category of the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: standard SSD.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// <item><description>cloud_regional_disk_auto: regional Standard SSD (ESSD).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Disk category restrictions for disk cloning:</para>
        /// <list type="bullet">
        /// <item><description>Non-regional disks can only be cloned to non-regional disk types.</description></item>
        /// <item><description>Regional disks can only be cloned to regional disk types.</description></item>
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
        /// <para>The name of the disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). The name must start with a letter.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request without querying the filing status. The system checks whether your AccessKey pair is valid, whether RAM user authorization is granted, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check passes, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default): sends a normal request. After the check passes, a 2XX HTTP status code is returned and the filing status is queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the new disk is encrypted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The new disk is encrypted.</description></item>
        /// <item><description>false: The new disk is not encrypted.</description></item>
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
        /// <para>The key ID of the KMS key used by the new disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-szz67b2f696f4wh9yeg5d</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-attach attribute for the new disk. Settings for this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled: disables the multi-attach attribute.</description></item>
        /// <item><description>Enabled: enables the multi-attach attribute. Only standard SSDs support the value <c>Enabled</c>.</description></item>
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
        /// <para>The performance level (PL) of the enterprise SSD to create. Settings for this parameter vary based on the standard SSD type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: a single disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: a single disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: a single disk can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: a single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If DiskCategory is set to cloud_essd, PerformanceLevel is required.</para>
        /// </remarks>
        /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Capacity (GiB) &lt;= 3: provisioned performance is not supported.</description></item>
        /// <item><description>Capacity (GiB) &gt;= 4: [0, min{(1,000 IOPS/GiB × Capacity - Baseline IOPS), 50,000}]</description></item>
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
        /// <para>The region ID. You can call <a href="https://www.alibabacloud.com/help/en/ecs/api-regions-describeregions">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The capacity of the new disk. Unit: GiB. You must specify a value for this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: the valid value range varies based on the performance level.<list type="bullet">
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
        /// <para>The list of tags for the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CloneDisksRequestTag> Tag { get; set; }
        public class CloneDisksRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the disk. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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

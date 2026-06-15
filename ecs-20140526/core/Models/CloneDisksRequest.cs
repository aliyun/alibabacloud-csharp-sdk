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
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CloneDisksRequestArn> Arn { get; set; }
        public class CloneDisksRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available.</para>
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
            /// <para>This parameter is not yet available.</para>
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
            /// <para>This parameter is not yet available.</para>
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
        /// <para>Specifies whether to enable performance bursting for the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables performance bursting.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables performance bursting.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/zh/ecs/user-guide/essd-autopl-disks">ESSD AutoPL cloud disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>A client-generated token that, when provided, ensures the idempotence of the request. The token must be unique for each request. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The type of the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_essd</c>: ESSD cloud disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL cloud disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd_entry</c>: ESSD Entry cloud disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_regional_disk_auto</c>: regional disk.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Disk type limits for cloning</para>
        /// <list type="bullet">
        /// <item><description><para>A non-regional disk can be cloned only as a non-regional disk.</para>
        /// </description></item>
        /// <item><description><para>A regional disk can be cloned only as a regional disk.</para>
        /// </description></item>
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
        /// <para>The name of the new disk. The name must be 2 to 128 characters in length. It must start with a letter and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Performs a dry run to check the request without cloning the disk. The system checks whether your AccessKey is valid, whether the RAM user is authorized, and whether the required parameters are specified. If the request fails the check, the system returns the corresponding error message. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): Sends a normal request. If the request passes the check, the system returns a 2xx HTTP status code and clones the disk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The disk is encrypted.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The disk is not encrypted.</para>
        /// </description></item>
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
        /// <para>The ID of the KMS key to use for the new disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-szz67b2f696f4wh9yeg5d</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-attach feature for the new disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Disabled</c>: Disables the multi-attach feature.</para>
        /// </description></item>
        /// <item><description><para><c>Enabled</c>: Enables the multi-attach feature. You can set this parameter to <c>Enabled</c> only for ESSD cloud disks.</para>
        /// </description></item>
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
        /// <para>The performance level of the new ESSD cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PL0</c>: A single disk can deliver up to 10,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para><c>PL1</c>: A single disk can deliver up to 50,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para><c>PL2</c>: A single disk can deliver up to 100,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para><c>PL3</c>: A single disk can deliver up to 1,000,000 random read/write IOPS.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>DiskCategory</c> is set to <c>cloud_essd</c>.</para>
        /// </remarks>
        /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>You cannot set this parameter for disks that are 3 GiB or smaller in size.</para>
        /// </description></item>
        /// <item><description><para>For disks that are 4 GiB or larger in size, the value must be in the range of <c>[0, min(1000 * Size - baseline performance, 50000)]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>baseline performance = <c>max(min(1800 + 50 * Size, 50000), 3000)</c>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/zh/ecs/user-guide/essd-autopl-disks">ESSD AutoPL cloud disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/zh/ecs/api-regions-describeregions">DescribeRegions</a> operation to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group for the new disk.</para>
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
        /// <para>The size of the new disk, in GiB. The value must be greater than or equal to the size of the source disk. The value range varies based on the <c>DiskCategory</c> value:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_essd</c>: The value range depends on the <c>PerformanceLevel</c> value.</para>
        /// <list type="bullet">
        /// <item><description><para><c>PL0</c>: 1 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>PL1</c>: 20 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>PL2</c>: 461 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>PL3</c>: 1,261 to 65,536</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>cloud_auto</c>: 1 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd_entry</c>: 10 to 32,768</para>
        /// </description></item>
        /// <item><description><para><c>cloud_regional_disk_auto</c>: 10 to 65,536</para>
        /// </description></item>
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
        /// <para>The tags to add to the new disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CloneDisksRequestTag> Tag { get; set; }
        public class CloneDisksRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the new disk. Valid values of N: 1 to 20. The tag key must be 1 to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the new disk. Valid values of N: 1 to 20. The tag value can be an empty string or up to 128 characters in length, and it cannot contain <c>http://</c> or <c>https://</c>.</para>
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

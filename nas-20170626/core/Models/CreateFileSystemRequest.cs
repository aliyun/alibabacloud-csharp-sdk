// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The maximum throughput of the file system. Unit: MB/s. For available values, refer to the specifications on the buy page.
        /// &lt;props=&quot;china&quot;&gt;
        /// <a href="https://common-buy.aliyun.com/?commodityCode=nas_cpfs_post#/buy">Buy page for pay-as-you-go Parallel file systems</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// <a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui&commodityCode=nas_cpfspost_public_intl#/buy">Buy page for pay-as-you-go Parallel file systems</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The capacity of the file system. Unit: GiB. This parameter is required and valid only when FileSystemType is set to extreme, cpfs, or cpfsse. For available values, refer to the specifications on the buy page:
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=nas_extreme_post#/buy">Buy page for pay-as-you-go Extreme NAS file systems</a></description></item>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=nas_cpfs_post#/buy">Buy page for pay-as-you-go Parallel file systems</a></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><a href="https://common-buy-intl.alibabacloud.com/?commodityCode=nas_extpost_public_intl#/buy">Buy page for pay-as-you-go Extreme NAS file systems</a></description></item>
        /// <item><description><a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui&commodityCode=nas_cpfspost_public_intl#/buy">Buy page for pay-as-you-go Parallel file systems</a></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go. This is the default value.</description></item>
        /// <item><description>Subscription: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the file system. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The description of this file system</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the creation request. A dry run helps you check parameter validity and inventory, but does not actually create the instance or incur fees. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run without creating the instance. The system checks whether required parameters are specified, the request format, business limits, and NAS inventory. If the request fails the dry run, the corresponding error is returned. If the request passes the dry run, the HTTP status code 200 is returned and FileSystemId is empty.</description></item>
        /// <item><description>false: performs a normal request and creates the instance directly after the request passes the check. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: months. This parameter is required and valid only when ChargeType is set to Subscription. When a subscription instance expires and is not renewed, the instance is automatically released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the file system. Key Management Service (KMS) is used to manage keys and encrypt data at rest in the file system. You do not need to decrypt the data when you read or write the encrypted data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: not encrypted. This is the default value.</description></item>
        /// <item><description>1: NAS-managed key. NAS-managed keys are supported when FileSystemType is set to standard or extreme.</description></item>
        /// <item><description>2: custom key. Custom keys are supported when FileSystemType is set to standard or extreme.<remarks>
        /// <list type="bullet">
        /// <item><description>Extreme NAS file systems: The custom key (KMS) feature is supported in all regions except China East 1 Finance.</description></item>
        /// <item><description>General-purpose NAS file systems: The custom key (KMS) feature is supported in all regions.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public int? EncryptType { get; set; }

        /// <summary>
        /// <para>The file system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: General-purpose NAS file system. This is the default value.</description></item>
        /// <item><description>extreme: Extreme NAS file system.</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage (locally redundant version).</description></item>
        /// <item><description>cpfsse: Cloud Parallel File Storage SE (zone-redundant version).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The cluster ID in the high-performance network zone. This parameter is required when FileSystemType is set to bmcpfs and cannot be modified after creation. You can call the DescribeSpecifications operation to query available values. Example: B1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key. This parameter is required only when EncryptType is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcbd****-62**-4a**-b605-c58cc1d5****</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The file transfer protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When FileSystemType is set to standard: NFS or SMB.</description></item>
        /// <item><description>When FileSystemType is set to extreme: NFS.</description></item>
        /// <item><description>When FileSystemType is set to cpfs: cpfs.</description></item>
        /// <item><description>When FileSystemType is set to cpfsse: cpfs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The storage redundancy type. This parameter takes effect only for CPFS with ZRS. Valid value: ZRS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZRS</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RedundancyType")]
        [Validation(Required=false)]
        public string RedundancyType { get; set; }

        /// <summary>
        /// <para>The zone-redundant vSwitch IDs. When RedundancyType is set to ZRS, this parameter is required. You must specify three vSwitch IDs, and the vSwitches must reside in three different zones.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RedundancyVSwitchIds")]
        [Validation(Required=false)]
        public List<string> RedundancyVSwitchIds { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can view the resource group ID in the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfdf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot ID. This parameter is supported only for Extreme NAS file systems with the Premium storage type.</para>
        /// <remarks>
        /// <para>When you create a file system from a snapshot, the version of the created file system is the same as the version of the source file system of the snapshot. For example, if the source file system of the snapshot is of version 1 and you want to create a file system of version 2, you can first create File System A from the snapshot, and then create File System B that meets the version 2 configurations. After you copy the data from File System A to File System B, migrate your workloads to File System B.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-extreme-snapsho****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to standard: Performance (performance type), Capacity (capacity type), Premium (premium type), and Agentic (AgenticFS).</description></item>
        /// <item><description>If FileSystemType is set to extreme: standard (standard type) and advance (advanced type).</description></item>
        /// <item><description>If FileSystemType is set to cpfs: advance_100 (100 MB/s/TiB baseline), advance_200 (200 MB/s/TiB baseline), and economic (economy type).</description></item>
        /// <item><description>If FileSystemType is set to cpfsse: advance_100 (100 MB/s/TiB baseline).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Performance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tags. The array length is 1 to 20. If the array contains multiple tag objects, the tag keys must be unique.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFileSystemRequestTag> Tag { get; set; }
        public class CreateFileSystemRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Limits:</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot be empty or an empty string.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length.</description></item>
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nastest</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Limits:</para>
            /// <list type="bullet">
            /// <item><description>The tag value cannot be empty or an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length.</description></item>
            /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description>When FileSystemType is set to cpfs, this parameter is required.</description></item>
        /// <item><description>When FileSystemType is not set to cpfs, this parameter is reserved and does not take effect. You do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp131dkqilvw5pnlt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <list type="bullet">
        /// <item><description>When FileSystemType is set to cpfs or cpfsse, this parameter is required.</description></item>
        /// <item><description>When FileSystemType is set to standard or extreme, this parameter is reserved and does not take effect. You do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp18cx9a7zoh0h9b4****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. A zone is a physical area with independent power grids and networks within a region. When FileSystemType is set to standard, this parameter is optional. By default, an active zone that meets the conditional requirements is randomly selected based on the ProtocolType and StorageType settings. When FileSystemType is set to extreme or cpfs, this parameter is required.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>File systems and Elastic Computing Service (ECS) servers in different zones of the same region can communicate with each other.</description></item>
        /// <item><description>Deploy the file system and the ECS server in the same zone to avoid cross-zone latency.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

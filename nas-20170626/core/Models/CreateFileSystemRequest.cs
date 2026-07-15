// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The maximum throughput of the file system.</para>
        /// <para>Unit: MB/s.</para>
        /// <para>For available specification values, see the actual specifications on the buy page.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://common-buy.aliyun.com/?commodityCode=nas_cpfs_post#/buy">Parallel file system CPFS pay-as-you-go buy page</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui&commodityCode=nas_cpfspost_public_intl#/buy">Parallel file system CPFS pay-as-you-go buy page</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The capacity of the file system. Unit: GiB.
        /// This parameter is required and takes effect only when FileSystemType is set to extreme, cpfs, or cpfsse.</para>
        /// <para>For available values, see the actual specifications on the buy page:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=nas_extreme_post#/buy">Extreme NAS pay-as-you-go buy page</a></description></item>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=nas_cpfs_post#/buy">Parallel file system CPFS pay-as-you-go buy page</a></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://common-buy-intl.alibabacloud.com/?commodityCode=nas_extpost_public_intl#/buy">Extreme NAS pay-as-you-go buy page</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui&commodityCode=nas_cpfspost_public_intl#/buy">Parallel file system CPFS pay-as-you-go buy page</a></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo (default): Pay-as-you-go.</description></item>
        /// <item><description>Subscription: Subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a unique parameter value from your client. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the file system.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>此文件系统的描述。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.</para>
        /// <para>A dry run checks parameter validity and resource availability without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without creating the instance. The check items include required parameters, request format, service limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, HTTP status code 200 is returned, but FileSystemId is empty.  </description></item>
        /// <item><description>false (default): Sends a normal request. After the check succeeds, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <para>Unit: months. This parameter is required and takes effect only when ChargeType is set to Subscription.</para>
        /// <para>If a subscription instance is not renewed upon expiration, the instance is automatically released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the file system.</para>
        /// <para>Uses keys managed by Key Management Service (KMS) to encrypt data stored on the file system. No decryption is required when reading or writing encrypted data.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): Not encrypted.</description></item>
        /// <item><description>1: NAS-managed key. Supported when FileSystemType is set to standard or extreme.</description></item>
        /// <item><description>2: Custom Key (KMS). Supported when FileSystemType is set to standard or extreme.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Extreme NAS: The Custom Key (KMS) feature is supported in all regions except China (Hangzhou) Finance Cloud.</description></item>
        /// <item><description>General-purpose NAS: The Custom Key (KMS) feature is supported in all regions.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public int? EncryptType { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS file system.</description></item>
        /// <item><description>extreme: Extreme NAS file system.</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage (CPFS) (locally redundant).</description></item>
        /// <item><description>cpfsse: Cloud Parallel File Storage (CPFS) SE (zone-redundant).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The KMS key ID.</para>
        /// <para>This parameter is required only when EncryptType is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcbd****-62**-4a**-b605-c58cc1d5****</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The file transfer protocol type.</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to standard, valid values: NFS and SMB.</description></item>
        /// <item><description>If FileSystemType is set to extreme, valid values: NFS.</description></item>
        /// <item><description>If FileSystemType is set to cpfs, valid values: cpfs.</description></item>
        /// <item><description>If FileSystemType is set to cpfsse, valid values: cpfs.</description></item>
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
        /// <para>The storage redundancy type. This parameter takes effect only for CPFS SE.
        /// Valid values: ZRS.</para>
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
        /// <para>The list of zone-redundant vSwitch IDs.
        /// If RedundancyType is set to ZRS, this parameter is required. You must specify three vSwitch IDs, each from a different zone.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RedundancyVSwitchIds")]
        [Validation(Required=false)]
        public List<string> RedundancyVSwitchIds { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can view resource group IDs in the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfdf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// <para>This parameter is supported only for Extreme NAS file systems with the Advanced storage type.</para>
        /// <remarks>
        /// <para>A file system created from a snapshot has the same version as the source file system of the snapshot. For example, if the source file system version is 1 and you want to create a version 2 file system, first create file system A from the snapshot, then create file system B that meets the version 2 configuration. Copy the data from file system A to file system B, and migrate your workloads to file system B after the copy is complete.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-extreme-snapsho****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to standard, valid values: Performance, Capacity, and Premium.</description></item>
        /// <item><description>If FileSystemType is set to extreme, valid values: standard and advance.</description></item>
        /// <item><description>If FileSystemType is set to cpfs, valid values: advance_100 (100 MB/s/TiB baseline), advance_200 (200 MB/s/TiB baseline), and economic.</description></item>
        /// <item><description>If FileSystemType is set to cpfsse, valid values: advance_100 (100 MB/s/TiB baseline).</description></item>
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
        /// <para>The tags.</para>
        /// <para>Array length: 1 to 20. If the array contains multiple tag objects, the tag key (Key) must be unique.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFileSystemRequestTag> Tag { get; set; }
        public class CreateFileSystemRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot be empty.</description></item>
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
            /// <para>The tag value.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The tag value cannot be empty.</description></item>
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
        /// <item><description>If FileSystemType is set to cpfs, this parameter is required.</description></item>
        /// <item><description>If FileSystemType is not set to cpfs, this parameter is reserved and does not take effect. You do not need to configure it.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp131dkqilvw5pnlt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to cpfs or cpfsse, this parameter is required.</description></item>
        /// <item><description>If FileSystemType is set to standard or extreme, this parameter is reserved and does not take effect. You do not need to configure it.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp18cx9a7zoh0h9b4****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>A zone is an independent physical area within a region that has its own power supply and network.</para>
        /// <para>If FileSystemType is set to standard, this parameter is optional. By default, an active zone that matches the conditional ProtocolType and StorageType is randomly selected.</para>
        /// <para>If FileSystemType is set to extreme or cpfs, this parameter is required.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>File systems and Elastic Computing Service (ECS) instances in different zones of the same region can communicate with each other.</description></item>
        /// <item><description>Place the file system and the ECS server in the same zone to avoid cross-zone latency.</description></item>
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

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
        /// <para>Specify a value based on the specifications on the buy page.</para>
        /// <para><a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui%5C&commodityCode=nas_cpfspost_public_intl#/buy">CPFS (Pay-as-you-go)</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>Specify the capacity of the file system. Unit: GiB. This parameter is required and valid when FileSystemType is set to extreme, cpfs, or cpfsse.</para>
        /// <para>Specify a value based on the specifications on the following buy page:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://common-buy-intl.alibabacloud.com/?commodityCode=nas_extpost_public_intl#/buy">Extreme NAS (Pay-as-you-go)</a></description></item>
        /// <item><description><a href="https://common-buy-intl.alibabacloud.com/?spm=5176.nas_overview.0.0.7ea01dbft0dTui%5C&commodityCode=nas_cpfspost_public_intl#/buy">CPFS (Pay-as-you-go)</a></description></item>
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
        /// <item><description>PayAsYouGo (default): pay-as-you-go</description></item>
        /// <item><description>Subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. ClientToken only supports ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
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
        /// <item><description>Must be 2 to 128 characters in length.</description></item>
        /// <item><description>Must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether to precheck the creation request.</para>
        /// <para>The precheck operation helps you check the validity of parameters and verify inventory. It does not actually create instances and does not incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Checks the request without creating an instance. The system checks the required parameters, request syntax, service limits, and available NAS resources. If the request fails to pass the check, an error message is returned. If the request passes the check, the HTTP status code 200 is returned. No value is returned for the FileSystemId parameter.</description></item>
        /// <item><description>false (default): Sends the request. If the request passes the check, the instance is created.</description></item>
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
        /// <para>This parameter is valid and required if ChargeType is set to Subscription. Unit: months.</para>
        /// <para>If you do not renew a subscription file system when the file system expires, the file system is automatically released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt data in the file system.</para>
        /// <para>You can use the keys that are managed by Key Management Service (KMS) to encrypt data in a file system. When you read and write the encrypted data, the data is automatically decrypted.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): The data in the file system is not encrypted.</description></item>
        /// <item><description>1: A NAS-managed key is used to encrypt the data in the file system. This value is valid if FileSystemType is set to standard or extreme.</description></item>
        /// <item><description>2: A KMS-managed key is used to encrypt the data in the file system. This value is valid if the FileSystemType parameter is set to standard or extreme.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Extreme NAS: All regions except China East 1 Finance support KMS-managed keys.</para>
        /// </description></item>
        /// <item><description><para>General-purpose NAS: All regions support KMS-managed keys.</para>
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
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: General-purpose NAS</description></item>
        /// <item><description>extreme: Extreme NAS</description></item>
        /// <item><description>cpfs: CPFS (locally redundant storage)</description></item>
        /// <item><description>cpfsse: CPFS SE (zone-redundant storage)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key.</para>
        /// <para>This parameter is required if EncryptType is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3c0b3885-2adf-483d-8a65-5e280689****</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specify the protocol type.</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to standard, set this parameter to NFS or SMB.</description></item>
        /// <item><description>If FileSystemType is set to extreme, set this parameter to NFS.</description></item>
        /// <item><description>If FileSystemType is set to cpfs, set this parameter to cpfs.</description></item>
        /// <item><description>If FileSystemType is set to cpfsse, set this parameter to cpfs.</description></item>
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
        /// <para>Storage redundancy type. Only available for CPFS SE.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ZRS</description></item>
        /// </list>
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
        /// <para>A list of IDs for the zone-redundant vSwitches. This parameter is required if RedundancyType is set to ZRS. You must enter three vSwitch IDs from three different zones.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RedundancyVSwitchIds")]
        [Validation(Required=false)]
        public List<string> RedundancyVSwitchIds { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can log on to the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a> to view resource group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfdf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// <para>This parameter is available only for advanced Extreme NAS file systems.</para>
        /// <remarks>
        /// <para>You can create a file system from a snapshot. The version of the file system is the same as that of the source file system. For example, the source file system of the snapshot uses version 1. To create a file system of version 2, create File System A from the snapshot and create File System B of version 2. Then copy the data and migrate your business from File System A to File System B.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-xxx</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <list type="bullet">
        /// <item><description>If FileSystemType is set to standard, set this parameter to Performance, Capacity, or Premium.</description></item>
        /// <item><description>If FileSystemType is set to extreme, set this parameter to standard or advance.</description></item>
        /// <item><description>If FileSystemType is set to cpfs, set this parameter to advance_100 (100 MB/s/TiB Baseline), advance_200 (200 MB/s/TiB Baseline), or economic.</description></item>
        /// <item><description>If FileSystemType is set to cpfsse, set this parameter to advance_100 (100 MB/s/TiB Baseline).</description></item>
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
        /// <para>An array of tags.</para>
        /// <para>You can specify up to 20 tags. If you specify multiple tags, each tag key must be unique.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFileSystemRequestTag> Tag { get; set; }
        public class CreateFileSystemRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>Cannot be null or an empty string.</description></item>
            /// <item><description>Can be up to 128 characters in length.</description></item>
            /// <item><description>Cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>Cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
            /// <item><description>Cannot be null or an empty string.</description></item>
            /// <item><description>Can be up to 128 characters in length.</description></item>
            /// <item><description>Cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <item><description>This parameter is required if FileSystemType is set to cpfs.</description></item>
        /// <item><description>If FileSystemType is not set to cpfs, this parameter is reserved and not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2ze37k6jh8ums2fw2****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if FileSystemType is set to cpfs or cpfsse.</description></item>
        /// <item><description>This parameter is reserved and not required if FileSystemType is set to standard or extreme.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1cbv1ljve4j5hlw****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// <para>Each region has multiple isolated locations known as zones. Each zone has its own independent power supply and network.</para>
        /// <para>This parameter is not required if FileSystemType is set to standard. By default, a random zone is selected based on the protocol type and storage type.</para>
        /// <para>This parameter is required if FileSystemType is set to extreme or cpfs.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>An Elastic Compute Service (ECS) instance and a file system that reside in different zones of the same region can access each other.</para>
        /// </description></item>
        /// <item><description><para>We recommend that you select the zone where the ECS instance resides. This prevents cross-zone latency between the file system and the ECS instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

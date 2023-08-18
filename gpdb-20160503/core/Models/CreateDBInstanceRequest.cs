// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. For more information, see [Ensure idempotence](~~327176~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to load a sample dataset after the instance is created. Valid values:
        /// 
        /// - **true**
        /// - **false**
        /// 
        /// If you do not specify this parameter, no sample dataset is loaded.
        /// </summary>
        [NameInMap("CreateSampleData")]
        [Validation(Required=false)]
        public bool? CreateSampleData { get; set; }

        /// <summary>
        /// The edition of the instance. Valid values:
        /// 
        /// - **HighAvailability**: High-availability Edition.
        /// - **Basic**: Basic Edition.
        /// 
        /// > This parameter must be specified when you create an instance in elastic storage mode.
        /// </summary>
        [NameInMap("DBInstanceCategory")]
        [Validation(Required=false)]
        public string DBInstanceCategory { get; set; }

        /// <summary>
        /// The instance type of the instance. For information, see [Instance types](~~86942~~).
        /// 
        /// > This parameter must be specified when you create an instance in reserved storage mode.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The number of compute groups. Valid values: 2, 4, 8, 12, 16, 24, 32, 64, 96, and 128.
        /// 
        /// > This parameter must be specified when you create an instance in reserved storage mode.
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// The resource type of the instance. Valid values:
        /// 
        /// - **StorageElastic**: elastic storage mode.
        /// - **Serverless**: Serverless mode.
        /// - **Classic**: reserved storage mode.
        /// 
        /// > This parameter must be specified.
        /// </summary>
        [NameInMap("DBInstanceMode")]
        [Validation(Required=false)]
        public string DBInstanceMode { get; set; }

        /// <summary>
        /// The ID of the encryption key.
        /// 
        /// > If EncryptionType is set to CloudDisk, you must specify an encryption key that resides in the same region as the cloud disk that is specified by EncryptionType. Otherwise, leave this parameter empty.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The encryption type. Valid values:
        /// 
        /// - **NULL** (default): Encryption is disabled.
        /// - **CloudDisk**: Encryption is enabled on cloud disks, and EncryptionKey is used to specify an encryption key.
        /// 
        /// > Disk encryption cannot be disabled after it is enabled.
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to gpdb.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// - 6.0
        /// - 7.0
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The wait time for the instance that has no traffic to become idle. Minimum value: 60. Default value: 600. Unit: seconds.
        /// 
        /// > This parameter must be specified only when you create an instance in automatic Serverless mode.
        /// </summary>
        [NameInMap("IdleTime")]
        [Validation(Required=false)]
        public int? IdleTime { get; set; }

        /// <summary>
        /// The network type of the instance. Set the value to VPC.
        /// 
        /// > 
        /// - Only the Virtual Private Cloud (VPC) type is supported.
        /// - If you do not specify this parameter, VPC is used.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The specifications of compute nodes.
        /// 
        /// Valid values for High-availability Edition instances in elastic storage mode:
        /// 
        /// - **2C16G**
        /// - **4C32G**
        /// - **16C128G**
        /// 
        /// Valid values for Basic Edition instances in elastic storage mode:
        /// 
        /// - **2C8G**
        /// - **4C16G**
        /// - **8C32G**
        /// - **16C64G**
        /// 
        /// Valid values for instances in Serverless mode:
        /// 
        /// - **4C16G**
        /// - **8C32G**
        /// 
        /// > This parameter must be specified when you create an instance in elastic storage mode or Serverless mode.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// The number of coordinator nodes. Valid values: 1 and 2.
        /// 
        /// > If you do not specify this parameter, 1 is used.
        /// </summary>
        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// - **Postpaid**: pay-as-you-go.
        /// - **Prepaid**: subscription.
        /// > 
        /// - If you do not specify this parameter, Postpaid is used.
        /// - You can obtain more cost savings if you create a subscription instance for one year or longer. We recommend that you select the billing method that best suits your needs.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// - **Month**
        /// - **Year**
        /// > This parameter must be specified when PayType is set to Prepaid.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~86912~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The IP address whitelist of the instance.
        /// 
        /// A value of 127.0.0.1 specifies that no IP address is allowed for external access. You can call the [ModifySecurityIps](~~86928~~) operation to modify the IP address whitelist after you create an instance.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// The performance level of ESSDs. Valid values:
        /// 
        /// - **pl0**
        /// - **pl1**
        /// - **pl2**
        /// > 
        /// - This parameter takes effect only when SegStorageType is set to cloud_essd.
        /// - If you do not specify this parameter, pl1 is used.
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The number of compute nodes.
        /// 
        /// - Valid values for High-availability Edition instances in elastic storage mode: multiples of 4 in the range of 4 to 512.
        /// - Valid values for Basic Edition instances in elastic storage mode: multiples of 2 in the range of 2 to 512.
        /// - Valid values for instances in Serverless mode: multiples of 2 in the range of 2 to 512.
        /// 
        /// > This parameter must be specified when you create an instance in elastic storage mode or Serverless mode.
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// The disk storage type of the instance. Only enhanced SSDs (ESSDs) are supported. Set the value to cloud_essd.
        /// 
        /// > This parameter must be specified when you create an instance in elastic storage mode.
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// The type of the Serverless mode. Valid values:
        /// 
        /// - **Manual** (default): manual scheduling.
        /// - **Auto**: automatic scheduling.
        /// 
        /// > This parameter must be specified only when you create an instance in Serverless mode.
        /// </summary>
        [NameInMap("ServerlessMode")]
        [Validation(Required=false)]
        public string ServerlessMode { get; set; }

        /// <summary>
        /// The threshold of computing resources. Unit: AnalyticDB compute unit (ACU). Valid values: 8 to 32. The value must be in increments of 8 ACUs. Default value: 32.
        /// 
        /// > This parameter must be specified only when you create an instance in automatic Serverless mode.
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public int? ServerlessResource { get; set; }

        [NameInMap("SrcDbInstanceName")]
        [Validation(Required=false)]
        public string SrcDbInstanceName { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: GB. Valid values: 50 to 4000.
        /// 
        /// > This parameter must be specified when you create an instance in elastic storage mode.
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Take note of the following requirements:
            /// 
            /// - The tag key cannot be an empty string.
            /// - The tag key can be up to 128 characters in length.
            /// - The tag key cannot start with `aliyun` or `acs:`, and contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. Take note of the following requirements:
            /// 
            /// - The tag key cannot be an empty string.
            /// - The tag key can be up to 128 characters in length.
            /// - The tag key cannot start with `aliyun` or `acs:`, and contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The subscription duration.
        /// 
        /// - Valid values when Period is set to Month: 1 to 9.
        /// - Valid values when Period is set to Year: 1 to 3.
        /// > This parameter must be specified when PayType is set to Prepaid.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The VPC ID of the instance.
        /// 
        /// > 
        /// - This parameter must be specified.
        /// - The region where the VPC resides must be the same as the region that is specified by RegionId.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the instance.
        /// 
        /// > 
        /// - This parameter must be specified.
        /// - The zone where the vSwitch resides must be the same as the zone that is specified by ZoneId.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// Specifies whether to enable vector engine optimization. Valid values:
        /// 
        /// - **enabled**
        /// - **disabled** (default)
        /// 
        /// > 
        /// - We recommend that you do not enable vector engine optimization in mainstream analysis and real-time data warehousing scenarios.
        /// - We recommend that you enable vector engine optimization in AI Generated Content (AIGC) and vector retrieval scenarios that require the vector analysis engine.
        /// </summary>
        [NameInMap("VectorConfigurationStatus")]
        [Validation(Required=false)]
        public string VectorConfigurationStatus { get; set; }

        /// <summary>
        /// The zone ID of the read-only instance. You can call the [DescribeRegions](~~86912~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

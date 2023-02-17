// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// The password of the root account. The password must meet the following requirements:
        /// 
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   These special characters include ! # $ % ^ & \* ( ) \_ + - =
        /// *   The password must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Default value: false. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > If you set the **ChargeType** parameter to **PrePaid**, this parameter is valid and optional.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The ID of the backup set. You can call the [DescribeBackups](~~62172~~) operation to query the backup set ID.
        /// 
        /// > This parameter is required only when you call this operation to clone an instance. If you specify this parameter, you must also specify the **SrcDBInstanceId** parameter.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The business information. This is an additional parameter.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PostPaid:** pay-as-you-go
        /// *   **PrePaid:** subscription
        /// 
        /// > If you set this parameter to **PrePaid**, you must also specify the **Period** parameter.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster to which the instance belongs.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The coupon code. Default value: `youhuiquan_promotion_option_id_for_blank`.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The instance type. You can also call the [DescribeAvailableResource](~~149719~~) operation to view instance types.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The name of the instance. Valid values:
        /// 
        /// *   The name must start with a letter.
        /// *   The name can contain digits, letters, underscores (\_), and hyphens (-).
        /// *   It must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: GB.
        /// 
        /// The values that can be specified for this parameter vary based on the instance types. For more information, see [Replica set instance types](~~311410~~).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The name of the database.
        /// 
        /// > When you call this operation to clone an instance, you can set the databases that are specified by this parameter for cloning. Otherwise, all databases of the instance are cloned.
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **MongoDB**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// *   **6.0**
        /// *   **5.0**
        /// *   **4.4**
        /// *   **4.2**
        /// *   **4.0**
        /// 
        /// > If you call this operation to clone an instance or restore an instance from the recycle bin, set the value to the engine of the source instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The zone where the hidden node is deployed for multi-zone deployment. Valid values:
        /// 
        /// *   **cn-hangzhou-g**: Hangzhou Zone G
        /// *   **cn-hangzhou-h**: Hangzhou Zone H
        /// *   **cn-hangzhou-i**: Hangzhou Zone I
        /// *   **cn-hongkong-b**: Hongkong Zone B.
        /// *   **cn-hongkong-c**: Hongkong Zone C
        /// *   **cn-hongkong-d**: Hongkong Zone D
        /// *   **cn-wulanchabu-a**: Ulanqab Zone A
        /// *   **cn-wulanchabu-b**: Ulanqab Zone B
        /// *   **cn-wulanchabu-c**: Ulanqab Zone C
        /// *   **ap-southeast-1a**: Singapore Zone A
        /// *   **ap-southeast-1b**: Singapore Zone B
        /// *   **ap-southeast-1c**: Singapore Zone C
        /// *   **ap-southeast-5a**: Jakarta Zone A
        /// *   **ap-southeast-5b**: Jakarta Zone B
        /// *   **ap-southeast-5c**: Jakarta Zone C
        /// *   **eu-central-1a**: Frankfurt Zone A
        /// *   **eu-central-1b**: Frankfurt Zone B
        /// *   **eu-central-1c**: Frankfurt Zone C
        /// 
        /// > 
        /// 
        /// *   This parameter is available and required when the **EngineVersion** parameter is set to **4.4** or **5.0**.
        /// 
        /// *   The value of this parameter cannot be the same as the value of the **ZoneId** or **SecondaryZoneId** parameter.
        /// </summary>
        [NameInMap("HiddenZoneId")]
        [Validation(Required=false)]
        public string HiddenZoneId { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// **VPC**
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription period of the instance. Unit: months.
        /// 
        /// Valid values: **1** to **9**, **12**, **24**, **36**, and **60**.
        /// 
        /// > If you specify the **ChargeType** parameter to **PrePaid**, this parameter is valid and required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The number of **read-only nodes** in the replica set instance. Default value: **0**. Valid values: **0** to **5**.
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent region list.
        /// 
        /// > If you call this operation to clone an instance or restore an instance from the recycle bin, set the value to the engine of the source instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of **nodes** in the replica set instance. Default value: 3. Valid values:
        /// 
        /// *   **3**
        /// *   **5**
        /// *   **7**
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instances you want to query belong.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time to clone the instance, which must be within seven days. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > This parameter is required only when you call this operation to clone an instance. If you specify this parameter, you must also specify the **SrcDBInstanceId** parameter.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The zone where the secondary node is deployed for multi-zone deployment. Valid values:
        /// 
        /// *   **cn-hangzhou-g**: Hangzhou Zone G
        /// *   **cn-hangzhou-h**: Hangzhou Zone H
        /// *   **cn-hangzhou-i**: Hangzhou Zone I
        /// *   **cn-hongkong-b**: Hongkong Zone B.
        /// *   **cn-hongkong-c**: Hongkong Zone C
        /// *   **cn-hongkong-d**: Hongkong Zone D
        /// *   **cn-wulanchabu-a**: Ulanqab Zone A
        /// *   **cn-wulanchabu-b**: Ulanqab Zone B
        /// *   **cn-wulanchabu-c**: Ulanqab Zone C
        /// *   **ap-southeast-1a**: Singapore Zone A
        /// *   **ap-southeast-1b**: Singapore Zone B
        /// *   **ap-southeast-1c**: Singapore Zone C
        /// *   **ap-southeast-5a**: Jakarta Zone A
        /// *   **ap-southeast-5b**: Jakarta Zone B
        /// *   **ap-southeast-5c**: Jakarta Zone C
        /// *   **eu-central-1a**: Frankfurt Zone A
        /// *   **eu-central-1b**: Frankfurt Zone B
        /// *   **eu-central-1c**: Frankfurt Zone C
        /// 
        /// > 
        /// 
        /// *   This parameter is available and required when the **EngineVersion** parameter is set to **4.4** or **5.0**.
        /// 
        /// *   The value of this parameter cannot be the same as the value of the **ZoneId** or **HiddenZoneId** parameter.
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// The IP addresses in an IP address whitelist. Separate multiple IP addresses with commas (,). Each IP address in the IP address whitelist must be unique. The following types of IP addresses are supported:
        /// 
        /// *   0.0.0.0/0
        /// *   IP addresses, such as 10.23.12.24.
        /// *   Classless Inter-Domain Routing (CIDR) blocks, such as 10.23.12.0/24. In this case, /24 indicates that the prefix of each IP address is 24-bit long. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// > 
        /// 
        /// *   A maximum of 1,000 IP addresses and CIDR blocks can be configured for each instance.
        /// 
        /// *   If you enter 0.0.0.0/0, all IP addresses can access the instance. This may introduce security risks to the instance.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the source instance.
        /// 
        /// > This parameter can only be specified when this operation is called to clone instances. You must also specify the **BackupId** parameter or **RestoreTime** parameter. If you call this operation to restore an instance from the recycle bin, this parameter is required. The **BackupId** and **RestoreTime** parameters are not required.
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// The storage engine used by the instance. Set the value to **WiredTiger**.
        /// 
        /// > 
        /// 
        /// *   If you call this operation to clone an instance or restore an instance from the recycle bin, set the value to the engine of the source instance.
        /// 
        /// *   For more information about the limits on database versions and storage engines, see [MongoDB versions and storage engines](~~61906~~).
        /// </summary>
        [NameInMap("StorageEngine")]
        [Validation(Required=false)]
        public string StorageEngine { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_essd1** :ESSD PL1
        /// *   **cloud_essd2**: ESSD PL2
        /// *   **cloud_essd3**: ESSD PL3
        /// *   **local_ssd**: local SSD
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The vSwitch ID of the instance.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

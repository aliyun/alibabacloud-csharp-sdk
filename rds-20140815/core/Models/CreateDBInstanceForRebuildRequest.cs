// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceForRebuildRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 2 to 256 characters in length. The name can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
        /// 
        /// > : The name cannot start with http:// or https://.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/610396.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of the network connection to the instance. Valid values:
        /// 
        /// *   **Internet**
        /// *   **Intranet**
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **VPC**
        /// *   **Classic**
        /// 
        /// Default value: Classic.
        /// 
        /// >  The **VPCId** and **VSwitchId** parameters must be specified when this parameter is set to **VPC**.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the destination instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// >  If you set the PayType parameter to **Prepaid**, you must specify this parameter.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/610399.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. The value of this parameter can be NULL.
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
        /// The IP address whitelist of the serverless instance. For more information, see [Use a database client or the CLI to connect to an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/43185.html). If the IP address whitelist contains more than one entry, separate the entries with commas (,). Each entry must be unique. You can specify up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:
        /// 
        /// *   IP addresses, such as 10.10.XX.XX.
        /// *   CIDR blocks, such as 10.10.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// If this parameter is not specified, the default IP address whitelist is used.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Valid values:
        /// 
        /// *   If you set **Period** to **Year**, the value of **UsedTime** ranges from **1** to **5**.
        /// *   If you set **Period** to **Month**, the value of **UsedTime** ranges from **1** to **11**.
        /// 
        /// > If you set **PayType** to **Prepaid**, you must specify this parameter.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The VPC ID of the instance. If you set **InstanceNetworkType** to **VPC**, you must specify this parameter.
        /// 
        /// > : If you specify this parameter, you must also specify **ZoneId**.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch. The vSwitch must belong to the zone that is specified by **ZoneId**.
        /// 
        /// > 
        /// 
        /// *   If you set **InstanceNetworkType** to **VPC**, you must also specify this parameter.
        /// 
        /// *   If you specify the ZoneSlaveId1 parameter, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the primary instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/26243.html) operation to query the most recent zone list.
        /// 
        /// > If you specify a virtual private cloud (VPC) and a vSwitch, you must specify this parameter to identify the zone for the vSwitch.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The zone ID of the secondary instance.
        /// 
        /// >  If the instance does not run RDS Basic Edition, you must specify this parameter.
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// The zone ID of the logger instance.
        /// 
        /// >  This parameter is available only when the instance runs RDS Enterprise Edition.
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}

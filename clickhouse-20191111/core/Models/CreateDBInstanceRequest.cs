// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set. You can call the [DescribeBackups](~~360339~~) operation to query the backup sets.
        /// 
        /// >  If you want to restore the data of an ApsaraDB for ClickHouse cluster, this parameter is required.
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. The value is a string and can be up to 64 ASCII characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The edition of the cluster. Valid values:
        /// 
        /// *   **Basic**: Single-replica Edition
        /// *   **HighAvailability**: Double-replica Edition
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// The specifications of the cluster.
        /// 
        /// *   Valid values when the cluster is of Single-replica Edition: -**S4**: 4 CPU cores and 16 GB of memory -**S8**: 8 CPU cores and 32 GB of memory -**S16**: 16 CPU cores and 64 GB of memory
        /// 
        ///     *   **S32**: 32 CPU cores and 128 GB of memory
        ///     *   **S64**: 64 CPU cores and 256 GB of memory
        ///     *   **S104**: 104 CPU cores and 384 GB of memory
        /// 
        /// *   Valid values when the cluster is of Double-replica Edition: -**C4**: 4 CPU cores and 16 GB of memory -**C8**: 8 CPU cores and 32 GB of memory -**C16**: 16 CPU cores and 64 GB of memory -**C32**: 32 CPU cores and 128 GB of memory -**C64**: 64 CPU cores and 256 GB of memory -**C104**: 104 CPU cores and 384 GB of memory
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// The description of the cluster.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The network type of the cluster. Only Virtual Private Cloud (VPC) is supported.
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// The kernel version. Valid values:
        /// 
        /// *   **21.8.10.19**
        /// *   **22.8.5.29**
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// The number of nodes.
        /// 
        /// *   Valid values when the cluster is of Single-replica Edition: 1 to 48.
        /// *   Valid values when the cluster is of Double-replica Edition: 1 to 24.
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// The storage capacity of a single node. Valid values: 100 to 32000. Unit: GB.
        /// 
        /// >  This value is a multiple of 100.
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// The storage type of the cluster. Valid values:
        /// 
        /// *   **CloudESSD_PL1**: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.
        /// *   **CloudESSD_PL2**: The cluster uses an ESSD of PL2.
        /// *   **CloudESSD_PL3**: The cluster uses an ESSD of PL3.
        /// *   **CloudEfficiency**: The cluster uses an ultra disk.
        /// </summary>
        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        /// <summary>
        /// You must specify this parameter when EncryptionType is set to CloudDisk.
        /// 
        /// The ID of the key that is used to encrypt data on disks. You can obtain the ID of the key from the Key Management Service (KMS) console. You can also create a key.
        /// 
        /// >  If EncryptionType is empty, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The encryption type. Set the value to **CloudDisk**, which indicates that only disk encryption is supported.
        /// 
        /// >  If this parameter is not specified, data is not encrypted.
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the cluster. Valid values:
        /// 
        /// *   **Postpaid**: The cluster uses the pay-as-you-go billing method.
        /// *   **Prepaid**: The cluster uses the subscription billing method.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. This parameter is required when PayType is set to Prepaid.
        /// 
        /// Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~170875~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the cluster belongs.
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
        /// The ID of the source cluster. You can call the [DescribeDBClusters](~~170879~~) operation to query backup set IDs.
        /// 
        /// >  If you want to restore the data of an ApsaraDB for ClickHouse cluster, this parameter is required.
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        /// <summary>
        /// The subscription duration of the subscription cluster. This parameter is required when PayType is set to Prepaid.
        /// 
        /// Valid values:
        /// 
        /// *   If Period is set to Year, the value of UsedTime must be an integer that ranges from 1 to 3.
        /// *   If Period is set to Month, the value of UsedTime must be an integer that ranges from 1 to 9.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The VPC ID.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// 备专有网络交换机
        /// </summary>
        [NameInMap("VSwitchBak")]
        [Validation(Required=false)]
        public string VSwitchBak { get; set; }

        /// <summary>
        /// 备专有网络交换机2
        /// </summary>
        [NameInMap("VSwitchBak2")]
        [Validation(Required=false)]
        public string VSwitchBak2 { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZondIdBak2")]
        [Validation(Required=false)]
        public string ZondIdBak2 { get; set; }

        /// <summary>
        /// The zone ID. You can call the [DescribeRegions](~~170875~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("ZoneIdBak")]
        [Validation(Required=false)]
        public string ZoneIdBak { get; set; }

    }

}

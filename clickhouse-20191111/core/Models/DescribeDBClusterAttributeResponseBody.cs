// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// The information about the cluster.
        /// </summary>
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyDBCluster DBCluster { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBCluster : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// The scheduled restart time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).
            /// </summary>
            [NameInMap("AppointmentRestartTime")]
            [Validation(Required=false)]
            public string AppointmentRestartTime { get; set; }

            [NameInMap("AvailableUpgradeMajorVersion")]
            [Validation(Required=false)]
            public Dictionary<string, object> AvailableUpgradeMajorVersion { get; set; }

            /// <summary>
            /// The site ID. Valid values:
            /// 
            /// *   **26842**: the China site (aliyun.com)
            /// *   **26888**: the international site (alibabacloud.com)
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// The edition of the cluster. Valid values:
            /// 
            /// *   **Basic**: Single-replica Edition
            /// *   **HighAvailability**: Double-replica Edition
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The commodity code of the cluster.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The VPC endpoint of the cluster.
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// The version of the ApsaraDB for ClickHouse console that is used to manage the cluster. Valid values:
            /// 
            /// *   **v1**
            /// *   **v2**
            /// </summary>
            [NameInMap("ControlVersion")]
            [Validation(Required=false)]
            public string ControlVersion { get; set; }

            /// <summary>
            /// The time when the cluster was created. The value is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the cluster.
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The network type of the cluster. Only VPC is supported.
            /// </summary>
            [NameInMap("DBClusterNetworkType")]
            [Validation(Required=false)]
            public string DBClusterNetworkType { get; set; }

            /// <summary>
            /// The cluster state. Valid values:
            /// 
            /// *   **Preparing**: The cluster is being prepared.
            /// *   **Creating**: The cluster is being created.
            /// *   **Running**: The cluster is running.
            /// *   **Deleting**: The cluster is being deleted.
            /// *   **SCALING_OUT**: The storage capacity of the cluster is being expanded.
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   **Common**: a common cluster
            /// *   **Readonly**: a read-only cluster
            /// *   **Guard**: a disaster recovery cluster
            /// </summary>
            [NameInMap("DBClusterType")]
            [Validation(Required=false)]
            public string DBClusterType { get; set; }

            /// <summary>
            /// The specifications of the cluster.
            /// 
            /// *   Valid values when the cluster is of Single-replica Edition:
            /// 
            ///     *   **S4-NEW**
            ///     *   **S8**
            ///     *   **S16**
            ///     *   **S32**
            ///     *   **S64**
            ///     *   **S104**
            /// 
            /// *   Valid values when the cluster is of Double-replica Edition:
            /// 
            ///     *   **C4-NEW**
            ///     *   **C8**
            ///     *   **C16**
            ///     *   **C32**
            ///     *   **C64**
            ///     *   **C104**
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// The number of nodes.
            /// 
            /// *   Valid values when the cluster is of Single-replica Edition: 1 to 48.
            /// *   Valid values when the cluster is of Double-replica Edition: 1 to 24.
            /// </summary>
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public long? DBNodeCount { get; set; }

            /// <summary>
            /// The storage capacity of a single node of the cluster. Unit: GB.
            /// 
            /// Valid values: 100 to 32000.
            /// 
            /// >  This value is a multiple of 100.
            /// </summary>
            [NameInMap("DBNodeStorage")]
            [Validation(Required=false)]
            public long? DBNodeStorage { get; set; }

            /// <summary>
            /// The Key Management Service (KMS) key that is used to encrypt data.
            /// 
            /// >  If the value of the EncryptionType parameter is off, an empty string is returned for this parameter.
            /// </summary>
            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            /// <summary>
            /// The encryption type. Valid values:
            /// 
            /// *   **CloudDisk**: Disk encryption is enabled.
            /// *   **off**: Data is not encrypted.
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// The type of the database engine.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The latest minor version to which the cluster can be updated.
            /// </summary>
            [NameInMap("EngineLatestMinorVersion")]
            [Validation(Required=false)]
            public string EngineLatestMinorVersion { get; set; }

            /// <summary>
            /// The current minor version.
            /// </summary>
            [NameInMap("EngineMinorVersion")]
            [Validation(Required=false)]
            public string EngineMinorVersion { get; set; }

            /// <summary>
            /// The engine version.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the cluster expired. The time is in the yyyy-MM-ddTHH:mm:ssZ format.
            /// 
            /// >  Pay-as-you-go clusters never expire. If the cluster is a pay-as-you-go cluster, an empty string is returned for this parameter.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The extended storage space. Unit: GB.
            /// </summary>
            [NameInMap("ExtStorageSize")]
            [Validation(Required=false)]
            public int? ExtStorageSize { get; set; }

            /// <summary>
            /// The extended storage type. Valid values:
            /// 
            /// *   **CloudESSD**: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.
            /// *   **CloudESSD_PL2**: The cluster uses an ESSD of PL 2.
            /// *   **CloudESSD_PL3**: The cluster uses an ESSD of PL 3.
            /// *   **CloudEfficiency**: The cluster uses an ultra disk.
            /// </summary>
            [NameInMap("ExtStorageType")]
            [Validation(Required=false)]
            public string ExtStorageType { get; set; }

            /// <summary>
            /// Indicates whether the cluster has expired. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public string IsExpired { get; set; }

            /// <summary>
            /// The lock mode of the cluster. Valid values:
            /// 
            /// *   **Unlock**: The cluster is not locked.
            /// *   **ManualLock**: The cluster is manually locked.
            /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
            /// *   **LockByRestoration**: The cluster is automatically locked because the cluster is about to be rolled back.
            /// *   **LockByDiskQuota**: The cluster is automatically locked because the disk space is exhausted.
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// The cause why the cluster was locked.
            /// 
            /// >  If the value of the LockMode parameter is Unlock, an empty string is returned for this parameter.
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// The update type. If the value of the parameter is **false**, it indicates a manual update.
            /// </summary>
            [NameInMap("MaintainAutoType")]
            [Validation(Required=false)]
            public bool? MaintainAutoType { get; set; }

            /// <summary>
            /// The maintenance window of the cluster. The value is in the HH:mmZ-HH:mmZ format. The time is displayed in UTC.
            /// 
            /// For example, if you set the maintenance window to 00:00Z-01:00Z, the cluster can be maintained from 08:00 (UTC+8) to 09:00 (UTC+8).
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// The billing method of the cluster. Valid values:
            /// 
            /// *   **Postpaid**: indicates the pay-as-you-go billing method.
            /// *   **Prepaid**: indicates the subscription billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The HTTP port number.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The public endpoint.
            /// </summary>
            [NameInMap("PublicConnectionString")]
            [Validation(Required=false)]
            public string PublicConnectionString { get; set; }

            /// <summary>
            /// The IP address that is used to connect to the cluster over the Internet.
            /// </summary>
            [NameInMap("PublicIpAddr")]
            [Validation(Required=false)]
            public string PublicIpAddr { get; set; }

            /// <summary>
            /// The TCP port number in the public endpoint.
            /// </summary>
            [NameInMap("PublicPort")]
            [Validation(Required=false)]
            public string PublicPort { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the data migration task.
            /// </summary>
            [NameInMap("ScaleOutStatus")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus ScaleOutStatus { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus : TeaModel {
                /// <summary>
                /// The progress of the data migration task in percentage.
                /// 
                /// >  This parameter is returned only when the cluster is in the SCALING_OUT state.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The progress of the data migration task. This value is displayed in the following format: Data volume that has been migrated/Total data volume.
                /// 
                /// >  This parameter is returned only when the cluster is in the SCALING_OUT state.
                /// </summary>
                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public string Ratio { get; set; }

            }

            /// <summary>
            /// The storage type of the cluster. Valid values:
            /// 
            /// *   **CloudESSD**: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.
            /// *   **CloudESSD_PL2**: The cluster uses an ESSD of PL 2.
            /// *   **CloudESSD_PL3**: The cluster uses an ESSD of PL 3.
            /// *   **CloudEfficiency**: The cluster uses an ultra disk.
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// Indicates whether data backup is supported. Valid values:
            /// 
            /// *   **1**: Data backup is supported.
            /// *   **2**: Data backup is not supported.
            /// </summary>
            [NameInMap("SupportBackup")]
            [Validation(Required=false)]
            public int? SupportBackup { get; set; }

            /// <summary>
            /// Indicates whether HTTPS ports are supported. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("SupportHttpsPort")]
            [Validation(Required=false)]
            public bool? SupportHttpsPort { get; set; }

            /// <summary>
            /// Indicates whether the cluster supports a MySQL port. Valid values:
            /// 
            /// *   **true**: A MySQL port is supported.
            /// *   **false**: A MySQL port is not supported.
            /// </summary>
            [NameInMap("SupportMysqlPort")]
            [Validation(Required=false)]
            public bool? SupportMysqlPort { get; set; }

            /// <summary>
            /// Indicates whether tiered storage of hot data and cold data is supported. Valid values:
            /// 
            /// *   **1**: Tiered storage of hot data and cold data is supported.
            /// *   **2**: Tiered storage of hot data and cold data is not supported.
            /// </summary>
            [NameInMap("SupportOss")]
            [Validation(Required=false)]
            public int? SupportOss { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterTags Tags { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAttributeResponseBodyDBClusterTagsTag> Tag { get; set; }
                public class DescribeDBClusterAttributeResponseBodyDBClusterTagsTag : TeaModel {
                    /// <summary>
                    /// The tag name.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC in which the cluster is deployed.
            /// </summary>
            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The IP address that is used to connect to the cluster over the VPC.
            /// </summary>
            [NameInMap("VpcIpAddr")]
            [Validation(Required=false)]
            public string VpcIpAddr { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// The list of vSwitch IDs in multi-zone clusters.
            /// </summary>
            [NameInMap("ZoneIdVswitchMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> ZoneIdVswitchMap { get; set; }

            /// <summary>
            /// The ZooKeeper specifications.
            /// </summary>
            [NameInMap("ZookeeperClass")]
            [Validation(Required=false)]
            public string ZookeeperClass { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

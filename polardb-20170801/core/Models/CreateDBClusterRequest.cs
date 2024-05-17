// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the no-activity suspension feature. Default value: false. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("AllowShutDown")]
        [Validation(Required=false)]
        public string AllowShutDown { get; set; }

        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic renewal. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// Default value: **false**.
        /// 
        /// > This parameter is valid only when the **PayType** parameter is set to **Prepaid**.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The retention policy for the backup sets when you delete the cluster. Valid values:
        /// 
        /// *   **ALL**: permanently retains all backups.
        /// *   **LATEST**: permanently retains the last backup. A backup is automatically created before you delete the cluster.
        /// *   **NONE**: No backup sets are retained after the cluster is deleted.
        /// 
        /// The default value is **NONE** after you create a cluster.
        /// 
        /// > 
        /// 
        /// *   This parameter is valid only when the **DBType** parameter is set to **MySQL**.
        /// 
        /// *   This parameter is invalid for serverless clusters.
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The point in time when you want to clone data. Valid values:
        /// 
        /// *   **LATEST**: The data of the latest point in time is cloned.
        /// *   **BackupID**: You can specify the ID of a backup set. In this case, data is cloned based on the specified backup set.
        /// *   **Timestamp**: You can specify a point in time in the past in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// 
        /// Default value: **LATEST**.
        /// 
        /// > If the **CreationOption** parameter is set to **CloneFromRDS**, the value of this parameter must be **LATEST**.
        /// </summary>
        [NameInMap("CloneDataPoint")]
        [Validation(Required=false)]
        public string CloneDataPoint { get; set; }

        /// <summary>
        /// The network type of the cluster. Only virtual private clouds (VPCs) are supported. Set the value to **VPC**.
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// The edition of the cluster. Default value: Normal. Valid values:
        /// 
        /// *   **Normal**: Cluster Edition
        /// *   **Basic**: Single Node Edition
        /// *   **ArchiveNormal**: X-Engine Edition
        /// *   **NormalMultimaster**: Multi-master Cluster Edition
        /// 
        /// > 
        /// 
        /// *   Only when the **DBType** parameter is set to **MySQL** and **the DBVersion** parameter is set to **5.6**, **5.7**, or **8.0**, you can set this parameter to **Basic**.
        /// 
        /// *   Only when the **DBType** parameter is set to **MySQL** and the **DBVersion** parameter is set to **8.0**, you can set this parameter to **ArchiveNormal** or **NormalMultimaster**.
        /// 
        /// For more information, see [Product editions](https://help.aliyun.com/document_detail/183258.html).
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// The method that is used to create a cluster. Valid values:
        /// 
        /// *   **Normal**: creates a PolarDB cluster. For more information about how to perform this operation in the console, see the following topics:
        /// 
        ///     *   [Create a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/58769.html)
        ///     *   [Create a PolarDB for PostgreSQL cluster](https://help.aliyun.com/document_detail/118063.html)
        ///     *   [Create a PolarDB for Oracle cluster](https://help.aliyun.com/document_detail/118182.html)
        /// 
        /// *   **CloneFromPolarDB**: clones data from an existing PolarDB cluster to a new PolarDB cluster. For more information about how to perform this operation in the console, see the following topics:
        /// 
        ///     *   [Clone a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/87966.html)
        ///     *   [Clone a PolarDB for PostgreSQL cluster](https://help.aliyun.com/document_detail/118108.html)
        ///     *   [Clone a PolarDB for Oracle cluster](https://help.aliyun.com/document_detail/118221.html)
        /// 
        /// *   **CloneFromRDS**: clones data from an existing ApsaraDB RDS for MySQL instance to a new PolarDB for MySQL cluster. For more information about how to perform this operation in the console, see [Create a PolarDB for MySQL cluster by cloning an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/121812.html).
        /// 
        /// *   **MigrationFromRDS**: migrates data from an existing ApsaraDB RDS for MySQL instance to a new PolarDB for MySQL cluster. By default, the created PolarDB cluster is in read-only mode, and the binary logging feature is enabled. For more information about how to perform this operation in the console, see [Create a PolarDB for MySQL cluster from an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/121582.html).
        /// 
        /// *   **CreateGdnStandby**: creates a secondary cluster. For more information about how to perform this operation in the console, see [Add a secondary cluster](https://help.aliyun.com/document_detail/160381.html).
        /// 
        /// Default value: **Normal**.
        /// 
        /// > 
        /// 
        /// *   If the **DBType** parameter is set to **MySQL** and the **DBVersion** parameter is set to **5.6** or **5.7**, this parameter can be set to **CloneFromRDS** or **MigrationFromRDS**.
        /// 
        /// *   If the **DBType** parameter is set to **MySQL** and the **DBVersion** parameter is set to **8.0**, this parameter can be set to **CreateGdnStandby**.
        /// </summary>
        [NameInMap("CreationOption")]
        [Validation(Required=false)]
        public string CreationOption { get; set; }

        /// <summary>
        /// The name of the cluster. The name must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The minor version of the database engine. Valid values:
        /// 
        /// *   **8.0.2**
        /// *   **8.0.1**
        /// 
        /// > This parameter is valid only when the **DBType** parameter is set to **MySQL** and the **DBVersion** parameter is set to **8.0**.
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// The specifications of the node.
        /// 
        /// *   For more information about specifications supported by PolarDB for MySQL, see [Specifications of compute nodes](https://help.aliyun.com/document_detail/102542.html).
        /// *   For information about node specifications supported by the Oracle database engine, see [Specifications of compute nodes](https://help.aliyun.com/document_detail/207921.html).
        /// *   For information about node specifications supported by the PostgreSQL database engine, see [Specifications of compute nodes](https://help.aliyun.com/document_detail/209380.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// 标准版节点个数。
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// The type of the database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PostgreSQL**
        /// *   **Oracle**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine.
        /// 
        /// *   Valid values for the MySQL database engine:
        /// 
        ///     *   **5.6**
        ///     *   **5.7**
        ///     *   **8.0**
        /// 
        /// *   Valid values for the PostgreSQL database engine:
        /// 
        ///     *   **11**
        ///     *   **14**
        /// 
        /// *   Valid value for the Oracle database engine: **11**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The time zone of the cluster. The time must be in UTC. You can set the parameter to a value that is on the hour from **-12:00 to +13:00**. Example: 00:00. Default value: **SYSTEM**, which means that the value is the same as the time zone of the region.
        /// 
        /// > This parameter is valid only when the **DBType** parameter is set to **MySQL**.
        /// </summary>
        [NameInMap("DefaultTimeZone")]
        [Validation(Required=false)]
        public string DefaultTimeZone { get; set; }

        /// <summary>
        /// The ID of the Global Database Network (GDN).
        /// 
        /// > This parameter is required only when the **CreationOption** parameter is set to **CreateGdnStandby**.
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// 开启Binlog功能，取值范围如下：
        /// 
        /// - **ON**：集群开启Binlog功能
        /// - **OFF**：集群关闭Binlog功能
        /// > 当参数**DBType**为**MySQL**时，该参数才生效。
        /// </summary>
        [NameInMap("LoosePolarLogBin")]
        [Validation(Required=false)]
        public string LoosePolarLogBin { get; set; }

        /// <summary>
        /// 开启X-Engine存储引擎功能，取值范围如下：
        /// 
        /// - **ON**：集群开启X-Engine引擎
        /// - **OFF**：集群关闭X-Engine引擎
        /// > 当参数**CreationOption**不等于**CreateGdnStandby**，**DBType**为**MySQL**且**DBVersion**为**8.0**时，该参数才生效。开启X-Engine引擎的节点内存规格必须大于等于16 GB。
        /// </summary>
        [NameInMap("LooseXEngine")]
        [Validation(Required=false)]
        public string LooseXEngine { get; set; }

        /// <summary>
        /// 设置开启X-Engine存储引擎比例，取值范围10~90的整数。
        /// > 当参数**LooseXEngine**为**ON**时，该参数才生效。
        /// </summary>
        [NameInMap("LooseXEngineUseMemoryPct")]
        [Validation(Required=false)]
        public string LooseXEngineUseMemoryPct { get; set; }

        /// <summary>
        /// Specifies whether the table names are case-sensitive. Valid values:
        /// 
        /// *   **1**: The table names are case-insensitive.
        /// *   **0**: The table names are case-sensitive.
        /// 
        /// Default value: **1**.
        /// 
        /// > This parameter is valid only when the **DBType** parameter is set to **MySQL**.
        /// </summary>
        [NameInMap("LowerCaseTableNames")]
        [Validation(Required=false)]
        public string LowerCaseTableNames { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the parameter template.
        /// 
        /// > You can call the [DescribeParameterGroups](https://help.aliyun.com/document_detail/207178.html) operation to query the details of all parameter templates of a specified region, such as the ID of a parameter template.
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// The billing method. Valid values:
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
        /// The subscription type of the subscription cluster. This parameter is required only when the PayType parameter is set to **Prepaid**. Valid values:
        /// 
        /// *   **Year**: annual subscription. Unit: years.
        /// *   **Month**: monthly subscription. Unit: months.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// 标准版数据库代理规格。
        /// </summary>
        [NameInMap("ProxyClass")]
        [Validation(Required=false)]
        public string ProxyClass { get; set; }

        /// <summary>
        /// 数据库代理类型，取值范围如下：
        /// 
        /// - **Exclusive**：企业独享版
        /// - **General**：企业通用版
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query available regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The maximum number of PCUs per node for scaling. Valid values: 1 PCU to 32 PCUs.
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// The minimum number of PCUs per node for scaling. Valid values: 1 PCU to 31 PCUs.
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// The maximum number of read-only nodes for scaling. Valid values: 0 to 15.
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// The minimum number of read-only nodes for scaling. Valid values: 0 to 15.
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// The IP whitelist of the cluster.
        /// 
        /// > The whitelist can contain multiple IP addresses. Separate multiple IP addresses with commas (,).
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// The type of the serverless cluster. Set the value to **AgileServerless**.
        /// 
        /// > This parameter is valid only for serverless clusters.
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// The ID of the source ApsaraDB RDS instance or PolarDB cluster. This parameter is required only when the **CreationOption** parameter is set to **MigrationFromRDS**, **CloneFromRDS**, or **CloneFromPolarDB**.
        /// 
        /// *   If the **CreationOption** parameter is set to **MigrationFromRDS** or **CloneFromRDS**, you must set this parameter to the ID of the source ApsaraDB RDS instance. The source ApsaraDB RDS instance must use ApsaraDB RDS for MySQL 5.6, 5.7, or 8.0 High-availability Edition.
        /// *   If the **CreationOption** parameter is set to **CloneFromPolarDB**, you must set this parameter to the ID of the source PolarDB cluster. By default, the value of DBType of the destination cluster must be the same as that of the source cluster. For example, if a MySQL 8.0 cluster is used as the source cluster, you must set the **DBType** parameter to **MySQL** and the **DBVersion** parameter to **8.0** for the destination cluster.
        /// </summary>
        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// 存储热备集群的可用区。适用于标准版3AZ场景。
        /// 
        /// > 开启了多可用区数据强一致，该参数才生效。
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// The storage space that uses the subscription billing method. Unit: GB.
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// The storage type. Valid values for Enterprise Edition:
        /// 
        /// *   **PSL5**
        /// *   **PSL4**
        /// 
        /// Valid values for Standard Edition:
        /// 
        /// *   **ESSDPL1**
        /// *   **ESSDPL2**
        /// *   **ESSDPL3**
        /// 
        /// > This parameter is invalid for serverless clusters.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

        /// <summary>
        /// 集群是否开启了多可用区数据强一致。取值范围：
        /// 
        /// - **ON**：表示开启了多可用区数据强一致，适用于标准版3AZ场景。
        /// 
        /// - **OFF**：表示未开启多可用区数据强一致。
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// Specifies whether to enable transparent data encryption (TDE). Default value: false. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > 
        /// 
        /// *   This parameter is valid only when the **DBType** parameter is set to **PostgreSQL** or **Oracle**.
        /// 
        /// *   You can call the [ModifyDBClusterTDE](https://help.aliyun.com/document_detail/167982.html) operation to enable TDE for a PolarDB for MySQL cluster.
        /// *   TDE cannot be disabled after it is enabled.
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public bool? TDEStatus { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that you want to create for the cluster. To create multiple tags for a cluster at a time, click the **+** icon.
            /// 
            /// > You can create up to 20 key-value pairs of tags at a time. Each value of the `Tag.N.Key` parameter is paired with a value of the `Tag.N.Value` parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that you want to create for the cluster. To create multiple tags for a cluster at a time, click the **+** icon.
            /// 
            /// > You can create up to 20 key-value pairs of tags at a time. Each value of the `Tag.N.Value` parameter is paired with a value of the `Tag.N.Key` parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// *   If the **Period** parameter is set to **Month**, the **UsedTime** parameter can be set to `1, 2, 3, 4, 5, 6, 7, 8, or 9`.
        /// *   If the **Period** parameter is set to **Year**, the **UsedTime** parameter can be set to `1, 2, or 3`.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID of the cluster.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the cluster.
        /// 
        /// > If the VPCId parameter is specified, the VSwitchId parameter is required.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query available zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

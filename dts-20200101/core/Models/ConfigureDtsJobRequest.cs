/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureDtsJobRequest : TeaModel {
        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **MIGRATION**: data migration task
        /// *   **SYNC**: data synchronization task
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("DataCheckConfigure")]
        [Validation(Required=false)]
        public string DataCheckConfigure { get; set; }

        /// <summary>
        /// The objects that you want to migrate or synchronize. The value is a JSON string. For more information, see [Objects of DTS tasks](~~209545~~).
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to add more configurations of the source or destination instance to the DTS task. For example, you can specify the data storage format of the destination Kafka database and the ID of the CEN instance. For more information, see [Reserve](~~273111~~).
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// The start offset of incremental data migration or synchronization. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// The data verification task for a data migration or synchronization instance. The value is a JSON string that indicates parameter limits or alert configurations. For more information, see [DataCheckConfigure](~~459023~~).
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// Specifies whether to monitor the task status. Valid values:
        /// 
        /// *   **true**: monitors the task status.
        /// *   **false**: does not monitor the task status.
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// Specifies whether to monitor the task latency. Valid values:
        /// 
        /// *   **true**: monitors the task latency.
        /// *   **false**: does not monitor the task latency.
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// The mobile numbers that receive status-related alerts. Separate multiple mobile numbers with commas (,).
        /// 
        /// > 
        /// *   This parameter is available only for China site (aliyun.com) users. Only mobile numbers in the Chinese mainland are supported. Up to 10 mobile numbers can be specified.
        /// *   International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can [set alert rules for DTS tasks in the CloudMonitor console](~~175876~~).
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        [NameInMap("DestCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string DestCaCertificateOssUrl { get; set; }

        [NameInMap("DestCaCertificatePassword")]
        [Validation(Required=false)]
        public string DestCaCertificatePassword { get; set; }

        /// <summary>
        /// The password of the destination database account.
        /// 
        /// >  If the destination database is a MaxCompute project, you must specify the AccessKey secret of your Alibaba Cloud account. For information about how to obtain your AccessKey pair, see [Create an AccessKey pair](~~116401~~).
        /// </summary>
        [NameInMap("DestinationEndpointDataBaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDataBaseName { get; set; }

        /// <summary>
        /// The IP address of the destination instance.
        /// 
        /// >  If the **DestinationEndpointInstanceType** parameter is set to **OTHER**, **EXPRESS**, **DG**, or **CEN**, this parameter is available and required.
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// The name of the database to which the objects migrated to the destination instance belong.
        /// 
        /// > 
        /// *   If the destination instance is a PolarDB for Oracle cluster, an AnalyticDB for PostgreSQL instance, a PostgreSQL database, a MaxCompute project, or a MongoDB database, this parameter is available and required.
        /// *   If the destination instance is a MaxCompute project, you must specify the ID of the MaxCompute project.
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// The ID of the region in which the destination instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  If the destination instance is an Alibaba Cloud database instance, this parameter is required.
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// The database engine of the destination instance. Valid values:
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
        /// *   **MARIADB**: ApsaraDB RDS for MariaDB instance
        /// *   **PolarDB**: PolarDB for MySQL cluster
        /// *   **POLARDB_O**: PolarDB for Oracle cluster
        /// *   **POLARDBX10**: PolarDB-X 1.0 instance
        /// *   **POLARDBX20**: PolarDB-X 2.0 instance
        /// *   **ORACLE**: self-managed Oracle database
        /// *   **POSTGRESQL**: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database
        /// *   **MSSQL**: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database
        /// *   **ADS**: AnalyticDB for MySQL V2.0 cluster
        /// *   **ADB30**: AnalyticDB for MySQL V3.0 cluster
        /// *   **MONGODB**: ApsaraDB for MongoDB instance or self-managed MongoDB database
        /// *   **GREENPLUM**: AnalyticDB for PostgreSQL instance
        /// *   **KAFKA**: Message Queue for Apache Kafka instance or self-managed Kafka cluster
        /// *   **DATAHUB**: DataHub project
        /// *   **DB2**: self-managed Db2 for LUW database
        /// *   **AS400**: self-managed Db2 for i database
        /// *   **ODPS**: MaxCompute project
        /// *   **Tablestore**: Tablestore instance
        /// *   **ELK**: Elasticsearch cluster
        /// *   **REDIS**: ApsaraDB for Redis instance or self-managed Redis database
        /// 
        /// > 
        /// *   Default value: **MYSQL**.
        /// *   If the DestinationEndpointEngineName parameter is set to **KAFKA**, **MONGODB**, or **PolarDB**, you must also specify the database information in the Reserve parameter. For more information, see [Reserve](~~273111~~).
        /// </summary>
        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        /// <summary>
        /// The ID of the data migration or synchronization task.
        /// 
        /// >  You must specify at least one of the DtsJobId and **DtsInstanceId** parameters. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        [NameInMap("DestinationEndpointOwnerID")]
        [Validation(Required=false)]
        public string DestinationEndpointOwnerID { get; set; }

        /// <summary>
        /// Specifies whether to perform full data migration or synchronization. Default value: true. Valid values:
        /// 
        /// *   **true**: performs full data migration or synchronization.
        /// *   **false**: does not perform full data migration or synchronization.
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// The database account of the destination database.
        /// 
        /// > 
        /// *   In most cases, this parameter is required.
        /// *   The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see [Prepare the database accounts for data migration](~~175878~~) or [Prepare the database accounts for data synchronization](~~213152~~).
        /// *   If the destination database is a MaxCompute project, you must specify the AccessKey ID of your Alibaba Cloud account. For information about how to obtain your AccessKey pair, see [Create an AccessKey pair](~~116401~~).
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// The database service port of the destination instance.
        /// 
        /// >  If the destination instance is a self-managed database, this parameter is available and required.
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        [NameInMap("DestinationEndpointRole")]
        [Validation(Required=false)]
        public string DestinationEndpointRole { get; set; }

        /// <summary>
        /// Specifies whether to perform schema migration or synchronization. Default value: true. Valid values:
        /// 
        /// *   **true**: performs schema migration or synchronization.
        /// *   **false**: does not perform schema migration or synchronization.
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DisasterRecoveryJob")]
        [Validation(Required=false)]
        public bool? DisasterRecoveryJob { get; set; }

        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// The threshold for triggering latency-related alerts. Unit: seconds. The value must be an integer. You can set the threshold based on your business needs. To prevent jitters caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds.
        /// 
        /// >  If the **DelayNotice** parameter is set to **true**, this parameter is required.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The mobile numbers that receive latency-related alerts. Separate multiple mobile numbers with commas (,).
        /// 
        /// > 
        /// *   This parameter is available only for China site (aliyun.com) users. Only mobile numbers in the Chinese mainland are supported. Up to 10 mobile numbers can be specified.
        /// *   International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can [set alert rules for DTS tasks in the CloudMonitor console](~~175876~~).
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the source instance.
        /// 
        /// If the source instance is an Alibaba Cloud database instance, you must specify the ID of the database instance. For example, if the source instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.
        /// 
        /// If the source instance is a self-managed database, the value of this parameter varies with the value of the **SourceEndpointInstanceType** parameter.****
        /// 
        /// *   If the SourceEndpointInstanceType parameter is set to **ECS**, you must specify the ID of the ECS instance.
        /// *   If the SourceEndpointInstanceType parameter is set to **DG**, you must specify the ID of the database gateway.
        /// *   If the SourceEndpointInstanceType parameter is set to **EXPRESS** or **CEN**, you must specify the ID of the VPC that is connected to the source instance.
        /// 
        /// >  If the SourceEndpointInstanceType parameter is set to **CEN**, you must also specify the ID of the CEN instance in the Reserve parameter. For more information, see [Reserve](~~273111~~).
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**: Data is synchronized from the source database to the destination database.
        /// *   **Reverse**: Data is synchronized from the destination database to the source database.
        /// 
        /// > 
        /// *   Default value: **Forward**.
        /// *   The value **Reverse** takes effect only if the topology of the data synchronization task is two-way synchronization.
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        /// <summary>
        /// Specifies whether the instance is a disaster recovery instance.
        /// 
        /// *   **true**: The instance is a disaster recovery instance.
        /// *   **false**: The instance is not a disaster recovery instance.
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public string FileOssUrl { get; set; }

        /// <summary>
        /// The ID of the data migration or synchronization instance.
        /// 
        /// >  You must specify at least one of the **DtsJobId** and DtsInstanceId parameters. You can call the [DescribeDtsJobs](~~209702~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The URL of the Object Storage Service (OSS) bucket that stores the files related to the DTS task.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The SID of the Oracle database.
        /// 
        /// >  If the **DestinationEndpointEngineName** parameter is set to **ORACLE** and the **Oracle** database is deployed in a non-RAC architecture, this parameter is available and required.
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        /// <summary>
        /// The password of the source database account.
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// The IP address of the source instance.
        /// 
        /// >  If the **SourceEndpointInstanceType** parameter is set to **OTHER**, **EXPRESS**, **DG**, or **CEN**, this parameter is available and required.
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// The system ID (SID) of the Oracle database.
        /// 
        /// >  If the **SourceEndpointEngineName** parameter is set to **ORACLE** and the **Oracle** database is deployed in an architecture that is not a Real Application Cluster (RAC), this parameter is available and required.
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// The ID of the region in which the source instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  If the source instance is an Alibaba Cloud database instance, this parameter is required.
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// The database engine of the source instance. Valid values:
        /// 
        /// *   **MYSQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
        /// *   **MARIADB**: ApsaraDB RDS for MariaDB instance
        /// *   **PolarDB**: PolarDB for MySQL cluster
        /// *   **POLARDB_O**: PolarDB for Oracle cluster
        /// *   **POLARDBX10**: PolarDB-X 1.0 instance
        /// *   **POLARDBX20**: PolarDB-X 2.0 instance
        /// *   **ORACLE**: self-managed Oracle database
        /// *   **POSTGRESQL**: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database
        /// *   **MSSQL**: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database
        /// *   **MONGODB**: ApsaraDB for MongoDB instance or self-managed MongoDB database
        /// *   **DB2**: self-managed Db2 for LUW database
        /// *   **AS400**: self-managed Db2 for i database
        /// *   **DMSPOLARDB**: DMS logical database
        /// *   **HBASE**: self-managed HBase database
        /// *   **TERADATA**: Teradata database
        /// *   **TiDB**: TiDB database
        /// *   **REDIS**: ApsaraDB for Redis instance or self-managed Redis database
        /// 
        /// > 
        /// *   Default value: **MYSQL**.
        /// *   If the SourceEndpointEngineName parameter is set to **MONGODB**, you must also specify the architecture type of the MongoDB database in the Reserve parameter. For more information, see [Reserve](~~273111~~).
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// The database account of the source database.
        /// 
        /// > 
        /// *   In most cases, this parameter is required.
        /// *   The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see [Prepare the database accounts for data migration](~~175878~~) or [Prepare the database accounts for data synchronization](~~213152~~).
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// The type of the destination instance. Valid values:
        /// 
        /// **Alibaba Cloud database instances**
        /// 
        /// *   **RDS**: ApsaraDB RDS for MySQL instance, ApsaraDB RDS for SQL Server instance, ApsaraDB RDS for PostgreSQL instance, or ApsaraDB RDS for MariaDB instance
        /// *   **PolarDB**: PolarDB for MySQL cluster
        /// *   **POLARDBX10**: PolarDB-X 1.0 instance
        /// *   **POLARDBX20**: PolarDB-X 2.0 instance
        /// *   **REDIS**: ApsaraDB for Redis instance
        /// *   **ADS**: AnalyticDB for MySQL V2.0 cluster or AnalyticDB for MySQL V3.0 cluster
        /// *   **MONGODB**: ApsaraDB for MongoDB instance
        /// *   **GREENPLUM**: AnalyticDB for PostgreSQL instance
        /// *   **DATAHUB**: DataHub project
        /// *   **ELK**: Elasticsearch cluster
        /// *   **Tablestore**: Tablestore instance
        /// *   **ODPS**: MaxCompute project
        /// 
        /// **Self-managed databases**
        /// 
        /// *   **OTHER**: self-managed database with a public IP address
        /// *   **ECS**: self-managed database hosted on an ECS instance
        /// *   **EXPRESS**: self-managed database connected over Express Connect
        /// *   **CEN**: self-managed database connected over CEN
        /// *   **DG**: self-managed database connected over Database Gateway
        /// 
        /// > 
        /// *   If the destination instance is a PolarDB for Oracle cluster, you must set this parameter to **OTHER** or **EXPRESS** because you can use a PolarDB for Oracle cluster only as a self-managed database connected over the Internet or Express Connect.
        /// *   If the destination instance is a Message Queue for Apache Kafka instance, you must set this parameter to **ECS** or **EXPRESS** because you can use a Message Queue for Apache Kafka instance only as a self-managed database connected over ECS or Express Connect.
        /// *   For more information, see [Supported databases](~~176064~~).
        /// *   If the destination instance is a self-managed database, you must deploy the network environment for the database. For more information, see [Preparation overview](~~146958~~).
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// The name of the RAM role configured for the Alibaba Cloud account that owns the source instance.
        /// 
        /// >  This parameter is required when you migrate or synchronize data across different Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see [Configure RAM authorization for cross-account data migration and synchronization](~~48468~~).
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// The name of the database to which the objects to be migrated in the source instance belong.
        /// 
        /// >  If the source instance is a PolarDB for Oracle cluster, a PostgreSQL database, or a MongoDB database, this parameter is available and required.
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// The database service port of the source instance.
        /// 
        /// >  If the source instance is a self-managed database, this parameter is available and required.
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// The ID of the destination instance.
        /// 
        /// If the destination instance is an Alibaba Cloud database instance, you must specify the ID of the database instance. For example, if the destination instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.
        /// 
        /// If the destination instance is a self-managed database, the value of this parameter varies with the value of the **DestinationEndpointInstanceType** parameter.****
        /// 
        /// *   If the DestinationEndpointInstanceType parameter is set to **ECS**, you must specify the ID of the ECS instance.
        /// *   If the DestinationEndpointInstanceType parameter is set to **DG**, you must specify the ID of the database gateway.
        /// *   If the DestinationEndpointInstanceType parameter is set to **EXPRESS** or **CEN**, you must specify the ID of the VPC that is connected to the source instance.
        /// 
        /// >  If the DestinationEndpointInstanceType parameter is set to **CEN**, you must also specify the ID of the CEN instance in the Reserve parameter. For more information, see [Reserve](~~273111~~).
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the source instance belongs.
        /// 
        /// >  You can specify this parameter to migrate or synchronize data across different Alibaba Cloud accounts. In this case, you must specify the **SourceEndpointRole** parameter.
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// 数据投递链路交换机实例id
        /// </summary>
        [NameInMap("SourceEndpointVSwitchID")]
        [Validation(Required=false)]
        public string SourceEndpointVSwitchID { get; set; }

        [NameInMap("SrcCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string SrcCaCertificateOssUrl { get; set; }

        [NameInMap("SrcCaCertificatePassword")]
        [Validation(Required=false)]
        public string SrcCaCertificatePassword { get; set; }

        /// <summary>
        /// Specifies whether to perform incremental data migration or synchronization. Default value: false. Valid values:
        /// 
        /// *   **false**: does not perform incremental data migration or synchronization.
        /// *   **true**: performs incremental data migration or synchronization.
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// The ID of the DTS dedicated cluster on which the task runs.
        /// 
        /// >  If this parameter is specified, the task is scheduled to the specified DTS dedicated cluster.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}

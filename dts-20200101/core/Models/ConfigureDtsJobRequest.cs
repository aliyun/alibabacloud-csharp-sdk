// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureDtsJobRequest : TeaModel {
        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration task</description></item>
        /// <item><description><b>SYNC</b>: data synchronization task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1610540493</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fullCheckModel&quot;:1,&quot;fullCheckRatio&quot;:20,&quot;checkMaximumHourEnable&quot;:1,&quot;checkMaximumHour&quot;:1,&quot;fullCheckErrorNotice&quot;:true,&quot;fullCheckValidFailNotice&quot;:true,&quot;fullCheckNoticeValue&quot;:8,&quot;incrementalCheckErrorNotice&quot;:true,&quot;incrementalCheckValidFailNotice&quot;:true,&quot;incrementalCheckValidFailNoticeTimes&quot;:2,&quot;incrementalCheckValidFailNoticePeriod&quot;:1,&quot;incrementalCheckValidFailNoticeValue&quot;:1,&quot;incrementalCheckDelayNotice&quot;:true,&quot;incrementalCheckDelayNoticeTimes&quot;:2,&quot;incrementalCheckDelayNoticePeriod&quot;:1,&quot;incrementalCheckDelayNoticeValue&quot;:60,&quot;fullDataCheck&quot;:true,&quot;incrementalDataCheck&quot;:true,&quot;dataCheckNoticePhone&quot;:&quot;13126800****&quot;,&quot;dataCheckDbList&quot;:&quot;{&quot;dts&quot;:{&quot;name&quot;:&quot;dts&quot;,&quot;all&quot;:true}}&quot;}</para>
        /// </summary>
        [NameInMap("DataCheckConfigure")]
        [Validation(Required=false)]
        public string DataCheckConfigure { get; set; }

        /// <summary>
        /// <para>The objects that you want to migrate or synchronize. The value is a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to add more configurations of the source or destination instance to the DTS task. For example, you can specify the data storage format of the destination Kafka database and the ID of the CEN instance. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// <para>The start offset of incremental data migration or synchronization. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The data verification task for a data migration or synchronization instance. The value is a JSON string that indicates parameter limits or alert configurations. For more information, see <a href="https://help.aliyun.com/document_detail/459023.html">DataCheckConfigure</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the task status.</description></item>
        /// <item><description><b>false</b>: does not monitor the task status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the task latency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the task latency.</description></item>
        /// <item><description><b>false</b>: does not monitor the task latency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// <para>The mobile numbers that receive status-related alerts. Separate multiple mobile numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for China site (aliyun.com) users. Only mobile numbers in the Chinese mainland are supported. Up to 10 mobile numbers can be specified.</description></item>
        /// <item><description>International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can <a href="https://help.aliyun.com/document_detail/175876.html">set alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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

        [NameInMap("DestClientCertOssUrl")]
        [Validation(Required=false)]
        public string DestClientCertOssUrl { get; set; }

        [NameInMap("DestClientKeyOssUrl")]
        [Validation(Required=false)]
        public string DestClientKeyOssUrl { get; set; }

        [NameInMap("DestClientPassword")]
        [Validation(Required=false)]
        public string DestClientPassword { get; set; }

        /// <summary>
        /// <para>The password of the destination database account.</para>
        /// <remarks>
        /// <para> If the destination database is a MaxCompute project, you must specify the AccessKey secret of your Alibaba Cloud account. For information about how to obtain your AccessKey pair, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("DestinationEndpointDataBaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDataBaseName { get; set; }

        /// <summary>
        /// <para>The IP address of the destination instance.</para>
        /// <remarks>
        /// <para> If the <b>DestinationEndpointInstanceType</b> parameter is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The name of the database to which the objects migrated to the destination instance belong.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is a PolarDB for Oracle cluster, an AnalyticDB for PostgreSQL instance, a PostgreSQL database, a MaxCompute project, or a MongoDB database, this parameter is available and required.</description></item>
        /// <item><description>If the destination instance is a MaxCompute project, you must specify the ID of the MaxCompute project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.**.***</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the destination instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> If the destination instance is an Alibaba Cloud database instance, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The database engine of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB instance</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for Oracle cluster</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 instance</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle database</description></item>
        /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL V3.0 cluster</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL instance</description></item>
        /// <item><description><b>KAFKA</b>: Message Queue for Apache Kafka instance or self-managed Kafka cluster</description></item>
        /// <item><description><b>DATAHUB</b>: DataHub project</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database</description></item>
        /// <item><description><b>AS400</b>: self-managed Db2 for i database</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute project</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance</description></item>
        /// <item><description><b>ELK</b>: Elasticsearch cluster</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance or self-managed Redis database</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// <item><description>If the DestinationEndpointEngineName parameter is set to <b>KAFKA</b>, <b>MONGODB</b>, or <b>PolarDB</b>, you must also specify the database information in the Reserve parameter. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPRESS</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// <remarks>
        /// <para> You must specify at least one of the DtsJobId and <b>DtsInstanceId</b> parameters. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        [NameInMap("DestinationEndpointOwnerID")]
        [Validation(Required=false)]
        public string DestinationEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration or synchronization. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs full data migration or synchronization.</description></item>
        /// <item><description><b>false</b>: does not perform full data migration or synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database account of the destination database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, this parameter is required.</description></item>
        /// <item><description>The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare the database accounts for data migration</a> or <a href="https://help.aliyun.com/document_detail/213152.html">Prepare the database accounts for data synchronization</a>.</description></item>
        /// <item><description>If the destination database is a MaxCompute project, you must specify the AccessKey ID of your Alibaba Cloud account. For information about how to obtain your AccessKey pair, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The database service port of the destination instance.</para>
        /// <remarks>
        /// <para> If the destination instance is a self-managed database, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        [NameInMap("DestinationEndpointRole")]
        [Validation(Required=false)]
        public string DestinationEndpointRole { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform schema migration or synchronization. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs schema migration or synchronization.</description></item>
        /// <item><description><b>false</b>: does not perform schema migration or synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisasterRecoveryJob")]
        [Validation(Required=false)]
        public bool? DisasterRecoveryJob { get; set; }

        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency-related alerts. Unit: seconds. The value must be an integer. You can set the threshold based on your business needs. To prevent jitters caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds.</para>
        /// <remarks>
        /// <para> If the <b>DelayNotice</b> parameter is set to <b>true</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsk2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The mobile numbers that receive latency-related alerts. Separate multiple mobile numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for China site (aliyun.com) users. Only mobile numbers in the Chinese mainland are supported. Up to 10 mobile numbers can be specified.</description></item>
        /// <item><description>International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can <a href="https://help.aliyun.com/document_detail/175876.html">set alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// <para>If the source instance is an Alibaba Cloud database instance, you must specify the ID of the database instance. For example, if the source instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>If the source instance is a self-managed database, the value of this parameter varies with the value of the <b>SourceEndpointInstanceType</b> parameter.****</para>
        /// <list type="bullet">
        /// <item><description>If the SourceEndpointInstanceType parameter is set to <b>ECS</b>, you must specify the ID of the ECS instance.</description></item>
        /// <item><description>If the SourceEndpointInstanceType parameter is set to <b>DG</b>, you must specify the ID of the database gateway.</description></item>
        /// <item><description>If the SourceEndpointInstanceType parameter is set to <b>EXPRESS</b> or <b>CEN</b>, you must specify the ID of the VPC that is connected to the source instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the SourceEndpointInstanceType parameter is set to <b>CEN</b>, you must also specify the ID of the CEN instance in the Reserve parameter. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsmysql_to_mysql</para>
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: Data is synchronized from the source database to the destination database.</description></item>
        /// <item><description><b>Reverse</b>: Data is synchronized from the destination database to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// <item><description>The value <b>Reverse</b> takes effect only if the topology of the data synchronization task is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a disaster recovery instance.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is a disaster recovery instance.</description></item>
        /// <item><description><b>false</b>: The instance is not a disaster recovery instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb">http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb</a>**************</para>
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public string FileOssUrl { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization instance.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>DtsJobId</b> and DtsInstanceId parameters. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public double? MinDu { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The URL of the Object Storage Service (OSS) bucket that stores the files related to the DTS task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SID of the Oracle database.</para>
        /// <remarks>
        /// <para> If the <b>DestinationEndpointEngineName</b> parameter is set to <b>ORACLE</b> and the <b>Oracle</b> database is deployed in a non-RAC architecture, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;srcInstanceId&quot;: &quot;cen-9kqshqum*******&quot;  }</para>
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The password of the source database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdatabase</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The IP address of the source instance.</para>
        /// <remarks>
        /// <para> If the <b>SourceEndpointInstanceType</b> parameter is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The system ID (SID) of the Oracle database.</para>
        /// <remarks>
        /// <para> If the <b>SourceEndpointEngineName</b> parameter is set to <b>ORACLE</b> and the <b>Oracle</b> database is deployed in an architecture that is not a Real Application Cluster (RAC), this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.**.***</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the source instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> If the source instance is an Alibaba Cloud database instance, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1imrtn6fq7h****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The database engine of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB instance</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for Oracle cluster</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 instance</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle database</description></item>
        /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database</description></item>
        /// <item><description><b>AS400</b>: self-managed Db2 for i database</description></item>
        /// <item><description><b>DMSPOLARDB</b>: DMS logical database</description></item>
        /// <item><description><b>HBASE</b>: self-managed HBase database</description></item>
        /// <item><description><b>TERADATA</b>: Teradata database</description></item>
        /// <item><description><b>TiDB</b>: TiDB database</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance or self-managed Redis database</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// <item><description>If the SourceEndpointEngineName parameter is set to <b>MONGODB</b>, you must also specify the architecture type of the MongoDB database in the Reserve parameter. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The database account of the source database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, this parameter is required.</description></item>
        /// <item><description>The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare the database accounts for data migration</a> or <a href="https://help.aliyun.com/document_detail/213152.html">Prepare the database accounts for data synchronization</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The type of the destination instance. Valid values:</para>
        /// <para><b>Alibaba Cloud database instances</b></para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance, ApsaraDB RDS for SQL Server instance, ApsaraDB RDS for PostgreSQL instance, or ApsaraDB RDS for MariaDB instance</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 instance</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster or AnalyticDB for MySQL V3.0 cluster</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL instance</description></item>
        /// <item><description><b>DATAHUB</b>: DataHub project</description></item>
        /// <item><description><b>ELK</b>: Elasticsearch cluster</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute project</description></item>
        /// </list>
        /// <para><b>Self-managed databases</b></para>
        /// <list type="bullet">
        /// <item><description><b>OTHER</b>: self-managed database with a public IP address</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on an ECS instance</description></item>
        /// <item><description><b>EXPRESS</b>: self-managed database connected over Express Connect</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over CEN</description></item>
        /// <item><description><b>DG</b>: self-managed database connected over Database Gateway</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is a PolarDB for Oracle cluster, you must set this parameter to <b>OTHER</b> or <b>EXPRESS</b> because you can use a PolarDB for Oracle cluster only as a self-managed database connected over the Internet or Express Connect.</description></item>
        /// <item><description>If the destination instance is a Message Queue for Apache Kafka instance, you must set this parameter to <b>ECS</b> or <b>EXPRESS</b> because you can use a Message Queue for Apache Kafka instance only as a self-managed database connected over ECS or Express Connect.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/176064.html">Supported databases</a>.</description></item>
        /// <item><description>If the destination instance is a self-managed database, you must deploy the network environment for the database. For more information, see <a href="https://help.aliyun.com/document_detail/146958.html">Preparation overview</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The name of the RAM role configured for the Alibaba Cloud account that owns the source instance.</para>
        /// <remarks>
        /// <para> This parameter is required when you migrate or synchronize data across different Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The name of the database to which the objects to be migrated in the source instance belong.</para>
        /// <remarks>
        /// <para> If the source instance is a PolarDB for Oracle cluster, a PostgreSQL database, or a MongoDB database, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The database service port of the source instance.</para>
        /// <remarks>
        /// <para> If the source instance is a self-managed database, this parameter is available and required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance.</para>
        /// <para>If the destination instance is an Alibaba Cloud database instance, you must specify the ID of the database instance. For example, if the destination instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>If the destination instance is a self-managed database, the value of this parameter varies with the value of the <b>DestinationEndpointInstanceType</b> parameter.****</para>
        /// <list type="bullet">
        /// <item><description>If the DestinationEndpointInstanceType parameter is set to <b>ECS</b>, you must specify the ID of the ECS instance.</description></item>
        /// <item><description>If the DestinationEndpointInstanceType parameter is set to <b>DG</b>, you must specify the ID of the database gateway.</description></item>
        /// <item><description>If the DestinationEndpointInstanceType parameter is set to <b>EXPRESS</b> or <b>CEN</b>, you must specify the ID of the VPC that is connected to the source instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the DestinationEndpointInstanceType parameter is set to <b>CEN</b>, you must also specify the ID of the CEN instance in the Reserve parameter. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the source instance belongs.</para>
        /// <remarks>
        /// <para> You can specify this parameter to migrate or synchronize data across different Alibaba Cloud accounts. In this case, you must specify the <b>SourceEndpointRole</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>数据投递链路交换机实例id</para>
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

        [NameInMap("SrcClientCertOssUrl")]
        [Validation(Required=false)]
        public string SrcClientCertOssUrl { get; set; }

        [NameInMap("SrcClientKeyOssUrl")]
        [Validation(Required=false)]
        public string SrcClientKeyOssUrl { get; set; }

        [NameInMap("SrcClientPassword")]
        [Validation(Required=false)]
        public string SrcClientPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform incremental data migration or synchronization. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: does not perform incremental data migration or synchronization.</description></item>
        /// <item><description><b>true</b>: performs incremental data migration or synchronization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// <para>The ID of the DTS dedicated cluster on which the task runs.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the task is scheduled to the specified DTS dedicated cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}

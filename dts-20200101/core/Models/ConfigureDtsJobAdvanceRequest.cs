// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureDtsJobAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The start offset of incremental data migration or incremental data synchronization. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1610540493</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The parameters for data verification, including the configurations for data verification and alerts. The value is a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/459023.html">DataCheckConfigure parameter description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fullCheckModel&quot;:1,&quot;fullCheckRatio&quot;:20,&quot;checkMaximumHourEnable&quot;:1,&quot;checkMaximumHour&quot;:1,&quot;fullCheckErrorNotice&quot;:true,&quot;fullCheckValidFailNotice&quot;:true,&quot;fullCheckNoticeValue&quot;:8,&quot;incrementalCheckErrorNotice&quot;:true,&quot;incrementalCheckValidFailNotice&quot;:true,&quot;incrementalCheckValidFailNoticeTimes&quot;:2,&quot;incrementalCheckValidFailNoticePeriod&quot;:1,&quot;incrementalCheckValidFailNoticeValue&quot;:1,&quot;incrementalCheckDelayNotice&quot;:true,&quot;incrementalCheckDelayNoticeTimes&quot;:2,&quot;incrementalCheckDelayNoticePeriod&quot;:1,&quot;incrementalCheckDelayNoticeValue&quot;:60,&quot;fullDataCheck&quot;:true,&quot;incrementalDataCheck&quot;:true,&quot;dataCheckNoticePhone&quot;:&quot;13126800****&quot;,&quot;dataCheckDbList&quot;:{&quot;dts&quot;:{&quot;name&quot;:&quot;dts&quot;,&quot;all&quot;:true}}}</para>
        /// </summary>
        [NameInMap("DataCheckConfigure")]
        [Validation(Required=false)]
        public string DataCheckConfigure { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration or full data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, set this parameter to <b>false</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform incremental data migration or incremental data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, set this parameter to <b>false</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// <para>The objects that you want to migrate or synchronize. The value is a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The ID of the DTS dedicated cluster on which the task runs.</para>
        /// <remarks>
        /// <para>If this parameter is specified, the task is scheduled to the specified DTS dedicated cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor task latency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers to which latency-related alerts are sent. Separate multiple mobile phone numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for users of the China site (aliyun.com). Only mobile phone numbers in the Chinese mainland are supported. You can specify up to 10 mobile phone numbers.</description></item>
        /// <item><description>Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phone numbers, but can configure alert rules for DTS tasks in the CloudMonitor console. For more information, see <a href="https://help.aliyun.com/document_detail/175876.html">Configure alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// <para>The threshold for latency alerts. Unit: seconds. The value must be an integer. You can set the threshold based on your business requirements. To prevent unstable latency caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds.</para>
        /// <remarks>
        /// <para>If <b>DelayNotice</b> is set to <b>true</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// <para>The path of the CA certificate that is used if the connection to the destination database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string DestCaCertificateOssUrl { get; set; }

        /// <summary>
        /// <para>The key of the CA certificate that is used if the connection to the destination database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestCaCertificatePassword")]
        [Validation(Required=false)]
        public string DestCaCertificatePassword { get; set; }

        /// <summary>
        /// <para>The path to the client certificate that is used if the connection to the destination database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestClientCertOssUrl")]
        [Validation(Required=false)]
        public string DestClientCertOssUrl { get; set; }

        /// <summary>
        /// <para>The path to the private key of the client certificate that is used if the connection to the destination database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestClientKeyOssUrl")]
        [Validation(Required=false)]
        public string DestClientKeyOssUrl { get; set; }

        /// <summary>
        /// <para>The password of the private key of the client certificate that is used if the connection to the destination database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestClientPassword")]
        [Validation(Required=false)]
        public string DestClientPassword { get; set; }

        /// <summary>
        /// <para>VPCNAT destination main VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestPrimaryVswId")]
        [Validation(Required=false)]
        public string DestPrimaryVswId { get; set; }

        /// <summary>
        /// <para>VPCNAT destination backup VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestSecondaryVswId")]
        [Validation(Required=false)]
        public string DestSecondaryVswId { get; set; }

        /// <summary>
        /// <para>The name of the database to which the objects are migrated or synchronized in the destination instance.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is valid and required only if the destination database is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, an AnalyticDB for PostgreSQL instance, a PostgreSQL database, a MaxCompute project, or a MongoDB database.</description></item>
        /// <item><description>If the destination instance is a MaxCompute project, you must specify the MaxCompute project ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("DestinationEndpointDataBaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDataBaseName { get; set; }

        /// <summary>
        /// <para>The type of the destination database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database.</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB instance.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster.</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for PostgreSQL (Compatible with Oracle) cluster.</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 instance (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance.</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle database.</description></item>
        /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database.</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database.</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster.</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL V3.0 cluster.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database.</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL instance.</description></item>
        /// <item><description><b>KAFKA</b>: ApsaraMQ for Kafka instance or self-managed Kafka cluster.</description></item>
        /// <item><description><b>DATAHUB</b>: DataHub project.</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database.</description></item>
        /// <item><description><b>AS400</b>: Db2 for i database.</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute project.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance.</description></item>
        /// <item><description><b>ELK</b>: Elasticsearch cluster.</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance or self-managed Redis database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// <item><description>If this parameter is set to <b>KAFKA</b>, <b>MONGODB</b>, or <b>PolarDB</b>, you must also specify the database information in Reserve. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The IP address of the destination instance.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if <b>DestinationEndpointInstanceType</b> is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c>*</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The destination instance ID.</para>
        /// <para>If the destination instance is an Alibaba Cloud database instance, you must specify the database instance ID. For example, if the destination instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>If the destination instance is a self-managed database, the value of this parameter varies with the value of <b>DestinationEndpointInstanceType</b>.****</para>
        /// <list type="bullet">
        /// <item><description>If DestinationEndpointInstanceType is set to <b>ECS</b>, you must specify the ECS instance ID.</description></item>
        /// <item><description>If DestinationEndpointInstanceType is set to <b>DG</b>, you must specify the database gateway ID.</description></item>
        /// <item><description>If DestinationEndpointInstanceType is set to <b>EXPRESS</b> or <b>CEN</b>, you must specify the ID of the VPC that is connected to the source instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If DestinationEndpointInstanceType is set to <b>CEN</b>, you must also specify the ID of the CEN instance in Reserve. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The type of the destination instance. Valid values:</para>
        /// <para><b>Alibaba Cloud database instance</b></para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance, ApsaraDB RDS for SQL Server instance, ApsaraDB RDS for PostgreSQL instance, or ApsaraDB RDS for MariaDB instance.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster.</description></item>
        /// <item><description><b>DISTRIBUTED_POLARDBX10</b>: PolarDB-X 1.0 instance (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance.</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance.</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster or AnalyticDB for MySQL V3.0 cluster.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance.</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL instance.</description></item>
        /// <item><description><b>DATAHUB</b>: DataHub project.</description></item>
        /// <item><description><b>ELK</b>: Elasticsearch cluster.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance.</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute project.</description></item>
        /// </list>
        /// <para><b>Self-managed database</b></para>
        /// <list type="bullet">
        /// <item><description><b>OTHER</b>: self-managed database with a public IP address.</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on an ECS instance.</description></item>
        /// <item><description><b>EXPRESS</b>: self-managed database connected over Express Connect.</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN).</description></item>
        /// <item><description><b>DG</b>: self-managed database connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, you must connect the cluster to DTS as a self-managed database by using a public IP address or Express Connect and set this parameter to <b>OTHER</b> or <b>EXPRESS</b>.</description></item>
        /// <item><description>If the destination instance is an ApsaraMQ for Kafka instance, you must connect the instance to DTS as a self-managed database by using ECS or Express Connect and set this parameter to <b>ECS</b> or <b>EXPRESS</b>.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/176064.html">Supported source and destination databases</a>.</description></item>
        /// <item><description>If the destination instance is a self-managed database, you must deploy the network environment for the database. For more information, see <a href="https://help.aliyun.com/document_detail/146958.html">Preparation overview</a>.</description></item>
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
        /// <para>The SID of the Oracle database.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if <b>DestinationEndpointEngineName</b> is set to <b>ORACLE</b> and the <b>Oracle</b> database is deployed in a non-RAC architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the destination ApsaraDB RDS for MySQL instance belongs.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only if the destination instance is an ApsaraDB RDS for MySQL instance.</description></item>
        /// <item><description>You can specify this parameter to migrate or synchronize data across different Alibaba Cloud accounts. In this case, you must specify <b>DestinationEndpointRole</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("DestinationEndpointOwnerID")]
        [Validation(Required=false)]
        public string DestinationEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to log on to the destination database.</para>
        /// <remarks>
        /// <para>If the destination database is a MaxCompute project, you must specify the AccessKey secret of your Alibaba Cloud account. For information about how to obtain an AccessKey pair, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port number of the destination instance.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if the destination instance is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the destination instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the destination instance is an Alibaba Cloud database instance, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// <para>The name of the RAM role configured for the Alibaba Cloud account to which the destination instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if you migrate or synchronize data across Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account DTS tasks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("DestinationEndpointRole")]
        [Validation(Required=false)]
        public string DestinationEndpointRole { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to log on to the destination database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, this parameter is required.</description></item>
        /// <item><description>The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare the database accounts for data migration</a> or <a href="https://help.aliyun.com/document_detail/213152.html">Prepare the database accounts for data synchronization</a>.</description></item>
        /// <item><description>If the destination database is a MaxCompute project, you must specify the AccessKey ID of your Alibaba Cloud account. For information about how to obtain an AccessKey pair, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a disaster recovery instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisasterRecoveryJob")]
        [Validation(Required=false)]
        public bool? DisasterRecoveryJob { get; set; }

        /// <summary>
        /// <para>The environment tag of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>****</description></item>
        /// <item><description><b>online</b>****</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsk2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>k2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The name of the DTS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsmysql_to_mysql</para>
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers to which status-related alerts are sent. Separate multiple mobile phone numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for users of the China site (aliyun.com). Only mobile phone numbers in the Chinese mainland are supported. You can specify up to 10 mobile phone numbers.</description></item>
        /// <item><description>Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phone numbers, but can configure alert rules for DTS tasks in the CloudMonitor console. For more information, see <a href="https://help.aliyun.com/document_detail/175876.html">Configure alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        /// <summary>
        /// <para>The URL of the Object Storage Service (OSS) bucket that stores the files related to the DTS task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb">http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb</a>**************</para>
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public Stream FileOssUrlObject { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration task.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization task.</description></item>
        /// <item><description><b>CHECK</b>: data verification task. You must separately purchase a data verification instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>MIGRATION</b> or <b>SYNC</b>, you can also enable data verification in the data migration or synchronization task.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The maximum number of DUs.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        /// <summary>
        /// <para>The minimum number of DTS Units (DUs).</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public double? MinDu { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to add more configurations of the source or destination instance to the DTS task. For example, you can specify the data storage format of the destination Kafka database and the CEN instance ID. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;srcInstanceId&quot;: &quot;cen-9kqshqum*******&quot;  }</para>
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the database from which the objects are migrated or synchronized in the source instance.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if the source instance is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, a PostgreSQL database, or a MongoDB database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdatabase</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database type of the source instance.</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database.</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB instance.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster.</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for PostgreSQL (Compatible with Oracle) cluster.</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 instance (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance.</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle database.</description></item>
        /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL instance or self-managed PostgreSQL database.</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database.</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database.</description></item>
        /// <item><description><b>AS400</b>: self-managed Db2 for i database.</description></item>
        /// <item><description><b>DMSPOLARDB</b>: DMS logical database.</description></item>
        /// <item><description><b>HBASE</b>: self-managed HBase database.</description></item>
        /// <item><description><b>TERADATA</b>: Teradata database.</description></item>
        /// <item><description><b>TiDB</b>: TiDB database.</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance or self-managed Redis database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// <item><description>If this parameter is set to <b>MONGODB</b>, you must also specify the architecture type of the MongoDB database in Reserve. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The IP address of the source instance.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if <b>SourceEndpointInstanceType</b> is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c>*</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The source instance ID.</para>
        /// <para>If the source instance is an Alibaba Cloud database instance, you must specify the database instance ID. For example, if the source instance is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>If the source instance is a self-managed database, the value of this parameter varies with the value of <b>SourceEndpointInstanceType</b>.****</para>
        /// <list type="bullet">
        /// <item><description>If SourceEndpointInstanceType is set to <b>ECS</b>, you must specify the ECS instance ID.</description></item>
        /// <item><description>If SourceEndpointInstanceType is set to <b>DG</b>, you must specify the database gateway ID.</description></item>
        /// <item><description>If SourceEndpointInstanceType is set to <b>EXPRESS</b> or <b>CEN</b>, you must specify the ID of the virtual private cloud (VPC) that is connected to the source instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If SourceEndpointInstanceType is set to <b>CEN</b>, you must also specify the ID of the CEN instance in Reserve. For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1imrtn6fq7h****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values:</para>
        /// <para><b>Alibaba Cloud database instance</b></para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance, ApsaraDB RDS for SQL Server instance, ApsaraDB RDS for PostgreSQL instance, or ApsaraDB RDS for MariaDB instance</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster.</description></item>
        /// <item><description><b>REDIS</b>: ApsaraDB for Redis instance.</description></item>
        /// <item><description><b>DISTRIBUTED_POLARDBX10</b>: PolarDB-X 1.0 instance (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0 instance.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB instance.</description></item>
        /// <item><description><b>DISTRIBUTED_DMSLOGICDB</b>: Data Management (DMS) logical database</description></item>
        /// </list>
        /// <para><b>Self-managed database</b></para>
        /// <list type="bullet">
        /// <item><description><b>OTHER</b>: self-managed database with a public IP address.</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on an ECS instance.</description></item>
        /// <item><description><b>EXPRESS</b>: self-managed database connected over Express Connect.</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN).</description></item>
        /// <item><description><b>DG</b>: self-managed database connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the source instance is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, you must connect the cluster to DTS as a self-managed database by using a public IP address or Express Connect and set this parameter to <b>OTHER</b> or <b>EXPRESS</b>.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/176064.html">Supported sources and targets</a>.</description></item>
        /// <item><description>If the source instance is a self-managed database, you must deploy the network environment for the database. For more information, see <a href="https://help.aliyun.com/document_detail/146958.html">Preparation overview</a>.</description></item>
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
        /// <para>The SID of the Oracle database.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only if <b>SourceEndpointEngineName</b> is set to <b>ORACLE</b> and the <b>Oracle</b> database is deployed in a non-Real Application Cluster (RAC) architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the source database belongs.</para>
        /// <remarks>
        /// <para>You can specify this parameter to migrate or synchronize data across different Alibaba Cloud accounts. In this case, you must specify <b>SourceEndpointRole</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to log on to the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port number of the source instance.</para>
        /// <remarks>
        /// <para>This parameter is required only if the source instance is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the source instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the source instance is an Alibaba Cloud database instance, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role configured for the Alibaba Cloud account to which the source instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if you migrate or synchronize data across different Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account DTS tasks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to log on to the source database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, this parameter is required.</description></item>
        /// <item><description>The permissions that are required for the database account vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare the database accounts for data migration</a> or <a href="https://help.aliyun.com/document_detail/213152.html">Prepare the database accounts for data synchronization</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is used for data shipping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10df3mxae6lpmku****</para>
        /// </summary>
        [NameInMap("SourceEndpointVSwitchID")]
        [Validation(Required=false)]
        public string SourceEndpointVSwitchID { get; set; }

        /// <summary>
        /// <para>The path of the certificate authority (CA) certificate that is used if the connection to the source database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string SrcCaCertificateOssUrl { get; set; }

        /// <summary>
        /// <para>The key of the CA certificate that is used if the connection to the source database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcCaCertificatePassword")]
        [Validation(Required=false)]
        public string SrcCaCertificatePassword { get; set; }

        /// <summary>
        /// <para>The path to the client certificate that is used if the connection to the source database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientCertOssUrl")]
        [Validation(Required=false)]
        public string SrcClientCertOssUrl { get; set; }

        /// <summary>
        /// <para>The path to the private key of the client certificate that is used if the connection to the source database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientKeyOssUrl")]
        [Validation(Required=false)]
        public string SrcClientKeyOssUrl { get; set; }

        /// <summary>
        /// <para>The password of the private key of the client certificate that is used if the connection to the source database is encrypted by using SSL.</para>
        /// <remarks>
        /// <para>This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientPassword")]
        [Validation(Required=false)]
        public string SrcClientPassword { get; set; }

        /// <summary>
        /// <para>VPCNAT source end main VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPrimaryVswId")]
        [Validation(Required=false)]
        public string SrcPrimaryVswId { get; set; }

        /// <summary>
        /// <para>VPCNAT source backup VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcSecondaryVswId")]
        [Validation(Required=false)]
        public string SrcSecondaryVswId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform schema migration or schema synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, set this parameter to <b>false</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b></description></item>
        /// <item><description><b>Reverse</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>Forward</b>.</description></item>
        /// <item><description>The value <b>Reverse</b> takes effect only if the topology of the data synchronization task is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}

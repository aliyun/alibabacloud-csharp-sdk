// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureDtsJobRequest : TeaModel {
        /// <summary>
        /// <para>The start position for incremental data migration or the synchronization checkpoint, in the format of a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>If you specify the <b>Checkpoint</b> parameter, make sure that no other running DTS instance has the same source database as the destination DTS instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610540493</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The parameters of the data validation node, in JSON character string format, such as parameter limits and alert configuration. For more information, see <a href="https://help.aliyun.com/document_detail/459023.html">DataCheckConfigure parameter description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fullCheckModel&quot;:1,&quot;fullCheckRatio&quot;:20,&quot;checkMaximumHourEnable&quot;:1,&quot;checkMaximumHour&quot;:1,&quot;fullCheckErrorNotice&quot;:true,&quot;fullCheckValidFailNotice&quot;:true,&quot;fullCheckNoticeValue&quot;:8,&quot;incrementalCheckErrorNotice&quot;:true,&quot;incrementalCheckValidFailNotice&quot;:true,&quot;incrementalCheckValidFailNoticeTimes&quot;:2,&quot;incrementalCheckValidFailNoticePeriod&quot;:1,&quot;incrementalCheckValidFailNoticeValue&quot;:1,&quot;incrementalCheckDelayNotice&quot;:true,&quot;incrementalCheckDelayNoticeTimes&quot;:2,&quot;incrementalCheckDelayNoticePeriod&quot;:1,&quot;incrementalCheckDelayNoticeValue&quot;:60,&quot;fullDataCheck&quot;:true,&quot;incrementalDataCheck&quot;:true,&quot;dataCheckNoticePhone&quot;:&quot;13126800****&quot;,&quot;dataCheckDbList&quot;:{&quot;dts&quot;:{&quot;name&quot;:&quot;dts&quot;,&quot;all&quot;:true}}}</para>
        /// </summary>
        [NameInMap("DataCheckConfigure")]
        [Validation(Required=false)]
        public string DataCheckConfigure { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration or initial full data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes. This is the default value.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, this parameter can only be set to <b>false</b>.</para>
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
        /// <para>Specifies whether to perform incremental data migration or synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No. This is the default value.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, this parameter can only be set to <b>false</b>.</para>
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
        /// <para>The objects to be migrated or synchronized, in JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of migration, synchronization, or change tracking tasks</a>.</para>
        /// <list type="bullet">
        /// <item><description>The maximum size of the DbList value is 1 MB.</description></item>
        /// <item><description>If DbList contains filter conditions, the total length of DbList (including filter conditions) cannot exceed 1 MB.</description></item>
        /// <item><description>For distributed tasks (such as migration or synchronization tasks with PolarDB-X 1.0 as the source), DbList is split based on physical shards and multiple subtasks are generated. The maximum size of DbList for each subtask is 1 MB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The ID of the DTS dedicated cluster.</para>
        /// <remarks>
        /// <para>If you specify the ID of a dedicated cluster, the task is scheduled to the corresponding cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the latency status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers for latency alerting of the contact. Separate multiple phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site. Only the Chinese mainland phone numbers are supported, and a maximum of 10 phone numbers can be specified.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The international site does not support phone alerting. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks through the CloudMonitor platform to set alert rules</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency alerts. Unit: seconds. The value must be an integer. Set the threshold based on your business requirements. To avoid alert fluctuations caused by network conditions or database loads, set the threshold to 10 seconds or more.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DelayNotice</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// <para>The path of the CA certificate for SSL connection to the destination database.</para>
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
        /// <para>The password of the CA certificate for SSL connection to the destination database.</para>
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
        /// <para>The path of the client certificate for SSL connection to the destination database.</para>
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
        /// <para>The path of the client certificate private key for SSL connection to the destination database.</para>
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
        /// <para>The password of the client certificate private key for SSL connection to the destination database.</para>
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
        /// <para>The primary vSwitch of the VPC NAT gateway on the destination side.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestPrimaryVswId")]
        [Validation(Required=false)]
        public string DestPrimaryVswId { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch of the VPC NAT gateway on the destination side.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestSecondaryVswId")]
        [Validation(Required=false)]
        public string DestSecondaryVswId { get; set; }

        /// <summary>
        /// <para>The name of the database to which the objects to be migrated belong in the destination instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the destination instance or destination database type is PolarDB for PostgreSQL (Compatible with Oracle), AnalyticDB for PostgreSQL, PostgreSQL, MaxCompute, or MongoDB.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination database is MaxCompute, specify the project of the MaxCompute instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("DestinationEndpointDataBaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDataBaseName { get; set; }

        /// <summary>
        /// <para>The database type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b>: MySQL database (including ApsaraDB RDS for MySQL and self-managed MySQL).</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for PostgreSQL (Compatible with Oracle).</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: cloud-native distributed database PolarDB-X 2.0.</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle.</description></item>
        /// <item><description><b>PostgreSQL</b>: PostgreSQL database (including ApsaraDB RDS for PostgreSQL and self-managed PostgreSQL).</description></item>
        /// <item><description><b>MSSQL</b>: SQL Server database (including ApsaraDB RDS for SQL Server and self-managed SQL Server).</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL 2.0.</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL 3.0.</description></item>
        /// <item><description><b>MONGODB</b>: MongoDB database (including self-managed MongoDB and ApsaraDB for MongoDB).</description></item>
        /// <item><description><b>ROCKETMQ</b>: ApsaraMQ for RocketMQ.</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL.</description></item>
        /// <item><description><b>KAFKA</b>: Kafka database (including MSMQ for Apache Kafka and self-managed Kafka).</description></item>
        /// <item><description><b>DATAHUB</b>: Alibaba Cloud DataHub.</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW.</description></item>
        /// <item><description><b>AS400</b>: Db2 for i.</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore.</description></item>
        /// <item><description><b>ELK</b>: Alibaba Cloud Elasticsearch.</description></item>
        /// <item><description><b>REDIS</b>: Redis database, including self-managed Redis and Tair (Redis® OSS-Compatible).</description></item>
        /// <item><description><b>LINDORM</b>: cloud-native multi-model database Lindorm.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the database type of the destination instance is set to <b>KAFKA</b>, <b>MONGODB</b>, or <b>PolarDB</b>, you must also specify additional information in the Reserve parameter. For the metric description, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</description></item>
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
        /// <para>This parameter is available and required only when <b>DestinationEndpointInstanceType</b> is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c>*</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance.</para>
        /// <para> If the destination instance is an Alibaba Cloud database (such as ApsaraDB RDS for MySQL), specify the ID of the Alibaba Cloud database instance (such as the ApsaraDB RDS for MySQL instance ID).</para>
        /// <para> If the destination instance is a self-managed database, the value of this parameter varies based on the value of <b>DestinationEndpointInstanceType</b>. Example:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Specify the ID of the ECS instance.</description></item>
        /// <item><description><b>DG</b>: Specify the ID of the database gateway.</description></item>
        /// <item><description><b>EXPRESS</b> or <b>CEN</b>: Specify the ID of the VPC that is connected to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value is <b>CEN</b>, you must also specify the CEN instance ID in the Reserve parameter. For the metric description, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The target instance type. Valid values:</para>
        /// <para><b>Alibaba Cloud databases</b></para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL, ApsaraDB RDS for SQL Server, ApsaraDB RDS for PostgreSQL, or ApsaraDB RDS for MariaDB.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>DISTRIBUTED_POLARDBX10</b>: PolarDB-X 1.0 (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0.</description></item>
        /// <item><description><b>REDIS</b>: Tair (Redis® OSS-Compatible).</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL 2.0 or 3.0.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB.</description></item>
        /// <item><description><b>ROCKETMQ</b>: ApsaraMQ for RocketMQ.</description></item>
        /// <item><description><b>GREENPLUM</b>: AnalyticDB for PostgreSQL.</description></item>
        /// <item><description><b>DATAHUB</b>: Alibaba Cloud DataHub platform.</description></item>
        /// <item><description><b>ELK</b>: Alibaba Cloud Elasticsearch.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore.</description></item>
        /// <item><description><b>ODPS</b>: MaxCompute.</description></item>
        /// <item><description><b>LINDORM</b>: cloud-native multi-model database Lindorm.</description></item>
        /// </list>
        /// <para><b>Self-managed databases</b></para>
        /// <list type="bullet">
        /// <item><description><b>OTHER</b>: self-managed database with a public IP address.</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on ECS.</description></item>
        /// <item><description><b>EXPRESS</b>: self-managed database connected over Express Connect.</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN).</description></item>
        /// <item><description><b>DG</b>: self-managed database connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, set this parameter to <b>OTHER</b> or <b>EXPRESS</b> to connect the cluster as a self-managed database over a public IP address or Express Connect.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is MSMQ for Apache Kafka, set this parameter to <b>ECS</b> or <b>EXPRESS</b> to connect the instance as a self-managed database over ECS or Express Connect.</description></item>
        /// <item><description>For information about supported source and destination database combinations, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/131497.html">Supported databases</a>&lt;props=&quot;intl&quot;&gt;<a href="https://help.aliyun.com/document_detail/176064.html">Supported source and destination databases</a>.</description></item>
        /// <item><description>If the destination instance is a self-managed database, you must also execute the required preparations. For more information, see <a href="https://help.aliyun.com/document_detail/146958.html">Preparations overview</a>.</description></item>
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
        /// <para>This parameter is available and required only when <b>DestinationEndpointEngineName</b> is set to <b>Oracle</b> and the Oracle database is a non-RAC instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the destination ApsaraDB RDS for MySQL instance belongs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter can be configured only when the destination instance is ApsaraDB RDS for MySQL.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Specifying this parameter indicates you execute a cross-account data migration or synchronization. You must also specify the <b>DestinationEndpointRole</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("DestinationEndpointOwnerID")]
        [Validation(Required=false)]
        public string DestinationEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the destination database account.</para>
        /// <remarks>
        /// <para>If the destination database is MaxCompute, specify the AccessKey secret of the Alibaba Cloud account. For more information about how to obtain the AccessKey secret, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database service port of the destination instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the destination instance is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the destination instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the destination instance is an Alibaba Cloud database, this parameter is required.</para>
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
        /// <para>This parameter is required for cross-account data migration or synchronization. For information about the permissions and authorization method required for this role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration or synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("DestinationEndpointRole")]
        [Validation(Required=false)]
        public string DestinationEndpointRole { get; set; }

        /// <summary>
        /// <para>The database account of the destination database.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, you must specify the database account of the destination database.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The required permissions vary depending on the database being migrated or synchronized. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare database accounts for data migration</a> and <a href="https://help.aliyun.com/document_detail/213152.html">Prepare database accounts for data synchronization</a>.</description></item>
        /// <item><description>If the destination database is MaxCompute, specify the AccessKey ID of the Alibaba Cloud account. For more information about how to obtain the AccessKey ID, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether this is a disaster recovery instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisasterRecoveryJob")]
        [Validation(Required=false)]
        public bool? DisasterRecoveryJob { get; set; }

        /// <summary>
        /// <para>The environment label of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: normal</description></item>
        /// <item><description><b>online</b>: online.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The ID of the migration or synchronization instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsk2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the migration or synchronization task.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
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
        /// <para>Specifies whether to monitor the error status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers for error alerting of the contact. Separate multiple phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site. Only the Chinese mainland phone numbers are supported, and a maximum of 10 phone numbers can be specified.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The international site does not support phone alerting. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks through the CloudMonitor platform to set alert rules</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        /// <summary>
        /// <para>The OSS URL of the task file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb">http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_121852**********_79dd3aeabe2f43cdb</a>**************</para>
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public string FileOssUrl { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization.</description></item>
        /// <item><description><b>CHECK</b>: data validation (purchased separately).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the value is <b>MIGRATION</b> or <b>SYNC</b>, you can also configure a data validation node within the migration or synchronization instance.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To configure a data validation node, you must also specify the <b>DataCheckConfigure</b> parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The maximum number of DTS Units (DUs).</para>
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
        /// <para>The region ID of the DTS instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS, in JSON character string format. You can specify this parameter to add information about the source and destination databases (such as the data storage format of the destination Kafka database, the CEN instance ID, and ETL feature configurations). For more information, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</para>
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
        /// <para>The name of the database to which the objects to be migrated belong in the source instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the source instance or its database type is PolarDB for PostgreSQL (Compatible with Oracle), PostgreSQL, or MongoDB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdatabase</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b>: MySQL database (including ApsaraDB RDS for MySQL and self-managed MySQL).</description></item>
        /// <item><description><b>MARIADB</b>: ApsaraDB RDS for MariaDB.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>POLARDB_O</b>: PolarDB for PostgreSQL (Compatible with Oracle).</description></item>
        /// <item><description><b>POLARDBX10</b>: PolarDB-X 1.0 (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: cloud-native distributed database PolarDB-X 2.0.</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL 3.0.</description></item>
        /// <item><description><b>ORACLE</b>: self-managed Oracle.</description></item>
        /// <item><description><b>POSTGRESQL</b>: PostgreSQL database (including ApsaraDB RDS for PostgreSQL and self-managed PostgreSQL).</description></item>
        /// <item><description><b>MSSQL</b>: SQL Server database (including ApsaraDB RDS for SQL Server and self-managed SQL Server).</description></item>
        /// <item><description><b>MONGODB</b>: MongoDB database (including self-managed MongoDB and ApsaraDB for MongoDB).</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW.</description></item>
        /// <item><description><b>AS400</b>: self-managed Db2 for i.</description></item>
        /// <item><description><b>DMSPOLARDB</b>: Data Management (DMS) logical database.</description></item>
        /// <item><description><b>HBASE</b>: self-managed HBase database.</description></item>
        /// <item><description><b>TERADATA</b>: Teradata database.</description></item>
        /// <item><description><b>TiDB</b>: TiDB database.</description></item>
        /// <item><description><b>REDIS</b>: Redis database, including self-managed Redis and Tair (Redis® OSS-Compatible).</description></item>
        /// <item><description><b>LINDORM</b>: Lindorm.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MYSQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the database type of the source instance is set to <b>MONGODB</b>, you must also specify additional information in the Reserve parameter. For the metric description, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</description></item>
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
        /// <para>This parameter is available and required only when <b>SourceEndpointInstanceType</b> is set to <b>OTHER</b>, <b>EXPRESS</b>, <b>DG</b>, or <b>CEN</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c>*</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// <para>If the source instance is an Alibaba Cloud database (such as ApsaraDB RDS for MySQL), specify the ID of the Alibaba Cloud database instance (such as the ApsaraDB RDS for MySQL instance ID).</para>
        /// <para>If the source instance is a self-managed database, the value of this parameter varies based on the value of <b>SourceEndpointInstanceType</b>. Example:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Specify the ID of the ECS instance.</description></item>
        /// <item><description><b>DG</b>: Specify the ID of the database gateway.</description></item>
        /// <item><description><b>EXPRESS</b> or <b>CEN</b>: Specify the ID of the VPC that is connected to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value is <b>CEN</b>, you must also specify the CEN instance ID in the Reserve parameter. For the metric description, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</para>
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
        /// <para><b>Alibaba Cloud databases</b></para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL, ApsaraDB RDS for SQL Server, ApsaraDB RDS for PostgreSQL, or ApsaraDB RDS for MariaDB.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL.</description></item>
        /// <item><description><b>REDIS</b>: Tair (Redis® OSS-Compatible).</description></item>
        /// <item><description><b>DISTRIBUTED_POLARDBX10</b>: PolarDB-X 1.0 (formerly DRDS).</description></item>
        /// <item><description><b>POLARDBX20</b>: PolarDB-X 2.0.</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB.</description></item>
        /// <item><description><b>DISTRIBUTED_DMSLOGICDB</b>: Data Management (DMS) logical database.</description></item>
        /// <item><description><b>LINDORM</b>: Lindorm.</description></item>
        /// </list>
        /// <para><b>Self-managed databases</b></para>
        /// <list type="bullet">
        /// <item><description><b>OTHER</b>: self-managed database with a public IP address.</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on ECS.</description></item>
        /// <item><description><b>EXPRESS</b>: self-managed database connected over Express Connect.</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN).</description></item>
        /// <item><description><b>DG</b>: self-managed database connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the source instance is a PolarDB for PostgreSQL (Compatible with Oracle) cluster, set this parameter to <b>OTHER</b> or <b>EXPRESS</b> to connect the cluster as a self-managed database over a public IP address or Express Connect.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For information about supported source and destination database combinations, see <a href="https://help.aliyun.com/document_detail/131497.html">Supported databases</a>.</description></item>
        /// <item><description>If the source instance is a self-managed database, you must complete the required preparations. For more information, see <a href="https://help.aliyun.com/document_detail/130607.html">Preparations overview</a>.</description></item>
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
        /// <para>This parameter is available and required only when <b>SourceEndpointEngineName</b> is set to <b>Oracle</b> and the Oracle database is a non-RAC instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the source instance belongs.</para>
        /// <remarks>
        /// <para>Specifying this parameter indicates you execute a cross-account data migration or synchronization. You must also specify the <b>SourceEndpointRole</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the source database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database service port of the source instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the source instance is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the source instance. For details, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the source instance is an Alibaba Cloud database, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The name of the RAM role configured for the Alibaba Cloud account to which the source instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-account data migration or synchronization. For information about the permissions and authorization method required for this role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration or synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// <para>The database account of the source database.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>In most cases, you must specify the database account of the source database.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The required permissions vary depending on the database being migrated or synchronized. For more information, see <a href="https://help.aliyun.com/document_detail/175878.html">Prepare database accounts for data migration</a> and <a href="https://help.aliyun.com/document_detail/213152.html">Prepare database accounts for data synchronization</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The vSwitch instance ID for the data delivery link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10df3mxae6lpmku****</para>
        /// </summary>
        [NameInMap("SourceEndpointVSwitchID")]
        [Validation(Required=false)]
        public string SourceEndpointVSwitchID { get; set; }

        /// <summary>
        /// <para>The path of the CA certificate for SSL connection to the source database.</para>
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
        /// <para>The password of the CA certificate for SSL connection to the source database.</para>
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
        /// <para>The path of the client certificate for SSL connection to the source database.</para>
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
        /// <para>The path of the client certificate private key for SSL connection to the source database.</para>
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
        /// <para>The password of the client certificate private key for SSL connection to the source database.</para>
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
        /// <para>The primary vSwitch of the VPC NAT gateway on the source side.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPrimaryVswId")]
        [Validation(Required=false)]
        public string SrcPrimaryVswId { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch of the VPC NAT gateway on the source side.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcSecondaryVswId")]
        [Validation(Required=false)]
        public string SrcSecondaryVswId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform schema migration or initial schema synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes. This is the default value.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>JobType</b> is set to <b>CHECK</b>, this parameter can only be set to <b>false</b>.</para>
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
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The value <b>Reverse</b> takes effect only when the synchronization topology of the synchronization task is two-way synchronization.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the synchronization object in the destination instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// <para>The IP address of the destination database.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>Express</b>, <b>dg</b>, or <b>cen</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The ID of the destination instance.</para>
            /// <remarks>
            /// <para> If the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b> or <b>DataHub</b>, you must specify the name of the MaxCompute project or the DataHub project.</para>
            /// </remarks>
            /// <para>If the destination instance is an AnalyticDB for MySQL cluster, specify the ID of the AnalyticDB for MySQL cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1r46452ai50****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the destination instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Redis</b>: ApsaraDB for Redis instance</description></item>
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster or PolarDB O Edition cluster</description></item>
            /// <item><description><b>ECS</b>: self-managed database that is hosted on ECS</description></item>
            /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect</description></item>
            /// <item><description><b>DataHub</b>: DataHub project</description></item>
            /// <item><description><b>MaxCompute</b>: MaxCompute project</description></item>
            /// <item><description><b>AnalyticDB</b>: AnalyticDB for MySQL cluster V3.0 or V2.0</description></item>
            /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL instance</description></item>
            /// </list>
            /// <remarks>
            /// <para> The default value is <b>RDS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The password of the destination database account.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>, you must specify the DestinationEndpoint.Password parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Test654321</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The service port number of the destination database.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The database account of the destination database.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The permissions that are required for database accounts vary with the synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/140954.html">Overview of data synchronization scenarios</a>.</description></item>
            /// <item><description>If the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>, you must specify the DestinationEndpoint.UserName parameter.</description></item>
            /// <item><description>If the <b>DestinationEndpoint.InstanceType</b> parameter is set to RDS and the database version is MySQL 5.5 or MySQL 5.6, you do not need to specify the DestinationEndpoint.UserName and <b>DestinationEndpoint.Password</b> parameters.</description></item>
            /// <item><description>If the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>Redis</b>, you do not need to specify the DestinationEndpoint.UserName parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestPartitionKey PartitionKey { get; set; }
        public class ConfigureSynchronizationJobRequestPartitionKey : TeaModel {
            /// <summary>
            /// <para>Specifies whether the incremental data table contains partitions defined by the modifytime_day field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// <remarks>
            /// <para> This parameter is available only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Day")]
            [Validation(Required=false)]
            public bool? ModifyTimeDay { get; set; }

            /// <summary>
            /// <para>Specifies whether the incremental data table contains partitions defined by the modifytime_hour field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// <remarks>
            /// <para> This parameter is available only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Hour")]
            [Validation(Required=false)]
            public bool? ModifyTimeHour { get; set; }

            /// <summary>
            /// <para>Specifies whether the incremental data table contains partitions defined by the modifytime_minute field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// <remarks>
            /// <para> This parameter is available only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Minute")]
            [Validation(Required=false)]
            public bool? ModifyTimeMinute { get; set; }

            /// <summary>
            /// <para>Specifies whether the incremental data table contains partitions defined by the modifytime_month field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// <remarks>
            /// <para> This parameter is available only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Month")]
            [Validation(Required=false)]
            public bool? ModifyTimeMonth { get; set; }

            /// <summary>
            /// <para>Specifies whether the incremental data table contains partitions defined by the modifytime_year field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// <remarks>
            /// <para> This parameter is available only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>MaxCompute</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Year")]
            [Validation(Required=false)]
            public bool? ModifyTimeYear { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the synchronization object in the source instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The IP address of the source database.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1i99e8l7913****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the source instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>Redis</b>: ApsaraDB for Redis instance</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster or PolarDB O Edition cluster</description></item>
            /// <item><description><b>ECS</b>: self-managed database that is hosted on Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect</description></item>
            /// <item><description><b>dg</b>: self-managed database that is connected over Database Gateway</description></item>
            /// <item><description><b>cen</b>: self-managed database that is connected over Cloud Enterprise Network (CEN)</description></item>
            /// </list>
            /// <remarks>
            /// <para> The default value is <b>RDS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the source RDS instance.</para>
            /// <remarks>
            /// <para> You can specify this parameter to synchronize data across different Alibaba Cloud accounts. In this case, you also need to specify the <b>SourceEndpoint.Role</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>The password of the source database account.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The service port number of the source database.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The name of the RAM role configured for the Alibaba Cloud account that owns the source instance.</para>
            /// <remarks>
            /// <para> You must specify this parameter when you synchronize data across different Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The database account of the source database.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You must specify this parameter only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>Express</b>, <b>dg</b>, or <b>cen</b>.</description></item>
            /// <item><description>If the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>Redis</b>, you do not need to specify the database account.</description></item>
            /// <item><description>The permissions that are required for database accounts vary with the synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/140954.html">Overview of data synchronization scenarios</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The synchronization checkpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1610540493</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform initial full data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: <b>true</b>.</para>
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
        /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, for example, whether to automatically start a precheck. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved</a>.</para>
        /// <remarks>
        /// <para> This parameter can be used for data synchronization between ApsaraDB for Redis Enterprise Edition instances. For more information, see <a href="https://help.aliyun.com/document_detail/155967.html">Use OpenAPI Explorer to configure one-way or two-way data synchronization between ApsaraDB for Redis Enterprise Edition instances</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;autoStartModulesAfterConfig&quot;: &quot;none&quot;,     &quot;targetTableMode&quot;: 2 }</para>
        /// </summary>
        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>资源组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform initial schema synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: <b>true</b>.</para>
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
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// <item><description>The value <b>Reverse</b> takes effect only if the topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance. You can call the <a href="https://help.aliyun.com/document_detail/49454.html">DescribeSynchronizationJobs</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsz4ao1dor13d****</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data synchronization task.</para>
        /// <remarks>
        /// <para> We recommend that you specify an informative name for easy identification. You do not need to use a unique task name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL同步</para>
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        /// <summary>
        /// <para>The objects that you want to synchronize. The value is a JSON string and can contain regular expressions. For more information, see <a href="https://help.aliyun.com/document_detail/141901.html">SynchronizationObjects</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;DBName&quot;:&quot;dtstestdata&quot;,&quot;TableIncludes&quot;:[{&quot;TableName&quot;:&quot;customer&quot;}]}]</para>
        /// </summary>
        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public string SynchronizationObjects { get; set; }

    }

}

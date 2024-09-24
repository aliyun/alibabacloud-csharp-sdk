// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of instances.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                /// <summary>
                /// <para>The maximum number of accounts that can be created on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AccountMaxQuantity")]
                [Validation(Required=false)]
                public int? AccountMaxQuantity { get; set; }

                /// <summary>
                /// <para>The advanced features that are enabled for the instance. If multiple advanced features are enabled, the advanced features are separated by commas (,). This parameter is available only to instances that run <b>SQL Server</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>LinkedServer</b></description></item>
                /// <item><description><b>DistributeTransaction</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LinkedServer</para>
                /// </summary>
                [NameInMap("AdvancedFeatures")]
                [Validation(Required=false)]
                public string AdvancedFeatures { get; set; }

                /// <summary>
                /// <para>The method that is used to update the minor engine version of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Auto</b>: automatic update.</description></item>
                /// <item><description><b>Manual</b>: manual update. The minor engine version of the instance is forcefully updated only when the in-use minor engine version is phased out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Auto</para>
                /// </summary>
                [NameInMap("AutoUpgradeMinorVersion")]
                [Validation(Required=false)]
                public string AutoUpgradeMinorVersion { get; set; }

                /// <summary>
                /// <para>The availability status of the instance in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0%</para>
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// <para>The configuration of the Babelfish feature for the ApsaraDB RDS for PostgreSQL instance.</para>
                /// <remarks>
                /// <para> This parameter applies only to ApsaraDB RDS for PostgreSQL instances for which Babelfish is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/428613.html">Introduction to Babelfish</a>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("BabelfishConfig")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig BabelfishConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether Babelfish is enabled.</para>
                    /// <remarks>
                    /// <para> If Babelfish is enabled when you purchase an ApsaraDB RDS for PostgreSQL instance, this parameter is fixed as <b>true</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BabelfishEnabled")]
                    [Validation(Required=false)]
                    public string BabelfishEnabled { get; set; }

                    /// <summary>
                    /// <para>The migration mode for Babelfish. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>single-db</b></description></item>
                    /// <item><description><b>multi-db</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> For more information about migration modes for Babelfish, see <a href="https://help.aliyun.com/document_detail/428613.html">Migration modes</a>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>single-db</para>
                    /// </summary>
                    [NameInMap("MigrationMode")]
                    [Validation(Required=false)]
                    public string MigrationMode { get; set; }

                }

                /// <summary>
                /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BpeEnabled")]
                [Validation(Required=false)]
                public string BpeEnabled { get; set; }

                /// <summary>
                /// <para>An invalid parameter. You do not need to specify this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the conditions for a temporary upgrade are met.</para>
                /// <remarks>
                /// <para> Pay-as-you-go instances do not support temporary upgrades.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CanTempUpgrade")]
                [Validation(Required=false)]
                public bool? CanTempUpgrade { get; set; }

                /// <summary>
                /// <para>The RDS edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
                /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
                /// <item><description><b>cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL</description></item>
                /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server</description></item>
                /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
                /// <item><description><b>Serverless_basic</b>: RDS Basic Edition for serverless instances</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("ColdDataEnabled")]
                [Validation(Required=false)]
                public bool? ColdDataEnabled { get; set; }

                /// <summary>
                /// <para>The character set collation of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chinese_PRC_CI_AS</para>
                /// </summary>
                [NameInMap("Collation")]
                [Validation(Required=false)]
                public string Collation { get; set; }

                /// <summary>
                /// <para>The connection mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard mode</description></item>
                /// <item><description><b>Safe</b>: database proxy mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// <para>The internal endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5*****.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The type of the proxy that is used by the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: shared database proxy</description></item>
                /// <item><description><b>2</b>: dedicated database proxy</description></item>
                /// </list>
                /// <remarks>
                /// <para> We recommend that you use the <b>ProxyType</b> parameter instead of this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConsoleVersion")]
                [Validation(Required=false)]
                public string ConsoleVersion { get; set; }

                /// <summary>
                /// <para>The creation time. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011-05-30T12:11:04Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The minor engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds_20181010</para>
                /// </summary>
                [NameInMap("CurrentKernelVersion")]
                [Validation(Required=false)]
                public string CurrentKernelVersion { get; set; }

                /// <summary>
                /// <para>The information about the node in the cluster.</para>
                /// </summary>
                [NameInMap("DBClusterNodes")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodes DBClusterNodes { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodes : TeaModel {
                    [NameInMap("DBClusterNode")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodesDBClusterNode> DBClusterNode { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodesDBClusterNode : TeaModel {
                        /// <summary>
                        /// <para>The node specification.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mysql.n2.medium.xc</para>
                        /// </summary>
                        [NameInMap("ClassCode")]
                        [Validation(Required=false)]
                        public string ClassCode { get; set; }

                        /// <summary>
                        /// <para>The node type. Default value: true. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>d: dedicated node type</description></item>
                        /// <item><description>x: general-purpose node type</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>x</para>
                        /// </summary>
                        [NameInMap("ClassType")]
                        [Validation(Required=false)]
                        public string ClassType { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public string Cpu { get; set; }

                        /// <summary>
                        /// <para>The memory capacity of the node. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4096</para>
                        /// </summary>
                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public string Memory { get; set; }

                        /// <summary>
                        /// <para>The node ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rn-****</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("NodeRegionId")]
                        [Validation(Required=false)]
                        public string NodeRegionId { get; set; }

                        /// <summary>
                        /// <para>The role of the node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>primary</b></description></item>
                        /// <item><description><b>secondary</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>primary</para>
                        /// </summary>
                        [NameInMap("NodeRole")]
                        [Validation(Required=false)]
                        public string NodeRole { get; set; }

                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing-h</para>
                        /// </summary>
                        [NameInMap("NodeZoneId")]
                        [Validation(Required=false)]
                        public string NodeZoneId { get; set; }

                        /// <summary>
                        /// <para>The node status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>active</description></item>
                        /// <item><description>creating</description></item>
                        /// <item><description>deleting</description></item>
                        /// <item><description>classchanging</description></item>
                        /// <item><description>restarting</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// <para>The instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds.mys2.small</para>
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// <para>The instance family. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: shared instance family</description></item>
                /// <item><description><b>x</b>: general-purpose instance family</description></item>
                /// <item><description><b>d</b>: dedicated instance family</description></item>
                /// <item><description><b>h</b>: dedicated host instance family</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The number of cores that are configured for the instance.</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The disk usage of the instance. Unit: byte.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("DBInstanceDiskUsed")]
                [Validation(Required=false)]
                public string DBInstanceDiskUsed { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5*****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The memory capacity of the instance. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// <para>The type of the network over which the instance is connected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Internet</b></description></item>
                /// <item><description><b>Intranet</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/26315.html">Instance statuses</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage capacity of the instance. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The storage type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local_ssd</b> or <b>ephemeral_ssd</b>: local SSD</description></item>
                /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
                /// <item><description><b>cloud_essd</b>: Enterprise SSD (ESSD).</description></item>
                /// <item><description><b>general_essd</b>: general ESSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd</para>
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b>: primary instance</description></item>
                /// <item><description><b>Readonly</b>: read-only instance</description></item>
                /// <item><description><b>Guard</b>: disaster recovery instance</description></item>
                /// <item><description><b>Temp</b>: temporary instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The maximum number of databases that can be created on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DBMaxQuantity")]
                [Validation(Required=false)]
                public int? DBMaxQuantity { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated cluster to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-7a9*****</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the release protection feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>Disaster Recovery Instance Information</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;replicatorAccount&quot;: &quot;<b><b><b>&quot;,&quot;sourcePort&quot;:</b></b></b>,&quot;sourceAddress&quot;: &quot;pgm-2ze******&quot;,&quot;sourceCategory&quot;: &quot;aliyunRDS&quot;,&quot;sourceInstanceRegionId&quot;: &quot;cn-<b><b><b>&quot;,&quot;replicatorPassword&quot;: &quot;</b></b></b>&quot;,&quot;sourceInstanceName&quot;: &quot;pgm-2ze******&quot;}</para>
                /// </summary>
                [NameInMap("DisasterRecoveryInfo")]
                [Validation(Required=false)]
                public string DisasterRecoveryInfo { get; set; }

                /// <summary>
                /// <para>All disaster recovery instances of the current instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;regionId&quot;:&quot;cn-<b><b><b>&quot;,&quot;insName&quot;:&quot;pgm-2ze</b></b></b>&quot;},{&quot;regionId&quot;:&quot;cn-<b><b><b>&quot;,&quot;insName&quot;:&quot;pgm-2ze</b></b></b>&quot;}]</para>
                /// </summary>
                [NameInMap("DisasterRecoveryInstances")]
                [Validation(Required=false)]
                public string DisasterRecoveryInstances { get; set; }

                /// <summary>
                /// <para>The database engine of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>MySQL</b></description></item>
                /// <item><description><b>PostgreSQL</b></description></item>
                /// <item><description><b>SQLServer</b></description></item>
                /// <item><description><b>MariaDB</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.5</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The expiration time of the instance. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> Pay-as-you-go instances never expire.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-27T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The extended information about the instance.</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra Extra { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra : TeaModel {
                    /// <summary>
                    /// <para>The group policy of the instance account.</para>
                    /// <list type="bullet">
                    /// <item><description>MaximumPasswordAge: maximum use time</description></item>
                    /// <item><description>MinimumPasswordAge: minimum use time</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;MaximumPasswordAge&quot;: 42,&quot;MinimumPasswordAge&quot;: 30}</para>
                    /// </summary>
                    [NameInMap("AccountSecurityPolicy")]
                    [Validation(Required=false)]
                    public string AccountSecurityPolicy { get; set; }

                    /// <summary>
                    /// <para>The instance IDs.</para>
                    /// </summary>
                    [NameInMap("DBInstanceIds")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds DBInstanceIds { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public List<string> DBInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The recovery model. Valid values: Simple and Full.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Simple</para>
                    /// </summary>
                    [NameInMap("RecoveryModel")]
                    [Validation(Required=false)]
                    public string RecoveryModel { get; set; }

                }

                /// <summary>
                /// <para>The name of the dedicated cluster to which the instance belongs. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroup</para>
                /// </summary>
                [NameInMap("GeneralGroupName")]
                [Validation(Required=false)]
                public string GeneralGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the disaster recovery instance that is attached to the primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf64zsu*****</para>
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// <para>The IP address type. Only <b>IPv4 addresses</b> are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// <para>The ID of the instance from which incremental data comes. The incremental data of a disaster recovery instance comes from its primary instance. The incremental data of a read-only instance comes from its primary instance. If this parameter is not returned, the instance is a primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5*****</para>
                /// </summary>
                [NameInMap("IncrementSourceDBInstanceId")]
                [Validation(Required=false)]
                public string IncrementSourceDBInstanceId { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Classic</b></description></item>
                /// <item><description><b>VPC</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Classic</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>The architecture type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>x86</b></description></item>
                /// <item><description><b>arm</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>x86</para>
                /// </summary>
                [NameInMap("InstructionSetArch")]
                [Validation(Required=false)]
                public string InstructionSetArch { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("IoAccelerationEnabled")]
                [Validation(Required=false)]
                public string IoAccelerationEnabled { get; set; }

                /// <summary>
                /// <para>The latest minor engine version that is supported by the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds_20201031</para>
                /// </summary>
                [NameInMap("LatestKernelVersion")]
                [Validation(Required=false)]
                public string LatestKernelVersion { get; set; }

                /// <summary>
                /// <para>The lock mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked due to instance restoration.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked due to exhausted storage space.</description></item>
                /// <item><description><b>LockReadInstanceByDiskQuota</b>: The instance is a read-only instance and is automatically locked due to exhausted storage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The reason why the instance was locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_expired</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The maintenance window of the instance. The time is displayed in UTC. The maintenance window displayed in the ApsaraDB RDS console is equal to the value of this parameter plus 8 hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00Z-02:00Z</para>
                /// </summary>
                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// <para>The primary instance ID.</para>
                /// <remarks>
                /// <para> If this parameter is not returned, the instance is the primary instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5*****</para>
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// <para>The zone ID of the primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5454284</para>
                /// </summary>
                [NameInMap("MasterZone")]
                [Validation(Required=false)]
                public string MasterZone { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrent connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// <para>The maximum I/O throughput. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0MB/s</para>
                /// </summary>
                [NameInMap("MaxIOMBPS")]
                [Validation(Required=false)]
                public int? MaxIOMBPS { get; set; }

                /// <summary>
                /// <para>The maximum number of I/O requests per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// <para>Indicates whether PgBouncer is enabled.</para>
                /// <remarks>
                /// <para> This parameter is returned only for RDS instances that run PostgreSQL. If PgBouncer is enabled, the return value is <b>true</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PGBouncerEnabled")]
                [Validation(Required=false)]
                public string PGBouncerEnabled { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
                /// <item><description><b>Prepaid</b>: subscription</description></item>
                /// <item><description><b>SERVERLESS</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the instance over an internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The type of the proxy that is supported by the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The instance does not support database proxies.</description></item>
                /// <item><description><b>1</b>: The instance supports shared proxies, with which the instance runs in multi-tenant mode.</description></item>
                /// <item><description><b>2</b>: The instance supports dedicated proxies, with which the instance runs in single-tenant mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public int? ProxyType { get; set; }

                /// <summary>
                /// <para>The IDs of the read-only instances that are attached to the primary instance.</para>
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The read-only instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rm-bp*****</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The latency at which the system replicates data to read-only instances. The system replicates data from the primary instance to the read-only instances at the latency that is specified by the <b>ReadonlyInstanceSQLDelayedTime</b> parameter. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmy*****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The IP addresses in the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX/24</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>The whitelist mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: standard whitelist mode</description></item>
                /// <item><description><b>safety</b>: enhanced whitelist mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("SecurityIPMode")]
                [Validation(Required=false)]
                public string SecurityIPMode { get; set; }

                /// <summary>
                /// <para>The settings of the serverless instance.</para>
                /// </summary>
                [NameInMap("ServerlessConfig")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig ServerlessConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the automatic start and stop feature is enabled for the serverless instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b> (default)</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection to the instance is established, the instance is automatically resumed.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoPause")]
                    [Validation(Required=false)]
                    public bool? AutoPause { get; set; }

                    /// <summary>
                    /// <para>The maximum number of RCUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("ScaleMax")]
                    [Validation(Required=false)]
                    public double? ScaleMax { get; set; }

                    /// <summary>
                    /// <para>The minimum number of RDS Capacity Units (RCUs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("ScaleMin")]
                    [Validation(Required=false)]
                    public double? ScaleMin { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the forced scaling feature is enabled for the serverless instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b> (default)</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> In most cases, ApsaraDB RDS automatically scales in or out the RCUs of a serverless instance based on business requirements in real time. In rare cases, the scaling does not take effect in real time. You can enable the forced scaling feature to forcefully scales in or out the RCUs of the instance.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SwitchForce")]
                    [Validation(Required=false)]
                    public bool? SwitchForce { get; set; }

                }

                /// <summary>
                /// <para>The zone IDs of the secondary instances.</para>
                /// </summary>
                [NameInMap("SlaveZones")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones SlaveZones { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones : TeaModel {
                    [NameInMap("SlaveZone")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone> SlaveZone { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone : TeaModel {
                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-a</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the instance supports superuser accounts, such as the system administrator (SA) account, Active Directory (AD) account, and host account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enable</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("SuperPermissionMode")]
                [Validation(Required=false)]
                public string SuperPermissionMode { get; set; }

                /// <summary>
                /// <para>The ID of the temporary instance that is attached to the primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf64zsu*****</para>
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// <para>The end time of the temporary upgrade of the instance.</para>
                /// <remarks>
                /// <para> This parameter is unavailable for pay-as-you-go instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 00:00:00</para>
                /// </summary>
                [NameInMap("TempUpgradeTimeEnd")]
                [Validation(Required=false)]
                public string TempUpgradeTimeEnd { get; set; }

                /// <summary>
                /// <para>The start time of the temporary upgrade of the instance.</para>
                /// <remarks>
                /// <para> This parameter is unavailable for pay-as-you-go instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-29 00:00:00</para>
                /// </summary>
                [NameInMap("TempUpgradeTimeStart")]
                [Validation(Required=false)]
                public string TempUpgradeTimeStart { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Central Standard Time</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// <para>The information about the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The IP addresses in the IP address whitelist.</para>
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// <para>The severity of the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The instance is normal.</description></item>
                /// <item><description><b>2</b>: The specifications of the read-only instances do not match the specifications of the primary instance. You must adjust the specifications of these instances based on your business requirements.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TipsLevel")]
                [Validation(Required=false)]
                public int? TipsLevel { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-*****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC. This parameter is returned only when the instance resides in a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-23rsxdf*****</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>An internal parameter. You do not need to specify this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The architecture type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>x86</b></description></item>
                /// <item><description><b>arm</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("kindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

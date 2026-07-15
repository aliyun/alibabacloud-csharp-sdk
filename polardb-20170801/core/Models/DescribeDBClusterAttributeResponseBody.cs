// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The start time of the free AI feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-13T01:20:28Z</para>
        /// </summary>
        [NameInMap("AiCreatingTime")]
        [Validation(Required=false)]
        public string AiCreatingTime { get; set; }

        /// <summary>
        /// <para>The AI node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SearchNode</b>: search node.</description></item>
        /// <item><description><b>DLNode</b>: AI node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DLNode</para>
        /// </summary>
        [NameInMap("AiType")]
        [Validation(Required=false)]
        public string AiType { get; set; }

        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>X86</b></description></item>
        /// <item><description><b>ARM</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The minor version update method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: Automatic update.</description></item>
        /// <item><description>Manual: Manual update.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("AutoUpgradeMinorVersion")]
        [Validation(Required=false)]
        public string AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of blktags in the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7,864,320</para>
        /// </summary>
        [NameInMap("BlktagTotal")]
        [Validation(Required=false)]
        public long? BlktagTotal { get; set; }

        /// <summary>
        /// <para>The current blktag usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,242,880</para>
        /// </summary>
        [NameInMap("BlktagUsed")]
        [Validation(Required=false)]
        public long? BlktagUsed { get; set; }

        [NameInMap("Branch")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyBranch Branch { get; set; }
        public class DescribeDBClusterAttributeResponseBodyBranch : TeaModel {
            [NameInMap("BranchLsn")]
            [Validation(Required=false)]
            public string BranchLsn { get; set; }

            [NameInMap("BranchTime")]
            [Validation(Required=false)]
            public string BranchTime { get; set; }

            [NameInMap("ChildBranch")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAttributeResponseBodyBranchChildBranch> ChildBranch { get; set; }
            public class DescribeDBClusterAttributeResponseBodyBranchChildBranch : TeaModel {
                [NameInMap("BranchLsn")]
                [Validation(Required=false)]
                public string BranchLsn { get; set; }

                [NameInMap("BranchTime")]
                [Validation(Required=false)]
                public string BranchTime { get; set; }

                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                [NameInMap("HasChild")]
                [Validation(Required=false)]
                public bool? HasChild { get; set; }

                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

            }

            [NameInMap("ParentInsName")]
            [Validation(Required=false)]
            public string ParentInsName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether I/O performance burst is enabled for the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/183258.html">edition</a> of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition</description></item>
        /// <item><description><b>Basic</b>: Single Node Edition</description></item>
        /// <item><description><b>Archive</b>: X-Engine Edition</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster Edition</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>PolarDB for PostgreSQL 11 does not support Single Node Edition.</description></item>
        /// <item><description>PolarDB for MySQL 8.0, PolarDB for MySQL 5.7, and PolarDB for PostgreSQL 14 support Standard Edition.</description></item>
        /// <item><description>PolarDB for MySQL 8.0 supports X-Engine Edition and Multi-master Cluster Edition.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Indicates whether column store tables are enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ColumnTable")]
        [Validation(Required=false)]
        public string ColumnTable { get; set; }

        /// <summary>
        /// <para>Indicates whether storage compression is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ON: Enabled.</description></item>
        /// <item><description>OFF: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CompressStorageMode")]
        [Validation(Required=false)]
        public string CompressStorageMode { get; set; }

        /// <summary>
        /// <para>The compressed storage data size.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the storage compression feature is enabled for the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15529410560</para>
        /// </summary>
        [NameInMap("CompressStorageUsed")]
        [Validation(Required=false)]
        public long? CompressStorageUsed { get; set; }

        [NameInMap("ConnectionResourceQuota")]
        [Validation(Required=false)]
        public long? ConnectionResourceQuota { get; set; }

        [NameInMap("ConnectionResourceUsed")]
        [Validation(Required=false)]
        public long? ConnectionResourceUsed { get; set; }

        /// <summary>
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The network type of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The cluster status. For more information, see <a href="https://help.aliyun.com/document_detail/99286.html">Cluster status table</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores added by second-level rapid scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-23T21:35:43Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The CXL remote memory configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("DBNodeCXLRemoteMemory")]
            [Validation(Required=false)]
            public string DBNodeCXLRemoteMemory { get; set; }

            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The node description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The role of the node. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>Writer</b>: primary node.</description></item>
            /// <item><description><b>Reader</b>: read-only node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Reader</para>
            /// </summary>
            [NameInMap("DBNodeRole")]
            [Validation(Required=false)]
            public string DBNodeRole { get; set; }

            /// <summary>
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: Being created. </description></item>
            /// <item><description><b>Running</b>: Running. </description></item>
            /// <item><description><b>Deleting</b>: Being deleted.  </description></item>
            /// <item><description><b>Rebooting</b>: Being restarted.  </description></item>
            /// <item><description><b>DBNodeCreating</b>: Increase node in progress.  </description></item>
            /// <item><description><b>DBNodeDeleting</b>: Deleting a node. </description></item>
            /// <item><description><b>ClassChanging</b>: Changing node specifications.  </description></item>
            /// <item><description><b>NetAddressCreating</b>: Creating network connectivity.  </description></item>
            /// <item><description><b>NetAddressDeleting</b>: Deleting network connectivity.  </description></item>
            /// <item><description><b>NetAddressModifying</b>: Modifying network connectivity.</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: Upgrade of the minor version in progress.</description></item>
            /// <item><description><b>Maintaining</b>: Instance under maintenance.  </description></item>
            /// <item><description><b>Switching</b>: Switching over.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The failover priority. Each node has a failover priority that determines the probability of the node being elected as the primary node during a failover. A higher value indicates a higher priority.
            /// Valid values: 1 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

            /// <summary>
            /// <para>Indicates whether hot standby is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("HotReplicaMode")]
            [Validation(Required=false)]
            public string HotReplicaMode { get; set; }

            /// <summary>
            /// <para>Indicates whether In-Memory Column Index (IMCI) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("ImciSwitch")]
            [Validation(Required=false)]
            public string ImciSwitch { get; set; }

            /// <summary>
            /// <para>The primary node ID of the Multi-master Cluster Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52akld3*****</para>
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections to the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum number of I/O requests per second (IOPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public int? MaxIOPS { get; set; }

            /// <summary>
            /// <para>The memory size of the node. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The name of the hot replica that corresponds to this node in the hot standby storage and compute architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52mirror*****</para>
            /// </summary>
            [NameInMap("MirrorInsName")]
            [Validation(Required=false)]
            public string MirrorInsName { get; set; }

            /// <summary>
            /// <para>The multi-master local standby node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("MultiMasterLocalStandby")]
            [Validation(Required=false)]
            public string MultiMasterLocalStandby { get; set; }

            /// <summary>
            /// <para>The multi-master primary node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("MultiMasterPrimaryNode")]
            [Validation(Required=false)]
            public string MultiMasterPrimaryNode { get; set; }

            /// <summary>
            /// <para>The Orca feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Orca")]
            [Validation(Required=false)]
            public string Orca { get; set; }

            [NameInMap("RemoteMemoryMax")]
            [Validation(Required=false)]
            public int? RemoteMemoryMax { get; set; }

            [NameInMap("RemoteMemoryMin")]
            [Validation(Required=false)]
            public int? RemoteMemoryMin { get; set; }

            [NameInMap("RemoteMemoryRecommended")]
            [Validation(Required=false)]
            public int? RemoteMemoryRecommended { get; set; }

            /// <summary>
            /// <para>The remote memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("RemoteMemorySize")]
            [Validation(Required=false)]
            public string RemoteMemorySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the global consistency (high-performance mode) feature is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

            /// <summary>
            /// <para>The routing weight.
            /// Valid values: 1 to 100. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            /// <summary>
            /// <para>The serverless type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AgileServerless: agile serverless node.</description></item>
            /// <item><description>SteadyServerless: steady serverless node, which is a node in a cluster with defined specifications that has serverless capabilities enabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only for serverless clusters or clusters with defined specifications that have the serverless feature enabled. For more information, see <a href="https://help.aliyun.com/document_detail/452274.html">Serverless</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SteadyServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is in the primary zone or secondary zone. This parameter is mainly used for resource-equivalent deployments.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: primary zone.</description></item>
            /// <item><description>Standby: secondary zone.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("SubCluster")]
            [Validation(Required=false)]
            public string SubCluster { get; set; }

            /// <summary>
            /// <para>The cluster subgroup description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test Description</para>
            /// </summary>
            [NameInMap("SubGroupDescription")]
            [Validation(Required=false)]
            public string SubGroupDescription { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the current minor database version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The current version is stable.</description></item>
        /// <item><description><b>Old</b>: The current version is outdated. Upgrade to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The current version has critical defects. Upgrade to the latest version immediately.</description></item>
        /// <item><description><b>Beta</b>: The current version is a beta version.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For information about how to upgrade the minor database version, see <a href="https://help.aliyun.com/document_detail/158572.html">Version upgrade</a>.</description></item>
        /// <item><description>This parameter is returned only when the database engine type (<b>DBType</b>) is <b>MySQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <para>The total size of level-1 backups (snapshots), in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74448896</para>
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// <para>The data replication relationship mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AsyncSync</b>: asynchronous</description></item>
        /// <item><description><b>SemiSync</b>: semi-synchronous</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncSync</para>
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// <para>The lock status for cluster deletion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unlocked. The cluster can be deleted.</description></item>
        /// <item><description><b>1</b>: Locked. The cluster cannot be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DeletionLock")]
        [Validation(Required=false)]
        public int? DeletionLock { get; set; }

        /// <summary>
        /// <para>The cluster engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The expiration time of the cluster.</para>
        /// <remarks>
        /// <para>A specific value is returned only for clusters whose billing method is <b>Prepaid</b> (subscription). An empty value is returned for <b>Postpaid</b> (pay-as-you-go) clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster has expired.</para>
        /// <remarks>
        /// <para>This parameter is returned only for clusters whose billing method is <b>Prepaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>Indicates whether resources are replenished for the new primary node after a cross-zone failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Resources are replenished.</description></item>
        /// <item><description><b>false</b>: Resources are not replenished.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasCompleteStandbyRes")]
        [Validation(Required=false)]
        public bool? HasCompleteStandbyRes { get; set; }

        /// <summary>
        /// <para>Indicates whether the Hot Standby Cluster (and standby compute nodes) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>StandbyClusterON</b>: The Hot Standby Cluster or both the Hot Standby Cluster and standby compute nodes are enabled. </description></item>
        /// <item><description><b>StandbyClusterOFF</b>: The Hot Standby Cluster or both the Hot Standby Cluster and standby compute nodes are disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StandbyClusterON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>The automatic IMCI-based query acceleration feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ON</c>: Enabled.</description></item>
        /// <item><description><c>OFF</c>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ImciAutoIndex")]
        [Validation(Required=false)]
        public string ImciAutoIndex { get; set; }

        /// <summary>
        /// <para>The failover with hot replica feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ImperceptibleSwitch")]
        [Validation(Required=false)]
        public string ImperceptibleSwitch { get; set; }

        /// <summary>
        /// <para>The maximum number of inodes in the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6,291,456</para>
        /// </summary>
        [NameInMap("InodeTotal")]
        [Validation(Required=false)]
        public long? InodeTotal { get; set; }

        /// <summary>
        /// <para>The current inode usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,194,304</para>
        /// </summary>
        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster runs the latest Milvus version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The cluster runs the latest Milvus version.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The cluster does not run the latest Milvus version.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the database proxy is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The database proxy is the latest version.</description></item>
        /// <item><description><b>false</b>: The database proxy is not the latest version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public bool? IsProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Unlock</b>: Not locked.</description></item>
        /// <item><description><b>ManualLock</b>: Manually locked. </description></item>
        /// <item><description><b>LockByExpiration</b>: Automatically locked due to cluster expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. The time is in the <c>HH:mmZ-HH:mmZ</c> format (UTC). For example, <c>16:00Z-17:00Z</c> indicates that routine maintenance can be performed from 00:00 to 01:00 (UTC+08:00).</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z-19:00Z</para>
        /// </summary>
        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

        /// <summary>
        /// <para>The Orca feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enabled.</para>
        /// </description></item>
        /// <item><description><para>off: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("Orca")]
        [Validation(Required=false)]
        public string Orca { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <p id="p_wyg_t4a_glm" props="china" icmsditafragmentmagic=1>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
        /// <p id="p_6de_jxy_k2g" props="china" icmsditafragmentmagic=1>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
        /// <note id="note_7kj_j0o_rgs" props="china" icmsditafragmentmagic=1>This parameter is supported only when StorageType is set to ESSDAUTOPL.</note>
        /// 
        /// <b>Example:</b>
        /// <para>2500</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public string ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of CPU cores of the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ProxyCpuCores")]
        [Validation(Required=false)]
        public string ProxyCpuCores { get; set; }

        /// <summary>
        /// <para>The serverless type of the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AgileServerless: agile serverless cluster.</description></item>
        /// <item><description>SteadyServerless: steady serverless, which is a cluster with defined specifications (billing method is subscription or pay-as-you-go).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SteadyServerless</para>
        /// </summary>
        [NameInMap("ProxyServerlessType")]
        [Validation(Required=false)]
        public string ProxyServerlessType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores in the standard configuration of the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProxyStandardCpuCores")]
        [Validation(Required=false)]
        public string ProxyStandardCpuCores { get; set; }

        /// <summary>
        /// <para>The status of the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: Being created.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Deleting</b>: Being released.</description></item>
        /// <item><description><b>Rebooting</b>: Being restarted.</description></item>
        /// <item><description><b>DBNodeCreating</b>: Increase node in progress.</description></item>
        /// <item><description><b>DBNodeDeleting</b>: Deleting a node.</description></item>
        /// <item><description><b>ClassChanging</b>: Changing node specifications.</description></item>
        /// <item><description><b>NetAddressCreating</b>: Creating network connectivity.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: Deleting network connectivity.</description></item>
        /// <item><description><b>NetAddressModifying</b>: Modifying network connectivity.</description></item>
        /// <item><description><b>Deleted</b>: Released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>The database proxy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exclusive</b>: Dedicated Enterprise Edition</description></item>
        /// <item><description><b>General</b>: Standard Enterprise Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>074467EF-86B9-4C23-ACBF-E9B81A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-***************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If RestoreType is <b>RestoreByTime</b> or <b>RestoreByTimeOss</b>, this value indicates the point in time to which the cluster was restored.</description></item>
        /// <item><description>If RestoreType is <b>RestoreByBackupSet</b> or <b>RestoreByBackupSetOss</b>, this value indicates the backup set ID used for the restoration.</description></item>
        /// </list>
        /// <para><note>This parameter is supported only for clusters restored from a backup set or point in time after June 1, 2024.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>2179639137</para>
        /// </summary>
        [NameInMap("RestoreDataPoint")]
        [Validation(Required=false)]
        public string RestoreDataPoint { get; set; }

        /// <summary>
        /// <para>The cluster restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RestoreByTime</b>: Restored from a point in time based on a level-1 backup.</description></item>
        /// <item><description><b>RestoreByBackupSet</b>: Restored from a backup set based on a level-1 backup.</description></item>
        /// <item><description><b>RestoreByTimeOss</b>: Restored from a point in time based on a level-2 backup.</description></item>
        /// <item><description><b>RestoreByBackupSetOss</b>: Restored from a backup set based on a level-2 backup.</description></item>
        /// <item><description><b>CloneFromSourceCluster</b>: Cloned from the source cluster.</description></item>
        /// </list>
        /// <para><note>This parameter is supported only for clusters restored from a backup set or point in time after June 1, 2024.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>RestoreByTime</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The row compression setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("RowCompression")]
        [Validation(Required=false)]
        public string RowCompression { get; set; }

        /// <summary>
        /// <para>The storage size of SQL statements, in bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>The running status of the search node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("SearchClusterStatus")]
        [Validation(Required=false)]
        public string SearchClusterStatus { get; set; }

        /// <summary>
        /// <para>The compressed storage data size of the search node.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the storage compression feature is enabled for the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15529410560</para>
        /// </summary>
        [NameInMap("SearchCompressStorageUsed")]
        [Validation(Required=false)]
        public long? SearchCompressStorageUsed { get; set; }

        /// <summary>
        /// <para>The storage usage of the search node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("SearchStorageUsed")]
        [Validation(Required=false)]
        public long? SearchStorageUsed { get; set; }

        /// <summary>
        /// <para>The serverless type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AgileServerless: agile serverless cluster.</description></item>
        /// <item><description>SteadyServerless: steady serverless, which is a cluster with defined specifications that has the serverless feature enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters or clusters with defined specifications that have the serverless feature enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SteadyServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The source cluster ID.
        /// <note>This parameter is supported only for clusters restored from a backup set or point in time after June 1, 2024.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-pz51ziv48317b2880</para>
        /// </summary>
        [NameInMap("SourceDBCluster")]
        [Validation(Required=false)]
        public string SourceDBCluster { get; set; }

        /// <summary>
        /// <para>The region ID of the source cluster.
        /// <note>This parameter is returned only when the source cluster ID exists.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>The cross-zone disaster recovery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Cross-zone disaster recovery is enabled.</description></item>
        /// <item><description><b>OFF</b>: Cross-zone disaster recovery is disabled.</description></item>
        /// <item><description><b>0</b>: Customer drill mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for the current cluster specifications, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10995116277760</para>
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// <para>The storage billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-by-capacity (pay-as-you-go).</description></item>
        /// <item><description><b>Prepaid</b>: pay-by-space (subscription).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space for pay-by-space (subscription) billing. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. The value is fixed as <b>HighPerformance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HighPerformance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>The storage usage, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether multi-zone data strong consistency is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Multi-zone data strong consistency is enabled. This applies to Standard Edition clusters deployed across three zones.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Multi-zone data strong consistency is not enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// <para>The specification type of compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exclusive</b>: Dedicated</description></item>
        /// <item><description><b>General</b>: General-purpose</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for PolarDB for MySQL clusters of the Cluster Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// <para>Indicates whether the failover with hot replica feature that is compatible with IMCI is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("SupportInstantSwitchWithImci")]
        [Validation(Required=false)]
        public string SupportInstantSwitchWithImci { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBClusterAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}

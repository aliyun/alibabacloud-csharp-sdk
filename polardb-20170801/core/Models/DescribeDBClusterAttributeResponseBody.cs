// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The start time of the free trial for the AI feature.</para>
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
        /// <item><description><para><b>SearchNode</b>: a search node.</para>
        /// </description></item>
        /// <item><description><para><b>DLNode</b>: an AI node.</para>
        /// </description></item>
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
        /// <item><description><para><b>X86</b></para>
        /// </description></item>
        /// <item><description><para><b>ARM</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The method for minor version upgrades.</para>
        /// <list type="bullet">
        /// <item><description><para>Auto: automatic upgrade</para>
        /// </description></item>
        /// <item><description><para>Manual: manual upgrade</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("AutoUpgradeMinorVersion")]
        [Validation(Required=false)]
        public string AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of blktags for the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7,864,320</para>
        /// </summary>
        [NameInMap("BlktagTotal")]
        [Validation(Required=false)]
        public long? BlktagTotal { get; set; }

        /// <summary>
        /// <para>The number of used blktags.</para>
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
        /// <para>Indicates whether the performance burst feature is enabled for the ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/183258.html">product edition</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Cluster Edition</para>
        /// </description></item>
        /// <item><description><para><b>Basic</b>: Single Node Edition</para>
        /// </description></item>
        /// <item><description><para><b>Archive</b>: X-Engine</para>
        /// </description></item>
        /// <item><description><para><b>NormalMultimaster</b>: Multi-master Cluster Edition</para>
        /// </description></item>
        /// <item><description><para><b>SENormal</b>: Standard Edition</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The single node edition is not supported for PolarDB for PostgreSQL that runs PostgreSQL 11.</para>
        /// </description></item>
        /// <item><description><para>The Standard Edition is supported on PolarDB for MySQL that runs MySQL 8.0 or 5.7 and on PolarDB for PostgreSQL that runs PostgreSQL 14.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for MySQL that runs MySQL 8.0 supports X-Engine and the Multi-master Cluster Edition.</para>
        /// </description></item>
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
        /// <para>Indicates whether column-oriented tables are enabled.</para>
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
        /// <item><description><para>ON: enabled</para>
        /// </description></item>
        /// <item><description><para>OFF: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CompressStorageMode")]
        [Validation(Required=false)]
        public string CompressStorageMode { get; set; }

        /// <summary>
        /// <para>The size of the compressed storage data.</para>
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
        /// <para>The cluster status. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/99286.html">Cluster states</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The details of the nodes.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores that are added for the elastic scaling feature within seconds.</para>
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
            /// <para>The role of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Writer</b>: the primary node.</para>
            /// </description></item>
            /// <item><description><para><b>Reader</b>: a read-only node.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Reader</para>
            /// </summary>
            [NameInMap("DBNodeRole")]
            [Validation(Required=false)]
            public string DBNodeRole { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b></para>
            /// </description></item>
            /// <item><description><para><b>Running</b></para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b></para>
            /// </description></item>
            /// <item><description><para><b>Rebooting</b></para>
            /// </description></item>
            /// <item><description><para><b>DBNodeCreating</b>: A node is being added.</para>
            /// </description></item>
            /// <item><description><para><b>DBNodeDeleting</b>: A node is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressDeleting</b>: A network connection is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressModifying</b>: A network connection is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>MinorVersionUpgrading</b>: The minor version is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>Maintaining</b>: The instance is being maintained.</para>
            /// </description></item>
            /// <item><description><para><b>Switching</b>: A switchover is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The failover priority. Each node has a failover priority. A larger value indicates a higher priority for the node to be promoted to the primary node during a failover. Valid values: 1 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

            /// <summary>
            /// <para>Indicates whether the hot replica feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: disabled</para>
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
            /// <para>Indicates whether the In-Memory Column Index (IMCI) feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: disabled</para>
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
            /// <para>The ID of the primary node in a Multi-master Cluster Edition cluster.</para>
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
            /// <para>The maximum input/output operations per second (IOPS).</para>
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
            /// <para>The name of the hot replica compute node that corresponds to the node in an architecture where both hot standby storage and hot standby compute are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52mirror*****</para>
            /// </summary>
            [NameInMap("MirrorInsName")]
            [Validation(Required=false)]
            public string MirrorInsName { get; set; }

            /// <summary>
            /// <para>The local secondary node in a multi-master cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("MultiMasterLocalStandby")]
            [Validation(Required=false)]
            public string MultiMasterLocalStandby { get; set; }

            /// <summary>
            /// <para>The primary node in a multi-master cluster.</para>
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
            /// <item><description><para>on: enabled</para>
            /// </description></item>
            /// <item><description><para>off: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Orca")]
            [Validation(Required=false)]
            public string Orca { get; set; }

            /// <summary>
            /// <para>The size of the remote memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("RemoteMemorySize")]
            [Validation(Required=false)]
            public string RemoteMemorySize { get; set; }

            /// <summary>
            /// <para>Indicates whether global consistency (high-performance mode) is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: disabled</para>
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
            /// <para>The routing weight. Valid values: 1 to 100. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            /// <summary>
            /// <para>The Serverless type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AgileServerless: agile, which indicates a Serverless node.</para>
            /// </description></item>
            /// <item><description><para>SteadyServerless: steady, which indicates that Serverless capabilities are added to a node with defined specifications.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for Serverless clusters or clusters with defined specifications for which the Serverless feature is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/452274.html">Serverless</a>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SteadyServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is in the primary zone or a secondary zone. This parameter is mainly used for peer resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Primary: the primary zone</para>
            /// </description></item>
            /// <item><description><para>Standby: a secondary zone</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("SubCluster")]
            [Validation(Required=false)]
            public string SubCluster { get; set; }

            /// <summary>
            /// <para>The description of the cluster subgroup.</para>
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
        /// <para>The status of the minor engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Stable</b>: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para><b>Old</b>: The current version is old. Upgrade the cluster to the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>HighRisk</b>: The current version has critical defects. Immediately upgrade the cluster to the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>Beta</b>: The current version is a beta version.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For more information about how to upgrade the minor engine version, see <a href="https://help.aliyun.com/document_detail/158572.html">Upgrade versions</a>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned only when the <b>DBType</b> parameter is set to <b>MySQL</b>.</para>
        /// </description></item>
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
        /// <para>The total size of level-1 backups (snapshots). Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74448896</para>
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// <para>The data replication mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AsyncSync</b>: asynchronous</para>
        /// </description></item>
        /// <item><description><para><b>SemiSync</b>: semi-synchronous</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncSync</para>
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// <para>The lock state of the cluster for deletion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The cluster is not locked and can be deleted.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The cluster is locked and cannot be deleted.</para>
        /// </description></item>
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
        /// <para>This parameter is returned only for subscription clusters. An empty value is returned for pay-as-you-go clusters.</para>
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
        /// <para>This parameter is returned only for subscription clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>Indicates whether resources for the new primary database are provisioned after a cross-zone failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasCompleteStandbyRes")]
        [Validation(Required=false)]
        public bool? HasCompleteStandbyRes { get; set; }

        /// <summary>
        /// <para>Indicates whether the hot standby storage cluster (and standby compute nodes) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>StandbyClusterON</b>: The hot standby storage cluster or both the hot standby storage cluster and standby compute nodes are enabled.</para>
        /// </description></item>
        /// <item><description><para><b>StandbyClusterOFF</b>: The hot standby storage cluster or both the hot standby storage cluster and standby compute nodes are disabled.</para>
        /// </description></item>
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
        /// <item><description><para><c>ON</c>: enabled.</para>
        /// </description></item>
        /// <item><description><para><c>OFF</c>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ImciAutoIndex")]
        [Validation(Required=false)]
        public string ImciAutoIndex { get; set; }

        /// <summary>
        /// <para>The imperceptible switchover feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ImperceptibleSwitch")]
        [Validation(Required=false)]
        public string ImperceptibleSwitch { get; set; }

        /// <summary>
        /// <para>The maximum number of inodes for the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6,291,456</para>
        /// </summary>
        [NameInMap("InodeTotal")]
        [Validation(Required=false)]
        public long? InodeTotal { get; set; }

        /// <summary>
        /// <para>The number of used inodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,194,304</para>
        /// </summary>
        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether the kernel is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
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
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public bool? IsProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Unlock</b>: The cluster is not locked.</para>
        /// </description></item>
        /// <item><description><para><b>ManualLock</b>: The cluster is manually locked.</para>
        /// </description></item>
        /// <item><description><para><b>LockByExpiration</b>: The cluster is automatically locked after it expires.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. The time is in the <c>HH:mmZ-HH:mmZ</c> format and is in UTC. For example, <c>16:00Z-17:00Z</c> indicates that routine maintenance can be performed from 00:00 to 01:00 (UTC+8).</para>
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
        /// <item><description><para>on: enabled</para>
        /// </description></item>
        /// <item><description><para>off: disabled</para>
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
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is supported only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
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
        /// <para>The Serverless type of the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AgileServerless: agile, which indicates a Serverless cluster.</para>
        /// </description></item>
        /// <item><description><para>SteadyServerless: steady, which indicates a cluster with defined specifications (a subscription or pay-as-you-go cluster).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SteadyServerless</para>
        /// </summary>
        [NameInMap("ProxyServerlessType")]
        [Validation(Required=false)]
        public string ProxyServerlessType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores of the database proxy with standard specifications.</para>
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
        /// <item><description><para><b>Creating</b></para>
        /// </description></item>
        /// <item><description><para><b>Running</b></para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The proxy is being released.</para>
        /// </description></item>
        /// <item><description><para><b>Rebooting</b></para>
        /// </description></item>
        /// <item><description><para><b>DBNodeCreating</b>: A node is being added.</para>
        /// </description></item>
        /// <item><description><para><b>DBNodeDeleting</b>: A node is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressDeleting</b>: A network connection is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressModifying</b>: A network connection is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: The proxy is released.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>The type of the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Exclusive</b>: Dedicated Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para><b>General</b> : Standard Enterprise Edition</para>
        /// </description></item>
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
        /// <item><description><para>If RestoreType is set to <b>RestoreByTime</b> or <b>RestoreByTimeOss</b>, this parameter indicates the point in time for the restoration.</para>
        /// </description></item>
        /// <item><description><para>If RestoreType is set to <b>RestoreByBackupSet</b> or <b>RestoreByBackupSetOss</b>, this parameter indicates the ID of the backup set that is used for the restoration.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for clusters that are restored from a backup set or a point in time after June 1, 2024.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2179639137</para>
        /// </summary>
        [NameInMap("RestoreDataPoint")]
        [Validation(Required=false)]
        public string RestoreDataPoint { get; set; }

        /// <summary>
        /// <para>The method that is used to restore the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RestoreByTime</b>: The cluster is restored to a point in time from a level-1 backup.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByBackupSet</b>: The cluster is restored from a level-1 backup set.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByTimeOss</b>: The cluster is restored to a point in time from a level-2 backup.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByBackupSetOss</b>: The cluster is restored from a level-2 backup set.</para>
        /// </description></item>
        /// <item><description><para><b>CloneFromSourceCluster</b>: The cluster is cloned from a source cluster.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for clusters that are restored from a backup set or a point in time after June 1, 2024.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RestoreByTime</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The row compression settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("RowCompression")]
        [Validation(Required=false)]
        public string RowCompression { get; set; }

        /// <summary>
        /// <para>The storage usage for SQL statements. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>The running state of the search node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("SearchClusterStatus")]
        [Validation(Required=false)]
        public string SearchClusterStatus { get; set; }

        /// <summary>
        /// <para>The size of the compressed storage data of the search node.</para>
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
        /// <para>The Serverless type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AgileServerless: agile, which indicates a Serverless cluster.</para>
        /// </description></item>
        /// <item><description><para>SteadyServerless: steady, which indicates a cluster with defined specifications for which the Serverless feature is enabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for Serverless clusters or clusters with defined specifications for which the Serverless feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SteadyServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The source cluster ID.</para>
        /// <remarks>
        /// <para>This parameter is supported only for clusters that are restored from a backup set or a point in time after June 1, 2024.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-pz51ziv48317b2880</para>
        /// </summary>
        [NameInMap("SourceDBCluster")]
        [Validation(Required=false)]
        public string SourceDBCluster { get; set; }

        /// <summary>
        /// <para>The region ID of the source cluster.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the source cluster ID exists.</para>
        /// </remarks>
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
        /// <item><description><para><b>ON</b>: The cross-zone disaster recovery mode is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: The cross-zone disaster recovery mode is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: The customer drill mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of the current cluster specifications. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10995116277760</para>
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// <para>The billing method for storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space of the subscription cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage class. The value is fixed as <b>HighPerformance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HighPerformance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The used storage space. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether strong consistency is enabled for the multi-zone data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Strong consistency is enabled for the multi-zone data. This applies to Standard Edition clusters that are deployed across three zones.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Strong consistency is not enabled for the multi-zone data.</para>
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
        /// <para>The specification type of the compute node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Exclusive</b>: Dedicated</para>
        /// </description></item>
        /// <item><description><para><b>General</b>: General-purpose</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for PolarDB for MySQL Cluster Edition clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// <para>Indicates whether the instant switchover feature that is compatible with IMCI is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("SupportInstantSwitchWithImci")]
        [Validation(Required=false)]
        public string SupportInstantSwitchWithImci { get; set; }

        /// <summary>
        /// <para>The details of the tags.</para>
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
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The virtual switch ID.</para>
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

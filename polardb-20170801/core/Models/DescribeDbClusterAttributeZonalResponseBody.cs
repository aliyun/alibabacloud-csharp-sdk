// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDbClusterAttributeZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The start time of the free trial for the AI feature</para>
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
        /// <item><description><para><b>SearchNode</b>: Search node.</para>
        /// </description></item>
        /// <item><description><para><b>DLNode</b>: AI node.</para>
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
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The upgrade method for the minor version</para>
        /// <list type="bullet">
        /// <item><description><para>Auto: Automatic upgrade</para>
        /// </description></item>
        /// <item><description><para>Manual: Manual upgrade</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
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

        /// <summary>
        /// <para>Indicates whether the I/O performance burst feature is enabled for the ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled</para>
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
        /// <item><description><para><b>Basic</b>: Single Node</para>
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
        /// <item><description><para>PolarDB for PostgreSQL clusters of PostgreSQL 11 do not support the single node edition.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for MySQL clusters of 8.0 and 5.7, and PolarDB for PostgreSQL clusters of PostgreSQL 14 support the Standard Edition.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for MySQL clusters of 8.0 support X-Engine and the Multi-master Cluster Edition.</para>
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
        /// <para>Indicates whether storage compression is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ON: Enabled</para>
        /// </description></item>
        /// <item><description><para>OFF: Disabled</para>
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
        /// <para>The size of the compressed data in storage.</para>
        /// <remarks>
        /// <para>This parameter is returned only when storage compression is enabled for the cluster.</para>
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
        /// <para>The cluster specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x8.medium.c</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

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
        /// <para>pc-**************</para>
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
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The cluster is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The cluster is being released.</para>
        /// </description></item>
        /// <item><description><para><b>Rebooting</b>: The cluster is being restarted.</para>
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
        /// <item><description><para><b>Deleted</b>: The cluster is released.</para>
        /// </description></item>
        /// <item><description><para><b>ClassChanged</b>: Resources are being reclaimed after an upgrade or downgrade.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The details of the node information.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDbClusterAttributeZonalResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDbClusterAttributeZonalResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores for bursting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            /// <summary>
            /// <para>The number of CPU cores in the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

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
            /// <para>The node role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Writer</b>: The primary node.</para>
            /// </description></item>
            /// <item><description><para><b>Reader</b>: The read-only node.</para>
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
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The node is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: The node is running.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The node is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Rebooting</b>: The node is being restarted.</para>
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
            /// <item><description><para><b>MinorVersionUpgrading</b>: The minor version is being updated.</para>
            /// </description></item>
            /// <item><description><para><b>Maintaining</b>: The instance is under maintenance.</para>
            /// </description></item>
            /// <item><description><para><b>Switching</b>: A failover is in progress.</para>
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
            /// <para>The failover priority. Each node has a failover priority. A higher priority value indicates a higher probability that the node is elected as the primary node during a failover.
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
            /// <item><description><para><b>ON</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled</para>
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
            /// <item><description><para><b>ON</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled</para>
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
            /// <para>The maximum number of input/output operations per second (IOPS).</para>
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
            /// <para>The name of the hot replica compute node that corresponds to the node in an architecture where hot standby storage and hot standby compute are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52mirror*****</para>
            /// </summary>
            [NameInMap("MirrorInsName")]
            [Validation(Required=false)]
            public string MirrorInsName { get; set; }

            /// <summary>
            /// <para>MultiMasterLocalStandby</para>
            /// 
            /// <b>Example:</b>
            /// <para>MultiMasterLocalStandby</para>
            /// </summary>
            [NameInMap("MultiMasterLocalStandby")]
            [Validation(Required=false)]
            public string MultiMasterLocalStandby { get; set; }

            /// <summary>
            /// <para>MultiMasterPrimaryNode</para>
            /// 
            /// <b>Example:</b>
            /// <para>MultiMasterPrimaryNode</para>
            /// </summary>
            [NameInMap("MultiMasterPrimaryNode")]
            [Validation(Required=false)]
            public string MultiMasterPrimaryNode { get; set; }

            /// <summary>
            /// <para>The Orca feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled</para>
            /// </description></item>
            /// <item><description><para>off: Disabled</para>
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
            /// <para>Indicates whether the global consistency (high-performance mode) feature is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: Disabled</para>
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
            /// <para>The Serverless type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AgileServerless: Agile</para>
            /// </description></item>
            /// <item><description><para>SteadyServerless: Steady</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is in the primary or secondary zone. This parameter is mainly used for resource peering.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Primary: The primary zone</para>
            /// </description></item>
            /// <item><description><para>Standby: The secondary zone</para>
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
            /// <para>SubGroupDescription</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubGroupDescription</para>
            /// </summary>
            [NameInMap("SubGroupDescription")]
            [Validation(Required=false)]
            public string SubGroupDescription { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-d</para>
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
        /// <para>The status of the current minor version of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Stable</b>: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para><b>Old</b>: The current version is old. We recommend that you upgrade the cluster to the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>HighRisk</b>: The current version has critical bugs. Upgrade the cluster to the latest version immediately.</para>
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
        /// <para>The data replication relationship mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AsyncSync</b>: Asynchronous</para>
        /// </description></item>
        /// <item><description><para><b>SemiSync</b>: Semi-synchronous</para>
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
        /// <para>The database engine.</para>
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
        /// <para>This parameter is returned only for <b>Prepaid</b> (subscription) clusters. An empty value is returned for <b>Postpaid</b> (pay-as-you-go) clusters.</para>
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
        /// <para>Indicates whether resources of the new primary database are supplemented after a cross-zone failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No</para>
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
        /// <para>Indicates whether the hot standby storage cluster (and standby compute nodes) feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>StandbyClusterON</b>: The hot standby storage cluster feature or both the hot standby storage cluster and standby compute node features are enabled.</para>
        /// </description></item>
        /// <item><description><para><b>StandbyClusterOFF</b>: The hot standby storage cluster feature or both the hot standby storage cluster and standby compute node features are disabled.</para>
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
        /// <item><description><para><c>ON</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>OFF</c>: Disabled.</para>
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
        /// <para>Failover with hot replica. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
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
        /// <para>Indicates whether the cluster uses the latest kernel version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No</para>
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
        /// <para>Indicates whether the database proxy uses the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No</para>
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
        /// <item><description><para><b>LockByExpiration</b>: The cluster is automatically locked upon expiration.</para>
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
        /// <para>The maintenance window of the cluster. The time is in the <c>HH:mmZ-HH:mmZ</c> format and is displayed in UTC. For example, <c>16:00Z-17:00Z</c> indicates that routine maintenance can be performed from 00:00 to 01:00 (UTC+8).</para>
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
        /// <item><description><para>on: Enabled</para>
        /// </description></item>
        /// <item><description><para>off: Disabled</para>
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
        /// <item><description><para><b>Postpaid</b>: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: Subscription.</para>
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
        /// <para>The read and write IOPS that are preconfigured for the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is supported only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public string ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for the database proxy.</para>
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
        /// <item><description><para>AgileServerless: Agile. This indicates a Serverless cluster.</para>
        /// </description></item>
        /// <item><description><para>SteadyServerless: Steady. This indicates a cluster with defined specifications (a subscription or pay-as-you-go cluster).</para>
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
        /// <para>The number of CPU cores for the database proxy with standard specifications.</para>
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
        /// <item><description><para><b>Creating</b>: The proxy is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The proxy is running.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The proxy is being released.</para>
        /// </description></item>
        /// <item><description><para><b>Rebooting</b>: The proxy is being restarted.</para>
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
        /// <item><description><para><b>General</b>: Standard Enterprise Edition</para>
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
        /// <para>rg-************</para>
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
        /// <para>The method used to restore the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RestoreByTime</b>: The cluster is restored from a point in time based on a level-1 backup.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByBackupSet</b>: The cluster is restored from a backup set based on a level-1 backup.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByTimeOss</b>: The cluster is restored from a point in time based on a level-2 backup.</para>
        /// </description></item>
        /// <item><description><para><b>RestoreByBackupSetOss</b>: The cluster is restored from a backup set based on a level-2 backup.</para>
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
        /// <para>RowCompression</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("RowCompression")]
        [Validation(Required=false)]
        public string RowCompression { get; set; }

        /// <summary>
        /// <para>The storage usage for SQL. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>The Serverless type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AgileServerless: Agile</para>
        /// </description></item>
        /// <item><description><para>SteadyServerless: Steady</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
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
        /// <para>The ID of the region where the source cluster resides.</para>
        /// <remarks>
        /// <para>This parameter is returned only if a source cluster ID exists.</para>
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
        /// <item><description><para><b>0</b>: Customer drill mode.</para>
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
        /// <item><description><para><b>Postpaid</b>: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: Subscription.</para>
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
        /// <para>The storage capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage class of the Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PSL5</b></para>
        /// </description></item>
        /// <item><description><para><b>PSL4</b></para>
        /// </description></item>
        /// </list>
        /// <para>The storage class of the Standard Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ESSDPL0</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL1</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL2</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL3</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDAUTOPL</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ESSDPL0</para>
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
        /// <para>Indicates whether strong consistency is enabled for the multi-zone cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Strong consistency is enabled for the multi-zone cluster. This applies to Standard Edition clusters that are deployed in three zones.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Strong consistency is not enabled for the multi-zone cluster.</para>
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
        /// <para>Indicates whether the failover with hot replica feature that is compatible with the IMCI feature is supported.</para>
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
        public List<DescribeDbClusterAttributeZonalResponseBodyTags> Tags { get; set; }
        public class DescribeDbClusterAttributeZonalResponseBodyTags : TeaModel {
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
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The virtual switch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**********</para>
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

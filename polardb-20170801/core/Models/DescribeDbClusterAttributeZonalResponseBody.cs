// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDbClusterAttributeZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The start time of the free AI feature. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
        /// <item><description><b>SearchNode</b>: Search node.</description></item>
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
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The minor version update policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: Automatic update.</description></item>
        /// <item><description>Manual: Manual update.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
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
        /// <para>The number of used blktags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,242,880</para>
        /// </summary>
        [NameInMap("BlktagUsed")]
        [Validation(Required=false)]
        public long? BlktagUsed { get; set; }

        /// <summary>
        /// <para>Specifies whether I/O performance burst is enabled for ESSD AutoPL cloud disks. Valid values:</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/183258.html">edition</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition</description></item>
        /// <item><description><b>Basic</b>: Single Node Edition</description></item>
        /// <item><description><b>Archive</b>: X-Engine</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster Edition</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>PolarDB for PostgreSQL 11 does not support the Single Node Edition.</description></item>
        /// <item><description>PolarDB for MySQL 8.0 and 5.7, and PolarDB for PostgreSQL 14 support the Standard Edition.</description></item>
        /// <item><description>PolarDB for MySQL 8.0 supports X-Engine and the Multi-master Cluster Edition.</description></item>
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
        /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
        /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
        /// <item><description><b>Running</b>: The cluster is running.</description></item>
        /// <item><description><b>Deleting</b>: The cluster is being released.</description></item>
        /// <item><description><b>Rebooting</b>: The cluster is restarting.</description></item>
        /// <item><description><b>DBNodeCreating</b>: Nodes are being increased.</description></item>
        /// <item><description><b>DBNodeDeleting</b>: A node is being deleted.</description></item>
        /// <item><description><b>ClassChanging</b>: The node specifications are being changed.</description></item>
        /// <item><description><b>NetAddressCreating</b>: Network connectivity is being created.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: Network connectivity is being deleted.</description></item>
        /// <item><description><b>NetAddressModifying</b>: Network connectivity is being modified. </description></item>
        /// <item><description><b>Deleted</b>: The cluster is released.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description><b>ClassChanged</b>: The upgrade or decrease the quota is completed and resources are being revoked.</description></item>
        /// </list>
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
        public List<DescribeDbClusterAttributeZonalResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDbClusterAttributeZonalResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores added by the automatic scaling of local resources.</para>
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
            /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
            /// <para>The node role. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>Writer</b>: Primary node.</description></item>
            /// <item><description><b>Reader</b>: Read-only node.</description></item>
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
            /// <item><description><b>Creating</b>: The node is being created. </description></item>
            /// <item><description><b>Running</b>: The node is running. </description></item>
            /// <item><description><b>Deleting</b>: The node is being deleted.  </description></item>
            /// <item><description><b>Rebooting</b>: The node is restarting.  </description></item>
            /// <item><description><b>DBNodeCreating</b>: Nodes are being increased.  </description></item>
            /// <item><description><b>DBNodeDeleting</b>: A node is being deleted. </description></item>
            /// <item><description><b>ClassChanging</b>: The node specifications are being changed.  </description></item>
            /// <item><description><b>NetAddressCreating</b>: Network connectivity is being created.  </description></item>
            /// <item><description><b>NetAddressDeleting</b>: Network connectivity is being deleted.  </description></item>
            /// <item><description><b>NetAddressModifying</b>: Network connectivity is being modified.</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: The minor version is being upgraded.</description></item>
            /// <item><description><b>Maintaining</b>: The instance is under maintenance.  </description></item>
            /// <item><description><b>Switching</b>: A switchover is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The failover priority. Each node has a failover priority, which determines the probability of the node being elected as the primary node during a failover. A higher value indicates a higher priority.
            /// Valid values: 1 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

            /// <summary>
            /// <para>Indicates whether the hot standby feature is enabled. Valid values:</para>
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
            /// <para>Indicates whether the In-Memory Column Index (IMCI) feature is enabled. Valid values:</para>
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
            /// <para>The maximum number of I/O requests per second, namely IOPS.</para>
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
            /// <para>The name of the hot replica corresponding to the node in the hot standby storage and compute architecture.</para>
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
            /// <para>The Orca feature status. Valid values:</para>
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
            /// <para>The serverless type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AgileServerless: Agile.</description></item>
            /// <item><description>SteadyServerless: Steady.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>The zone where the node is deployed. This parameter is mainly used for resource symmetry.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: The primary zone.</description></item>
            /// <item><description>Standby: The secondary zone.</description></item>
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
        /// <para>The status of the current minor engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The current version is stable.</description></item>
        /// <item><description><b>Old</b>: The current version is outdated. Upgrade to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The current version has critical defects. Upgrade to the latest version immediately.</description></item>
        /// <item><description><b>Beta</b>: The current version is a beta version.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For more information about how to upgrade the minor engine version, see <a href="https://help.aliyun.com/document_detail/158572.html">Upgrade minor engine versions</a>.</description></item>
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
        /// <para>The total size of level-1 backups (snapshots). Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74448896</para>
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// <para>The data replication relationship pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AsyncSync</b>: Asynchronous synchronization.</description></item>
        /// <item><description><b>SemiSync</b>: Semi-synchronous synchronization.</description></item>
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
        /// <para>A specific value is returned only for clusters whose billing method is <b>Prepaid</b> (subscription). An empty value is returned for clusters whose billing method is <b>Postpaid</b> (pay-as-you-go). The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
        /// <para>Indicates whether to replenish the resources of the new primary database after a cross-zone switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <item><description><b>StandbyClusterON</b>: Enables the Hot Standby Cluster, or enables both the Hot Standby Cluster and standby compute nodes. </description></item>
        /// <item><description><b>StandbyClusterOFF</b>: shutdown the Hot Standby Cluster, or shutdown both the Hot Standby Cluster and standby compute nodes.</description></item>
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
        /// <para>The seamless switchover feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
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
        /// <para>The number of used inodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,194,304</para>
        /// </summary>
        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether the kernel version is the latest. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
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
        /// <para>Indicates whether the database proxy is of the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
        /// <item><description><b>ManualLock</b>: The cluster is manually locked. </description></item>
        /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. The time follows the ISO 8601 standard in the <c>HH:mmZ-HH:mmZ</c> format. The time is displayed in UTC. For example, <c>16:00Z-17:00Z</c> indicates that routine maintenance can be performed from 00:00 to 01:00 (UTC+8).</para>
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
        /// <item><description><b>Postpaid</b>: Pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: Subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <p id="p_wyg_t4a_glm" props="china" icmsditafragmentmagic=1>The provisioned read and write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.</para>
        /// <p id="p_6de_jxy_k2g" props="china" icmsditafragmentmagic=1>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <note id="note_7kj_j0o_rgs" props="china" icmsditafragmentmagic=1>This parameter is supported only when StorageType is set to ESSDAUTOPL.</note>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
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
        /// <item><description>AgileServerless: Agile mode, which indicates a serverless cluster.</description></item>
        /// <item><description>SteadyServerless: Steady mode, which indicates a cluster with defined specifications (a cluster whose billing is subscription or pay-as-you-go).</description></item>
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
        /// <item><description><b>Creating</b>: The database proxy is being created.</description></item>
        /// <item><description><b>Running</b>: The database proxy is running.</description></item>
        /// <item><description><b>Deleting</b>: The database proxy is being released.</description></item>
        /// <item><description><b>Rebooting</b>: The database proxy is restarting.</description></item>
        /// <item><description><b>DBNodeCreating</b>: Nodes are being increased.</description></item>
        /// <item><description><b>DBNodeDeleting</b>: A node is being deleted.</description></item>
        /// <item><description><b>ClassChanging</b>: The node specifications are being changed.</description></item>
        /// <item><description><b>NetAddressCreating</b>: Network connectivity is being created.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: Network connectivity is being deleted.</description></item>
        /// <item><description><b>NetAddressModifying</b>: Network connectivity is being modified.</description></item>
        /// <item><description><b>Deleted</b>: The database proxy is released.</description></item>
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
        /// <item><description><b>Exclusive</b>: Dedicated Enterprise Edition.</description></item>
        /// <item><description><b>General</b>: Standard Enterprise Edition.</description></item>
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
        /// <item><description>If RestoreType is set to <b>RestoreByTime</b> or <b>RestoreByTimeOss</b>, this value indicates the point in time to which the cluster is restored.</description></item>
        /// <item><description>If RestoreType is set to <b>RestoreByBackupSet</b> or <b>RestoreByBackupSetOss</b>, this value indicates the ID of the backup set from which the cluster is restored.</description></item>
        /// </list>
        /// <para><note>This parameter is supported only for clusters restored from a backup set or a point in time after June 1, 2024.</note></para>
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
        /// <item><description><b>RestoreByTime</b>: Restores the cluster from a level-1 backup to a specific point in time.</description></item>
        /// <item><description><b>RestoreByBackupSet</b>: Restores the cluster from a level-1 backup set.</description></item>
        /// <item><description><b>RestoreByTimeOss</b>: Restores the cluster from a level-2 backup to a specific point in time.</description></item>
        /// <item><description><b>RestoreByBackupSetOss</b>: Restores the cluster from a level-2 backup set.</description></item>
        /// <item><description><b>CloneFromSourceCluster</b>: Clones the cluster from the source cluster.</description></item>
        /// </list>
        /// <para><note>This parameter is supported only for clusters restored from a backup set or a point in time after June 1, 2024.</note></para>
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
        /// <para>The storage usage of SQL statements. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>The serverless type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AgileServerless: Agile.</description></item>
        /// <item><description>SteadyServerless: Steady.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The ID of the source cluster.
        /// <note>This parameter is supported only for clusters restored from a backup set or a point in time after June 1, 2024.</note></para>
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

        /// <summary>
        /// <para>The maximum storage capacity for the current cluster specifications. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10995116277760</para>
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// <para>The storage billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: Pay-as-you-go based on capacity.</description></item>
        /// <item><description><b>Prepaid</b>: Subscription based on storage space.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type of the Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>The storage type of the Standard Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ESSDPL0</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The amount of used storage space. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether strict data consistency across multiple zones is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Strict data consistency across multiple zones is enabled. This applies to the three-zone deployment scenario of the Standard Edition.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Strict data consistency across multiple zones is disabled.</para>
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
        /// <para>The specification type of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exclusive</b>: Dedicated</description></item>
        /// <item><description><b>General</b>: General-purpose</description></item>
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
        /// <para>Indicates whether the failover with hot replica feature compatible with IMCI is supported.</para>
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
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
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

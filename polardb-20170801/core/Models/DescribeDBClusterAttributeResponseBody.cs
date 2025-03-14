// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Start time for free AI activation</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-13T01:20:28Z</para>
        /// </summary>
        [NameInMap("AiCreatingTime")]
        [Validation(Required=false)]
        public string AiCreatingTime { get; set; }

        /// <summary>
        /// <para>Types of AI nodes. Values include:</para>
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
        /// <para>CPU architecture. Available options are:</para>
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
        /// <para>Maximum number of blktags in the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7,864,320</para>
        /// </summary>
        [NameInMap("BlktagTotal")]
        [Validation(Required=false)]
        public long? BlktagTotal { get; set; }

        /// <summary>
        /// <para>Current blktag usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,242,880</para>
        /// </summary>
        [NameInMap("BlktagUsed")]
        [Validation(Required=false)]
        public long? BlktagUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/183258.html">Product Series</a>, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition</description></item>
        /// <item><description><b>Basic</b>: Single Node</description></item>
        /// <item><description><b>Archive</b>: High Compression Engine (X-Engine)</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-Master Cluster Edition</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>PolarDB PostgreSQL version 11 does not support single-node.</description></item>
        /// <item><description>PolarDB MySQL versions 8.0 and 5.7, and PolarDB PostgreSQL version 14 support the Standard Edition.</description></item>
        /// <item><description>PolarDB MySQL version 8.0 supports High Compression Engine (X-Engine) and Multi-Master Cluster Edition.</description></item>
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
        /// <para>Whether storage compression is enabled. Values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>ON: Enabled</description></item>
        /// <item><description>OFF: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CompressStorageMode")]
        [Validation(Required=false)]
        public string CompressStorageMode { get; set; }

        /// <summary>
        /// <para>Compressed storage data size.</para>
        /// <remarks>
        /// <para>This parameter is supported only when the cluster\&quot;s storage compression feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15529410560</para>
        /// </summary>
        [NameInMap("CompressStorageUsed")]
        [Validation(Required=false)]
        public long? CompressStorageUsed { get; set; }

        /// <summary>
        /// <para>Cluster creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Network type of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>Cluster status. For the full list of values, refer to <a href="https://help.aliyun.com/document_detail/99286.html">Cluster Status Table</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The information about the nodes.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// <para>Number of CPU cores for second-level elastic scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            /// <summary>
            /// <para>Number of CPU cores for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>Node creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-23T21:35:43Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Node specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <para>Node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>Node role, with possible values as follows:</para>
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
            /// <para>Node status, with possible values as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: Creating</description></item>
            /// <item><description><b>Running</b>: Running</description></item>
            /// <item><description><b>Deleting</b>: Deleting</description></item>
            /// <item><description><b>Rebooting</b>: Rebooting</description></item>
            /// <item><description><b>DBNodeCreating</b>: Adding node</description></item>
            /// <item><description><b>DBNodeDeleting</b>: Removing node</description></item>
            /// <item><description><b>ClassChanging</b>: Modifying node specification</description></item>
            /// <item><description><b>NetAddressCreating</b>: Creating network connection</description></item>
            /// <item><description><b>NetAddressDeleting</b>: Deleting network connection</description></item>
            /// <item><description><b>NetAddressModifying</b>: Modifying network connection</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: Upgrading minor version</description></item>
            /// <item><description><b>Maintaining</b>: Instance maintenance</description></item>
            /// <item><description><b>Switching</b>: Switching</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>Failover priority. Each node has a failover priority, determining the likelihood of being elected as the primary node during a failover. A higher value indicates a higher priority.
            /// Range: 1 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

            /// <summary>
            /// <para>Whether hot standby is enabled. Possible values are:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b>: Enabled</description></item>
            /// <item><description><b>OFF</b>: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("HotReplicaMode")]
            [Validation(Required=false)]
            public string HotReplicaMode { get; set; }

            /// <summary>
            /// <para>Whether columnar index is enabled. Possible values are:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b>: Enabled</description></item>
            /// <item><description><b>OFF</b>: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("ImciSwitch")]
            [Validation(Required=false)]
            public string ImciSwitch { get; set; }

            /// <summary>
            /// <para>Primary node ID of the multi-master architecture cluster edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52akld3*****</para>
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            /// <summary>
            /// <para>Maximum concurrent connections of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <para>Maximum number of I/O requests, that is, IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public int? MaxIOPS { get; set; }

            /// <summary>
            /// <para>Node memory size, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The name of the hot standby compute node corresponding to the node when the hot standby storage and compute clusters feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52mirror*****</para>
            /// </summary>
            [NameInMap("MirrorInsName")]
            [Validation(Required=false)]
            public string MirrorInsName { get; set; }

            [NameInMap("MultiMasterLocalStandby")]
            [Validation(Required=false)]
            public string MultiMasterLocalStandby { get; set; }

            [NameInMap("MultiMasterPrimaryNode")]
            [Validation(Required=false)]
            public string MultiMasterPrimaryNode { get; set; }

            /// <summary>
            /// <para>Orca feature, valid values are:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled</description></item>
            /// <item><description>off: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Orca")]
            [Validation(Required=false)]
            public string Orca { get; set; }

            /// <summary>
            /// <para>Remote memory size, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("RemoteMemorySize")]
            [Validation(Required=false)]
            public string RemoteMemorySize { get; set; }

            /// <summary>
            /// <para>Whether the node has the global consistency (high-performance mode) feature enabled. Possible values are:</para>
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
            /// <para>Routing weight.
            /// Range: 1~100. Default is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            /// <summary>
            /// <para>Serverless type. Possible values include:</para>
            /// <list type="bullet">
            /// <item><description><b>AgileServerless</b>: Agile</description></item>
            /// <item><description><b>SteadyServerless</b>: Steady</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is only supported by Serverless clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>Identifies whether the node is in the primary or standby availability zone, primarily used in resource mirroring scenarios.
            /// Values include:</para>
            /// <list type="bullet">
            /// <item><description><b>Primary</b>: Primary Availability Zone</description></item>
            /// <item><description><b>Standby</b>: Standby Availability Zone</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("SubCluster")]
            [Validation(Required=false)]
            public string SubCluster { get; set; }

            /// <summary>
            /// <para>Availability zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>Database engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the minor version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The minor version is stable.</description></item>
        /// <item><description><b>Old</b>: The minor version is outdated. We recommend that you update it to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The minor version has critical defects. We recommend that you immediately update it to the latest version.</description></item>
        /// <item><description><b>Beta</b>: The minor version is a Beta version.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For information about how to update the minor version, see <a href="https://help.aliyun.com/document_detail/158572.html">Minor version update</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <para>Total size of Level 1 backups (snapshots), in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74448896</para>
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// <para>Data replication relationship mode. Values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>AsyncSync</b>: Asynchronous</description></item>
        /// <item><description><b>SemiSync</b>: Semi-synchronous</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncSync</para>
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// <para>Lock status for cluster deletion, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unlocked, cluster can be deleted.</description></item>
        /// <item><description><b>1</b>: Locked, cluster cannot be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DeletionLock")]
        [Validation(Required=false)]
        public int? DeletionLock { get; set; }

        /// <summary>
        /// <para>Cluster engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Cluster expiration time.</para>
        /// <remarks>
        /// <para>Only clusters with <b>Prepaid</b> (subscription) payment methods return specific parameter values; <b>Postpaid</b> (pay-as-you-go) clusters return empty values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Whether the cluster has expired.</para>
        /// <remarks>
        /// <para>This parameter is only supported for clusters with <b>Prepaid</b> (Subscription) payment methods.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>Whether to replenish resources for the new primary after cross-AZ switch. Values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasCompleteStandbyRes")]
        [Validation(Required=false)]
        public bool? HasCompleteStandbyRes { get; set; }

        /// <summary>
        /// <para>Whether to enable storage hot backup cluster (and Standby compute nodes). Values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>StandbyClusterON</b>: Enable storage hot backup/Enable storage hot backup and Standby compute nodes.</description></item>
        /// <item><description><b>StandbyClusterOFF</b>: Disable storage hot backup/Disable storage hot backup and Standby compute nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StandbyClusterON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>Indicates whether the automatic IMCI-based query acceleration feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ON</c>: enabled</description></item>
        /// <item><description><c>OFF</c>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ImciAutoIndex")]
        [Validation(Required=false)]
        public string ImciAutoIndex { get; set; }

        /// <summary>
        /// <para>Indicates whether failover with hot replica is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c> (default)</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ImperceptibleSwitch")]
        [Validation(Required=false)]
        public string ImperceptibleSwitch { get; set; }

        /// <summary>
        /// <para>Maximum number of inodes in the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6,291,456</para>
        /// </summary>
        [NameInMap("InodeTotal")]
        [Validation(Required=false)]
        public long? InodeTotal { get; set; }

        /// <summary>
        /// <para>Current inode usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,194,304</para>
        /// </summary>
        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether it is the latest kernel version. Values are as follows:</para>
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
        /// <para>Indicates whether it is the latest version of the database proxy, with possible values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public bool? IsProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>Lock mode. Possible values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Unlock</b>: Unlocked.</description></item>
        /// <item><description><b>ManualLock</b>: Manually triggered lock.</description></item>
        /// <item><description><b>LockByExpiration</b>: Automatic cluster lock upon expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance window for the cluster, formatted as <c>HH:mmZ-HH:mmZ</c> (UTC time). For example, <c>16:00Z-17:00Z</c> indicates that routine maintenance can be performed from 0:00 to 1:00 (UTC+08:00).</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z-19:00Z</para>
        /// </summary>
        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

        /// <summary>
        /// <para>Orca function with possible values as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled</para>
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
        /// <para>Payment type. Possible values are:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: Pay-As-You-Go</description></item>
        /// <item><description><b>Prepaid</b>: Prepaid (Subscription).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Describes the preconfigured read and write IOPS for ESSD AutoPL cloud disks. Possible values: 0 to min{50,000, 1000<em>capacity - baseline performance}.<br>Baseline performance = min{1,800 + 50</em>capacity, 50000}.<br>Note: This parameter is supported only when StorageType is ESSDAUTOPL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2500</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public string ProvisionedIops { get; set; }

        /// <summary>
        /// <para>Number of CPU cores for the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ProxyCpuCores")]
        [Validation(Required=false)]
        public string ProxyCpuCores { get; set; }

        /// <summary>
        /// <para>Serverless type for the database proxy. Currently, the value is fixed to AgileServerless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ProxyServerlessType")]
        [Validation(Required=false)]
        public string ProxyServerlessType { get; set; }

        /// <summary>
        /// <para>Standard configuration CPU cores for the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProxyStandardCpuCores")]
        [Validation(Required=false)]
        public string ProxyStandardCpuCores { get; set; }

        /// <summary>
        /// <para>Status of the database proxy. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: Creating</description></item>
        /// <item><description><b>Running</b>: Running</description></item>
        /// <item><description><b>Deleting</b>: Releasing</description></item>
        /// <item><description><b>Rebooting</b>: Restarting</description></item>
        /// <item><description><b>DBNodeCreating</b>: Adding nodes</description></item>
        /// <item><description><b>DBNodeDeleting</b>: Deleting nodes</description></item>
        /// <item><description><b>ClassChanging</b>: Changing node specifications</description></item>
        /// <item><description><b>NetAddressCreating</b>: Creating network connections</description></item>
        /// <item><description><b>NetAddressDeleting</b>: Deleting network connections</description></item>
        /// <item><description><b>NetAddressModifying</b>: Modifying network connections</description></item>
        /// <item><description><b>Deleted</b>: Released</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>Database proxy types, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exclusive</b>: Enterprise Exclusive Edition</description></item>
        /// <item><description><b>General</b>: Enterprise General Purpose Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>074467EF-86B9-4C23-ACBF-E9B81A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-***************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>If RestoreType is <b>RestoreByTime</b> or <b>RestoreByTimeOss</b>, this value represents the recovery time point. If RestoreType is <b>RestoreByBackupSet</b> or <b>RestoreByBackupSetOss</b>, this value indicates the ID of the backup set on which the recovery is based.
        /// <note>Only clusters restored from a backup set or time point after June 1, 2024, support this parameter.</note></para>
        /// 
        /// <b>Example:</b>
        /// <para>2179639137</para>
        /// </summary>
        [NameInMap("RestoreDataPoint")]
        [Validation(Required=false)]
        public string RestoreDataPoint { get; set; }

        /// <summary>
        /// <para>Cluster recovery method, with possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>RestoreByTime</b>: Restore from a time point based on primary backup. * <b>RestoreByBackupSet</b>: Restore from a backup set based on primary backup. * <b>RestoreByTimeOss</b>: Restore from a time point based on secondary backup. * <b>RestoreByBackupSetOss</b>: Restore from a backup set based on secondary backup. * <b>CloneFromSourceCluster</b>: Clone from the source cluster.
        /// <note>This parameter is only supported for clusters restored from a backup set or time point after June 1, 2024.</note></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RestoreByTime</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("RowCompression")]
        [Validation(Required=false)]
        public string RowCompression { get; set; }

        /// <summary>
        /// <para>Storage amount of SQL, in bytes. If the value is -1, it indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>Serverless type. Valid values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>AgileServerless: Agile - SteadyServerless: Stable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>Source cluster ID. <note>Clusters restored from backup sets or specific points in time after June 1, 2024, support this parameter.</note></para>
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
        /// <para> This parameter is returned only if the source cluster ID exists.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>Cross-AZ disaster recovery mode. Values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Enable cross-AZ disaster recovery mode.</description></item>
        /// <item><description><b>OFF</b>: Disable cross-AZ disaster recovery mode.</description></item>
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
        /// <para>The maximum storage capacity of the current cluster specification, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10995116277760</para>
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// <para>Storage billing type. Valid values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: Pay-as-you-go (by capacity).</description></item>
        /// <item><description><b>Prepaid</b>: Subscription (by space).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>Storage space for pay-by-space (subscription) billing. Unit: Byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>Storage type, with a fixed value of <b>HighPerformance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HighPerformance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>Amount of used storage space, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether multi-AZ data strong consistency is enabled for the cluster. The value ranges are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Indicates that multi-AZ data strong consistency is enabled, applicable to the Standard 3AZ scenario.</description></item>
        /// <item><description><b>OFF</b>: Indicates that multi-AZ data strong consistency is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// <para>Specification type of compute nodes, with possible values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Exclusive</b>: Dedicated specification</description></item>
        /// <item><description><b>General</b>: General-purpose specification</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for PolarDB MySQL Edition with the product series set to Cluster Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// <para>Indicates whether queries based on In-Memory Column Indexes (IMCIs) are supported during and after a failover with hot replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("SupportInstantSwitchWithImci")]
        [Validation(Required=false)]
        public string SupportInstantSwitchWithImci { get; set; }

        /// <summary>
        /// <para>Details of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBClusterAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>VSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>Availability Zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}

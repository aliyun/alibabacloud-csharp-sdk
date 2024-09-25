// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-13T01:20:28Z</para>
        /// </summary>
        [NameInMap("AiCreatingTime")]
        [Validation(Required=false)]
        public string AiCreatingTime { get; set; }

        /// <summary>
        /// <para>The information status of the AI node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SearchNode: search node.</description></item>
        /// <item><description>DLNode: AI node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DLNode</para>
        /// </summary>
        [NameInMap("AiType")]
        [Validation(Required=false)]
        public string AiType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Maximum blktags in file system.</para>
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

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/183258.html">The edition of PolarDB</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition.</description></item>
        /// <item><description><b>Basic</b>: Single Node Edition.</description></item>
        /// <item><description><b>Archive</b>: X-Engine Edition.</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster Edition.</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only PolarDB for MySQL supports Single Node Edition.</description></item>
        /// <item><description>Only PolarDB for MySQL 8.0.1 supports Standard Edition.</description></item>
        /// <item><description>Only PolarDB for MySQL 8.0 supports X-Engine Edition and Multi-master Cluster Edition.</description></item>
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
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CompressStorageMode")]
        [Validation(Required=false)]
        public string CompressStorageMode { get; set; }

        /// <summary>
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
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
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
        /// <para>The status of the cluster. For information about the valid values, see <a href="https://help.aliyun.com/document_detail/99286.html">Cluster states</a>.</para>
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
            /// <para>The number of CPU cores for compute node scale-out within seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            /// <summary>
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
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
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
            /// <item><description><b>Writer</b>: The node is the primary node.</description></item>
            /// <item><description><b>Reader</b>: The node is a read-only node.</description></item>
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
            /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
            /// <item><description><b>Running</b>: The cluster is running.</description></item>
            /// <item><description><b>Deleting</b>: The cluster is being deleted.</description></item>
            /// <item><description><b>Rebooting</b>: The cluster is restarting.</description></item>
            /// <item><description><b>DBNodeCreating</b>: PolarProxy is being added.</description></item>
            /// <item><description><b>DBNodeDeleting</b>: PolarProxy is being deleted.</description></item>
            /// <item><description><b>ClassChanging</b>: The specification type of PolarProxy are being modified.</description></item>
            /// <item><description><b>NetAddressCreating</b>: The network connection is being created.</description></item>
            /// <item><description><b>NetAddressDeleting</b>: The network connection is being deleted.</description></item>
            /// <item><description><b>NetAddressModifying</b>: The network connection is being modified.</description></item>
            /// <item><description><b>MinorVersionUpgrading</b>: The minor version is being updated.</description></item>
            /// <item><description><b>Maintaining</b>: The cluster is being maintained.</description></item>
            /// <item><description><b>Switching</b>: A failover is being performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The failover priority. Each node is assigned a failover priority. If a failover occurs, a node can be selected as a primary node. The priority determines the probability at which a node is selected as a primary node. A larger value indicates a higher priority. Valid values: 1 to 15.</para>
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
            /// <item><description><b>ON</b></description></item>
            /// <item><description><b>OFF</b></description></item>
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
            /// <item><description><b>ON</b></description></item>
            /// <item><description><b>OFF</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("ImciSwitch")]
            [Validation(Required=false)]
            public string ImciSwitch { get; set; }

            /// <summary>
            /// <para>The ID of the primary node in the cluster that runs Multi-master Cluster Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp18z52akld3*****</para>
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections in the cluster.</para>
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
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("MirrorInsName")]
            [Validation(Required=false)]
            public string MirrorInsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Orca")]
            [Validation(Required=false)]
            public string Orca { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("RemoteMemorySize")]
            [Validation(Required=false)]
            public string RemoteMemorySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the global consistency (high-performance mode) feature is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b></description></item>
            /// <item><description><b>OFF</b></description></item>
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
            /// <para>The routing weight of the node. Valid values: 1 to 100 Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            /// <summary>
            /// <para>The type of the serverless node. Only <b>AgileServerless</b> can be returned.</para>
            /// <remarks>
            /// <para>This parameter is supported only for serverless clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("SubCluster")]
            [Validation(Required=false)]
            public string SubCluster { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
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
        /// <item><description><b>Old</b>: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about how to upgrade the minor version, see <a href="https://help.aliyun.com/document_detail/158572.html">Upgrade versions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <para>The total physical storage of level-1 backups (snapshots). Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74448896</para>
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// <para>Indicates the rule of data replication. Valid values: AsyncSync: asynchronous. SemiSync: semi-synchronous.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncSync</para>
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster is locked and can be deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The cluster is not locked and can be deleted.</description></item>
        /// <item><description><b>1</b>: The cluster is locked and cannot be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DeletionLock")]
        [Validation(Required=false)]
        public int? DeletionLock { get; set; }

        /// <summary>
        /// <para>The database type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The time when the cluster expires.</para>
        /// <remarks>
        /// <para>A specific value will be returned only for subscription (<b>Prepaid</b>) clusters. For pay-as-you-go (<b>Postpaid</b>) clusters, an empty string will be returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster has expired. Valid values:</para>
        /// <remarks>
        /// <para>This parameter is returned only for subscription (<b>Prepaid</b>) clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>Indicates whether to replenish resources for the primary database after a cross-zone switchover. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasCompleteStandbyRes")]
        [Validation(Required=false)]
        public bool? HasCompleteStandbyRes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StandbyClusterON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>Maximum inodes in file system.</para>
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
        /// <para>Indicates whether the kernel is of the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether PolarProxy uses the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
        /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
        /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. The format is <c>HH:mmZ-HH:mmZ</c>. The time is displayed in UTC. For example, the value <c>16:00Z-17:00Z</c> indicates that the cluster can be maintained from 00:00 to 01:00 (UTC+08:00).</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z-19:00Z</para>
        /// </summary>
        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("Orca")]
        [Validation(Required=false)]
        public string Orca { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2500</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public string ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for PolarProxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ProxyCpuCores")]
        [Validation(Required=false)]
        public string ProxyCpuCores { get; set; }

        /// <summary>
        /// <para>The type of the serverless PolarProxy. Valid value: AgileServerless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ProxyServerlessType")]
        [Validation(Required=false)]
        public string ProxyServerlessType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for PolarProxy Standard Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProxyStandardCpuCores")]
        [Validation(Required=false)]
        public string ProxyStandardCpuCores { get; set; }

        /// <summary>
        /// <para>The status of PolarProxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: PolarProxy is being created.</description></item>
        /// <item><description><b>Running</b>: PolarProxy is running.</description></item>
        /// <item><description><b>Deleting</b>: PolarProxy is being released.</description></item>
        /// <item><description><b>Rebooting</b>: PolarProxy is restarting.</description></item>
        /// <item><description><b>DBNodeCreating</b>: PolarProxy is being added.</description></item>
        /// <item><description><b>DBNodeDeleting</b>: PolarProxy is being deleted.</description></item>
        /// <item><description><b>ClassChanging</b>: The specifications of PolarProxy are being changed.</description></item>
        /// <item><description><b>NetAddressCreating</b>: The network connection is being created.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: The network connection is being deleted.</description></item>
        /// <item><description><b>NetAddressModifying</b>: The network connection is being modified.</description></item>
        /// <item><description><b>Deleted</b>: PolarProxy is released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>The type of PolarProxy. Valid values:</para>
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
        /// <para>The region ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>074467EF-86B9-4C23-ACBF-E9B81A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of your Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-***************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2179639137</para>
        /// </summary>
        [NameInMap("RestoreDataPoint")]
        [Validation(Required=false)]
        public string RestoreDataPoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RestoreByTime</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The storage of SQL. Unit: bytes. If the value is -1, no data is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// <para>The type of the serverless cluster. Only <b>AgileServerless</b> can be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-pz51ziv48317b2880</para>
        /// </summary>
        [NameInMap("SourceDBCluster")]
        [Validation(Required=false)]
        public string SourceDBCluster { get; set; }

        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>Indicates whether the cross-zone disaster recovery feature is enabled. Valid values: ON OFF 0: Customer Drill Mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of the current cluster specification. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10995116277760</para>
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// <para>The billing method of the storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space that uses the subscription billing method. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. Set the value to <b>HighPerformance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HighPerformance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The storage space consumed by the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// <para>Indicates whether the multi-zone data consistency feature is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Multi-zone data consistency is enabled, which is suitable for Standard Edition clusters that run Multi-zone Edition.</description></item>
        /// <item><description><b>OFF</b></description></item>
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
        /// <item><description><b>Exclusive</b>: dedicated.</description></item>
        /// <item><description><b>General</b>: general-purpose.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for PolarDB for MySQL clusters of Cluster Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        [NameInMap("SupportInstantSwitchWithImci")]
        [Validation(Required=false)]
        public string SupportInstantSwitchWithImci { get; set; }

        /// <summary>
        /// <para>Details about the tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBClusterAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}

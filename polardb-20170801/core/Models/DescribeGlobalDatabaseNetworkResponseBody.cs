// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection details.</para>
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyConnections> Connections { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyConnections : TeaModel {
            /// <summary>
            /// <para>The connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc.polardb.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The port number of the connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The time when the GDN was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-24T11:57:54Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1s826a1up******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The clusters in the GDN.</para>
        /// </summary>
        [NameInMap("DBClusters")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyDBClusters> DBClusters { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyDBClusters : TeaModel {
            /// <summary>
            /// <para>The edition of the cluster. Valid values:</para>
            /// <para><c>Normal</c>: Cluster Edition <c>Basic</c>: Single-node Edition <c>Archive</c>: X-Engine Edition <c>NormalMultimaster</c>: Multi-master Cluster Edition <c>SENormal</c>: Standard Edition</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>Single-node Edition is not supported for PolarDB for PostgreSQL clusters that run PostgreSQL 11.</para>
            /// </description></item>
            /// <item><description><para>Standard Edition is supported for PolarDB for MySQL clusters that run MySQL 8.0 or 5.7 and for PolarDB for PostgreSQL clusters that run PostgreSQL 14.</para>
            /// </description></item>
            /// <item><description><para>X-Engine Edition and Multi-master Cluster Edition are supported only for PolarDB for MySQL clusters that run MySQL 8.0.</para>
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
            /// <para>The description of the cluster.</para>
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
            /// <para>pc-wz9fb5nn44u1d****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The status of the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/99286.html">Cluster statuses</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The details of the nodes in the cluster.</para>
            /// </summary>
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<DescribeGlobalDatabaseNetworkResponseBodyDBClustersDBNodes> DBNodes { get; set; }
            public class DescribeGlobalDatabaseNetworkResponseBodyDBClustersDBNodes : TeaModel {
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
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x4.large</para>
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

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
                /// <item><description><para><b>Writer</b>: the primary node</para>
                /// </description></item>
                /// <item><description><para><b>Reader</b>: a read-only node</para>
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
                /// <item><description><para><b>Creating</b>: The node is being created.</para>
                /// </description></item>
                /// <item><description><para><b>Running</b>: The node is running.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The node is being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>Rebooting</b>: The node is being restarted.</para>
                /// </description></item>
                /// <item><description><para><b>ClassChanging</b>: The node type is being changed.</para>
                /// </description></item>
                /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created.</para>
                /// </description></item>
                /// <item><description><para><b>NetAddressDeleting</b>: A network connection is being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>NetAddressModifying</b>: A network connection is being modified.</para>
                /// </description></item>
                /// <item><description><para><b>MinorVersionUpgrading</b>: The minor version is being upgraded.</para>
                /// </description></item>
                /// <item><description><para><b>Maintaining</b>: The cluster is being maintained.</para>
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
                /// <para>The failover priority. In the event of a failover, the system promotes a read-only node to the primary node. A larger value indicates a higher priority. Each read-only node is assigned a failover priority. Valid values: 1 to 15.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailoverPriority")]
                [Validation(Required=false)]
                public int? FailoverPriority { get; set; }

                /// <summary>
                /// <para>The maximum number of concurrent connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8000</para>
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// <para>The maximum I/O operations per second (IOPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>32000</para>
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

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
            /// <para>The database engine. Only MySQL is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The database engine version. Only version 8.0 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The expiration time of the cluster.</para>
            /// <remarks>
            /// <para>This parameter is returned only for subscription clusters. An empty string is returned for pay-as-you-go clusters.</para>
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
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The cluster has expired.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The cluster has not expired.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The billing method of the cluster. Valid values:</para>
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
            /// <para>The region ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The replication lag for cross-region replication between the primary and standby clusters. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReplicaLag")]
            [Validation(Required=false)]
            public string ReplicaLag { get; set; }

            /// <summary>
            /// <para>The role of the cluster in the GDN. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>primary</b>: the primary cluster</para>
            /// </description></item>
            /// <item><description><para><b>standby</b>: a standby cluster</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A GDN consists of one primary cluster and up to four standby clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The type of the Serverless cluster. The value is fixed as <c>AgileServerless</c>.</para>
            /// <remarks>
            /// <para>This parameter is returned only for Serverless clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>The amount of storage space used. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3012558848</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public string StorageUsed { get; set; }

        }

        /// <summary>
        /// <para>The database engine type. Only MySQL is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database engine version. Only version 8.0 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The description of the GDN. It must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter or a Chinese character.</para>
        /// </description></item>
        /// <item><description><para>It can contain only letters, Chinese characters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 126 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GDN-fortest</para>
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        /// <summary>
        /// <para>The GDN ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-bp1fttxsrmv*****</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <para>The status of the Global Database Network (GDN). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>creating</b>: The GDN is being created.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The GDN is running.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The GDN is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>locked</b>: The GDN is locked. In this state, you cannot perform any operations on any cluster in the GDN.</para>
        /// </description></item>
        /// <item><description><para><b>removing_member</b>: A cluster is being removed from the GDN.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("GDNStatus")]
        [Validation(Required=false)]
        public string GDNStatus { get; set; }

        /// <summary>
        /// <para>The global domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[gdnid].gdn.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("GlobalDomainName")]
        [Validation(Required=false)]
        public string GlobalDomainName { get; set; }

        /// <summary>
        /// <para>The labels of the GDN.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public DescribeGlobalDatabaseNetworkResponseBodyLabels Labels { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The version of the GDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("GDNVersion")]
            [Validation(Required=false)]
            public string GDNVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F2E75F-AE67-4FB2-821F-A81237EACD15</para>
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

    }

}

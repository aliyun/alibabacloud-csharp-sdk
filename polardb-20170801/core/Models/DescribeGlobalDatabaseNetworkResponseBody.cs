// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the connection to the cluster.</para>
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyConnections> Connections { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyConnections : TeaModel {
            /// <summary>
            /// <para>The endpoint URL of the database service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc.polardb.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The network type for the database connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The port number for the database connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The time at which the GDN was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-24T11:57:54Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
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
            /// <para>Normal: Cluster Edition Basic: Single Node Edition Archive: X-Engine Edition NormalMultimaster: Multi-master Cluster Edition SENormal: Standard Edition</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>PolarDB for PostgreSQL clusters that run the PostgreSQL 11 database engine do not support Single Node Edition.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for MySQL 8.0 and 5.7 clusters, and PolarDB for PostgreSQL clusters that run the PostgreSQL 14 database engine support Standard Edition.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for MySQL 8.0 clusters support X-Engine Edition and Multi-master Cluster Edition.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-wz9fb5nn44u1d****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The status of the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/99286.html">Cluster status table</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// <para>The node specifications of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The nodes of the cluster.</para>
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
                /// <para>The specifications of the node.</para>
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
                /// <item><description><b>Writer</b>: the primary node</description></item>
                /// <item><description><b>Reader</b>: a read-only node</description></item>
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
                /// <item><description><b>Creating</b>: The node is being created.</description></item>
                /// <item><description><b>Running</b>: The node is running.</description></item>
                /// <item><description><b>Deleting</b>: The node is being deleted.</description></item>
                /// <item><description><b>Rebooting</b>: The node is restarting.</description></item>
                /// <item><description><b>ClassChanging</b>: The specifications of the node are being changed.</description></item>
                /// <item><description><b>NetAddressCreating</b>: The network connection is being created.</description></item>
                /// <item><description><b>NetAddressDeleting</b>: The network connection is being deleted.</description></item>
                /// <item><description><b>NetAddressModifying</b>: The network connection is being modified.</description></item>
                /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the node is being updated.</description></item>
                /// <item><description><b>Maintaining</b>: The node is being maintained.</description></item>
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
                /// <para>The failover priority. Each node is assigned a failover priority. The failover priority determines which node is selected as the primary node when a failover occurs. A larger value indicates a higher priority. Valid values: 1 to 15.</para>
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
                /// <para>The maximum input/output operations per second (IOPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>32000</para>
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// <para>The zone ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The database engine type of the cluster. Only MySQL is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The version of the database engine. Only version 8.0 is supported.</para>
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
            /// <para> A specific value is returned only for subscription (<b>Prepaid</b>) clusters. No value is returned for pay-as-you-go (<b>Postpaid</b>) clusters.</para>
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
            /// <item><description><b>true</b> (default)</description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only for subscription (<b>Prepaid</b>) clusters.</para>
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
            /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
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
            /// <para>The region ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The cross-region data replication latency between the primary cluster and secondary clusters. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReplicaLag")]
            [Validation(Required=false)]
            public string ReplicaLag { get; set; }

            /// <summary>
            /// <para>The role of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Primary</b>: the primary cluster</description></item>
            /// <item><description><b>standby</b>: a secondary cluster</description></item>
            /// </list>
            /// <remarks>
            /// <para> A GDN consists of one primary cluster and up to four secondary clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster is a serverless cluster. The value is fixed at AgileServerless.</para>
            /// <remarks>
            /// <para> This parameter is returned only for serverless clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>The storage usage of the cluster. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3012558848</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public string StorageUsed { get; set; }

        }

        /// <summary>
        /// <para>The type of the database engine. Only MySQL is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine. Only version 8.0 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The description of the GDN. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It must start with a letter.</description></item>
        /// <item><description>It can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>It must be 2 to 126 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GDN-fortest</para>
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        /// <summary>
        /// <para>The ID of the GDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-bp1fttxsrmv*****</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <para>The status of the GDN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The GDN is being created.</description></item>
        /// <item><description><b>active</b>: The GDN is running.</description></item>
        /// <item><description><b>deleting</b>: The GDN is being deleted.</description></item>
        /// <item><description><b>locked</b>: The GDN is locked. If the GDN is locked, you cannot perform operations on clusters in the GDN.</description></item>
        /// <item><description><b>removing_member</b>: The secondary cluster is being removed from the GDN.</description></item>
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

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public DescribeGlobalDatabaseNetworkResponseBodyLabels Labels { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyLabels : TeaModel {
            [NameInMap("GDNVersion")]
            [Validation(Required=false)]
            public string GDNVersion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F2E75F-AE67-4FB2-821F-A81237EACD15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

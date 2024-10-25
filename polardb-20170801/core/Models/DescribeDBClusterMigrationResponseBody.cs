// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterMigrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of a migration exception. If no exception occurs during the migration, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The endpoints of the PolarDB cluster.</para>
        /// </summary>
        [NameInMap("DBClusterEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointList> DBClusterEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointList : TeaModel {
            /// <summary>
            /// <para>Details about the endpoints.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**************.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The IP address of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.<em><b>.</b></em>.10</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: the public endpoint</description></item>
                /// <item><description><b>Private</b>: the internal endpoint (VPC)</description></item>
                /// <item><description><b>Inner</b>: the internal endpoint (classic network)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>Indicates whether SSL encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

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

            }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-***********</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Cluster</b>: the default cluster endpoint</description></item>
            /// <item><description><b>Primary</b>: the primary endpoint</description></item>
            /// <item><description><b>Custom</b>: the custom endpoint</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The read/write mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ReadWrite: receives and forwards read and write requests (automatic read-write splitting).</description></item>
            /// <item><description>ReadOnly (default): receives and forwards read requests only.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("ReadWriteMode")]
            [Validation(Required=false)]
            public string ReadWriteMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The mode of the PolarDB cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rw</b>: read and write mode</description></item>
        /// <item><description><b>ro</b>: read-only mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ro</para>
        /// </summary>
        [NameInMap("DBClusterReadWriteMode")]
        [Validation(Required=false)]
        public string DBClusterReadWriteMode { get; set; }

        /// <summary>
        /// <para>The replication latency between the ApsaraDB RDS instance and the PolarDB cluster. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelayedSeconds")]
        [Validation(Required=false)]
        public int? DelayedSeconds { get; set; }

        /// <summary>
        /// <para>The ID of the synchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dts**********618bs</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The expiration time of the replication between ApsaraDB RDS and PolarDB. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-17T01:56:36Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The migration state of the PolarDB cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NO_MIGRATION</b>: No migration task is running.</description></item>
        /// <item><description><b>RDS2POLARDB_CLONING</b>: Data is being replicated.</description></item>
        /// <item><description><b>RDS2POLARDB_SYNCING</b>: Data is being replicated. During the replication, the PolarDB cluster is running in read-only mode and the source ApsaraDB RDS instance is running in read and write mode.</description></item>
        /// <item><description><b>SWITCHING</b>: Databases are being switched.</description></item>
        /// <item><description><b>POLARDB2RDS_SYNCING</b>: Databases are switched. The PolarDB cluster is running in read and write mode and the source ApsaraDB RDS instance is running in read-only mode. In this state, you can modify the endpoints for your applications.</description></item>
        /// <item><description><b>ROLLBACK</b>: The migration is being rolled back. After the rollback is complete, the value <b>RDS2POLARDB_SYNCING</b> is returned.</description></item>
        /// <item><description><b>CLOSING_MIGRATION</b>: The migration task is being terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS2POLARDB_SYNCING</para>
        /// </summary>
        [NameInMap("MigrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// <para>The endpoints of the ApsaraDB RDS instance.</para>
        /// </summary>
        [NameInMap("RdsEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyRdsEndpointList> RdsEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyRdsEndpointList : TeaModel {
            /// <summary>
            /// <para>Details about the endpoints.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-***********.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The IP address of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.<em><b>.</b></em>.173</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: the public endpoint</description></item>
                /// <item><description><b>Private</b>: the internal endpoint (VPC)</description></item>
                /// <item><description><b>Inner</b>: the internal endpoint (classic network)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>Indicates whether SSL encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-**************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The role of the source database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly
            /// Maxscale
            /// Primary</para>
            /// </summary>
            [NameInMap("CustinsType")]
            [Validation(Required=false)]
            public string CustinsType { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-************-normal</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: the standard endpoint</description></item>
            /// <item><description><b>ReadWriteSplitting</b>: the read/write splitting endpoint</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// <para>The mode of the source ApsaraDB RDS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rw</b>: read and write mode</description></item>
        /// <item><description><b>ro</b>: read-only mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rw</para>
        /// </summary>
        [NameInMap("RdsReadWriteMode")]
        [Validation(Required=false)]
        public string RdsReadWriteMode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2A9EFA7-915F-4572-8299-85A307******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the source ApsaraDB RDS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-************</para>
        /// </summary>
        [NameInMap("SourceRDSDBInstanceId")]
        [Validation(Required=false)]
        public string SourceRDSDBInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PolarDBMySQL</b>: The source database is a PolarDB for MySQL database when the major version of your PolarDB cluster is upgraded.</description></item>
        /// <item><description><b>RDS</b>: The source database is an ApsaraDB RDS database when data is migrated from ApsaraDB RDS to PolarDB for MySQL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBMySQL</para>
        /// </summary>
        [NameInMap("SrcDbType")]
        [Validation(Required=false)]
        public string SrcDbType { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS2POLARDB</b>: Data is replicated from an ApsaraDB RDS instance to a PolarDB cluster.</description></item>
        /// <item><description><b>POLARDB2RDS</b>: Data is replicated from a PolarDB cluster to an ApsaraDB RDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS2POLARDB</para>
        /// </summary>
        [NameInMap("Topologies")]
        [Validation(Required=false)]
        public string Topologies { get; set; }

    }

}

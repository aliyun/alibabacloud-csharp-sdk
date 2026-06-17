// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterMigrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The comments on the migration exception. If no exception occurs during the migration, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The details of the PolarDB endpoints.</para>
        /// </summary>
        [NameInMap("DBClusterEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointList> DBClusterEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointList : TeaModel {
            /// <summary>
            /// <para>The details of the connection strings.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems : TeaModel {
                /// <summary>
                /// <para>The connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**************.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
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
                /// <item><description><para><b>Public</b>: An endpoint for the Internet.</para>
                /// </description></item>
                /// <item><description><para><b>Private</b>: A private endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>Inner</b>: A private endpoint in a classic network.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>Indicates whether Secure Sockets Layer (SSL) encryption is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: SSL encryption is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: SSL encryption is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-**********</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-**********</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The endpoint ID.</para>
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
            /// <item><description><para><b>Cluster</b>: The default cluster endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Primary</b>: The primary endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Custom</b>: A custom cluster endpoint.</para>
            /// </description></item>
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
            /// <item><description><para>ReadWrite: Read and write (automatic read/write splitting).</para>
            /// </description></item>
            /// <item><description><para>ReadOnly (Default): Read-only.</para>
            /// </description></item>
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
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The read/write mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>rw</b>: Read and write.</para>
        /// </description></item>
        /// <item><description><para><b>ro</b>: Read-only.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ro</para>
        /// </summary>
        [NameInMap("DBClusterReadWriteMode")]
        [Validation(Required=false)]
        public string DBClusterReadWriteMode { get; set; }

        /// <summary>
        /// <para>The replication delay between the ApsaraDB RDS instance and the PolarDB cluster, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelayedSeconds")]
        [Validation(Required=false)]
        public int? DelayedSeconds { get; set; }

        /// <summary>
        /// <para>The ID of the sync task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dts**********618bs</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the replication relationship between the ApsaraDB RDS instance and the PolarDB cluster expires. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-17T01:56:36Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The migration status of the PolarDB cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NO_MIGRATION</b>: No migration task is created.</para>
        /// </description></item>
        /// <item><description><para><b>RDS2POLARDB_CLONING</b>: Data is being cloned.</para>
        /// </description></item>
        /// <item><description><para><b>RDS2POLARDB_SYNCING</b>: Data is being synchronized. In this state, the PolarDB cluster is read-only, and the ApsaraDB RDS instance is read-write.</para>
        /// </description></item>
        /// <item><description><para><b>SWITCHING</b>: The database is being switched.</para>
        /// </description></item>
        /// <item><description><para><b>POLARDB2RDS_SYNCING</b>: The database switch is complete. In this state, the PolarDB cluster is read-write, and the ApsaraDB RDS instance is read-only. Change the endpoints in your application.</para>
        /// </description></item>
        /// <item><description><para><b>ROLLBACK</b>: The migration is being rolled back. After the rollback is complete, the migration status changes to <b>RDS2POLARDB_SYNCING</b>.</para>
        /// </description></item>
        /// <item><description><para><b>CLOSING_MIGRATION</b>: The migration task is being shut down.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS2POLARDB_SYNCING</para>
        /// </summary>
        [NameInMap("MigrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// <para>The details of the ApsaraDB RDS endpoints.</para>
        /// </summary>
        [NameInMap("RdsEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyRdsEndpointList> RdsEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyRdsEndpointList : TeaModel {
            /// <summary>
            /// <para>The details of the connection strings.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems : TeaModel {
                /// <summary>
                /// <para>The connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-***********.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
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
                /// <item><description><para><b>Public</b>: An endpoint for the Internet.</para>
                /// </description></item>
                /// <item><description><para><b>Private</b>: A private endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>Inner</b>: A private endpoint in a classic network.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port.</para>
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
                /// <item><description><para><b>Enabled</b>: SSL encryption is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: SSL encryption is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-**************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The instance type.</para>
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
            /// <para>The endpoint ID.</para>
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
            /// <item><description><para><b>Normal</b>: A regular endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>ReadWriteSplitting</b>: A read/write splitting endpoint.</para>
            /// </description></item>
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
        /// <para>The read/write mode of the source ApsaraDB RDS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>rw</b>: Read and write.</para>
        /// </description></item>
        /// <item><description><para><b>ro</b>: Read-only.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rw</para>
        /// </summary>
        [NameInMap("RdsReadWriteMode")]
        [Validation(Required=false)]
        public string RdsReadWriteMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description><para><b>PolarDBMySQL</b>: The source database for a major version upgrade of a PolarDB cluster.</para>
        /// </description></item>
        /// <item><description><para><b>RDS</b>: The source database for migrating data from an ApsaraDB RDS instance to a PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBMySQL</para>
        /// </summary>
        [NameInMap("SrcDbType")]
        [Validation(Required=false)]
        public string SrcDbType { get; set; }

        /// <summary>
        /// <para>The data synchronization relationship. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS2POLARDB</b>: Data is synchronized from the ApsaraDB RDS instance to the PolarDB cluster.</para>
        /// </description></item>
        /// <item><description><para><b>POLARDB2RDS</b>: Data is synchronized from the PolarDB cluster to the ApsaraDB RDS instance.</para>
        /// </description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterMigrationResponseBody : TeaModel {
        /// <summary>
        /// The description of a migration exception. If no exception occurs during the migration, an empty string is returned.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The endpoints of the PolarDB cluster.
        /// </summary>
        [NameInMap("DBClusterEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointList> DBClusterEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointList : TeaModel {
            /// <summary>
            /// Details about the endpoints.
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems : TeaModel {
                /// <summary>
                /// The connection string.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The IP address of the endpoint.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **Public**: the public endpoint
                /// *   **Private**: the internal endpoint (VPC)
                /// *   **Inner**: the internal endpoint (classic network)
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// Indicates whether SSL encryption is enabled. Valid values:
                /// 
                /// *   **Enabled**
                /// *   **Disabled**
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// The type of the endpoint. Valid values:
            /// 
            /// *   **Cluster**: the default cluster endpoint
            /// *   **Primary**: the primary endpoint
            /// *   **Custom**: the custom cluster endpoint
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The mode of the PolarDB cluster. Valid values:
        /// 
        /// *   **rw**: read and write mode
        /// *   **ro**: read-only mode
        /// </summary>
        [NameInMap("DBClusterReadWriteMode")]
        [Validation(Required=false)]
        public string DBClusterReadWriteMode { get; set; }

        /// <summary>
        /// The replication latency between the ApsaraDB RDS instance and the PolarDB cluster. Unit: seconds.
        /// </summary>
        [NameInMap("DelayedSeconds")]
        [Validation(Required=false)]
        public int? DelayedSeconds { get; set; }

        /// <summary>
        /// The ID of the synchronous task.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The expiration time of the replication between ApsaraDB RDS and PolarDB. The time is in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// The migration state of the PolarDB cluster. Valid values:
        /// 
        /// *   **NO_MIGRATION**: No migration task is running.
        /// *   **RDS2POLARDB_CLONING**: Data is being replicated.
        /// *   **RDS2POLARDB_SYNCING**: Data is being replicated. During the replication, the PolarDB cluster is running in read-only mode and the source ApsaraDB RDS instance is running in read and write mode.
        /// *   **SWITCHING**: Databases are being switched.
        /// *   **POLARDB2RDS_SYNCING**: Databases are switched. The PolarDB cluster is running in read and write mode and the source ApsaraDB RDS instance is running in read-only mode. In this state, you can modify the endpoints for your applications.
        /// *   **ROLLBACK**: The migration is being rolled back. After the rollback is complete, the value **RDS2POLARDB_SYNCING** is returned.
        /// *   **CLOSING_MIGRATION**: The migration task is being terminated.
        /// </summary>
        [NameInMap("MigrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// The endpoints of the ApsaraDB RDS instance.
        /// </summary>
        [NameInMap("RdsEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyRdsEndpointList> RdsEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyRdsEndpointList : TeaModel {
            /// <summary>
            /// Details about the endpoints.
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems : TeaModel {
                /// <summary>
                /// The connection string.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The IP address of the endpoint.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **Public**: the public endpoint
                /// *   **Private**: the internal endpoint (VPC)
                /// *   **Inner**: the internal endpoint (classic network)
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// Indicates whether SSL encryption is enabled. Valid values:
                /// 
                /// *   **Enabled**
                /// *   **Disabled**
                /// </summary>
                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// The type of the endpoint. Valid values:
            /// 
            /// *   **Normal**: the standard endpoint
            /// *   **ReadWriteSplitting**: the read/write splitting endpoint
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// The mode of the source ApsaraDB RDS instance. Valid values:
        /// 
        /// *   **rw**: read and write mode
        /// *   **ro**: read-only mode
        /// </summary>
        [NameInMap("RdsReadWriteMode")]
        [Validation(Required=false)]
        public string RdsReadWriteMode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the source ApsaraDB RDS instance.
        /// </summary>
        [NameInMap("SourceRDSDBInstanceId")]
        [Validation(Required=false)]
        public string SourceRDSDBInstanceId { get; set; }

        /// <summary>
        /// The type of the source database. Valid values:
        /// 
        /// *   **PolarDBMySQL**: The source database is a PolarDB for MySQL database when the major version of your PolarDB cluster is upgraded.
        /// *   **RDS**: The source database is an ApsaraDB RDS database when data is migrated from ApsaraDB RDS to PolarDB for MySQL.
        /// </summary>
        [NameInMap("SrcDbType")]
        [Validation(Required=false)]
        public string SrcDbType { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **RDS2POLARDB**: Data is replicated from an ApsaraDB RDS instance to a PolarDB cluster.
        /// *   **POLARDB2RDS**: Data is replicated from a PolarDB cluster to an ApsaraDB RDS instance.
        /// </summary>
        [NameInMap("Topologies")]
        [Validation(Required=false)]
        public string Topologies { get; set; }

    }

}

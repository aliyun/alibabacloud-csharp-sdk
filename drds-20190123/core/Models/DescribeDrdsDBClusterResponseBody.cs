// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBClusterResponseBody : TeaModel {
        /// <summary>
        /// The details of each PolarDB cluster.
        /// </summary>
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDBClusterResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDBClusterResponseBodyDbInstance : TeaModel {
            /// <summary>
            /// The ID of the PolarDB cluster.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The status of the PolarDB instance.
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// The information about the nodes in the PolarDB Cluster.
            /// </summary>
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes DBNodes { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes : TeaModel {
                [NameInMap("DBNode")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode> DBNode { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode : TeaModel {
                    /// <summary>
                    /// The ID of the node in the apsaradb for PolarDB cluster.
                    /// </summary>
                    [NameInMap("DBNodeId")]
                    [Validation(Required=false)]
                    public string DBNodeId { get; set; }

                    /// <summary>
                    /// The role of a node in the apsaradb for PolarDB cluster. Valid values:
                    /// 
                    /// *   **Reader**
                    /// *   **Writer**
                    /// </summary>
                    [NameInMap("DBNodeRole")]
                    [Validation(Required=false)]
                    public string DBNodeRole { get; set; }

                    /// <summary>
                    /// The status of the nodes in the PolarDB cluster.
                    /// </summary>
                    [NameInMap("DBNodeStatus")]
                    [Validation(Required=false)]
                    public string DBNodeStatus { get; set; }

                    /// <summary>
                    /// The ID of the zone where the node of the PolarDB cluster resides.
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// The type of storage used by the DRDS database.
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }

            /// <summary>
            /// The endpoint of the PolarDB read /write splitting endpoint
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints Endpoints { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint> Endpoint { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint : TeaModel {
                    /// <summary>
                    /// The ID of the PolarDB connection address.
                    /// </summary>
                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// The ID list of the nodes in the PolarDB connection string. Separate multiple nodes with commas (,).
                    /// </summary>
                    [NameInMap("NodeIds")]
                    [Validation(Required=false)]
                    public string NodeIds { get; set; }

                    /// <summary>
                    /// The read ratio of this connection address managed by the DRDS database.
                    /// </summary>
                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                }

            }

            /// <summary>
            /// The type of the DRDS database storage engine.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The version of the DRDS database storage engine.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the PolarDB cluster expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The network type of the PolarDB cluster.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The billing method of the PolarDB cluster.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The PolarDB access port.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The type of RDS instance. PolarDB cluster does not support this parameter.
            /// </summary>
            [NameInMap("RdsInstType")]
            [Validation(Required=false)]
            public string RdsInstType { get; set; }

            /// <summary>
            /// This parameter specifies the Read mode when the database storage type is PolarDB.
            /// 
            /// Valid values:
            /// 
            /// *   **DEFAULT**: the default mode (that is, all read traffic is sent to the PolarDB read /write node).
            /// *   **CUSTOM**: Custom mode (you can customize the ratio of traffic sent to read /write nodes and read-only nodes).
            /// *   **BALANCE**: read balancing mode (the read traffic is automatically distributed by the read load module of the PolarDB cluster, which can also be understood as the read traffic being evenly distributed to each node).
            /// </summary>
            [NameInMap("ReadMode")]
            [Validation(Required=false)]
            public string ReadMode { get; set; }

            /// <summary>
            /// The number of days remaining on the PolarDB for MySQL instance.
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

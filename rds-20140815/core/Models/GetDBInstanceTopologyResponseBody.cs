// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDBInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// An internal parameter. You can ignore this parameter.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details about the topology.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceTopologyResponseBodyData Data { get; set; }
        public class GetDBInstanceTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// The network connection of the instance.
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataConnections> Connections { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **vpc**
                /// *   **public**
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// The node information.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataNodes> Nodes { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// The ID of the dedicated cluster.
                /// 
                /// > If the instance does not reside in the specified dedicated cluster, no value is returned.
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// The ID of the host on which the instance resides in the dedicated cluster.
                /// 
                /// > If the instance does not reside in the specified dedicated cluster, no value is returned.
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// The unique identifier of the instance.
                /// 
                /// > The value \*\*-1\*\* is returned for an instance that does not reside in a dedicated cluster.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **Master**: a primary node
                /// *   **Slave**: a secondary node
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// An internal parameter. You can ignore this parameter.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

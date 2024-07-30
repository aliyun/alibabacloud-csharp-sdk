// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically associate newly added nodes with the cluster endpoint. Default value: Disable. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the custom cluster endpoint.
        /// </summary>
        [NameInMap("DBEndpointDescription")]
        [Validation(Required=false)]
        public string DBEndpointDescription { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// The advanced configurations of the cluster endpoint, which are in the JSON format. You can specify the configurations of the following attributes: consistency level, transaction splitting, connection pool, and primary node accepts read requests.
        /// 
        /// *   Specifies the load balancing policy in the format of `{\\"LoadBalancePolicy\\":\\"Selected value\\"}`. Default value: 0. Valid values:
        /// 
        ///     *   **0**: connections-based load balancing
        ///     *   **1**: active requests-based load balancing
        /// 
        /// *   Specifies whether to enable the primary node accepts read requests feature in the format of `{\\"MasterAcceptReads\\":\\"Selected value\\"}`. Default value: on. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// *   Specifies whether to enable the transaction splitting feature in the format of `{\\"DistributedTransaction\\":\\"Selected value\\"}`. Default value: on. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// *   Specifies the consistency level in the format of `{\\"ConsistLevel\\":\\"Selected value\\"}`. Default value: 1. Valid values:
        /// 
        ///     *   **0**: eventual consistency (weak)
        ///     *   **1**: session consistency (medium)
        ///     *   **2**: global consistency (strong)
        /// 
        /// *   Specifies the connection pool in the format of `{\\"ConnectionPersist\\":\\"Selected value\\"}`. Default value: off. Valid values:
        /// 
        ///     *   **off**: disables the connection pool.
        ///     *   **Session**: enables the session-level connection pool.
        ///     *   **Transaction**: enables the transaction-level connection pool.
        /// 
        /// *   Specifies whether to enable the parallel query feature in the format of `{\\"MaxParallelDegree\\":\\"Selected value\\"}`. Default value: off. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// *   Specifies whether to enable the automatic request distribution between row store and column store nodes feature in the format of `{\\"EnableHtapImci\\":\\"Selected value\\"}`. Default value: off. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// *   Specifies whether to enable the overload protection feature in the format of `{\\"EnableOverloadThrottle\\":\\"Selected value\\"}`. Default value: off. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// > 
        /// 
        /// *   You can specify the transaction splitting, primary node accepts read requests, connection pool, and overload protection features for a PolarDB for MySQL cluster only if ReadWriteMode is set to ReadWrite for the cluster endpoint.
        /// 
        /// *   If the read /write mode of a PolarDB for MySQL cluster is set to **Read-only**, the **Connection-based SLB** and **Active Request-based SLB** SLB policies are supported. The **Read-write (Automatic read /write splitting) **mode of the cluster supports** Active Request-based SLB** policy.
        /// *   If ReadWriteMode is set to **ReadWrite** for the cluster endpoint of a PolarDB for MySQL cluster or if ReadWriteMode is set to **ReadOnly** and the load balancing policy is set to **active requests-based load balancing**, the automatic request distribution between row store and column store nodes feature is supported.
        /// *   Only PolarDB for MySQL supports global consistency.
        /// *   If the **ReadWriteMode** parameter is set to **ReadOnly**, the consistency level must be **0**.
        /// *   You can specify the consistency level, transaction splitting, connection pool, and primary node accepts read requests features at a time, such as `{\\"ConsistLevel\\":\\"1\\",\\"DistributedTransaction\\":\\"on\\",\\"ConnectionPersist\\":\\"Session\\",\\"MasterAcceptReads\\":\\"on\\"}`.
        /// *   The transaction splitting settings are restricted by the consistency level settings. For example, if you set the consistency level to **0**, transaction splitting cannot be enabled. If you set the consistency level to **1** or **2**, transaction splitting can be enabled.
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// The reader nodes to be associated with the endpoint. If you need to specify multiple reader nodes, separate the reader nodes with commas (,). If you do not specify this parameter, the predefined nodes are used by default.
        /// 
        /// > 
        /// 
        /// *   You must specify the node ID for each PolarDB for MySQL cluster.
        /// 
        /// *   You must specify the role name of each node for each PolarDB for PostgreSQL or PolarDB for Oracle cluster. Example: `Writer,Reader1,Reader2`.
        /// 
        /// *   If you set **ReadWriteMode** to **ReadOnly**, only one node can be associated with the cluster endpoint. If the only node becomes faulty, the cluster endpoint may be unavailable for up to an hour. We recommend that you do not associate only one node with the cluster endpoint in production environments. We recommend that you associate at least two nodes with the cluster endpoint to improve service availability.
        /// 
        /// *   If you set **ReadWriteMode** to **ReadWrite**, you must associate at least two nodes with the cluster endpoint.
        /// 
        ///     *   No limits are imposed on the two nodes that you select for each PolarDB for MySQL cluster. If the two nodes are read-only nodes, write requests are forwarded to the primary node.
        ///     *   The following limit applies to PolarDB for PostgreSQL and PolarDB for Oracle clusters: One of the selected nodes must be the primary node.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string Nodes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PolarSccTimeoutAction")]
        [Validation(Required=false)]
        public string PolarSccTimeoutAction { get; set; }

        [NameInMap("PolarSccWaitTimeout")]
        [Validation(Required=false)]
        public string PolarSccWaitTimeout { get; set; }

        /// <summary>
        /// The read/write mode. Valid values:
        /// 
        /// *   **ReadWrite**: The cluster endpoint handles read and write requests. Automatic read/write splitting is enabled.
        /// *   **ReadOnly**: The cluster endpoint handles read-only requests.
        /// </summary>
        [NameInMap("ReadWriteMode")]
        [Validation(Required=false)]
        public string ReadWriteMode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

    }

}

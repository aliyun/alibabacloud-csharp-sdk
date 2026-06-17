// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: Automatically adds new nodes to the endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b> (default): Does not automatically add new nodes to the endpoint.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request. The token must be unique, case-sensitive, and a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the custom cluster endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBEndpointDescription")]
        [Validation(Required=false)]
        public string DBEndpointDescription { get; set; }

        /// <summary>
        /// <para>The advanced configurations for the custom cluster endpoint, specified as a JSON string. You can configure features such as consistency level, transaction splitting, whether the primary node accepts read requests, connection pool, and load balancing policy.</para>
        /// <list type="bullet">
        /// <item><description><para>Specifies the load balancing policy. The format is {&quot;LoadBalancePolicy&quot;:&quot;policy&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: connections-based load balancing (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: active requests-based load balancing.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies the consistency level. The format is <c>{&quot;ConsistLevel&quot;:&quot;level&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: eventual consistency.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: session consistency (default).</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: global consistency.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable transaction splitting. The format is <c>{&quot;DistributedTransaction&quot;:&quot;status&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables transaction splitting (default).</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables transaction splitting.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether the primary node accepts read requests. The format is <c>{&quot;MasterAcceptReads&quot;:&quot;status&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The primary node accepts read requests.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The primary node does not accept read requests (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the connection pool. The format is <c>{&quot;ConnectionPersist&quot;:&quot;status&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>off</b>: disables the connection pool (default).</para>
        /// </description></item>
        /// <item><description><para><b>Session</b>: enables the session-level connection pool.</para>
        /// </description></item>
        /// <item><description><para><b>Transaction</b>: enables the transaction-level connection pool.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies the degree of parallelism for a parallel query. The format is {&quot;MaxParallelDegree&quot;:&quot;degree&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>A specific integer that specifies the degree of parallelism. For example: &quot;MaxParallelDegree&quot;:&quot;2&quot;.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables parallel query (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable automatic routing between row store and column store. The format is {&quot;EnableHtapImci&quot;:&quot;status&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables automatic routing.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables automatic routing (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable overload protection. The format is {&quot;EnableOverloadThrottle&quot;:&quot;status&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables overload protection.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables overload protection (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can configure transaction splitting, whether the primary node accepts read requests, the connection pool, and overload protection only for a PolarDB for MySQL endpoint in <b>ReadWrite</b> (automatic read/write splitting) mode.</para>
        /// </description></item>
        /// <item><description><para>A PolarDB for MySQL cluster endpoint in <b>ReadOnly</b> mode supports both <b>connections-based load balancing</b> and <b>active requests-based load balancing</b>. An endpoint in <b>ReadWrite</b> (automatic read/write splitting) mode supports only <b>active requests-based load balancing</b>.</para>
        /// </description></item>
        /// <item><description><para>You can enable automatic routing between row store and column store if the read/write mode of the cluster endpoint for PolarDB for MySQL is <b>ReadWrite</b> (automatic read/write splitting), or if the read/write mode is <b>ReadOnly</b> and the load balancing policy is <b>active requests-based load balancing</b>.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL clusters support global consistency.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, the consistency level must be <b>0</b> (eventual consistency).</para>
        /// </description></item>
        /// <item><description><para>You can configure the consistency level, transaction splitting, whether the primary node accepts read requests, and the connection pool at the same time. Example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The setting for transaction splitting depends on the consistency level. For example, if you set the consistency level to <b>0</b> (eventual consistency), you cannot enable transaction splitting. If you set the consistency level to <b>1</b> (session consistency) or <b>2</b> (global consistency), you can enable transaction splitting.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ConsistLevel&quot;: &quot;1&quot;,&quot;DistributedTransaction&quot;: &quot;on&quot;}</para>
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// <para>The type of the custom cluster endpoint. Set the value to <b>Custom</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The nodes to associate with the endpoint. Separate multiple node IDs with a comma (,). If you omit this parameter, all nodes in the cluster are added by default.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For a PolarDB for MySQL cluster, specify the node IDs.</para>
        /// </description></item>
        /// <item><description><para>For a PolarDB for PostgreSQL cluster or a PolarDB for PostgreSQL (compatible with Oracle) cluster, specify the roles of the nodes, such as <c>Writer,Reader1,Reader2</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, you can associate only one node with the endpoint. If this node fails, the endpoint may be unavailable for up to 1 hour. This configuration is not recommended for a production environment. To improve availability, associate at least two nodes with the endpoint.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadWrite</b>, you must associate at least two nodes with the endpoint.
        /// \* For a PolarDB for MySQL cluster, you can select any two nodes. If both nodes are read-only nodes, write requests are routed to the primary node.
        /// \* For a PolarDB for PostgreSQL cluster or a PolarDB for PostgreSQL (compatible with Oracle) cluster, the primary node must be included.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-**********,pi-*********</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-test****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The policy for handling global consistency read timeouts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Send the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Downgrade to a regular request. If a global consistency read times out, the query is automatically downgraded, and the client does not receive an error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PolarSccTimeoutAction")]
        [Validation(Required=false)]
        public string PolarSccTimeoutAction { get; set; }

        /// <summary>
        /// <para>The timeout period for global consistency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PolarSccWaitTimeout")]
        [Validation(Required=false)]
        public string PolarSccWaitTimeout { get; set; }

        /// <summary>
        /// <para>The read/write mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ReadWrite</b>: read/write (automatic read/write splitting).</para>
        /// </description></item>
        /// <item><description><para><b>ReadOnly</b> (default): read-only.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadOnly</para>
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

        /// <summary>
        /// <para>Specifies whether to enable global consistency (high-performance mode). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-2zehr7ghqovftils0****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-2ze775gnf7jn33ua****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}

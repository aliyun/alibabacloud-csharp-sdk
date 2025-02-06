// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic association of newly added nodes with the cluster endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: enables automatic association of newly added nodes with the cluster endpoint.</description></item>
        /// <item><description><b>Disable</b> (default): disables automatic association of newly added nodes with the cluster endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
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
        /// <para>The ID of the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-**************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The advanced configurations of the cluster endpoint, which are in the JSON format. You can configure the consistency level, transaction splitting, and connection pool settings, and specify whether the primary node accepts read requests.</para>
        /// <list type="bullet">
        /// <item><description><para>The load balancing policy. Format: <c>{\\&quot;LoadBalancePolicy\\&quot;:\\&quot;Load balancing policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): connections-based load balancing</description></item>
        /// <item><description><b>1</b>: active requests-based load balancing</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to allow the primary node to accept read requests. Format: <c>{\\&quot;MasterAcceptReads\\&quot;:\\&quot;Specification about whether to allow the primary node to accept read requests\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default): allows the primary node to accept read requests.</description></item>
        /// <item><description><b>off</b>: does not allow the primary node to accept read requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the transaction splitting feature. Format: <c>{\\&quot;DistributedTransaction\\&quot;:\\&quot;Specification about whether to enable the transaction splitting feature\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default): enables the transaction splitting feature.</description></item>
        /// <item><description><b>off</b>: disables the transaction splitting feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The consistency level. Format: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;Consistency level\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: eventual consistency (weak)</description></item>
        /// <item><description><b>1</b> (default): session consistency (medium)</description></item>
        /// <item><description><b>2</b>: global consistency (strong)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The global consistency timeout. Format: <c>{\\&quot;ConsistTimeout\\&quot;:\\&quot;Global consistency timeout\\&quot;}</c>. Valid values: 0 to 60,000. Default value: 20. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>The session consistency timeout. Format: <c>{\\&quot;ConsistSessionTimeout\\&quot;:\\&quot;Session consistency timeout\\&quot;}</c>. Valid values: 0 to 60,000. Default value: 0. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>The global (or session) consistency timeout policy. Format: <c>{\\&quot;ConsistTimeoutAction\\&quot;:\\&quot;Consistency timeout policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): PolarProxy sends read requests to the primary node.</description></item>
        /// <item><description><b>1</b>: PolarProxy returns the &quot;wait replication complete timeout, please retry&quot; error message to the application.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the connection pool feature. Format: <c>{\\&quot;ConnectionPersist\\&quot;:\\&quot;Specification about whether to enable the connection pool feature\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>off</b> (default): disables the connection pool feature.</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables the transaction-level connection pool.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the parallel query feature. Format: <c>{\\&quot;MaxParallelDegree\\&quot;:\\&quot;Specification about whether to enable the parallel query feature\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the parallel query feature.</description></item>
        /// <item><description><b>off</b> (default): disables the parallel query feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the automatic request distribution among row store and column store nodes feature. Format: <c>{\\&quot;EnableHtapImci\\&quot;:\\&quot;Specification about whether to enable automatic request distribution among row store and column store nodes feature\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the automatic request distribution among row store and column store nodes feature.</description></item>
        /// <item><description><b>off</b> (default): disables the automatic request distribution among row store and column store nodes feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the overload protection feature. Format: <c>{\\&quot;EnableOverloadThrottle\\&quot;:\\&quot;Specification about whether to enable the overload protection feature\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the overload protection feature.</description></item>
        /// <item><description><b>off</b> (default): disables the overload protection feature.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can configure the transaction splitting, connection pool, and overload protection settings, and specify whether the primary node accepts read requests settings for the cluster endpoint of a PolarDB for MySQL cluster only if ReadWriteMode of the cluster endpoint is set to Read and Write (Automatic Read/Write Splitting).</para>
        /// </description></item>
        /// <item><description><para>If ReadWriteMode of the cluster endpoint of a PolarDB for MySQL cluster is set to <b>Read-only</b>, you can specify the <b>Connections-based Load Balancing</b> or <b>Active Request-based Load Balancing</b> policy for the cluster endpoint. If ReadWriteMode of the cluster endpoint of a PolarDB for MySQL cluster is set to <b>Read/Write (Automatic Read/Write Splitting)</b>, you can specify only the <b>Active Request-based Load Balancing</b> policy for the cluster endpoint.</para>
        /// </description></item>
        /// <item><description><para>You can enable automatic request distribution among column store and row store nodes for the cluster endpoint of a PolarDB for MySQL cluster if ReadWriteMode of the cluster endpoint is set to <b>Read and Write (Automatic Read/Write Splitting)</b>, or if the ReadWriteMode of the cluster endpoint is set to <b>Read-only</b> and the load balancing policy is set to <b>Active requests-based load balancing</b>.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL supports global consistency.</para>
        /// </description></item>
        /// <item><description><para>You can set the consistency level of the cluster endpoint of a PolarDB for MySQL cluster only to <b>0</b> if <b>ReadWriteMode</b> of the cluster endpoint is set to <b>ReadOnly</b>.</para>
        /// </description></item>
        /// <item><description><para>You can configure the settings for the consistency level, transaction splitting, and connection pool features, and specify whether the primary node accepts read requests settings at a time. Example: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;1\\&quot;,\\&quot;DistributedTransaction\\&quot;:\\&quot;on\\&quot;,\\&quot;ConnectionPersist\\&quot;:\\&quot;Session\\&quot;,\\&quot;MasterAcceptReads\\&quot;:\\&quot;on\\&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The configuration for transaction splitting is limited by the configuration for the consistency level. For example, if you set the consistency level to <b>0</b>, you cannot enable transaction splitting. If you set the consistency level to <b>1</b> or <b>2</b>, you can enable transaction splitting.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;MasterAcceptReads&quot;:&quot;off&quot;,&quot;ConnectionPersist&quot;: &quot;on&quot;}</para>
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// <para>The reader nodes to be associated with the endpoint. If you need to specify multiple reader nodes, separate the reader nodes with commas (,). If you do not specify this parameter, the predefined nodes are used by default.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify the node ID for each PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// <item><description><para>You must specify the role name of each node for each PolarDB for PostgreSQL or PolarDB for Oracle cluster. Example: <c>Writer,Reader1,Reader2</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, only one node can be associated with the cluster endpoint. If the only node becomes faulty, the cluster endpoint may be unavailable for up to an hour. We recommend that you do not associate only one node with the cluster endpoint in production environments. We recommend that you associate at least two nodes with the cluster endpoint to improve service availability.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadWrite</b>, you must associate at least two nodes with the cluster endpoint.</para>
        /// <list type="bullet">
        /// <item><description>No limits are imposed on the two nodes that you select for each PolarDB for MySQL cluster. If the two nodes are read-only nodes, write requests are forwarded to the primary node.</description></item>
        /// <item><description>The following limit applies to PolarDB for PostgreSQL and PolarDB for Oracle clusters: One of the selected nodes must be the primary node.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pi-**************,pi-*************</para>
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
        /// <para>Global consistency timeout policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: sends the request to the primary node.</description></item>
        /// <item><description><b>2</b>: downgrades the consistency level of a query to inconsistent read when a global consistent read in the query times out. No error message is returned to the client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PolarSccTimeoutAction")]
        [Validation(Required=false)]
        public string PolarSccTimeoutAction { get; set; }

        /// <summary>
        /// <para>Global consistency timeout.</para>
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
        /// <item><description><b>ReadWrite</b>: The cluster endpoint handles read and write requests. Automatic read/write splitting is enabled.</description></item>
        /// <item><description><b>ReadOnly</b>: The cluster endpoint handles read-only requests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
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
        /// <para>Specifies whether to enable the global consistency (high-performance mode) feature for the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

    }

}

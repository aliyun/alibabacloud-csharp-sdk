// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointZonalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to this endpoint. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Yes.</description></item>
        /// <item><description><b>Disable</b>: No (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. The value can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The edge cloud cluster ID. You can call DescribeDBClustersZonal to query the ID. The ID of a common PolarDB cluster returned by DescribeDBClusters is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The endpoint name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBEndpointDescription")]
        [Validation(Required=false)]
        public string DBEndpointDescription { get; set; }

        /// <summary>
        /// <para>The cluster endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-****************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The advanced configurations of the cluster endpoint. The value is in JSON format. You can configure the consistency level, transaction splitting, whether to offload offload reads from primary node, and the connection pool.</para>
        /// <list type="bullet">
        /// <item><description><para>To set the load balancing policy, use the format <c>{&quot;LoadBalancePolicy&quot;:&quot;Load balancing policy&quot;}</c>. Valid values:   </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: load balancing based on the number of connections (default).</description></item>
        /// <item><description><b>1</b>: load balancing based on the number of active requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set whether to offload offload reads from primary node, use the format <c>{&quot;MasterAcceptReads&quot;:&quot;Whether to offload offload reads from primary node&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts reads (default).</description></item>
        /// <item><description><b>off</b>: Reads are offloaded from the primary node.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set transaction splitting, use the format <c>{&quot;DistributedTransaction&quot;:&quot;Transaction splitting&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables transaction splitting (default).</description></item>
        /// <item><description><b>off</b>: disables transaction splitting.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the consistency level, use the format <c>{&quot;ConsistLevel&quot;:&quot;Consistency level&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: eventual consistency (weak).</description></item>
        /// <item><description><b>1</b>: session consistency (medium) (default).</description></item>
        /// <item><description><b>2</b>: global consistency (strong).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the global consistency read timeout period, use the format <c>{&quot;ConsistTimeout&quot;:&quot;Global consistency read timeout period&quot;}</c>. Valid values: 0 to 60000. Default value: 20. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para>To set the session consistency read timeout period, use the format <c>{&quot;ConsistSessionTimeout&quot;:&quot;Session consistency read timeout period&quot;}</c>. Valid values: 0 to 60000. Default value: 0. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para>To set the global (or session) consistency read timeout policy, use the format <c>{&quot;ConsistTimeoutAction&quot;:&quot;Global consistency read timeout policy&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: forwards read requests to the primary node (default).</description></item>
        /// <item><description><b>1</b>: The proxy returns an error message <c>wait replication complete timeout, please retry</c> to the application.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the connection pool, use the format <c>{&quot;ConnectionPersist&quot;:&quot;Connection pool&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>off</b>: disables the connection pool (default).</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables transaction-level connection pooling.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set parallel query, use the format <c>{&quot;MaxParallelDegree&quot;:&quot;Parallel query&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables parallel query.</description></item>
        /// <item><description><b>off</b>: disables parallel query (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set automatic request distribution between row store and column store nodes, use the format <c>{&quot;EnableHtapImci&quot;:&quot;Automatic request distribution between row store and column store nodes&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables automatic request distribution between row store and column store nodes.</description></item>
        /// <item><description><b>off</b>: disables automatic request distribution between row store and column store nodes (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set whether to enable overload protection, use the format <c>{&quot;EnableOverloadThrottle&quot;:&quot;Whether to enable overload protection&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables overload protection.</description></item>
        /// <item><description><b>off</b>: disables overload protection (default).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can configure transaction splitting, whether to offload offload reads from primary node, the connection pool, and whether to enable overload protection only when the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>Read/write (automatic read/write splitting)</b>.</description></item>
        /// <item><description>When the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>Read-only</b>, both <b>load balancing based on the number of connections</b> and <b>load balancing based on the number of active requests</b> are supported. Cluster endpoints in <b>Read/write (automatic read/write splitting)</b> mode support only <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>You can configure automatic request distribution between row store and column store nodes when the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>Read/write (automatic read/write splitting)</b>, or when the read/write mode is set to <b>Read-only</b> and the load balancing policy is set to <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>Only PolarDB for MySQL supports setting the consistency level to global consistency.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, the consistency level can only be set to <b>0</b>.</description></item>
        /// <item><description>You can configure the consistency level, transaction splitting, whether to offload offload reads from primary node, and the connection pool at the same time. Example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</description></item>
        /// <item><description>The transaction splitting configuration is restricted by the consistency level configuration. For example, if the consistency level is set to <b>0</b>, transaction splitting cannot be enabled. If the consistency level is set to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;DistributedTransaction\&quot;:\&quot;off\&quot;,\&quot;ConsistLevel\&quot;:\&quot;0\&quot;,\&quot;LoadBalanceStrategy\&quot;:\&quot;load\&quot;,\&quot;MasterAcceptReads\&quot;:\&quot;on\&quot;}</para>
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// <para>The read-only nodes to be added to the destination endpoint. Separate multiple nodes with commas (,). Default value: the original nodes.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For PolarDB for MySQL, you must specify node IDs.</description></item>
        /// <item><description>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle), you must specify node role names, such as <c>Writer,Reader1,Reader2</c>.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, you can mount only one node. However, if this node fails, the endpoint may be unavailable for up to 1 hour. Do not use this configuration in production environments. Therefore, select at least two nodes to improve availability.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadWrite</b>, you must select at least two nodes.<list type="bullet">
        /// <item><description>For PolarDB for MySQL, you can select any two nodes. If both nodes are read-only nodes, write requests are forwarded to the primary node.</description></item>
        /// <item><description>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle), the primary node must be included.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The global consistency timeout policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: send the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: timeout degradation. If a global consistency read times out, the current query operation is automatically downgraded to regular requests, and the client does not receive an error message.</para>
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
        /// <para>The global consistency timeout period.</para>
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
        /// <item><description><b>ReadWrite</b>: read/write (automatic read/write splitting).</description></item>
        /// <item><description><b>ReadOnly</b>: read-only.</description></item>
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
        /// <para>Specifies whether to enable the global consistency (high-performance mode) feature for the node. Valid values: on (enabled) and off (disabled).</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterEndpointZonalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: New nodes are automatically added to the endpoint.</description></item>
        /// <item><description>Disable (default): New nodes are not automatically added to the endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. It can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the ENS edge cloud cluster. You can call DescribeDBClustersZonal to obtain the ID. Standard PolarDB cluster IDs are not applicable. Operation description: Prerequisites for edge cloud clusters: This API applies only to ENS edge cloud clusters and is not applicable to standard PolarDB clusters. It provides an overview of edge clouds, activation methods, and instructions on how to obtain the edge cluster ID, noting that the CreateDBClusterZonal API is currently unavailable and clusters must be created through alternative methods.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
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
        /// <para>The advanced configurations of the cluster endpoint. The value is a JSON string. Supported settings include the consistency level, transaction splitting, offload reads from primary node, and connection pool.</para>
        /// <list type="bullet">
        /// <item><description>Set the load balancing policy. Format: <c>{&quot;LoadBalancePolicy&quot;:&quot;Load balancing policy&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: Load balancing based on the number of connections (default).</description></item>
        /// <item><description><b>1</b>: Load balancing based on the number of active requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set the consistency level. Format: <c>{&quot;ConsistLevel&quot;:&quot;Consistency level&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: Eventual consistency.</description></item>
        /// <item><description><b>1</b>: Session consistency (default).</description></item>
        /// <item><description><b>2</b>: Global consistency.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set transaction splitting. Format: <c>{&quot;DistributedTransaction&quot;:&quot;Transaction splitting&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: Enable transaction splitting (default).</description></item>
        /// <item><description><b>off</b>: Disable transaction splitting.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set whether the primary node accepts read requests. Format: <c>{&quot;MasterAcceptReads&quot;:&quot;offload reads from primary node&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts read requests.</description></item>
        /// <item><description><b>off</b>: The primary node does not accept read requests (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set the connection pool. Format: <c>{&quot;ConnectionPersist&quot;:&quot;Connection pool&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>off</b>: Disable the connection pool (default).</description></item>
        /// <item><description><b>Session</b>: Enable the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: Enable the transaction-level connection pool.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set parallel query. Format: <c>{&quot;MaxParallelDegree&quot;:&quot;Parallel query&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description>A specific degree of parallelism. Example: <c>&quot;MaxParallelDegree&quot;:&quot;2&quot;</c>.</description></item>
        /// <item><description><b>off</b>: Disable parallel query (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set automatic request distribution among row store and column store nodes. Format: <c>{&quot;EnableHtapImci&quot;:&quot;Automatic request distribution among row store and column store nodes&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: Enable automatic request distribution among row store and column store nodes.</description></item>
        /// <item><description><b>off</b>: Disable automatic request distribution among row store and column store nodes (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set whether to enable overload protection. Format: <c>{&quot;EnableOverloadThrottle&quot;:&quot;Whether to enable overload protection&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: Enable overload protection.</description></item>
        /// <item><description><b>off</b>: Disable overload protection (default).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Transaction splitting, offloading reads from the primary node, the connection pool, and overload protection can be configured only when the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>Read and write (automatic read/write splitting)</b>.</description></item>
        /// <item><description>When the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>Read-only</b>, both <b>load balancing based on the number of connections</b> and <b>load balancing based on the number of active requests</b> are supported. Cluster endpoints in the <b>read and write (automatic read/write splitting) pattern</b> support only <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>Automatic request distribution among row store and column store nodes can be configured when the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>Read and write (automatic read/write splitting)</b>, or when the read/write pattern is set to <b>Read-only</b> and the load balancing policy is set to <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>Only PolarDB for MySQL supports setting the consistency level to global consistency.</description></item>
        /// <item><description>If the <b>ReadWriteMode</b> parameter is set to <b>ReadOnly</b>, the consistency level can only be set to <b>0</b>.</description></item>
        /// <item><description>You can apply settings for the consistency level, transaction splitting, offloading reads from the primary node, and the connection pool at the same time. Example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</description></item>
        /// <item><description>The configuration of transaction splitting is restricted by the consistency level. For example, if the consistency level is set to <b>0</b>, transaction splitting cannot be enabled. If the consistency level is set to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</description></item>
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
        /// <para>The nodes that handle read requests to be added to the target endpoint. Separate multiple nodes with commas (,). By default, all nodes are added.</para>
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
        /// <para>The timeout policy for global consistency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Send the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para>2: Timeout degradation. If a global consistency read times out, the query is automatically downgraded to regular requests, and the client does not receive an error message.</para>
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
        /// <item><description>ReadWrite: Read and write (automatic read/write splitting).</description></item>
        /// <item><description>ReadOnly (default): Read-only.</description></item>
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
        /// <para>Specifies whether to enable the global consistency (high-performance mode) feature for the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ON: Enabled.</para>
        /// </description></item>
        /// <item><description><para>OFF: Disabled.</para>
        /// </description></item>
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

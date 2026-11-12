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
        /// <item><description>Disable: New nodes are not automatically added to the endpoint. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. The value can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB on ENS cluster. You can call the DescribeDBClustersZonal operation to obtain the ID. Standard PolarDB cluster IDs are not supported. Usage notes: This operation applies only to PolarDB on ENS clusters. It outlines the concepts of edge clouds, activation methods, and how to obtain the edge cluster ID, noting that the CreateDBClusterZonal operation is unavailable and clusters must be created through alternative methods.</para>
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
        /// <para>The advanced configurations of the cluster endpoint. The value is a JSON string. Currently, settings for the consistency level, transaction splitting, offload reads from primary node, and connection pool are supported.</para>
        /// <list type="bullet">
        /// <item><description>Configure the load balancing policy. Format: {&quot;LoadBalancePolicy&quot;:&quot;load balancing policy&quot;}. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: load balancing based on the number of connections. This is the default value.</description></item>
        /// <item><description><b>1</b>: load balancing based on the number of active requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure the consistency level. Format: <c>{&quot;ConsistLevel&quot;:&quot;consistency level&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: eventual consistency.</description></item>
        /// <item><description><b>1</b>: session consistency. This is the default value.</description></item>
        /// <item><description><b>2</b>: global consistency.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure transaction splitting. Format: <c>{&quot;DistributedTransaction&quot;:&quot;transaction splitting&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables transaction splitting. This is the default value.</description></item>
        /// <item><description><b>off</b>: disables transaction splitting.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure whether the primary node accepts read requests. Format: <c>{&quot;MasterAcceptReads&quot;:&quot;offload reads from primary node&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts read requests.</description></item>
        /// <item><description><b>off</b>: The primary node does not accept read requests. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure the connection pool. Format: <c>{&quot;ConnectionPersist&quot;:&quot;connection pool&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>off</b>: disables the connection pool. This is the default value.</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables the transaction-level connection pool.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure parallel query. Format: {&quot;MaxParallelDegree&quot;:&quot;parallel query&quot;}. Valid values:<list type="bullet">
        /// <item><description>A specific number of concurrent queries. Example: &quot;MaxParallelDegree&quot;:&quot;2&quot;.</description></item>
        /// <item><description><b>off</b>: disables parallel query. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure automatic request distribution among row store and column store nodes. Format: {&quot;EnableHtapImci&quot;:&quot;automatic request distribution among row store and column store nodes&quot;}. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables automatic request distribution among row store and column store nodes.</description></item>
        /// <item><description><b>off</b>: disables automatic request distribution among row store and column store nodes. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Configure whether to enable overload protection. Format: {&quot;EnableOverloadThrottle&quot;:&quot;overload protection&quot;}. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables overload protection.</description></item>
        /// <item><description><b>off</b>: disables overload protection. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Transaction splitting, whether the primary node accepts read requests, the connection pool, and overload protection can be configured only when the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>read and write (automatic read/write splitting)</b>.</description></item>
        /// <item><description>When the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>read-only</b>, both <b>load balancing based on the number of connections</b> and <b>load balancing based on the number of active requests</b> are supported. Cluster endpoints in the <b>read and write (automatic read/write splitting) mode</b> only support the <b>load balancing based on the number of active requests</b> policy.</description></item>
        /// <item><description>Automatic request distribution among row store and column store nodes can be configured when the read/write mode of the PolarDB for MySQL cluster endpoint is set to <b>read and write (automatic read/write splitting)</b>, or when the read/write mode is set to <b>read-only</b> and the load balancing policy is set to <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>Only PolarDB for MySQL supports setting the consistency level to global consistency.</description></item>
        /// <item><description>If the ReadWriteMode parameter is set to <b>ReadOnly</b>, the consistency level can only be set to <b>0</b>.</description></item>
        /// <item><description>You can configure the consistency level, transaction splitting, whether the primary node accepts read requests, and the connection pool at the same time. Example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</description></item>
        /// <item><description>The configuration of transaction splitting is constrained by the consistency level. For example, if the consistency level is set to <b>0</b>, transaction splitting cannot be enabled. If the consistency level is set to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</description></item>
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
        /// <para>The read-only nodes to add to the endpoint. Separate multiple node IDs with commas (,). By default, all nodes are added.</para>
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
        /// <item><description><para>0: sends the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para>2: degrades the request upon timeout. If a global consistency read times out, the query is automatically downgraded to regular requests, and the client does not receive an error message.</para>
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
        /// <item><description>ReadWrite: read and write (automatic read/write splitting).</description></item>
        /// <item><description>ReadOnly: read-only. This is the default value.</description></item>
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
        /// <item><description><para>ON: enables the feature.</para>
        /// </description></item>
        /// <item><description><para>OFF: disables the feature.</para>
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

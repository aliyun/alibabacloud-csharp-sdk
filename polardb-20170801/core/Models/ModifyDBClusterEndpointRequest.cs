// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether new nodes are automatically added to the endpoint. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: New nodes are automatically added.</description></item>
        /// <item><description><b>Disable</b>: New nodes are not automatically added. (Default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
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
        /// <para>pe-**************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The advanced configuration of the cluster endpoint in JSON format. You can configure the consistency level, transaction splitting, whether the primary node accepts read requests, and connection pooling.</para>
        /// <list type="bullet">
        /// <item><description><para>To set the load balancing policy, use the format <c>{\\&quot;LoadBalancePolicy\\&quot;:\\&quot;Load balancing policy\\&quot;}</c>. Valid values:   </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: connection-based load balancing (default)</description></item>
        /// <item><description><b>1</b>: active-request-based load balancing</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set whether the primary node accepts read requests, use the format <c>{\\&quot;MasterAcceptReads\\&quot;:\\&quot;Whether the primary node accepts reads\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts read requests. (Default)</description></item>
        /// <item><description><b>off</b>: The primary node does not accept read requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set transaction splitting, use the format <c>{\\&quot;DistributedTransaction\\&quot;:\\&quot;Transaction splitting\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Transaction splitting is enabled. (Default)</description></item>
        /// <item><description><b>off</b>: Transaction splitting is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the consistency level, use the format <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;Consistency level\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: eventual consistency (weak)</description></item>
        /// <item><description><b>1</b>: session consistency (medium) (default)</description></item>
        /// <item><description><b>2</b>: global consistency (strong)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the global consistency read timeout period, use the format <c>{\\&quot;ConsistTimeout\\&quot;:\\&quot;Global consistency read timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 20. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>To set the session consistency read timeout period, use the format <c>{\\&quot;ConsistSessionTimeout\\&quot;:\\&quot;Session consistency read timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 0. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>To set the global (or session) consistency read timeout policy, use the format <c>{\\&quot;ConsistTimeoutAction\\&quot;:\\&quot;Global consistency read timeout policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Forward the read request to the primary node. (Default)</description></item>
        /// <item><description><b>1</b>: The proxy returns the error message <c>wait replication complete timeout, please retry</c> to the application.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the connection pool, use the format <c>{\\&quot;ConnectionPersist\\&quot;:\\&quot;Connection pool\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>off</b>: The connection pool is disabled. (Default)</description></item>
        /// <item><description><b>Session</b>: The session-level connection pool is enabled.</description></item>
        /// <item><description><b>Transaction</b>: The transaction-level connection pooling is enabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set parallel query, use the format <c>{\\&quot;MaxParallelDegree\\&quot;:\\&quot;Parallel query\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Parallel query is enabled.</description></item>
        /// <item><description><b>off</b>: Parallel query is disabled. (Default)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set automatic request distribution among row offload reads from primary nodes, use the format <c>{\\&quot;EnableHtapImci\\&quot;:\\&quot;Automatic request distribution among row store and column store\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Automatic request distribution among row offload reads from primary nodes is enabled.</description></item>
        /// <item><description><b>off</b>: Automatic request distribution among row offload reads from primary nodes is disabled. (Default)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set whether to enable overload protection, use the format <c>{\\&quot;EnableOverloadThrottle\\&quot;:\\&quot;Whether to enable overload protection\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Overload protection is enabled.</description></item>
        /// <item><description><b>off</b>: Overload protection is disabled. (Default)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set node weights, use the format <c>{\\&quot;NodesWeight\\&quot;:{\\&quot;Node ID\\&quot;:\\&quot;Weight value\\&quot;}}</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Transaction splitting, whether the primary node accepts read requests, connection pooling, and overload protection can be configured only when the read/write mode of the PolarDB for MySQL cluster endpoint is <b>ReadWrite (automatic read/write splitting)</b>.</description></item>
        /// <item><description>When the read/write mode of the PolarDB for MySQL cluster endpoint is <b>ReadOnly</b>, both <b>connection-based load balancing</b> and <b>active-request-based load balancing</b> policies are supported. The <b>ReadWrite (automatic read/write splitting)</b> mode supports only the <b>active-request-based load balancing</b> policy.</description></item>
        /// <item><description>Automatic request distribution among row offload reads from primary nodes can be configured when the read/write mode of the PolarDB for MySQL cluster endpoint is <b>ReadWrite (automatic read/write splitting)</b>, or when the read/write mode is <b>ReadOnly</b> and the load balancing policy is <b>active-request-based load balancing</b>.</description></item>
        /// <item><description>Only PolarDB for MySQL supports setting the consistency level to global consistency.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, the consistency level can only be set to <b>0</b>.</description></item>
        /// <item><description>You can configure the consistency level, transaction splitting, whether the primary node accepts read requests, and connection pooling at the same time. Example: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;1\\&quot;,\\&quot;DistributedTransaction\\&quot;:\\&quot;on\\&quot;,\\&quot;ConnectionPersist\\&quot;:\\&quot;Session\\&quot;,\\&quot;MasterAcceptReads\\&quot;:\\&quot;on\\&quot;}</c>.</description></item>
        /// <item><description>Transaction splitting is constrained by the consistency level. For example, transaction splitting cannot be enabled when the consistency level is <b>0</b>. Transaction splitting can be enabled when the consistency level is <b>1</b> or <b>2</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;MasterAcceptReads&quot;:&quot;off&quot;,&quot;ConnectionPersist&quot;: &quot;on&quot;}</para>
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// <para>The read load nodes to add to the endpoint. Separate multiple nodes with commas (,). Default value: the existing nodes.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For PolarDB for MySQL, specify node IDs.</description></item>
        /// <item><description>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle), specify node role names, such as <c>Writer,Reader1,Reader2</c>.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, you can mount only one node. However, if this node fails, the endpoint may be unavailable for up to 1 hour. Do not use this configuration in production environments. Select at least 2 nodes to improve availability.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadWrite</b>, select at least 2 nodes.<list type="bullet">
        /// <item><description>PolarDB for MySQL allows you to select any two nodes. If both nodes are read-only nodes, write requests are forwarded to the primary node.</description></item>
        /// <item><description>PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle) require the primary node to be included.</description></item>
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
        /// <para>The timeout policy for global consistency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Send the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Timeout degradation. When the global consistency read times out, the query is automatically degraded to regular requests, and the client does not receive an error message.</para>
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
        /// <item><description><b>ReadWrite</b>: read/write (automatic read/write splitting)</description></item>
        /// <item><description><b>ReadOnly</b>: read-only</description></item>
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
        /// <para>Specifies whether to enable the global consistency (high-performance mode) feature for the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Disabled.</para>
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

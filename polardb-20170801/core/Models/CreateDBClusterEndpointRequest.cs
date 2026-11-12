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
        /// <item><description><b>Enable</b>: New nodes are automatically added to the endpoint.</description></item>
        /// <item><description><b>Disable</b> (default): New nodes are not automatically added to the endpoint.</description></item>
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
        /// <para>The advanced settings of the cluster endpoint. The value must be in JSON format. You can set the consistency level, transaction splitting, offload reads from primary node, and connection pool.</para>
        /// <list type="bullet">
        /// <item><description>Set the load balancing policy. Format: <c>{&quot;LoadBalancePolicy&quot;:&quot;load balancing policy&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: load balancing based on the number of connections (default).</description></item>
        /// <item><description><b>1</b>: load balancing based on the number of active requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set the consistency level. Format: <c>{&quot;ConsistLevel&quot;:&quot;consistency level&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: eventual consistency.</description></item>
        /// <item><description><b>1</b>: session consistency (default).</description></item>
        /// <item><description><b>2</b>: global consistency.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set transaction splitting. Format: <c>{&quot;DistributedTransaction&quot;:&quot;transaction splitting&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables transaction splitting (default).</description></item>
        /// <item><description><b>off</b>: shutdown transaction splitting.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set whether the primary node accepts read requests. Format: <c>{&quot;MasterAcceptReads&quot;:&quot;offload reads from primary node&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts read requests.</description></item>
        /// <item><description><b>off</b>: The primary node does not accept read requests (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set the connection pool. Format: <c>{&quot;ConnectionPersist&quot;:&quot;connection pool&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>off</b>: shutdown the connection pool (default).</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables transaction-level connection pooling.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set parallel query. Format: <c>{&quot;MaxParallelDegree&quot;:&quot;parallel query&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description>A specific concurrent count. Example: <c>&quot;MaxParallelDegree&quot;:&quot;2&quot;</c>.</description></item>
        /// <item><description><b>off</b>: shutdown parallel query (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set automatic request distribution among row store and column store nodes. Format: <c>{&quot;EnableHtapImci&quot;:&quot;automatic request distribution&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables the automatic request distribution feature among row store and column store nodes.</description></item>
        /// <item><description><b>off</b>: shutdown the automatic request distribution feature among row store and column store nodes (default).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Set whether to enable overload protection. Format: <c>{&quot;EnableOverloadThrottle&quot;:&quot;whether to enable overload protection&quot;}</c>. Valid values:<list type="bullet">
        /// <item><description><b>on</b>: enables overload protection.</description></item>
        /// <item><description><b>off</b>: shutdown overload protection (default).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Transaction splitting, offloading reads from the primary node, connection pool, and overload protection can be set only when the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>read and write (automatic read/write splitting)</b>.</description></item>
        /// <item><description>When the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>read-only</b>, both <b>load balancing based on the number of connections</b> and <b>load balancing based on the number of active requests</b> are supported. For cluster endpoints in the <b>read and write (automatic read/write splitting) pattern</b>, only <b>load balancing based on the number of active requests</b> is supported.</description></item>
        /// <item><description>Automatic request distribution among row store and column store nodes can be set when the read/write pattern of the PolarDB for MySQL cluster endpoint is set to <b>read and write (automatic read/write splitting)</b>, or when the read/write pattern is set to <b>read-only</b> and the load balancing policy is set to <b>load balancing based on the number of active requests</b>.</description></item>
        /// <item><description>Only PolarDB for MySQL supports setting the consistency level to global consistency.</description></item>
        /// <item><description>If the parameter <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, the consistency level can only be set to <b>0</b>.</description></item>
        /// <item><description>You can set the consistency level, transaction splitting, offloading reads from the primary node, and connection pool at the same time. Example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</description></item>
        /// <item><description>The transaction splitting settings are constrained by the consistency level settings. For example, if the consistency level is set to <b>0</b>, transaction splitting cannot be enabled. If the consistency level is set to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Note: Clusters with DeployUnit=Advanced (hot standby/multi-master) may not support some advanced endpoint settings. If the OperationDenied.InstanceType error occurs, remove EndpointConfig and retry, or confirm the compatibility of the target cluster deployment type with the selected settings.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ConsistLevel&quot;: &quot;1&quot;,&quot;DistributedTransaction&quot;: &quot;on&quot;}</para>
        /// </summary>
        [NameInMap("EndpointConfig")]
        [Validation(Required=false)]
        public string EndpointConfig { get; set; }

        /// <summary>
        /// <para>The type of the custom cluster endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Custom</b>: custom cluster endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>DynamoDB</b>: DynamoDB endpoint.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The read-only nodes to be added to the endpoint. Separate multiple nodes with commas (,). Default value: all nodes. </para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For PolarDB for MySQL, specify node IDs.</description></item>
        /// <item><description>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle), specify node role names, such as <c>Writer,Reader1,Reader2</c>.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadOnly</b>, you can add only one node. However, if this node fails, the endpoint may be unavailable for up to 1 hour. Do not use this configuration in production environments. Select at least two nodes to improve availability.</description></item>
        /// <item><description>If <b>ReadWriteMode</b> is set to <b>ReadWrite</b>, select at least two nodes.<list type="bullet">
        /// <item><description>For PolarDB for MySQL, you can select any two nodes. If both nodes are read-only nodes, write requests are forwarded to the primary node.</description></item>
        /// <item><description>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Compatible with Oracle), the primary node must be included.</description></item>
        /// </list>
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
        /// <para>The PolarFS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-test****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The timeout policy for global consistency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: sends the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: degrades the request upon timeout. If a global consistency read times out, the query is automatically downgraded to regular requests, and the client does not receive an error message.</para>
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
        /// <para>The read/write mode. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write (automatic read/write splitting). </description></item>
        /// <item><description><b>ReadOnly</b> (default): read-only.</description></item>
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
        /// <item><description><para><b>ON</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: shutdown</para>
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
        /// <para>vpc-2zehr7ghqovft******
        /// Virtual private cloud identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zehr7ghqovftils0****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2ze775gnf7jn33ua****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}

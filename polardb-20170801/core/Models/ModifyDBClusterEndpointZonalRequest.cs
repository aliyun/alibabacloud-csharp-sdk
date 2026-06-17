// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointZonalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to this endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b>: no (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. The client generates the value, but you must make sure that the value is unique among different requests. The token is case-sensitive and can contain up to 64 ASCII characters.</para>
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
        /// <para>The name of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBEndpointDescription")]
        [Validation(Required=false)]
        public string DBEndpointDescription { get; set; }

        /// <summary>
        /// <para>The ID of the cluster endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-****************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The advanced configurations of the cluster endpoint, which are specified in the JSON format. You can set the consistency level, transaction splitting, whether the primary node accepts read requests, the connection pool, and more.</para>
        /// <list type="bullet">
        /// <item><description><para>To set the load balancing policy, use the format <c>{\\&quot;LoadBalancePolicy\\&quot;:\\&quot;policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: connection-based load balancing (default)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: active request-based load balancing</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To specify whether the primary node accepts read requests, use the format <c>{\\&quot;MasterAcceptReads\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The primary node accepts read requests (default).</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The primary node does not accept read requests.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To configure transaction splitting, use the format <c>{\\&quot;DistributedTransaction\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables transaction splitting (default)</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables transaction splitting</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the consistency level, use the format <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;level\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: eventual consistency (weak)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: session consistency (medium) (default)</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: global consistency (strong)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To set the timeout period for a global consistency read, use the format <c>{\\&quot;ConsistTimeout\\&quot;:\\&quot;timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 20. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>To set the timeout period for a session consistency read, use the format <c>{\\&quot;ConsistSessionTimeout\\&quot;:\\&quot;timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 0. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>To set the policy for a global or session consistency read timeout, use the format <c>{\\&quot;ConsistTimeoutAction\\&quot;:\\&quot;policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Sends the read request to the primary node (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The proxy returns a \<c>wait replication complete timeout, please retry\\</c> error message to the application.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To configure the connection pool, use the format <c>{\\&quot;ConnectionPersist\\&quot;:\\&quot;pool_type\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>off</b>: disables the connection pool (default)</para>
        /// </description></item>
        /// <item><description><para><b>Session</b>: enables the session-level connection pool</para>
        /// </description></item>
        /// <item><description><para><b>Transaction</b>: enables transaction-level connection pooling</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To configure parallel queries, use the format <c>{\\&quot;MaxParallelDegree\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables parallel queries</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables parallel queries (default)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To configure automatic routing between row store and column store, use the format <c>{\\&quot;EnableHtapImci\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables automatic routing between row store and column store</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables automatic routing between row store and column store (default)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>To specify whether to enable overload protection, use the format <c>{\\&quot;EnableOverloadThrottle\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enables overload protection</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disables overload protection (default)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can configure transaction splitting, specify whether the primary node accepts read requests, configure the connection pool, and enable overload protection only when the read/write mode of the cluster endpoint for PolarDB for MySQL is set to <b>ReadWrite</b> (automatic read/write splitting).</para>
        /// </description></item>
        /// <item><description><para>If the read/write mode of a cluster endpoint for PolarDB for MySQL is <b>ReadOnly</b>, both connection-based and active request-based load balancing policies are supported. If the read/write mode is <b>ReadWrite</b> (automatic read/write splitting), only the active request-based load balancing policy is supported.</para>
        /// </description></item>
        /// <item><description><para>You can configure automatic routing between row store and column store when the read/write mode of the cluster endpoint for PolarDB for MySQL is <b>ReadWrite</b> (automatic read/write splitting), or when the read/write mode is <b>ReadOnly</b> and the load balancing policy is active request-based.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL supports the global consistency level.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, you can set the consistency level only to <b>0</b>.</para>
        /// </description></item>
        /// <item><description><para>You can set the consistency level, transaction splitting, whether the primary node accepts read requests, and the connection pool at the same time. For example: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;1\\&quot;,\\&quot;DistributedTransaction\\&quot;:\\&quot;on\\&quot;,\\&quot;ConnectionPersist\\&quot;:\\&quot;Session\\&quot;,\\&quot;MasterAcceptReads\\&quot;:\\&quot;on\\&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The transaction splitting setting is constrained by the consistency level. For example, if the consistency level is <b>0</b>, you cannot enable transaction splitting. If the consistency level is <b>1</b> or <b>2</b>, you can enable transaction splitting.</para>
        /// </description></item>
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
        /// <para>The read-only nodes to add to the endpoint. Separate multiple node IDs with commas (,). If you do not specify this parameter, the original nodes are retained.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For PolarDB for MySQL, specify the node IDs.</para>
        /// </description></item>
        /// <item><description><para>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (compatible with Oracle), specify the node role names, such as <c>Writer,Reader1,Reader2</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, you can attach only one node. However, if this node fails, the endpoint might be unavailable for up to one hour. Do not use this configuration in a production environment. Select at least two nodes to improve availability.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadWrite</b>, you must select at least two nodes.
        /// \* For PolarDB for MySQL, you can select any two nodes. If both nodes are read-only nodes, write requests are sent to the primary node.
        /// \* For PolarDB for PostgreSQL and PolarDB for PostgreSQL (compatible with Oracle), you must include the primary node.</para>
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
        /// <para>The policy for a global consistency timeout. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Sends the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Timeout degradation. If a global consistency read times out, the query is automatically downgraded to a regular request, and the client does not receive an error message.</para>
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
        /// <item><description><para><b>ReadWrite</b>: read-write (automatic read/write splitting)</para>
        /// </description></item>
        /// <item><description><para><b>ReadOnly</b>: read-only</para>
        /// </description></item>
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
        /// <item><description><para><b>ON</b>: enables the feature</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables the feature</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

    }

}

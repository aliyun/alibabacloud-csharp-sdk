// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: Automatically adds new nodes.</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b>: Does not automatically add new nodes. This is the default value.</para>
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
        /// <para>The ID of the cluster endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-**************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The advanced configurations of the cluster endpoint in JSON format. You can set the consistency level, transaction splitting, whether the primary node accepts read requests, the connection pool, and other settings.</para>
        /// <list type="bullet">
        /// <item><description><para>Sets the load balancing policy. Format: <c>{\\&quot;LoadBalancePolicy\\&quot;:\\&quot;policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Connections-based load balancing (default)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Active requests-based load balancing</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether the primary node accepts read requests. Format: <c>{\\&quot;MasterAcceptReads\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The primary node accepts read requests (default).</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The primary node does not accept read requests.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Enables or disables transaction splitting. Format: <c>{\\&quot;DistributedTransaction\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables transaction splitting (default).</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables transaction splitting.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets the consistency level. Format: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;level\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Eventual consistency (weak)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Session consistency (medium) (default)</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Global consistency (strong)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets the timeout period for a global consistency read. Format: <c>{\\&quot;ConsistTimeout\\&quot;:\\&quot;timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 20. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>Sets the timeout period for a session consistency read. Format: <c>{\\&quot;ConsistSessionTimeout\\&quot;:\\&quot;timeout\\&quot;}</c>. Valid values: 0 to 60000. Default value: 0. Unit: ms.</para>
        /// </description></item>
        /// <item><description><para>Sets the policy for handling timeouts of global or session consistency reads. Format: <c>{\\&quot;ConsistTimeoutAction\\&quot;:\\&quot;policy\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Forwards read requests to the primary node (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The proxy returns the error message \<c>wait replication complete timeout, please retry\\</c> to the application.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets the connection pool type. Format: <c>{\\&quot;ConnectionPersist\\&quot;:\\&quot;type\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>off</b>: Disables the connection pool (default).</para>
        /// </description></item>
        /// <item><description><para><b>Session</b>: Enables the session-level connection pool.</para>
        /// </description></item>
        /// <item><description><para><b>Transaction</b>: Enables the transaction-level connection pool.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Enables or disables parallel query. Format: <c>{\\&quot;MaxParallelDegree\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables parallel query.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables parallel query (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Enables or disables automatic routing of requests to the row store or column store. Format: <c>{\\&quot;EnableHtapImci\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables automatic routing.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables automatic routing (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Enables or disables overload protection. Format: <c>{\\&quot;EnableOverloadThrottle\\&quot;:\\&quot;value\\&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables overload protection.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables overload protection (default).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can set transaction splitting, whether the primary node accepts read requests, the connection pool, and overload protection only when the read/write mode of the cluster endpoint for PolarDB for MySQL is set to ReadWrite (automatic read/write splitting).</para>
        /// </description></item>
        /// <item><description><para>If the read/write mode of a cluster endpoint for PolarDB for MySQL is <b>ReadOnly</b>, both <b>connections-based</b> and <b>active requests-based</b> load balancing policies are supported. If the read/write mode is <b>ReadWrite</b> (automatic read/write splitting), only the <b>active requests-based</b> load balancing policy is supported.</para>
        /// </description></item>
        /// <item><description><para>You can enable automatic routing to the row store or column store if the read/write mode of the cluster endpoint for PolarDB for MySQL is <b>ReadWrite</b> (automatic read/write splitting), or if the read/write mode is <b>ReadOnly</b> and the load balancing policy is <b>active requests-based</b>.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL supports global consistency.</para>
        /// </description></item>
        /// <item><description><para>If you set the <b>ReadWriteMode</b> parameter to <b>ReadOnly</b>, you can only set the consistency level to <b>0</b>.</para>
        /// </description></item>
        /// <item><description><para>You can set the consistency level, transaction splitting, whether the primary node accepts read requests, and the connection pool at the same time. For example: <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;1\\&quot;,\\&quot;DistributedTransaction\\&quot;:\\&quot;on\\&quot;,\\&quot;ConnectionPersist\\&quot;:\\&quot;Session\\&quot;,\\&quot;MasterAcceptReads\\&quot;:\\&quot;on\\&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The transaction splitting setting is constrained by the consistency level. For example, you cannot enable transaction splitting if the consistency level is <b>0</b> (eventual consistency). You can enable transaction splitting if the consistency level is <b>1</b> (session consistency) or <b>2</b> (global consistency).</para>
        /// </description></item>
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
        /// <para>The nodes to be added to the endpoint for read request distribution. Separate multiple node IDs with commas (,). The original nodes are used by default.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For PolarDB for MySQL, specify the node IDs.</para>
        /// </description></item>
        /// <item><description><para>For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Oracle Compatible), specify the node roles, such as <c>Writer,Reader1,Reader2</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, you can attach only one node. However, if this node fails, the endpoint may be unavailable for up to one hour. Do not use this configuration in a production environment. Select at least two nodes to improve availability.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>ReadWriteMode</b> to <b>ReadWrite</b>, you must select at least two nodes.
        /// \* For PolarDB for MySQL, you can select any two nodes. If both nodes are read-only nodes, write requests are sent to the primary node.
        /// \* For PolarDB for PostgreSQL and PolarDB for PostgreSQL (Oracle Compatible), you must include the primary node.</para>
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
        /// <para>The policy for handling global consistency timeouts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Forwards the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Degrades the request. If a global consistency read times out, the query is automatically degraded to a regular request. The client does not receive an error message.</para>
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
        /// <item><description><para><b>ReadWrite</b>: Read/write (automatic read/write splitting)</para>
        /// </description></item>
        /// <item><description><para><b>ReadOnly</b>: Read-only</para>
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
        /// <item><description><para><b>ON</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Disable</para>
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

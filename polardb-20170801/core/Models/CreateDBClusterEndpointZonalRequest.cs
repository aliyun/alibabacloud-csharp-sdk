// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterEndpointZonalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add new nodes to this endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enable: New nodes are automatically added to this endpoint.</para>
        /// </description></item>
        /// <item><description><para>Disable: New nodes are not automatically added to this endpoint. This is the default value.</para>
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
        /// <para>A client token that is used to ensure the idempotence of the request. The client generates the value, which must be unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
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
        /// <para>The advanced configurations of the cluster endpoint, specified in the JSON format. This parameter supports settings for consistency level, transaction splitting, offloading reads from the primary node, and the connection pool.</para>
        /// <list type="bullet">
        /// <item><description><para>Sets the load balancing policy. The format is {&quot;LoadBalancePolicy&quot;:&quot;policy&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Connections-based load balancing. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Active requests-based load balancing.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets the consistency level. The format is <c>{&quot;ConsistLevel&quot;:&quot;level&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Eventual consistency.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Session consistency. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Global consistency.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets transaction splitting. The format is <c>{&quot;DistributedTransaction&quot;:&quot;on/off&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables transaction splitting. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables transaction splitting.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether the primary node accepts read requests. The format is <c>{&quot;MasterAcceptReads&quot;:&quot;on/off&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The primary node accepts read requests.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The primary node does not accept read requests. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets the connection pool. The format is <c>{&quot;ConnectionPersist&quot;:&quot;type&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>off</b>: Disables the connection pool. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>Session</b>: Enables the session-level connection pool.</para>
        /// </description></item>
        /// <item><description><para><b>Transaction</b>: Enables transaction-level connection pooling.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets parallel query. The format is {&quot;MaxParallelDegree&quot;:&quot;degree&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>A specific number of concurrent queries. Example: &quot;MaxParallelDegree&quot;:&quot;2&quot;.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables parallel query. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Sets automatic routing for row store and column store. The format is {&quot;EnableHtapImci&quot;:&quot;on/off&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables automatic routing for row store and column store.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables automatic routing for row store and column store. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable overload protection. The format is {&quot;EnableOverloadThrottle&quot;:&quot;on/off&quot;}. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables overload protection.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables overload protection. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can set transaction splitting, specify whether the primary node accepts read requests, configure the connection pool, and enable overload protection only when the read/write mode of the cluster endpoint for a PolarDB for MySQL cluster is set to \<em>\<em>ReadWrite\</em>\</em> (automatic read/write splitting).</para>
        /// </description></item>
        /// <item><description><para>When the read/write mode of the cluster endpoint for a PolarDB for MySQL cluster is set to <b>ReadOnly</b>, both <b>connections-based load balancing</b> and <b>active requests-based load balancing</b> are supported. When the read/write mode is set to <b>ReadWrite</b> (automatic read/write splitting), only <b>active requests-based load balancing</b> is supported.</para>
        /// </description></item>
        /// <item><description><para>You can enable automatic routing for row store and column store when the read/write mode of the cluster endpoint for a PolarDB for MySQL cluster is set to <b>ReadWrite</b> (automatic read/write splitting), or when the read/write mode is set to <b>ReadOnly</b> and the load balancing policy is set to <b>active requests-based load balancing</b>.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL supports setting the consistency level to global consistency.</para>
        /// </description></item>
        /// <item><description><para>If you set the <b>ReadWriteMode</b> parameter to <b>ReadOnly</b>, you can only set the consistency level to <b>0</b>.</para>
        /// </description></item>
        /// <item><description><para>You can configure the consistency level, transaction splitting, whether the primary node accepts reads, and the connection pool at the same time. For example: <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The transaction splitting setting is constrained by the consistency level. For example, if the consistency level is set to <b>0</b>, you cannot enable transaction splitting. If the consistency level is set to <b>1</b> or <b>2</b>, you can enable transaction splitting.</para>
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
        /// <para>The type of the custom cluster endpoint. The value is fixed to <b>Custom</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The read-only nodes to be added to the endpoint. Separate multiple node IDs with commas (,). By default, all nodes are added.</para>
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
        /// <item><description><para>0: Sends the request to the primary node.</para>
        /// </description></item>
        /// <item><description><para>2: Degrades to regular requests. If a global consistency read times out, the query is automatically degraded to a regular request, and the client does not receive an error message.</para>
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
        /// <item><description><para>ReadWrite: read and write (automatic read/write splitting).</para>
        /// </description></item>
        /// <item><description><para>ReadOnly: read-only. This is the default value.</para>
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
        /// <para>Specifies whether to enable the global consistency (high-performance mode) feature for the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ON: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>OFF: Disables the feature.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically associate newly added nodes with the cluster endpoint. Default value: Disable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b></description></item>
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
        /// <para>The advanced configurations of the cluster endpoint, which are in the JSON format. You can specify the configurations of the following attributes: consistency level, transaction splitting, connection pool, and primary node accepts read requests.</para>
        /// <list type="bullet">
        /// <item><description><para>Specifies the load balancing policy in the format of <c>{\\&quot;LoadBalancePolicy\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: connections-based load balancing</description></item>
        /// <item><description><b>1</b>: active requests-based load balancing</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the primary node accepts read requests feature in the format of <c>{\\&quot;MasterAcceptReads\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: on. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the transaction splitting feature in the format of <c>{\\&quot;DistributedTransaction\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: on. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies the consistency level in the format of <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: eventual consistency (weak)</description></item>
        /// <item><description><b>1</b>: session consistency (medium)</description></item>
        /// <item><description><b>2</b>: global consistency (strong)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies the connection pool in the format of <c>{\\&quot;ConnectionPersist\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>off</b>: disables the connection pool.</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables the transaction-level connection pool.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the parallel query feature in the format of <c>{\\&quot;MaxParallelDegree\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the automatic request distribution between row store and column store nodes feature in the format of <c>{\\&quot;EnableHtapImci\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specifies whether to enable the overload protection feature in the format of <c>{\\&quot;EnableOverloadThrottle\\&quot;:\\&quot;Selected value\\&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify the transaction splitting, primary node accepts read requests, connection pool, and overload protection features for a PolarDB for MySQL cluster only if ReadWriteMode is set to ReadWrite for the cluster endpoint.</para>
        /// </description></item>
        /// <item><description><para>If the read /write mode of a PolarDB for MySQL cluster is set to <b>Read-only</b>, the <b>Connection-based SLB</b> and <b>Active Request-based SLB</b> SLB policies are supported. The <b>Read-write (Automatic read /write splitting) <b>mode of the cluster supports</b> Active Request-based SLB</b> policy.</para>
        /// </description></item>
        /// <item><description><para>If ReadWriteMode is set to <b>ReadWrite</b> for the cluster endpoint of a PolarDB for MySQL cluster or if ReadWriteMode is set to <b>ReadOnly</b> and the load balancing policy is set to <b>active requests-based load balancing</b>, the automatic request distribution between row store and column store nodes feature is supported.</para>
        /// </description></item>
        /// <item><description><para>Only PolarDB for MySQL supports global consistency.</para>
        /// </description></item>
        /// <item><description><para>If the <b>ReadWriteMode</b> parameter is set to <b>ReadOnly</b>, the consistency level must be <b>0</b>.</para>
        /// </description></item>
        /// <item><description><para>You can specify the consistency level, transaction splitting, connection pool, and primary node accepts read requests features at a time, such as <c>{\\&quot;ConsistLevel\\&quot;:\\&quot;1\\&quot;,\\&quot;DistributedTransaction\\&quot;:\\&quot;on\\&quot;,\\&quot;ConnectionPersist\\&quot;:\\&quot;Session\\&quot;,\\&quot;MasterAcceptReads\\&quot;:\\&quot;on\\&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>The transaction splitting settings are restricted by the consistency level settings. For example, if you set the consistency level to <b>0</b>, transaction splitting cannot be enabled. If you set the consistency level to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</para>
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

        [NameInMap("PolarSccTimeoutAction")]
        [Validation(Required=false)]
        public string PolarSccTimeoutAction { get; set; }

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

        [NameInMap("SccMode")]
        [Validation(Required=false)]
        public string SccMode { get; set; }

    }

}

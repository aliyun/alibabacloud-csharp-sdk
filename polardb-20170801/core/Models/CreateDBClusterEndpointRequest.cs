// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic association of newly added nodes with the cluster endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("AutoAddNewNodes")]
        [Validation(Required=false)]
        public string AutoAddNewNodes { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
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
        /// <para>The advanced configurations of the cluster endpoint. You must specify the configurations in the JSON format. You can specify the configurations of the following attributes: consistency level, transaction splitting, connection pool, and offload reads from the primary node.</para>
        /// <list type="bullet">
        /// <item><description><para>Specify the consistency level in the format of <c>{&quot;ConsistLevel&quot;:&quot;Consistency level&quot;}</c>. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: eventual consistency.</description></item>
        /// <item><description><b>1</b>: session consistency.</description></item>
        /// <item><description><b>2</b>: global consistency.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specify the transaction splitting feature in the format of <c>{&quot;DistributedTransaction&quot;:&quot;Transaction splitting&quot;}</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the transaction splitting feature. By default, the feature is enabled.</description></item>
        /// <item><description><b>off</b>: disables the transaction splitting feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specify the offload reads from the primary node feature in the format of <c>{&quot;MasterAcceptReads&quot;:&quot;Offload reads from the primary node&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: The primary node accepts read requests.</description></item>
        /// <item><description><b>off</b>: The primary node does not accept read requests.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specify the connection pool in the format of <c>{&quot;ConnectionPersist&quot;:&quot;Connection pool&quot;}</c>. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>off</b>: disables the connection pool.</description></item>
        /// <item><description><b>Session</b>: enables the session-level connection pool.</description></item>
        /// <item><description><b>Transaction</b>: enables the transaction-level connection pool.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify the transaction splitting, connection pool, and offload reads from the primary node features for a PolarDB for MySQL cluster only if ReadWriteMode is set to ReadWrite for the cluster endpoint.</description></item>
        /// <item><description>Only PolarDB for MySQL supports global consistency.</description></item>
        /// <item><description>If the <b>ReadWriteMode</b> parameter is set to <b>ReadOnly</b>, the consistency level must be <b>0</b>.</description></item>
        /// <item><description>You can use one record to specify the consistency level, transaction splitting, connection pool, and offload reads from the primary node features, such as <c>{&quot;ConsistLevel&quot;:&quot;1&quot;,&quot;DistributedTransaction&quot;:&quot;on&quot;,&quot;ConnectionPersist&quot;:&quot;Session&quot;,&quot;MasterAcceptReads&quot;:&quot;on&quot;}</c>.</description></item>
        /// <item><description>The transaction splitting settings are restricted by the consistency level settings. For example, if you set the consistency level to <b>0</b>, transaction splitting cannot be enabled. If you set the consistency level to <b>1</b> or <b>2</b>, transaction splitting can be enabled.</description></item>
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
        /// <para>The type of the cluster endpoint. Set the value to <b>Custom</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The reader nodes that you want to associate with the endpoint. If you want to specify multiple reader nodes, separate the reader nodes with commas (,). If you do not specify this parameter, all nodes are used.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You need to specify the node IDs for a PolarDB for MySQL cluster.</description></item>
        /// <item><description>You need to specify the role name of each node for a PolarDB for PostgreSQL cluster or a PolarDB for PostgreSQL (Compatible with Oracle) cluster. Example: <c>Writer, Reader1, Reader2</c>.</description></item>
        /// <item><description>If you set <b>ReadWriteMode</b> to <b>ReadOnly</b>, you can associate only one node with the endpoint. If the only node becomes faulty, the cluster endpoint may be unavailable for up to 1 hour. We recommend that you associate more than one node with the cluster endpoint in production environments. We recommend that you associate at least two nodes with the cluster endpoint to improve service availability.</description></item>
        /// <item><description>If you set <b>ReadWriteMode</b> to <b>ReadWrite</b>, you need to associate at least two nodes with the cluster endpoint.</description></item>
        /// <item><description>PolarDB for MySQL does not impose a limit on the types of the two nodes. If the nodes are read-only nodes, write requests are forwarded to the primary node. </description></item>
        /// <item><description>PolarDB for PostgreSQL and PolarDB for PostgreSQL (compatible with Oracle) require a primary node.</description></item>
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
        /// <b>Example:</b>
        /// <para>pfs-test****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>Global consistency timeout strategy. The value range is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Send the request to the primary node</description></item>
        /// <item><description><b>2</b>: Timeout degradation, when a global consistency read times out, the query operation will automatically degrade to an inconsistent read, and the client will not receive an error message</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PolarSccTimeoutAction")]
        [Validation(Required=false)]
        public string PolarSccTimeoutAction { get; set; }

        /// <summary>
        /// <para>Global consistency timeout</para>
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
        /// <item><description><b>ReadWrite</b>: receives and forwards read and write requests. Automatic read/write splitting is enabled.</description></item>
        /// <item><description><b>ReadOnly</b>: The account has the read-only permissions on the database.</description></item>
        /// </list>
        /// <para>Default value: <b>ReadOnly</b>.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of cluster endpoints.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEndpointsResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterEndpointsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The connection addresses for the endpoint.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterEndpointsResponseBodyItemsAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterEndpointsResponseBodyItemsAddressItems : TeaModel {
                /// <summary>
                /// <para>The connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>********.rwlb.polardb-pg-public.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>Indicates whether the endpoint is a dashboard endpoint for a PolarDB Search node.</para>
                /// <list type="bullet">
                /// <item><description><para><b>True</b>: Yes</para>
                /// </description></item>
                /// <item><description><para><b>False</b>: No</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("DashboardUsed")]
                [Validation(Required=false)]
                public bool? DashboardUsed { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.<em><b>.</b></em>.***</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Public</b>: public network</para>
                /// </description></item>
                /// <item><description><para><b>Private</b>: private network</para>
                /// </description></item>
                /// </list>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description><b>Inner</b>: classic network</description></item>
                /// </list>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>Only PolarDB for MySQL clusters support the classic network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1521</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The connection string for the private domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>.</b></em>.**.com</para>
                /// </summary>
                [NameInMap("PrivateZoneConnectionString")]
                [Validation(Required=false)]
                public string PrivateZoneConnectionString { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-***************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC instance ID.</para>
                /// <remarks>
                /// <para>This parameter is returned only for PolarDB for MySQL clusters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pe-*************</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether new nodes are automatically added to the default cluster endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b></para>
            /// </description></item>
            /// <item><description><para><b>Disable</b></para>
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
            /// <para>The connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>********.rwlb.polardb-pg-public.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1s826a1up******</para>
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
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-*************</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>The advanced settings for the cluster endpoint.</para>
            /// <list type="bullet">
            /// <item><description><para><b>DistributedTransaction</b>: The transaction splitting status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ConsistLevel</b>: The consistency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: eventual consistency</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: session consistency</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: global consistency</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>LoadBalanceStrategy</b>: The load balancing policy. The value is fixed to <b>load</b>, which indicates load-based scheduling.</para>
            /// </description></item>
            /// <item><description><para><b>MasterAcceptReads</b>: Indicates whether the primary node accepts read requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: The primary node accepts read requests.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: The primary node does not accept read requests.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;DistributedTransaction\&quot;:\&quot;off\&quot;,\&quot;ConsistLevel\&quot;:\&quot;0\&quot;,\&quot;LoadBalanceStrategy\&quot;:\&quot;load\&quot;,\&quot;MasterAcceptReads\&quot;:\&quot;on\&quot;}</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public string EndpointConfig { get; set; }

            /// <summary>
            /// <para>The type of the cluster endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Cluster</b>: the default cluster endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Primary</b>: the primary endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Custom</b>: a custom cluster endpoint.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b>: public network</para>
            /// </description></item>
            /// <item><description><para><b>Private</b>: private network</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The role of each node in the endpoint. The primary node has the <b>Writer</b> role. Read-only nodes have numbered roles, such as <b>Reader1</b>, <b>Reader2</b>, and so on.</para>
            /// <remarks>
            /// <para>This parameter is supported only by PolarDB for PostgreSQL clusters and PolarDB for PostgreSQL (compatible with Oracle) clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Reader1</para>
            /// </summary>
            [NameInMap("NodeWithRoles")]
            [Validation(Required=false)]
            public string NodeWithRoles { get; set; }

            /// <summary>
            /// <para>The list of nodes configured for the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-<em><b><b><b><b><b><b><b>,pi-</b></b></b></b></b></b></b></em></para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public string Nodes { get; set; }

            /// <summary>
            /// <para>The policy for handling global consistency read timeouts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Redirects the request to the primary node.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Downgrades the request. If a global consistency read times out, the system automatically downgrades the query to a non-consistent read, and the client does not receive an error.</para>
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
            /// <para>The timeout period for global consistency reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PolarSccWaitTimeout")]
            [Validation(Required=false)]
            public string PolarSccWaitTimeout { get; set; }

            /// <summary>
            /// <para>The port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1521</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The read/write mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ReadWrite</b>: read and write (automatic read/write splitting).</para>
            /// </description></item>
            /// <item><description><para><b>ReadOnly</b>: read-only.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("ReadWriteMode")]
            [Validation(Required=false)]
            public string ReadWriteMode { get; set; }

            /// <summary>
            /// <para>Indicates whether global consistency (high-performance mode) is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled</para>
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
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-***************</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DC120BF-6EBA-4C63-BE99-B09F9E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

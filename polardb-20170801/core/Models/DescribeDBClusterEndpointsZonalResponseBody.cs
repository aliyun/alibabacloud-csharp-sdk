// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster endpoint details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEndpointsZonalResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterEndpointsZonalResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The connection string information.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterEndpointsZonalResponseBodyItemsAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterEndpointsZonalResponseBodyItemsAddressItems : TeaModel {
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
                /// <para>Specifies whether the address is the dashboard address of a PolarDB Search node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Ture: Yes.</para>
                /// </description></item>
                /// <item><description><para>False: No.</para>
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
                /// <item><description><para>Public: Internet.</para>
                /// </description></item>
                /// <item><description><para>Private: Private network.</para>
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
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1521</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The bound private domain name.</para>
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
                /// <para>The VPC-connected instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pe-*************</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether new nodes are automatically added to the default cluster endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enable.</para>
            /// </description></item>
            /// <item><description><para>Disable.</para>
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
            /// <para>The advanced configurations of the cluster endpoint.</para>
            /// <list type="bullet">
            /// <item><description><para><b>DistributedTransaction</b>: The transaction splitting status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Transaction splitting is enabled.</description></item>
            /// <item><description><b>off</b>: Transaction splitting is disabled.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ConsistLevel</b>: The session consistency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Eventual consistency.</description></item>
            /// <item><description><b>1</b>: Session consistency.</description></item>
            /// <item><description><b>2</b>: Global consistency.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>LoadBalanceStrategy</b>: The load balancing policy. Automatic scheduling based on load. The value is fixed as <b>load</b>.</para>
            /// </description></item>
            /// <item><description><para><b>MasterAcceptReads</b>: Specifies whether the primary database accepts reads. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: The primary database accepts reads.</description></item>
            /// <item><description><b>off</b>: Offload reads from primary node.</description></item>
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
            /// <para>The cluster endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Cluster: Default cluster endpoint.</para>
            /// </description></item>
            /// <item><description><para>Primary: Primary endpoint.</para>
            /// </description></item>
            /// <item><description><para>Custom: Custom cluster endpoint.</para>
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
            /// <para>The role names of the nodes under the target endpoint. The primary node is named Writer. Because multiple read-only nodes can be added to an endpoint, a number is appended to the role name of each read-only node for distinction, such as Reader1 and Reader2.</para>
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
            /// <para>The global consistency timeout policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Sends the request to the primary node.</para>
            /// </description></item>
            /// <item><description><para>2: Downgrades upon timeout. If a global consistency read times out, the query is automatically downgraded to regular requests, and the client does not receive an error message.</para>
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
            /// <para>The global consistency timeout period.</para>
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
            /// <item><description><para>ReadWrite: Read and write (automatic read/write splitting).</para>
            /// </description></item>
            /// <item><description><para>ReadOnly: Read-only.</para>
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
            /// <para>Specifies whether the global consistency (high-performance mode) feature is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
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

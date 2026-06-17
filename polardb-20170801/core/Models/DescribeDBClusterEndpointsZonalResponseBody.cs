// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cluster endpoints.</para>
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
                /// <para>Specifies whether the endpoint is the dashboard endpoint of a PolarDB search node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>True: Yes.</para>
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
                /// <item><description><para>Private: internal network.</para>
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
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1521</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The private domain name that is bound to the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>.</b></em>.**.com</para>
                /// </summary>
                [NameInMap("PrivateZoneConnectionString")]
                [Validation(Required=false)]
                public string PrivateZoneConnectionString { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-***************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The virtual switch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC instance ID.</para>
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
            /// <para>The name of the endpoint.</para>
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
            /// <item><description><para><b>DistributedTransaction</b>: The status of transaction splitting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: Transaction splitting is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: Transaction splitting is disabled.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ConsistLevel</b>: The consistency level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Eventual consistency.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Session consistency.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Global consistency.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>LoadBalanceStrategy</b>: The load balancing policy for automatic scheduling based on loads. The value is fixed as <b>load</b>.</para>
            /// </description></item>
            /// <item><description><para><b>MasterAcceptReads</b>: Specifies whether the primary node accepts read requests. Valid values:</para>
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
            /// <item><description><para>Cluster: the default cluster endpoint.</para>
            /// </description></item>
            /// <item><description><para>Primary: the primary endpoint.</para>
            /// </description></item>
            /// <item><description><para>Custom: a custom cluster endpoint.</para>
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
            /// <para>The role of each node in the endpoint. The primary node has the Writer role. Because multiple read-only nodes can be added to an endpoint, each read-only node is assigned a role name suffixed with a number, such as Reader1 and Reader2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reader1</para>
            /// </summary>
            [NameInMap("NodeWithRoles")]
            [Validation(Required=false)]
            public string NodeWithRoles { get; set; }

            /// <summary>
            /// <para>The list of nodes that are configured for the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-<em><b><b><b><b><b><b><b>,pi-</b></b></b></b></b></b></b></em></para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public string Nodes { get; set; }

            /// <summary>
            /// <para>The policy for global consistency timeout. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Sends the request to the primary node.</para>
            /// </description></item>
            /// <item><description><para>2: Degrades the request. If a global consistency read times out, the query is automatically degraded to a regular request. The client does not receive an error message.</para>
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
            /// <item><description><para>ReadOnly: read-only.</para>
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
            /// <para>Specifies whether global consistency (high-performance mode) is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: enabled.</para>
            /// </description></item>
            /// <item><description><para>off: disabled.</para>
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

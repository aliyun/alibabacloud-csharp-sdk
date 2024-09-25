// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the endpoints.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEndpointsResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterEndpointsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The details of the endpoint.</para>
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterEndpointsResponseBodyItemsAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterEndpointsResponseBodyItemsAddressItems : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>********.rwlb.polardb-pg-public.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

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
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b></description></item>
                /// <item><description><b>Private</b></description></item>
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
                /// <para>The private domain name that is bound to the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>.</b></em>.**.com</para>
                /// </summary>
                [NameInMap("PrivateZoneConnectionString")]
                [Validation(Required=false)]
                public string PrivateZoneConnectionString { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-***************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) instance.</para>
                /// <remarks>
                /// <para>This parameter is returned for only PolarDB for MySQL clusters.</para>
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
            /// <para>Indicates whether new nodes are automatically associated with the default cluster endpoint. Valid values:</para>
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
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-*************</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>The advanced configurations of the endpoint.</para>
            /// <list type="bullet">
            /// <item><description><para><b>DistributedTransaction</b>: indicates whether transaction splitting is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>ConsistLevel</b>: the consistency level of sessions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: eventual consistency.</description></item>
            /// <item><description><b>1</b>: session consistency.</description></item>
            /// <item><description><b>2</b>: global consistency.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>LoadBalanceStrategy</b>: the load balancing policy that automatically schedules loads. Only <b>load</b> may be returned.</para>
            /// </description></item>
            /// <item><description><para><b>MasterAcceptReads</b>: indicates whether the primary node processes read requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
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
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Cluster</b>: the default endpoint.</description></item>
            /// <item><description><b>Primary</b>: the primary endpoint.</description></item>
            /// <item><description><b>Custom</b>: a custom cluster endpoint.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The role name of each node in the endpoint. The role name of the primary node is <b>Writer</b>. Multiple read-only nodes can be associated with an endpoint. Therefore, the role name of each read-only node is suffixed with a number, such as <b>Reader1</b> and <b>Reader2</b>.</para>
            /// <remarks>
            /// <para>This parameter is valid only for PolarDB for PostgreSQL clusters and PolarDB for PostgreSQL (Compatible with Oracle)) clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Reader1</para>
            /// </summary>
            [NameInMap("NodeWithRoles")]
            [Validation(Required=false)]
            public string NodeWithRoles { get; set; }

            /// <summary>
            /// <para>The nodes in the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-<em><b><b><b><b><b><b><b>,pi-</b></b></b></b></b></b></b></em></para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public string Nodes { get; set; }

            [NameInMap("PolarSccTimeoutAction")]
            [Validation(Required=false)]
            public string PolarSccTimeoutAction { get; set; }

            [NameInMap("PolarSccWaitTimeout")]
            [Validation(Required=false)]
            public string PolarSccWaitTimeout { get; set; }

            /// <summary>
            /// <para>The read/write mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ReadWrite</b>: handles read and write requests. Automatic read/write splitting is enabled.</description></item>
            /// <item><description><b>ReadOnly</b>: handles read-only requests.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("ReadWriteMode")]
            [Validation(Required=false)]
            public string ReadWriteMode { get; set; }

            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DC120BF-6EBA-4C63-BE99-B09F9E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

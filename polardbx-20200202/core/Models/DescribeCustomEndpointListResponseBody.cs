// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCustomEndpointListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomEndpointListResponseBodyData Data { get; set; }
        public class DescribeCustomEndpointListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the node can be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanDeleteCount")]
            [Validation(Required=false)]
            public int? CanDeleteCount { get; set; }

            /// <summary>
            /// <para>The details of the endpoints.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<DescribeCustomEndpointListResponseBodyDataEndpoints> Endpoints { get; set; }
            public class DescribeCustomEndpointListResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// <para>[\&quot;pxc-i-vb1sqa7llp\&quot;,\&quot;pxc-i-bemprx50ad\&quot;]</para>
                /// </summary>
                [NameInMap("CnNames")]
                [Validation(Required=false)]
                public List<string> CnNames { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-shra****zq0j01.polarx.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The ID of the custom endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxe-b6e****o4pfap1s</para>
                /// </summary>
                [NameInMap("CustomEndpointId")]
                [Validation(Required=false)]
                public string CustomEndpointId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-hz****zoxherr7</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The name of the custom endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether a node automatically joins the cluster and starts providing services after the node is added or recovered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NodeAutoEnter")]
                [Validation(Required=false)]
                public string NodeAutoEnter { get; set; }

                /// <summary>
                /// <para>To query the metrics of a read-only node in a cloud-native read/write splitting architecture instance, set this parameter to <b>READONLY</b> and specify the <b>NodeId</b> parameter.</para>
                /// <remarks>
                /// <para> In other cases, you do not need to specify this parameter or you can set it to <b>MASTER</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>same_azone_as_last</para>
                /// </summary>
                [NameInMap("NodeRole")]
                [Validation(Required=false)]
                public string NodeRole { get; set; }

                /// <summary>
                /// <para>The port used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The status of the custom endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>created</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vbkw****5yh4nrd639ih</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) in which the endpoint resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf61h****dj1zg5fqp5x7</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6352AC16-76BF-5135-B1EA-ED49293526E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

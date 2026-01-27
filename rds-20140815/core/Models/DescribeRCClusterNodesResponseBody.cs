// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeRCClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeRCClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-21T07:20:09Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The container version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("DockerVersion")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// <para>The image ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-2oqiu973jwcxe****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-u79597n5f54s5bnz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The node role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Master</b>: master node</description></item>
            /// <item><description><b>Worker</b>: worker node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Master</para>
            /// </summary>
            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is provided by Alibaba Cloud. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAliyunNode")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// <para>The node name, which is the identifier of the RDS Custom node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou.192.168.XXX.XXX</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is ready. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ready</b>: The node is ready.</description></item>
            /// <item><description><b>NotReady</b>: The node is not ready.</description></item>
            /// <item><description><b>Unknown</b>: The status of the node is unknown.</description></item>
            /// <item><description><b>Offline</b>: The node is offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public long? PodCount { get; set; }

            /// <summary>
            /// <para>The runtime of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-21T07:20:09Z</para>
            /// </summary>
            [NameInMap("RuntimeVersion")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>starting</b></description></item>
            /// <item><description><b>stopping</b></description></item>
            /// <item><description><b>stopped</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeRCClusterNodesResponseBodyPage Page { get; set; }
        public class DescribeRCClusterNodesResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16C62438-491B-5C02-9B49-BA924A1372A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

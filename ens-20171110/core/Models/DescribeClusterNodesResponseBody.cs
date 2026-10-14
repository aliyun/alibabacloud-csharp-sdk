// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The node information.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eck-xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ENS edge zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-fuzhou-23</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The instance image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-680cki2ruj1q2bm0mz1k9tnbz</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-51mctytg7tv4yw4amu3oczxsx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the ENS instance.</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// <para>The node information.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public DescribeClusterNodesResponseBodyNodesNodeInfo NodeInfo { get; set; }
            public class DescribeClusterNodesResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// <para>The container runtime version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>containerd://1.6.28</para>
                /// </summary>
                [NameInMap("ContainerRuntimeVersion")]
                [Validation(Required=false)]
                public string ContainerRuntimeVersion { get; set; }

                /// <summary>
                /// <para>The kubelet version of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.30.7-aliyun.1</para>
                /// </summary>
                [NameInMap("KubeletVersion")]
                [Validation(Required=false)]
                public string KubeletVersion { get; set; }

                /// <summary>
                /// <para>The operating system image of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS Linux 7 (Core)</para>
                /// </summary>
                [NameInMap("OsImage")]
                [Validation(Required=false)]
                public string OsImage { get; set; }

            }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np861febb748f84f5f9f1c76819eff7f56</para>
            /// </summary>
            [NameInMap("NodepoolId")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The status of the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>initial: The node pool is being created.</description></item>
            /// <item><description>running: The node pool is created.</description></item>
            /// <item><description>removing: The node pool is being removed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>initial</para>
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
        public DescribeClusterNodesResponseBodyPage Page { get; set; }
        public class DescribeClusterNodesResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

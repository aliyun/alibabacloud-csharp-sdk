// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of container asset information.</para>
        /// </summary>
        [NameInMap("ContainerInstanceList")]
        [Validation(Required=false)]
        public List<DescribeContainerInstancesResponseBodyContainerInstanceList> ContainerInstanceList { get; set; }
        public class DescribeContainerInstancesResponseBodyContainerInstanceList : TeaModel {
            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>Indicates whether security alerts exist for the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: Security alerts exist.</description></item>
            /// <item><description><b>NO</b>: No security alerts exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba-log-controller</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfb41a869c71e4678a97021582dd8a****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The container ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48a6d9a92435a13ad573372c3f3c63b7e04d106458141df9f92155709d****</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The timestamp when the cluster was created, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1670368337000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether the container is exposed to the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: exposed.</description></item>
            /// <item><description><b>0</b>: not exposed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Exposed")]
            [Validation(Required=false)]
            public int? Exposed { get; set; }

            /// <summary>
            /// <para>The exposure details in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;exposedName\&quot;:\&quot;nginx-ingress-lb\&quot;,\&quot;exposedType\&quot;:\&quot;LoadBalancer\&quot;,\&quot;portDOList\&quot;:[{\&quot;name\&quot;:\&quot;http\&quot;,\&quot;nodePort\&quot;:32268,\&quot;port\&quot;:80,\&quot;targetPort\&quot;:80},{\&quot;name\&quot;:\&quot;https\&quot;,\&quot;nodePort\&quot;:32376,\&quot;port\&quot;:443,\&quot;targetPort\&quot;:443}]}]</para>
            /// </summary>
            [NameInMap("ExposedDetail")]
            [Validation(Required=false)]
            public string ExposedDetail { get; set; }

            /// <summary>
            /// <para>The number of baseline risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// <para>The baseline risk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No baseline risks exist. </description></item>
            /// <item><description><b>YES</b>: Baseline risks exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The host IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.24.XX.XX</para>
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// <para>The container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker.io/library/nginx:latest</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The digest value of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b046e2de8c490819125193ee2eb71a66f2cc16c032dcd8b69ead4be1024****</para>
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-beijing.aliyuncs.com/acs/log-controller@sha256:5b046e2de8c490819125193ee2eb71a66f2cc16c032dcd8b69ead4be1024****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log-controller</para>
            /// </summary>
            [NameInMap("ImageRepoName")]
            [Validation(Required=false)]
            public string ImageRepoName { get; set; }

            /// <summary>
            /// <para>The namespace of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs</para>
            /// </summary>
            [NameInMap("ImageRepoNamespace")]
            [Validation(Required=false)]
            public string ImageRepoNamespace { get; set; }

            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3.1.0-dfa2010-aliyun</para>
            /// </summary>
            [NameInMap("ImageRepoTag")]
            [Validation(Required=false)]
            public string ImageRepoTag { get; set; }

            /// <summary>
            /// <para>The UUID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5f23dfbceec289a49ac94e035e2****</para>
            /// </summary>
            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            /// <summary>
            /// <para>The asset instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zegzjyotydfkz9****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-system</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The node information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public string NodeInfo { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The pod name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba-log-controller-6f847f8786-mk2mg</para>
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>The pod IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.24.XX.XX</para>
            /// </summary>
            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            /// <summary>
            /// <para>The region ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public string RiskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether risks exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No risks exist.</description></item>
            /// <item><description><b>YES</b>: Risks exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The update identifier of the container asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79cff74d-e967-5407-8a78-ee03b9****</para>
            /// </summary>
            [NameInMap("UpdateMark")]
            [Validation(Required=false)]
            public string UpdateMark { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities in the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether vulnerabilities exist in the container asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: Vulnerabilities exist.</description></item>
            /// <item><description><b>NO</b>: No vulnerabilities exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeContainerInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeContainerInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use it for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

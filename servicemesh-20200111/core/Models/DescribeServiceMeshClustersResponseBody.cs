// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeServiceMeshClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The domain name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c.com</para>
            /// </summary>
            [NameInMap("ClusterDomain")]
            [Validation(Required=false)]
            public string ClusterDomain { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c80f45444b3da447da60a911390c2****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-12T15:38:16+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error message about the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fail</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Indicates that the cluster is available or the reason why the cluster cannot be added to the ASM instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: The cluster can be added to the ASM instance.</description></item>
            /// <item><description><c>1</c>: The cluster cannot be added to the ASM instance because you do not have administrator permissions on the cluster.</description></item>
            /// <item><description><c>2</c>: The cluster cannot be added to the ASM instance because the cluster and the ASM instance reside in different VPCs between which no private connections are built.</description></item>
            /// <item><description><c>3</c>: The CIDR block of the cluster conflicts with that of the ASM instance.</description></item>
            /// <item><description><c>4</c>: The cluster has a namespace that is named istio-system.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ForbiddenFlag")]
            [Validation(Required=false)]
            public long? ForbiddenFlag { get; set; }

            /// <summary>
            /// <para>The reason why the cluster on the data plane cannot be added to the ASM instance. The value is a JSON string in the following format:</para>
            /// <pre><c>[
            ///   {
            ///     &quot;cluster&quot;: &quot;cdd55bd6e054b4c6ca18ec02614******&quot;,
            ///     &quot;object&quot;: &quot;Pod&quot;,
            ///     &quot;cidr&quot;: &quot;172.16.0.0/24&quot;
            ///   },
            ///   {
            ///     &quot;cluster&quot;: &quot;cfa37fdf7cb1641e1976f8293ac******&quot;,
            ///     &quot;object&quot;: &quot;Pod&quot;,
            ///     &quot;cidr&quot;: &quot;172.16.0.0/24&quot;
            ///   }
            /// ]
            /// </c></pre>
            /// <para>In the preceding example, the CIDR block <c>172.16.0.0/24</c> of the pod in the <c>cdd55bd6e054b4c6ca18ec02614******</c> cluster conflicts with the CIDR block <c>172.16.0.0/24</c> of the pod in the <c>cfa37fdf7cb1641e1976f8293ac******</c> cluster.</para>
            /// <para>Valid values of the <c>object</c> parameter:</para>
            /// <list type="bullet">
            /// <item><description><c>Pod</c></description></item>
            /// <item><description><c>Service</c></description></item>
            /// <item><description><c>VSwitch</c></description></item>
            /// <item><description><c>VPC</c></description></item>
            /// <item><description><c>VPC CIDR</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;cdd55bd6e054b4c6ca18ec02614******&quot;, &quot;object&quot;:&quot;Pod&quot;, &quot;cidr&quot;:&quot;172.16.0.0/24&quot;},{&quot;cluster&quot;:&quot;cfa37fdf7cb1641e1976f8293ac******&quot;, &quot;object&quot;:&quot;Pod&quot;, &quot;cidr&quot;:&quot;172.16.0.0/24&quot;}]</para>
            /// </summary>
            [NameInMap("ForbiddenInfo")]
            [Validation(Required=false)]
            public string ForbiddenInfo { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ask1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the cluster resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ASM instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb8963379255149cb98c8686f274x****</para>
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp197668l6iupljy****</para>
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>starting</c>: The cluster is starting.</description></item>
            /// <item><description><c>stopping</c>: The cluster is being stopped.</description></item>
            /// <item><description><c>stopped</c>: The cluster is stopped.</description></item>
            /// <item><description><c>failed</c>: The cluster fails to be run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-12T15:38:16+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.16.6-aliyun.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-8vbrwmt95b4zf6wf7****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of ACK clusters in the current Region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NumberOfClusters")]
        [Validation(Required=false)]
        public long? NumberOfClusters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

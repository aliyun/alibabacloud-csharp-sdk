// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterResourcesResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeClusterResourcesResponseBody> Body { get; set; }
        public class DescribeClusterResourcesResponseBody : TeaModel {
            /// <summary>
            /// <para>集群ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>资源创建时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-15T14:34:42+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>资源ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-wz9sphwk42sdtjixo****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>资源信息。关于资源的源信息，请参见<a href="https://help.aliyun.com/document_detail/133836.html">ListStackResources</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Id\&quot;:\&quot;KubernetesWorkerRole\&quot;,\&quot;Name\&quot;:\&quot;KubernetesWorkerRole\&quot;,\&quot;Type\&quot;:\&quot;ALIYUN::RAM::Role\&quot;,\&quot;Status\&quot;:\&quot;CREATE_COMPLETE\&quot;,\&quot;StatusReason\&quot;:\&quot;state changed\&quot;,\&quot;Updated\&quot;:\&quot;2025-04-10T06:21:17\&quot;,\&quot;PhysicalId\&quot;:\&quot;KubernetesWorkerRole-7e611193-225f-40f6-bc3c-ea8633******\&quot;}</para>
            /// </summary>
            [NameInMap("resource_info")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            /// <summary>
            /// <para>资源类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::VPC::NatGateway</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>资源状态。可选值：</para>
            /// <list type="bullet">
            /// <item><description><c>CREATE_COMPLETE</c>：成功创建资源。</description></item>
            /// <item><description><c>CREATE_FAILED</c>：创建资源失败。</description></item>
            /// <item><description><c>CREATE_IN_PROGRESS</c>：创建资源中。</description></item>
            /// <item><description><c>DELETE_FAILED</c>：删除资源失败。</description></item>
            /// <item><description><c>DELETE_IN_PROGRESS</c>：删除资源中。</description></item>
            /// <item><description><c>ROLLBACK_COMPLETE</c>：成功回滚。</description></item>
            /// <item><description><c>ROLLBACK_FAILED</c>：回滚失败。</description></item>
            /// <item><description><c>ROLLBACK_IN_PROGRESS</c>：回滚中。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>资源是否由ACK创建：</para>
            /// <list type="bullet">
            /// <item><description>1：表示由ACK创建。</description></item>
            /// <item><description>0：表示该资源为已有资源。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

            /// <summary>
            /// <para>依赖资源列表。</para>
            /// </summary>
            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public List<DescribeClusterResourcesResponseBodyDependencies> Dependencies { get; set; }
            public class DescribeClusterResourcesResponseBodyDependencies : TeaModel {
                /// <summary>
                /// <para>依赖资源的集群ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc5ee03f63e43425cb6f71f1a1756****</para>
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>依赖资源类型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::VPC::NatGateway</para>
                /// </summary>
                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>依赖资源实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-wz9sphwk42sdtjixo****</para>
                /// </summary>
                [NameInMap("instance_id")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>资源关联的k8s对象。</para>
            /// </summary>
            [NameInMap("associated_object")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyAssociatedObject AssociatedObject { get; set; }
            public class DescribeClusterResourcesResponseBodyAssociatedObject : TeaModel {
                /// <summary>
                /// <para>k8s对象类型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>k8s对象命名空间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>k8s对象名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx-ingress-lb</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>删除集群时该资源的删除行为。</para>
            /// </summary>
            [NameInMap("delete_behavior")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyDeleteBehavior DeleteBehavior { get; set; }
            public class DescribeClusterResourcesResponseBodyDeleteBehavior : TeaModel {
                /// <summary>
                /// <para>删除集群时是否默认删除该资源。</para>
                /// <list type="bullet">
                /// <item><description><para>true：默认删除该资源。</para>
                /// </description></item>
                /// <item><description><para>fasle：不删除该资源。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("delete_by_default")]
                [Validation(Required=false)]
                public bool? DeleteByDefault { get; set; }

                /// <summary>
                /// <para><c>delete_by_default</c>的默认行为是否可以更改。</para>
                /// <list type="bullet">
                /// <item><description><para>true：可以更改。</para>
                /// </description></item>
                /// <item><description><para>false：不支持更改。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changeable")]
                [Validation(Required=false)]
                public bool? Changeable { get; set; }

            }

            /// <summary>
            /// <para>该资源创建者的类型。可能的取值：</para>
            /// <list type="bullet">
            /// <item><description>user：由用户自行创建；</description></item>
            /// <item><description>system：由ACK管控系统创建；</description></item>
            /// <item><description>addon：由集群组件创建。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addon</para>
            /// </summary>
            [NameInMap("creator_type")]
            [Validation(Required=false)]
            public string CreatorType { get; set; }

            /// <summary>
            /// <para>资源的其他信息。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;type&quot;: &quot;SLS_Data&quot; }</para>
            /// </summary>
            [NameInMap("extra_info")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

        }

    }

}

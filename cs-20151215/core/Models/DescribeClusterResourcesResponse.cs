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
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-15T14:34:42+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-wz9sphwk42sdtjixo****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Information about the resource. For more details about its source, see <a href="https://help.aliyun.com/document_detail/133836.html">ListStackResources</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Id\&quot;:\&quot;KubernetesWorkerRole\&quot;,\&quot;Name\&quot;:\&quot;KubernetesWorkerRole\&quot;,\&quot;Type\&quot;:\&quot;ALIYUN::RAM::Role\&quot;,\&quot;Status\&quot;:\&quot;CREATE_COMPLETE\&quot;,\&quot;StatusReason\&quot;:\&quot;state changed\&quot;,\&quot;Updated\&quot;:\&quot;2025-04-10T06:21:17\&quot;,\&quot;PhysicalId\&quot;:\&quot;KubernetesWorkerRole-7e611193-225f-40f6-bc3c-ea8633******\&quot;}</para>
            /// </summary>
            [NameInMap("resource_info")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::VPC::NatGateway</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The state of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>CREATE_COMPLETE</c>: The resource is successfully created.</para>
            /// </description></item>
            /// <item><description><para><c>CREATE_FAILED</c>: The resource fails to be created.</para>
            /// </description></item>
            /// <item><description><para><c>CREATE_IN_PROGRESS</c>: The resource is being created.</para>
            /// </description></item>
            /// <item><description><para><c>DELETE_FAILED</c>: The resource fails to be deleted.</para>
            /// </description></item>
            /// <item><description><para><c>DELETE_IN_PROGRESS</c>: The resource is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>ROLLBACK_COMPLETE</c>: The rollback is successful.</para>
            /// </description></item>
            /// <item><description><para><c>ROLLBACK_FAILED</c>: The rollback fails.</para>
            /// </description></item>
            /// <item><description><para><c>ROLLBACK_IN_PROGRESS</c>: The rollback is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource is created by ACK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The resource is created by ACK.</para>
            /// </description></item>
            /// <item><description><para>0: The resource is an existing resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

            /// <summary>
            /// <para>The list of dependent resources.</para>
            /// </summary>
            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public List<DescribeClusterResourcesResponseBodyDependencies> Dependencies { get; set; }
            public class DescribeClusterResourcesResponseBodyDependencies : TeaModel {
                /// <summary>
                /// <para>The cluster ID of the dependent resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc5ee03f63e43425cb6f71f1a1756****</para>
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The type of the dependent resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::VPC::NatGateway</para>
                /// </summary>
                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The instance ID of the dependent resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-wz9sphwk42sdtjixo****</para>
                /// </summary>
                [NameInMap("instance_id")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The Kubernetes object that is associated with the resource.</para>
            /// </summary>
            [NameInMap("associated_object")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyAssociatedObject AssociatedObject { get; set; }
            public class DescribeClusterResourcesResponseBodyAssociatedObject : TeaModel {
                /// <summary>
                /// <para>The type of the Kubernetes object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The namespace of the Kubernetes object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The name of the Kubernetes object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx-ingress-lb</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The deletion behavior of the resource when the cluster is deleted.</para>
            /// </summary>
            [NameInMap("delete_behavior")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyDeleteBehavior DeleteBehavior { get; set; }
            public class DescribeClusterResourcesResponseBodyDeleteBehavior : TeaModel {
                /// <summary>
                /// <para>Indicates whether to delete the resource by default when the cluster is deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The resource is deleted by default.</para>
                /// </description></item>
                /// <item><description><para>false: The resource is not deleted by default.</para>
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
                /// <para>Indicates whether the default behavior specified by the <c>delete_by_default</c> parameter can be changed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The default behavior can be changed.</para>
                /// </description></item>
                /// <item><description><para>false: The default behavior cannot be changed.</para>
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
            /// <para>The type of the creator of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>user: The resource is created by a user.</para>
            /// </description></item>
            /// <item><description><para>system: The resource is created by the ACK control plane.</para>
            /// </description></item>
            /// <item><description><para>addon: The resource is created by an add-on.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addon</para>
            /// </summary>
            [NameInMap("creator_type")]
            [Validation(Required=false)]
            public string CreatorType { get; set; }

            /// <summary>
            /// <para>Extra information about the resource.</para>
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

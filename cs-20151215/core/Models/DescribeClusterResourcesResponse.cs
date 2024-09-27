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
            /// <para>2020-09-11T10:11:54+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-wz9poz4r0ymh8u0uf****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource information. For more information about how to query the source information about the resource, see <a href="https://help.aliyun.com/document_detail/133836.html">ListStackResources</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Id\&quot;:\&quot;k8s_master_slb\&quot;,\&quot;Name\&quot;:\&quot;k8s_master_slb\&quot;,\&quot;Type\&quot;:\&quot;ALIYUN::SLB::LoadBalancer\&quot;,\&quot;Status\&quot;:\&quot;CREATE_COMPLETE\&quot;,\&quot;StatusReason\&quot;:\&quot;state changed\&quot;,\&quot;Updated\&quot;:\&quot;2020-05-21T13:25:02\&quot;,\&quot;PhysicalId\&quot;:\&quot;lb-wz9poz4r0ymh8u0uf****\&quot;}</para>
            /// </summary>
            [NameInMap("resource_info")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::SLB::LoadBalancer</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>CREATE_COMPLETE</c>: the resource is created.</description></item>
            /// <item><description><c>CREATE_FAILED</c>: the resource failed to be created.</description></item>
            /// <item><description><c>CREATE_IN_PROGRESS</c>: the resource is being created.</description></item>
            /// <item><description><c>DELETE_FAILED</c>: the resource failed to be deleted.</description></item>
            /// <item><description><c>DELETE_IN_PROGRESS</c>: the resource is being deleted.</description></item>
            /// <item><description><c>ROLLBACK_COMPLETE</c>: the resource is rolled back.</description></item>
            /// <item><description><c>ROLLBACK_FAILED</c>: the resource failed to be rolled back.</description></item>
            /// <item><description><c>ROLLBACK_IN_PROGRESS</c>: the resource is being rolled back.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Specifies whether the resource is created by Container Service for Kubernetes (ACK). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: the resource is created by ACK.</description></item>
            /// <item><description>0: the resource is an existing resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

            /// <summary>
            /// <para>The dependent resources.</para>
            /// </summary>
            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public List<DescribeClusterResourcesResponseBodyDependencies> Dependencies { get; set; }
            public class DescribeClusterResourcesResponseBodyDependencies : TeaModel {
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("instance_id")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The Kubernetes object with which the resource is associated.</para>
            /// </summary>
            [NameInMap("associated_object")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyAssociatedObject AssociatedObject { get; set; }
            public class DescribeClusterResourcesResponseBodyAssociatedObject : TeaModel {
                /// <summary>
                /// <para>The Kubernetes object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The namespace in which the Kubernetes object resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The Kubernetes object name.</para>
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
                /// <para>Specifies whether to delete the resource by default when the cluster is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("delete_by_default")]
                [Validation(Required=false)]
                public bool? DeleteByDefault { get; set; }

                /// <summary>
                /// <para>Specifies whether the default behavior returned in delete_by_default can be changed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changeable")]
                [Validation(Required=false)]
                public bool? Changeable { get; set; }

            }

            /// <summary>
            /// <para>The resource creator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: The resource is created by the user.</description></item>
            /// <item><description>system: The resource is created by the ACK management system.</description></item>
            /// <item><description>addon: The resource is created by a cluster component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addon</para>
            /// </summary>
            [NameInMap("creator_type")]
            [Validation(Required=false)]
            public string CreatorType { get; set; }

            /// <summary>
            /// <para>The additional information about the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;IP&quot;: &quot;xx.xx.xx.xx&quot;}</para>
            /// </summary>
            [NameInMap("extra_info")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

        }

    }

}

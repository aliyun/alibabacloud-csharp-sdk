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
            /// The cluster ID.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The time when the resource was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The resource ID.
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The resource information. For more information about how to query the source information about the resource, see [ListStackResources](https://help.aliyun.com/document_detail/133836.html).
            /// </summary>
            [NameInMap("resource_info")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The resource status. Valid values:
            /// 
            /// *   `CREATE_COMPLETE`: the resource is created.
            /// *   `CREATE_FAILED`: the resource failed to be created.
            /// *   `CREATE_IN_PROGRESS`: the resource is being created.
            /// *   `DELETE_FAILED`: the resource failed to be deleted.
            /// *   `DELETE_IN_PROGRESS`: the resource is being deleted.
            /// *   `ROLLBACK_COMPLETE`: the resource is rolled back.
            /// *   `ROLLBACK_FAILED`: the resource failed to be rolled back.
            /// *   `ROLLBACK_IN_PROGRESS`: the resource is being rolled back.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Specifies whether the resource is created by Container Service for Kubernetes (ACK). Valid values:
            /// 
            /// *   1: the resource is created by ACK.
            /// *   0: the resource is an existing resource.
            /// </summary>
            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

            /// <summary>
            /// The dependent resources.
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
            /// The Kubernetes object with which the resource is associated.
            /// </summary>
            [NameInMap("associated_object")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyAssociatedObject AssociatedObject { get; set; }
            public class DescribeClusterResourcesResponseBodyAssociatedObject : TeaModel {
                /// <summary>
                /// The Kubernetes object type.
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// The namespace in which the Kubernetes object resides.
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The Kubernetes object name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The deletion behavior of the resource when the cluster is deleted.
            /// </summary>
            [NameInMap("delete_behavior")]
            [Validation(Required=false)]
            public DescribeClusterResourcesResponseBodyDeleteBehavior DeleteBehavior { get; set; }
            public class DescribeClusterResourcesResponseBodyDeleteBehavior : TeaModel {
                /// <summary>
                /// Specifies whether to delete the resource by default when the cluster is deleted.
                /// </summary>
                [NameInMap("delete_by_default")]
                [Validation(Required=false)]
                public bool? DeleteByDefault { get; set; }

                /// <summary>
                /// Specifies whether the default behavior returned in delete_by_default can be changed.
                /// </summary>
                [NameInMap("changeable")]
                [Validation(Required=false)]
                public bool? Changeable { get; set; }

            }

            /// <summary>
            /// The resource creator. Valid values:
            /// 
            /// *   user: The resource is created by the user.
            /// *   system: The resource is created by the ACK management system.
            /// *   addon: The resource is created by a cluster component.
            /// </summary>
            [NameInMap("creator_type")]
            [Validation(Required=false)]
            public string CreatorType { get; set; }

            /// <summary>
            /// The additional information about the resource.
            /// </summary>
            [NameInMap("extra_info")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

        }

    }

}

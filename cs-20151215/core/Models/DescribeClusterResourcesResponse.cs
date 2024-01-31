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
            /// The information about the resource. For more information about how to query the source information about a resource, see [ListStackResources](~~133836~~).
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
            /// *   `CREATE_COMPLETE`: The resource is created.
            /// *   `CREATE_FAILED`: The resource failed to be created.
            /// *   `CREATE_IN_PROGRESS`: The resource is being created.
            /// *   `DELETE_FAILED`: The resource failed to be deleted.
            /// *   `DELETE_IN_PROGRESS`: The resource is being deleted.
            /// *   `ROLLBACK_COMPLETE`: The resource is rolled back.
            /// *   `ROLLBACK_FAILED`: The resource failed to be rolled back.
            /// *   `ROLLBACK_IN_PROGRESS`: The resource is being rolled back.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates whether the resource is created by Container Service for Kubernetes (ACK). Valid values:
            /// 
            /// *   1: The resource is created by ACK.
            /// *   0: The resource is an existing resource.
            /// </summary>
            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

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

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterInfoListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about clusters.
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public List<DescribeClusterInfoListResponseBodyClusterList> ClusterList { get; set; }
        public class DescribeClusterInfoListResponseBodyClusterList : TeaModel {
            /// <summary>
            /// The ID of the container cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the container cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   **ManagedKubernetes**: managed Kubernetes cluster.
            /// *   **NotManagedKubernetes**: non-managed Kubernetes cluster.
            /// *   **PrivateKubernetes**: private cluster.
            /// *   **kubernetes**: dedicated Kubernetes cluster.
            /// *   **ask**: dedicated serverless Kubernetes (ASK) cluster.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The region in which the cluster resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   **unavailable**: The cluster is unavailable.
            /// *   **Available**: The cluster is available.
            /// *   **Creating**: The cluster is being created.
            /// *   **CreateFailed**: The cluster failed to be created.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates whether container network topology was enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("TargetResult")]
            [Validation(Required=false)]
            public bool? TargetResult { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

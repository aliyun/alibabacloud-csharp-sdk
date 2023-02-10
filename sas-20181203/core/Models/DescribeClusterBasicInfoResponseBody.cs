// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the cluster.
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterBasicInfoResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterBasicInfoResponseBodyClusterInfo : TeaModel {
            /// <summary>
            /// The ID of cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   **ManagedKubernetes**: managed Kubernetes cluster
            /// *   **NotManagedKubernetes**: non-managed Kubernetes cluster
            /// *   **PrivateKubernetes**: private cluster
            /// *   **kubernetes**: dedicated Kubernetes cluster
            /// *   **ask**: dedicated ASK cluster
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The timestamp when the cluster was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The version of the cluster.
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// The number of instances in the cluster.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   **unavailable**
            /// *   **Available**
            /// *   **Creating**
            /// *   **CreateFailed**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates whether the cluster is enabled. Valid values:
            /// 
            /// *   **true**: The cluster is enabled.
            /// *   **false**: The cluster is disabled.
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

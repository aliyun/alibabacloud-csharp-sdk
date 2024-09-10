// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerGroupedFieldDetailResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerGroupedFieldDetailResponseBodyData Data { get; set; }
        public class DescribeContainerGroupedFieldDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The number of alerts.
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The version of the current online server in the cluster.
            /// </summary>
            [NameInMap("ClusterCurrentVersion")]
            [Validation(Required=false)]
            public string ClusterCurrentVersion { get; set; }

            /// <summary>
            /// The ID of the cluster.
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
            /// The status of the cluster. Valid values:
            /// 
            /// *   STARTING: The cluster is being started.
            /// *   START_FAILED: The cluster fails to be started.
            /// *   BOOTSTRAPPING: The bootstrap action is being performed for the cluster.
            /// *   RUNNING: The cluster is running.
            /// *   TERMINATING: The cluster is being terminated.
            /// *   TERMINATED: The cluster is terminated.
            /// *   TERMINATED_WITH_ERRORS: The cluster is terminated due to an exception.
            /// *   TERMINATE_FAILED: The cluster fails to be terminated.
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   **Kubernetes**: dedicated Kubernetes cluster.
            /// *   **ManagedKubernetes**: standard managed cluster (edge cluster).
            /// *   **Ask**: serverless Kubernetes (ASK) cluster.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The number of containers.
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public int? ContainerCount { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The number of pods.
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// The IP address of the pod.
            /// </summary>
            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of vulnerabilities.
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

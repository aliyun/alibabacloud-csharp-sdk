// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedContainerInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the container.
        /// </summary>
        [NameInMap("GroupedContainerInstanceList")]
        [Validation(Required=false)]
        public List<DescribeGroupedContainerInstancesResponseBodyGroupedContainerInstanceList> GroupedContainerInstanceList { get; set; }
        public class DescribeGroupedContainerInstancesResponseBodyGroupedContainerInstanceList : TeaModel {
            /// <summary>
            /// The number of alerts that are detected for the current pod, application, namespace, or cluster.
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
            /// The time when the cluster was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   **running**: The cluster is running.
            /// *   **stopped**: The cluster is stopped.
            /// *   **deleted**: The cluster is deleted.
            /// *   **delete_failed**: The cluster failed to be deleted.
            /// *   **failed**: The cluster failed to be created.
            /// </summary>
            [NameInMap("CusterState")]
            [Validation(Required=false)]
            public string CusterState { get; set; }

            /// <summary>
            /// The number of baseline risks that are detected for the current pod, application, namespace, or cluster.
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// The IP address of the host in the container cluster.
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// The container image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The digest value of the image.
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("ImageRepoName")]
            [Validation(Required=false)]
            public string ImageRepoName { get; set; }

            /// <summary>
            /// The namespace of the image repository.
            /// </summary>
            [NameInMap("ImageRepoNamespace")]
            [Validation(Required=false)]
            public string ImageRepoNamespace { get; set; }

            /// <summary>
            /// The tag that is added to the image repository.
            /// </summary>
            [NameInMap("ImageRepoTag")]
            [Validation(Required=false)]
            public string ImageRepoTag { get; set; }

            /// <summary>
            /// The UUID of the image.
            /// </summary>
            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            /// <summary>
            /// The number of pods, applications, clusters, or namespaces.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The namespace of the cluster.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The IP address of the pod.
            /// </summary>
            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of at-risk instances.
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// Indicates whether risks were detected. Valid values:
            /// 
            /// *   **NO**: No risks were detected.
            /// *   **YES**: Risks were detected.
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// Indicates whether the synchronization of cluster audit logs is enabled. Valid values:
            /// 
            /// *   **0**: disabled.
            /// *   **1**: enabled.
            /// </summary>
            [NameInMap("SyncOpen")]
            [Validation(Required=false)]
            public int? SyncOpen { get; set; }

            /// <summary>
            /// The status of the synchronization of cluster audit logs. Valid values:
            /// 
            /// *   **0**: The synchronization failed.
            /// *   **1**: The synchronization is successful.
            /// </summary>
            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public int? SyncStatus { get; set; }

            /// <summary>
            /// The number of vulnerabilities that are detected for the current pod, application, namespace, or cluster.
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeGroupedContainerInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeGroupedContainerInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of container assets returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of container assets returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

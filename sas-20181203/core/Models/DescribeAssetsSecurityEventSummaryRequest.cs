// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster to which the container belongs.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The key of the condition that is used to query on containers. Valid values:
        /// 
        /// *   **instanceId**: the ID of the container instance
        /// *   **clusterId**: the ID of the cluster
        /// *   **regionId**: the region ID of the container
        /// *   **clusterName**: the name of the cluster
        /// *   **image**: the name of the image
        /// *   **imageRepoName**: the name of the image repository
        /// *   **imageRepoNamespace**: the namespace to which the image repository belongs
        /// *   **imageRepoTag**: the tag that is added to the image repository
        /// *   **imageDigest**: the digest of the image
        /// *   **ClusterType**: the type of the cluster
        /// *   **hostIp**: the public IP address
        /// *   **pod**: the pod
        /// *   **podIp**: the IP address of the pod
        /// *   **containerId**: the ID of the container
        /// *   **vulStatus**: whether vulnerabilities are detected on the container
        /// *   **alarmStatus**: whether alerts are generated for the container
        /// *   **riskStatus**: whether risks are detected on the container
        /// *   **riskLevel**: the risk level of the container
        /// *   **containerScope**: the type of the container
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// The value of the condition that is used to query on containers.
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}

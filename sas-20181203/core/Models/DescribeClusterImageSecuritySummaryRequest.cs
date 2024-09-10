// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The key of the condition that is used to query containers. Valid values:
        /// 
        /// *   **instanceId**: the instance ID of the container
        /// *   **clusterId**: the ID of the cluster
        /// *   **regionId**: the region ID of the container
        /// *   **clusterName**: the name of the cluster
        /// *   **image**: the name of the image
        /// *   **imageRepoName**: the name of the image repository
        /// *   **imageRepoNamespace**: the namespace to which the image repository belongs
        /// *   **imageRepoTag**: the tag that is added to the image repository
        /// *   **imageDigest**: the digest of the image
        /// *   **clusterType**: the type of the cluster
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
        /// The value of the condition that is used to query containers.
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// The digest of the image.
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
        /// The tag of the image.
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}

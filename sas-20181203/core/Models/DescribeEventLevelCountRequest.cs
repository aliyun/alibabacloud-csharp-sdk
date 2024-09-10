// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The key of the condition that is used to query alert events on containers. Valid values:
        /// 
        /// *   **instanceId**: the ID of the asset
        /// *   **appName**: the name of the application
        /// *   **clusterId**: the ID of the cluster
        /// *   **regionId**: the ID of the region
        /// *   **nodeName**: the name of the node
        /// *   **namespace**: the namespace
        /// *   **clusterName**: the name of the cluster
        /// *   **image**: the name of the image
        /// *   **imageRepoName**: the name of the image repository
        /// *   **imageRepoNamespace**: the namespace to which the image repository belongs
        /// *   **imageRepoTag**: the tag that is added to the image
        /// *   **imageDigest**: the digest of the image
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// The value of the condition that is used to query alert events on containers. If you specify multiple values, separate them with commas (,).
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// The ID of the container.
        /// </summary>
        [NameInMap("ContainerIds")]
        [Validation(Required=false)]
        public string ContainerIds { get; set; }

        /// <summary>
        /// The ID of the request source. Set the value to **sas**.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// The type of the query condition. Valid values:
        /// 
        /// *   **containerId**: the ID of the container
        /// *   **uuid**: the UUID of the asset
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}

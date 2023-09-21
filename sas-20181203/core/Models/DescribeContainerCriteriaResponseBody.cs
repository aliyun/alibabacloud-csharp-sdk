// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerCriteriaResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the filter condition.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeContainerCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeContainerCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition. Valid values:
            /// 
            /// *   **instanceId**: the ID of the container instance.
            /// *   **clusterId**: the cluster ID.
            /// *   **regionId**: the ID of the region in which the container resides.
            /// *   **clusterName**: the name of the cluster.
            /// *   **image**: the name of the image.
            /// *   **imageRepoName**: the name of the image repository.
            /// *   **imageRepoNamespace**: the namespace of the image repository.
            /// *   **imageRepoTag**: the tag of the image repository.
            /// *   **imageDigest**: the image digest.
            /// *   **ClusterType**: the type of the cluster.
            /// *   **hostIp**: the public IP address.
            /// *   **pod**: the pod.
            /// *   **podIp**: the IP address of the pod.
            /// *   **containerId**: the container ID.
            /// *   **vulStatus**: indicates whether vulnerabilities exist in the container.
            /// *   **alarmStatus**: indicates whether alerts are generated for the container.
            /// *   **riskStatus**: indicates whether risks exist in the container.
            /// *   **riskLevel**: the risk level of the container.
            /// *   **containerScope**: the type of the container.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **input**: The search condition needs to be specified.
            /// *   **select**: The search condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The values of the search condition. This parameter is returned only if the value of **Type** is set to **select**.
            /// 
            /// > If the value of **Type** is set to **input**, the return value of this parameter is empty.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

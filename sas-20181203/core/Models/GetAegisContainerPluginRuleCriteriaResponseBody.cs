// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The information about the search condition.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The name of the search condition. Valid values:
            /// 
            /// *   **instanceId**: the ID of the container instance.
            /// *   **clusterId**: the cluster ID.
            /// *   **regionId**: the ID of the region in which the container resides.
            /// *   **clusterName**: the name of the cluster.
            /// *   **clusterType**: the type of the cluster.
            /// *   **hostIp**: the public IP address.
            /// *   **pod**: the pod.
            /// *   **podIp**: the IP address of the pod.
            /// *   **containerId**: the container ID.
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
            /// The values.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

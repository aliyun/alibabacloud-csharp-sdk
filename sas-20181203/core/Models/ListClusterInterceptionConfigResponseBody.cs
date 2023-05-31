// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of the cluster.
        /// </summary>
        [NameInMap("ClusterConfigList")]
        [Validation(Required=false)]
        public List<ListClusterInterceptionConfigResponseBodyClusterConfigList> ClusterConfigList { get; set; }
        public class ListClusterInterceptionConfigResponseBodyClusterConfigList : TeaModel {
            /// <summary>
            /// The status of the container firewall feature. Valid values:
            /// 
            /// *   **-1**: unknown
            /// *   **0**: abnormal
            /// *   **1**: normal
            /// *   **2**: normal to be confirmed
            /// </summary>
            [NameInMap("ClusterCNNFStatus")]
            [Validation(Required=false)]
            public int? ClusterCNNFStatus { get; set; }

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
            /// *   **ManagedKubernetes**: managed Kubernetes cluster
            /// *   **NotManagedKubernetes**: non-managed Kubernetes cluster
            /// *   **PrivateKubernetes**: private cluster
            /// *   **kubernetes**: dedicated Kubernetes cluster
            /// *   **ask**: dedicated serverless Kubernetes (ASK) cluster
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The status of the defense rule. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            /// <summary>
            /// The number of defense rules that are in effect.
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public long? OpenRuleCount { get; set; }

            /// <summary>
            /// Indicates whether the container firewall feature is supported.
            /// </summary>
            [NameInMap("SupportCNNF")]
            [Validation(Required=false)]
            public bool? SupportCNNF { get; set; }

            /// <summary>
            /// The total number of defense rules.
            /// </summary>
            [NameInMap("TotalRuleCount")]
            [Validation(Required=false)]
            public long? TotalRuleCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterInterceptionConfigResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterInterceptionConfigResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrrentPage")]
            [Validation(Required=false)]
            public int? CurrrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
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

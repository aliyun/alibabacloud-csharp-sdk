// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryGovernanceKubernetesClusterResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class QueryGovernanceKubernetesClusterResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryGovernanceKubernetesClusterResponseBodyDataResult> Result { get; set; }
            public class QueryGovernanceKubernetesClusterResponseBodyDataResult : TeaModel {
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
                /// The version of the cluster.
                /// </summary>
                [NameInMap("K8sVersion")]
                [Validation(Required=false)]
                public string K8sVersion { get; set; }

                /// <summary>
                /// The information of the namespace.
                /// </summary>
                [NameInMap("NamespaceInfos")]
                [Validation(Required=false)]
                public string NamespaceInfos { get; set; }

                /// <summary>
                /// The time when the ack-one-pilot component was started.
                /// </summary>
                [NameInMap("PilotStartTime")]
                [Validation(Required=false)]
                public string PilotStartTime { get; set; }

                /// <summary>
                /// Region
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// The number of clusters.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// HttpCode
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

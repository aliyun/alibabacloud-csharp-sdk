// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListContainerDefenseRuleClustersResponseBody : TeaModel {
        /// <summary>
        /// The clusters.
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public List<ListContainerDefenseRuleClustersResponseBodyClusterList> ClusterList { get; set; }
        public class ListContainerDefenseRuleClustersResponseBodyClusterList : TeaModel {
            /// <summary>
            /// Indicates whether all namespaces are included. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespaces.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

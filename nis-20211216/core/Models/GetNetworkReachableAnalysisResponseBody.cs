// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNetworkReachableAnalysisResponseBody : TeaModel {
        /// <summary>
        /// The unique ID (UID) of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// The time when the network path was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The network path ID.
        /// </summary>
        [NameInMap("NetworkPathId")]
        [Validation(Required=false)]
        public string NetworkPathId { get; set; }

        /// <summary>
        /// The parameters of the network path.
        /// </summary>
        [NameInMap("NetworkPathParameter")]
        [Validation(Required=false)]
        public string NetworkPathParameter { get; set; }

        /// <summary>
        /// The ID of the task for analyzing network reachability.
        /// </summary>
        [NameInMap("NetworkReachableAnalysisId")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisId { get; set; }

        /// <summary>
        /// The result of network reachability analysis, which includes the network topology, error codes of network unreachability, and rules of network unreachability.
        /// </summary>
        [NameInMap("NetworkReachableAnalysisResult")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisResult { get; set; }

        /// <summary>
        /// The state of the task for analyzing network reachability. Valid values:
        /// 
        /// *   **init**: The task is in progress.
        /// *   **finish**: The task is complete.
        /// *   **error**: An analysis error occurred.
        /// *   **timeout**: The task timed out.
        /// </summary>
        [NameInMap("NetworkReachableAnalysisStatus")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisStatus { get; set; }

        /// <summary>
        /// Indicates whether the network path is reachable. Valid values:
        /// 
        /// *   **true**: The network path is reachable.
        /// *   **false**: The network path is unreachable.
        /// </summary>
        [NameInMap("Reachable")]
        [Validation(Required=false)]
        public bool? Reachable { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

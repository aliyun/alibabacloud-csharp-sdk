// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The moderation results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpgradeEngineVersionResponseBodyResult> Result { get; set; }
        public class UpgradeEngineVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// The verification is passed. Valid values:
            /// 
            /// *   success: through
            /// *   failed: failed
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The verification information.
            /// </summary>
            [NameInMap("validateResult")]
            [Validation(Required=false)]
            public List<UpgradeEngineVersionResponseBodyResultValidateResult> ValidateResult { get; set; }
            public class UpgradeEngineVersionResponseBodyResultValidateResult : TeaModel {
                /// <summary>
                /// The error code returned if the request failed.
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The type of the error. Valid values:
                /// 
                /// *   clusterStatus: the health status of the cluster.
                /// *   clusterConfigYml: Cluster YML File
                /// *   clusterConfigPlugins: Cluster Configuration File
                /// *   clusterResource: cluster resources
                /// *   clusterSnapshot: cluster snapshot
                /// </summary>
                [NameInMap("errorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

            }

            /// <summary>
            /// The monitoring type. Valid values:
            /// 
            /// *   checkClusterHealth: Cluster Health Status
            /// *   checkConfigCompatible: Configuration Compatibility Status
            /// *   checkClusterResource: resource space status
            /// *   checkClusterSnapshot: Whether a snapshot exists
            /// </summary>
            [NameInMap("validateType")]
            [Validation(Required=false)]
            public string ValidateType { get; set; }

        }

    }

}

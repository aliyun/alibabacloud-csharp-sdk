// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAssetSelectionConfigResponseBodyData Data { get; set; }
        public class CreateAssetSelectionConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The business type that is selected for the asset. Valid values:
            /// 
            /// *   **VIRUS_SCAN_CYCLE_CONFIG**: virus detection configuration
            /// *   **VIRUS_SCAN_ONCE_TASK**: one-time scan for virus detection
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// The ID of the current asset selection. It can be used to query and modify the asset that is selected.
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public long? SelectionKey { get; set; }

            /// <summary>
            /// The dimension based on which the asset is selected. Valid values:
            /// 
            /// *   **group**: The asset is selected by server.
            /// *   **group**: The asset is selected by group.
            /// *   **vpc**: The asset is selected by VPC.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

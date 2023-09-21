// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of risk information about containers.
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetsSecurityEventSummaryResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetsSecurityEventSummaryResponseBodyAssets : TeaModel {
            /// <summary>
            /// The type of the asset. Valid values:
            /// 
            /// *   **namespace**
            /// *   **clusters**
            /// *   **applications**
            /// *   **pods**
            /// *   **containers**
            /// *   **images**
            /// *   **hosts**
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// The number of potential risky assets.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The total number of assets.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListResponseBody : TeaModel {
        /// <summary>
        /// The details of the assets.
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeAssetRiskListResponseBodyAssetList> AssetList { get; set; }
        public class DescribeAssetRiskListResponseBodyAssetList : TeaModel {
            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The IP version of the asset that is protected by Cloud Firewall.
            /// 
            /// Valid values:
            /// 
            /// *   **4**: IPv4
            /// *   **6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public long? IpVersion { get; set; }

            /// <summary>
            /// The reason for the risk.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **low**
            /// *   **middle**
            /// *   **high**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

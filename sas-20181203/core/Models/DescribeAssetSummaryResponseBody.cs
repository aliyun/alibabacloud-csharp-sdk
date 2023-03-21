// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// The statistical information about the assets.
        /// </summary>
        [NameInMap("AssetsSummary")]
        [Validation(Required=false)]
        public DescribeAssetSummaryResponseBodyAssetsSummary AssetsSummary { get; set; }
        public class DescribeAssetSummaryResponseBodyAssetsSummary : TeaModel {
            /// <summary>
            /// The total number of protected assets in all regions.
            /// </summary>
            [NameInMap("TotalAssetAllRegion")]
            [Validation(Required=false)]
            public int? TotalAssetAllRegion { get; set; }

            /// <summary>
            /// The total number of cores of protected assets in all regions.
            /// </summary>
            [NameInMap("TotalCoreAllRegion")]
            [Validation(Required=false)]
            public int? TotalCoreAllRegion { get; set; }

            /// <summary>
            /// The total number of cores of protected assets in the current region.
            /// </summary>
            [NameInMap("TotalCoreNum")]
            [Validation(Required=false)]
            public int? TotalCoreNum { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

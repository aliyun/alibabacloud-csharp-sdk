// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetSummaryResponseBody : TeaModel {
        [NameInMap("AssetsSummary")]
        [Validation(Required=false)]
        public DescribeAssetSummaryResponseBodyAssetsSummary AssetsSummary { get; set; }
        public class DescribeAssetSummaryResponseBodyAssetsSummary : TeaModel {
            [NameInMap("TotalAssetAllRegion")]
            [Validation(Required=false)]
            public int? TotalAssetAllRegion { get; set; }

            [NameInMap("TotalCoreAllRegion")]
            [Validation(Required=false)]
            public int? TotalCoreAllRegion { get; set; }

            [NameInMap("TotalCoreNum")]
            [Validation(Required=false)]
            public int? TotalCoreNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

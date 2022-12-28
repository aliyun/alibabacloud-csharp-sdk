// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryResponseBody : TeaModel {
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetsSecurityEventSummaryResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetsSecurityEventSummaryResponseBodyAssets : TeaModel {
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

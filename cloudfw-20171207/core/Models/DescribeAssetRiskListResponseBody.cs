// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListResponseBody : TeaModel {
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeAssetRiskListResponseBodyAssetList> AssetList { get; set; }
        public class DescribeAssetRiskListResponseBodyAssetList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public long? IpVersion { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

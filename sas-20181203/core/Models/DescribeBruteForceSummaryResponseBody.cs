// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBruteForceSummaryResponseBody : TeaModel {
        [NameInMap("BruteForceSummary")]
        [Validation(Required=false)]
        public DescribeBruteForceSummaryResponseBodyBruteForceSummary BruteForceSummary { get; set; }
        public class DescribeBruteForceSummaryResponseBodyBruteForceSummary : TeaModel {
            [NameInMap("AllStrategyCount")]
            [Validation(Required=false)]
            public int? AllStrategyCount { get; set; }

            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public int? EffectiveCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

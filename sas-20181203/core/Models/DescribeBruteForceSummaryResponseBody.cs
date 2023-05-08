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

            [NameInMap("AntiBruteForceRuleCount")]
            [Validation(Required=false)]
            public string AntiBruteForceRuleCount { get; set; }

            [NameInMap("CustomEffectiveCount")]
            [Validation(Required=false)]
            public string CustomEffectiveCount { get; set; }

            [NameInMap("CustomRecordCount")]
            [Validation(Required=false)]
            public string CustomRecordCount { get; set; }

            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public int? EffectiveCount { get; set; }

            [NameInMap("SystemEffectiveCount")]
            [Validation(Required=false)]
            public string SystemEffectiveCount { get; set; }

            [NameInMap("SystemRecordCount")]
            [Validation(Required=false)]
            public string SystemRecordCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

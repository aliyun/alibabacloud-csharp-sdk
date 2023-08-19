// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBruteForceSummaryResponseBody : TeaModel {
        /// <summary>
        /// The statistics of IP address blocking policies.
        /// </summary>
        [NameInMap("BruteForceSummary")]
        [Validation(Required=false)]
        public DescribeBruteForceSummaryResponseBodyBruteForceSummary BruteForceSummary { get; set; }
        public class DescribeBruteForceSummaryResponseBodyBruteForceSummary : TeaModel {
            /// <summary>
            /// The number of anti-brute force IP blocking policies.
            /// </summary>
            [NameInMap("AllStrategyCount")]
            [Validation(Required=false)]
            public int? AllStrategyCount { get; set; }

            /// <summary>
            /// The number of defense policies.
            /// </summary>
            [NameInMap("AntiBruteForceRuleCount")]
            [Validation(Required=false)]
            public string AntiBruteForceRuleCount { get; set; }

            /// <summary>
            /// The number of custom blocking rules that are in effect.
            /// </summary>
            [NameInMap("CustomEffectiveCount")]
            [Validation(Required=false)]
            public string CustomEffectiveCount { get; set; }

            /// <summary>
            /// The number of custom blocking rules.
            /// </summary>
            [NameInMap("CustomRecordCount")]
            [Validation(Required=false)]
            public string CustomRecordCount { get; set; }

            /// <summary>
            /// The number of anti-brute force IP blocking policies enabled.
            /// </summary>
            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public int? EffectiveCount { get; set; }

            /// <summary>
            /// The number of system blocking rules that are in effect.
            /// </summary>
            [NameInMap("SystemEffectiveCount")]
            [Validation(Required=false)]
            public string SystemEffectiveCount { get; set; }

            /// <summary>
            /// The number of system blocking rules.
            /// </summary>
            [NameInMap("SystemRecordCount")]
            [Validation(Required=false)]
            public string SystemRecordCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

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
            /// The total number of IP address blocking policies.
            /// </summary>
            [NameInMap("AllStrategyCount")]
            [Validation(Required=false)]
            public int? AllStrategyCount { get; set; }

            /// <summary>
            /// The number of enabled IP address blocking policies.
            /// </summary>
            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public int? EffectiveCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

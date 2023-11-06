// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateComplianceSummaryResponseBody : TeaModel {
        /// <summary>
        /// The compliance statistics.
        /// </summary>
        [NameInMap("ComplianceSummary")]
        [Validation(Required=false)]
        public GetAggregateComplianceSummaryResponseBodyComplianceSummary ComplianceSummary { get; set; }
        public class GetAggregateComplianceSummaryResponseBodyComplianceSummary : TeaModel {
            /// <summary>
            /// The summary of compliance statistics from the rule dimension.
            /// </summary>
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=false)]
            public GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                /// <summary>
                /// The time when the compliance statistics were collected. Unit: milliseconds.
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// The number of compliant rules.
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// The number of non-compliant rules.
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// The total number of rules.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The summary of compliance statistics from the resource dimension.
            /// </summary>
            [NameInMap("ComplianceSummaryByResource")]
            [Validation(Required=false)]
            public GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource : TeaModel {
                /// <summary>
                /// The time when the compliance statistics were collected. Unit: milliseconds.
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// The number of compliant resources.
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// The number of non-compliant resources.
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// The total number of resources.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

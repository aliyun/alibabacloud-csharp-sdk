// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetComplianceSummaryResponseBody : TeaModel {
        /// <summary>
        /// The summary of compliance statistics.
        /// </summary>
        [NameInMap("ComplianceSummary")]
        [Validation(Required=false)]
        public GetComplianceSummaryResponseBodyComplianceSummary ComplianceSummary { get; set; }
        public class GetComplianceSummaryResponseBodyComplianceSummary : TeaModel {
            /// <summary>
            /// The summary of compliance statistics from the rule dimension.
            /// </summary>
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=false)]
            public GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                /// <summary>
                /// The time when the compliance summary was generated. Unit: milliseconds.
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// The number of rules evaluated as compliant.
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// The number of rules evaluated as non-compliant.
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
            public GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource : TeaModel {
                /// <summary>
                /// The time when the compliance summary was generated. Unit: milliseconds.
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// The number of resources evaluated as compliant.
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// The number of resources evaluated as non-compliant.
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

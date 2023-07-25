// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAccountComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// The compliance evaluation results of member accounts for which the compliance package takes effect in an account group.
        /// </summary>
        [NameInMap("AccountComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult AccountComplianceResult { get; set; }
        public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult : TeaModel {
            /// <summary>
            /// The compliance evaluation result of member accounts.
            /// </summary>
            [NameInMap("AccountCompliances")]
            [Validation(Required=false)]
            public List<GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances> AccountCompliances { get; set; }
            public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances : TeaModel {
                /// <summary>
                /// The ID of the member account in the account group.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The name of the member account in the account group.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The compliance evaluation result. Valid values:
                /// 
                /// *   COMPLIANT: The resource was evaluated as compliant.
                /// *   NON_COMPLIANT: The resource was evaluated as incompliant.
                /// *   NOT_APPLICABLE: The rule did not apply to your resource.
                /// *   INSUFFICIENT_DATA: No resource data was available.
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

            }

            /// <summary>
            /// The ID of the compliance package.
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// The number of non-compliant member accounts.
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// The total number of member accounts.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

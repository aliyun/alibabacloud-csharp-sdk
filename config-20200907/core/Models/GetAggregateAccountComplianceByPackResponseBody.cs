// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAccountComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// The compliance evaluation results of member accounts monitored by the compliance package.
        /// </summary>
        [NameInMap("AccountComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult AccountComplianceResult { get; set; }
        public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult : TeaModel {
            /// <summary>
            /// The information about the compliance evaluation result of member account.
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
                /// *   COMPLIANT: The resources of the member accounts are evaluated as compliant.
                /// *   NON_COMPLIANT: The resources of the member account are evaluated as non-compliant.
                /// *   NOT_APPLICABLE: The rules do not apply to the resources of the member account.
                /// *   INSUFFICIENT_DATA: No resource data is available.
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
            /// The total number of monitored member accounts.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

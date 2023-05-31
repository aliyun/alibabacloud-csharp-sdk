// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the summary information about the configuration checks on cloud services.
        /// </summary>
        [NameInMap("Summarys")]
        [Validation(Required=false)]
        public List<GetCheckSummaryResponseBodySummarys> Summarys { get; set; }
        public class GetCheckSummaryResponseBodySummarys : TeaModel {
            /// <summary>
            /// The number of detected risk items.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// The number of check items that pass the check.
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public long? PassCount { get; set; }

            /// <summary>
            /// An array that consist of the standard IDs of check items.
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckSummaryResponseBodySummarysStandards> Standards { get; set; }
            public class GetCheckSummaryResponseBodySummarysStandards : TeaModel {
                /// <summary>
                /// The number of risk items.
                /// </summary>
                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public int? FailCount { get; set; }

                /// <summary>
                /// The ID of the check item.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The number of passed check items.
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// The number of **high-risk** items.
                /// </summary>
                [NameInMap("RiskLevelHighCount")]
                [Validation(Required=false)]
                public int? RiskLevelHighCount { get; set; }

                /// <summary>
                /// The number of **low-risk** items.
                /// </summary>
                [NameInMap("RiskLevelLowCount")]
                [Validation(Required=false)]
                public int? RiskLevelLowCount { get; set; }

                /// <summary>
                /// The number of **medium-risk** items.
                /// </summary>
                [NameInMap("RiskLevelMediumCount")]
                [Validation(Required=false)]
                public int? RiskLevelMediumCount { get; set; }

                /// <summary>
                /// The name of the check item.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

            }

            /// <summary>
            /// The type of the check item. Valid values:
            /// 
            /// *   **COMPLIANCE**: compliance
            /// *   **RISK**: security risk
            /// *   **IDENTITY_PERMISSION**: identity and permission
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

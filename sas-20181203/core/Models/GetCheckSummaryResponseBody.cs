// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        [NameInMap("OverallItemStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallItemStatistic OverallItemStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallItemStatistic : TeaModel {
            [NameInMap("ReleaseCount")]
            [Validation(Required=false)]
            public int? ReleaseCount { get; set; }

            [NameInMap("ResultCount")]
            [Validation(Required=false)]
            public int? ResultCount { get; set; }

        }

        /// <summary>
        /// overall risk statistics of check items.
        /// </summary>
        [NameInMap("OverallStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallStatistic OverallStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallStatistic : TeaModel {
            /// <summary>
            /// The number of unchecked check items.
            /// </summary>
            [NameInMap("NotCheckCount")]
            [Validation(Required=false)]
            public int? NotCheckCount { get; set; }

            /// <summary>
            /// The number of unchecked high-risk check items.
            /// </summary>
            [NameInMap("NotCheckHighCount")]
            [Validation(Required=false)]
            public int? NotCheckHighCount { get; set; }

            /// <summary>
            /// The number of unchecked low-risk check items.
            /// </summary>
            [NameInMap("NotCheckLowCount")]
            [Validation(Required=false)]
            public int? NotCheckLowCount { get; set; }

            /// <summary>
            /// The number of unchecked medium-risk check items.
            /// </summary>
            [NameInMap("NotCheckMediumCount")]
            [Validation(Required=false)]
            public int? NotCheckMediumCount { get; set; }

            /// <summary>
            /// The number of check items that failed to pass the check.
            /// </summary>
            [NameInMap("NotPassCount")]
            [Validation(Required=false)]
            public int? NotPassCount { get; set; }

            /// <summary>
            /// The number of high-risk check items that failed to pass the check.
            /// </summary>
            [NameInMap("NotPassHighCount")]
            [Validation(Required=false)]
            public int? NotPassHighCount { get; set; }

            /// <summary>
            /// The number of low-risk check items that failed to pass the check.
            /// </summary>
            [NameInMap("NotPassLowCount")]
            [Validation(Required=false)]
            public int? NotPassLowCount { get; set; }

            /// <summary>
            /// The number of low-risk check items that failed to pass the check.
            /// </summary>
            [NameInMap("NotPassMediumCount")]
            [Validation(Required=false)]
            public int? NotPassMediumCount { get; set; }

            /// <summary>
            /// The number of check items that passed the check.
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// The number off high-risk check items that passed the check.
            /// </summary>
            [NameInMap("PassHighCount")]
            [Validation(Required=false)]
            public int? PassHighCount { get; set; }

            /// <summary>
            /// The number off low-risk check items that passed the check.
            /// </summary>
            [NameInMap("PassLowCount")]
            [Validation(Required=false)]
            public int? PassLowCount { get; set; }

            /// <summary>
            /// The number off medium-risk check items that passed the check.
            /// </summary>
            [NameInMap("PassMediumCount")]
            [Validation(Required=false)]
            public int? PassMediumCount { get; set; }

        }

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
            /// The information about the check items.
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
                /// The number of check items that passed the check.
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

                /// <summary>
                /// Risk statistics of check items within the same standard.
                /// </summary>
                [NameInMap("StandardStatistic")]
                [Validation(Required=false)]
                public GetCheckSummaryResponseBodySummarysStandardsStandardStatistic StandardStatistic { get; set; }
                public class GetCheckSummaryResponseBodySummarysStandardsStandardStatistic : TeaModel {
                    /// <summary>
                    /// The number of unchecked check items.
                    /// </summary>
                    [NameInMap("NotCheckCount")]
                    [Validation(Required=false)]
                    public int? NotCheckCount { get; set; }

                    /// <summary>
                    /// The number of unchecked high-risk check items.
                    /// </summary>
                    [NameInMap("NotCheckHighCount")]
                    [Validation(Required=false)]
                    public int? NotCheckHighCount { get; set; }

                    /// <summary>
                    /// The number of unchecked low-risk check items.
                    /// </summary>
                    [NameInMap("NotCheckLowCount")]
                    [Validation(Required=false)]
                    public int? NotCheckLowCount { get; set; }

                    /// <summary>
                    /// The number of unchecked medium-risk check items.
                    /// </summary>
                    [NameInMap("NotCheckMediumCount")]
                    [Validation(Required=false)]
                    public int? NotCheckMediumCount { get; set; }

                    /// <summary>
                    /// The number of check items that failed to pass the check.
                    /// </summary>
                    [NameInMap("NotPassCount")]
                    [Validation(Required=false)]
                    public int? NotPassCount { get; set; }

                    /// <summary>
                    /// The number of high-risk check items that failed to pass the check.
                    /// </summary>
                    [NameInMap("NotPassHighCount")]
                    [Validation(Required=false)]
                    public int? NotPassHighCount { get; set; }

                    /// <summary>
                    /// The number of low-risk check items that failed to pass the check.
                    /// </summary>
                    [NameInMap("NotPassLowCount")]
                    [Validation(Required=false)]
                    public int? NotPassLowCount { get; set; }

                    /// <summary>
                    /// The number of medium-risk check items that failed to pass the check.
                    /// </summary>
                    [NameInMap("NotPassMediumCount")]
                    [Validation(Required=false)]
                    public int? NotPassMediumCount { get; set; }

                    /// <summary>
                    /// The number of check items that passed the check.
                    /// </summary>
                    [NameInMap("PassCount")]
                    [Validation(Required=false)]
                    public int? PassCount { get; set; }

                    /// <summary>
                    /// The number off high-risk check items that passed the check.
                    /// </summary>
                    [NameInMap("PassHighCount")]
                    [Validation(Required=false)]
                    public int? PassHighCount { get; set; }

                    /// <summary>
                    /// The number off low-risk check items that passed the check.
                    /// </summary>
                    [NameInMap("PassLowCount")]
                    [Validation(Required=false)]
                    public int? PassLowCount { get; set; }

                    /// <summary>
                    /// The number off medium-risk check items that passed the check.
                    /// </summary>
                    [NameInMap("PassMediumCount")]
                    [Validation(Required=false)]
                    public int? PassMediumCount { get; set; }

                }

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

            /// <summary>
            /// Risk statistics of check items within the same type.
            /// </summary>
            [NameInMap("TypeStatistic")]
            [Validation(Required=false)]
            public GetCheckSummaryResponseBodySummarysTypeStatistic TypeStatistic { get; set; }
            public class GetCheckSummaryResponseBodySummarysTypeStatistic : TeaModel {
                /// <summary>
                /// The number of unchecked check items.
                /// </summary>
                [NameInMap("NotCheckCount")]
                [Validation(Required=false)]
                public int? NotCheckCount { get; set; }

                /// <summary>
                /// The number of unchecked high-risk check items.
                /// </summary>
                [NameInMap("NotCheckHighCount")]
                [Validation(Required=false)]
                public int? NotCheckHighCount { get; set; }

                /// <summary>
                /// The number of unchecked low-risk check items.
                /// </summary>
                [NameInMap("NotCheckLowCount")]
                [Validation(Required=false)]
                public int? NotCheckLowCount { get; set; }

                /// <summary>
                /// The number of unchecked medium-risk check items.
                /// </summary>
                [NameInMap("NotCheckMediumCount")]
                [Validation(Required=false)]
                public int? NotCheckMediumCount { get; set; }

                /// <summary>
                /// The number of check items that failed to pass the check.
                /// </summary>
                [NameInMap("NotPassCount")]
                [Validation(Required=false)]
                public int? NotPassCount { get; set; }

                /// <summary>
                /// The number of high-risk check items that failed to pass the check.
                /// </summary>
                [NameInMap("NotPassHighCount")]
                [Validation(Required=false)]
                public int? NotPassHighCount { get; set; }

                /// <summary>
                /// The number of low-risk check items that failed to pass the check.
                /// </summary>
                [NameInMap("NotPassLowCount")]
                [Validation(Required=false)]
                public int? NotPassLowCount { get; set; }

                /// <summary>
                /// The number of medium-risk check items that failed to pass the check.
                /// </summary>
                [NameInMap("NotPassMediumCount")]
                [Validation(Required=false)]
                public int? NotPassMediumCount { get; set; }

                /// <summary>
                /// The number of check items that passed the check.
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// The number off high-risk check items that passed the check.
                /// </summary>
                [NameInMap("PassHighCount")]
                [Validation(Required=false)]
                public int? PassHighCount { get; set; }

                /// <summary>
                /// The number off low-risk check items that passed the check.
                /// </summary>
                [NameInMap("PassLowCount")]
                [Validation(Required=false)]
                public int? PassLowCount { get; set; }

                /// <summary>
                /// The number off medium-risk check items that passed the check.
                /// </summary>
                [NameInMap("PassMediumCount")]
                [Validation(Required=false)]
                public int? PassMediumCount { get; set; }

            }

        }

    }

}

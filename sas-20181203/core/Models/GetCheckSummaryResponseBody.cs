// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        [NameInMap("OverallStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallStatistic OverallStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallStatistic : TeaModel {
            [NameInMap("NotCheckCount")]
            [Validation(Required=false)]
            public int? NotCheckCount { get; set; }

            [NameInMap("NotCheckHighCount")]
            [Validation(Required=false)]
            public int? NotCheckHighCount { get; set; }

            [NameInMap("NotCheckLowCount")]
            [Validation(Required=false)]
            public int? NotCheckLowCount { get; set; }

            [NameInMap("NotCheckMediumCount")]
            [Validation(Required=false)]
            public int? NotCheckMediumCount { get; set; }

            [NameInMap("NotPassCount")]
            [Validation(Required=false)]
            public int? NotPassCount { get; set; }

            [NameInMap("NotPassHighCount")]
            [Validation(Required=false)]
            public int? NotPassHighCount { get; set; }

            [NameInMap("NotPassLowCount")]
            [Validation(Required=false)]
            public int? NotPassLowCount { get; set; }

            [NameInMap("NotPassMediumCount")]
            [Validation(Required=false)]
            public int? NotPassMediumCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            [NameInMap("PassHighCount")]
            [Validation(Required=false)]
            public int? PassHighCount { get; set; }

            [NameInMap("PassLowCount")]
            [Validation(Required=false)]
            public int? PassLowCount { get; set; }

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

                [NameInMap("StandardStatistic")]
                [Validation(Required=false)]
                public GetCheckSummaryResponseBodySummarysStandardsStandardStatistic StandardStatistic { get; set; }
                public class GetCheckSummaryResponseBodySummarysStandardsStandardStatistic : TeaModel {
                    [NameInMap("NotCheckCount")]
                    [Validation(Required=false)]
                    public int? NotCheckCount { get; set; }

                    [NameInMap("NotCheckHighCount")]
                    [Validation(Required=false)]
                    public int? NotCheckHighCount { get; set; }

                    [NameInMap("NotCheckLowCount")]
                    [Validation(Required=false)]
                    public int? NotCheckLowCount { get; set; }

                    [NameInMap("NotCheckMediumCount")]
                    [Validation(Required=false)]
                    public int? NotCheckMediumCount { get; set; }

                    [NameInMap("NotPassCount")]
                    [Validation(Required=false)]
                    public int? NotPassCount { get; set; }

                    [NameInMap("NotPassHighCount")]
                    [Validation(Required=false)]
                    public int? NotPassHighCount { get; set; }

                    [NameInMap("NotPassLowCount")]
                    [Validation(Required=false)]
                    public int? NotPassLowCount { get; set; }

                    [NameInMap("NotPassMediumCount")]
                    [Validation(Required=false)]
                    public int? NotPassMediumCount { get; set; }

                    [NameInMap("PassCount")]
                    [Validation(Required=false)]
                    public int? PassCount { get; set; }

                    [NameInMap("PassHighCount")]
                    [Validation(Required=false)]
                    public int? PassHighCount { get; set; }

                    [NameInMap("PassLowCount")]
                    [Validation(Required=false)]
                    public int? PassLowCount { get; set; }

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

            [NameInMap("TypeStatistic")]
            [Validation(Required=false)]
            public GetCheckSummaryResponseBodySummarysTypeStatistic TypeStatistic { get; set; }
            public class GetCheckSummaryResponseBodySummarysTypeStatistic : TeaModel {
                [NameInMap("NotCheckCount")]
                [Validation(Required=false)]
                public int? NotCheckCount { get; set; }

                [NameInMap("NotCheckHighCount")]
                [Validation(Required=false)]
                public int? NotCheckHighCount { get; set; }

                [NameInMap("NotCheckLowCount")]
                [Validation(Required=false)]
                public int? NotCheckLowCount { get; set; }

                [NameInMap("NotCheckMediumCount")]
                [Validation(Required=false)]
                public int? NotCheckMediumCount { get; set; }

                [NameInMap("NotPassCount")]
                [Validation(Required=false)]
                public int? NotPassCount { get; set; }

                [NameInMap("NotPassHighCount")]
                [Validation(Required=false)]
                public int? NotPassHighCount { get; set; }

                [NameInMap("NotPassLowCount")]
                [Validation(Required=false)]
                public int? NotPassLowCount { get; set; }

                [NameInMap("NotPassMediumCount")]
                [Validation(Required=false)]
                public int? NotPassMediumCount { get; set; }

                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                [NameInMap("PassHighCount")]
                [Validation(Required=false)]
                public int? PassHighCount { get; set; }

                [NameInMap("PassLowCount")]
                [Validation(Required=false)]
                public int? PassLowCount { get; set; }

                [NameInMap("PassMediumCount")]
                [Validation(Required=false)]
                public int? PassMediumCount { get; set; }

            }

        }

    }

}

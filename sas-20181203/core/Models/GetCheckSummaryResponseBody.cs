// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics about the number of check items.</para>
        /// </summary>
        [NameInMap("OverallItemStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallItemStatistic OverallItemStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallItemStatistic : TeaModel {
            /// <summary>
            /// <para>The number of check items supported by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>620</para>
            /// </summary>
            [NameInMap("ReleaseCount")]
            [Validation(Required=false)]
            public int? ReleaseCount { get; set; }

            /// <summary>
            /// <para>The number of check items available to you.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("ResultCount")]
            [Validation(Required=false)]
            public int? ResultCount { get; set; }

        }

        /// <summary>
        /// <para>The overall risk statistics.</para>
        /// </summary>
        [NameInMap("OverallStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallStatistic OverallStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallStatistic : TeaModel {
            /// <summary>
            /// <para>The number of unchecked check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NotCheckCount")]
            [Validation(Required=false)]
            public int? NotCheckCount { get; set; }

            /// <summary>
            /// <para>The number of unchecked high-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckHighCount")]
            [Validation(Required=false)]
            public int? NotCheckHighCount { get; set; }

            /// <summary>
            /// <para>The number of unchecked low-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckLowCount")]
            [Validation(Required=false)]
            public int? NotCheckLowCount { get; set; }

            /// <summary>
            /// <para>The number of unchecked medium-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckMediumCount")]
            [Validation(Required=false)]
            public int? NotCheckMediumCount { get; set; }

            /// <summary>
            /// <para>The number of check items that failed to pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NotPassCount")]
            [Validation(Required=false)]
            public int? NotPassCount { get; set; }

            /// <summary>
            /// <para>The number of high-risk check items that failed to pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassHighCount")]
            [Validation(Required=false)]
            public int? NotPassHighCount { get; set; }

            /// <summary>
            /// <para>The number of low-risk check items that failed to pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassLowCount")]
            [Validation(Required=false)]
            public int? NotPassLowCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk check items that failed to pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassMediumCount")]
            [Validation(Required=false)]
            public int? NotPassMediumCount { get; set; }

            /// <summary>
            /// <para>The number of check items that pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// <para>The number of high-risk check items that pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassHighCount")]
            [Validation(Required=false)]
            public int? PassHighCount { get; set; }

            /// <summary>
            /// <para>The number of low-risk check items that pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassLowCount")]
            [Validation(Required=false)]
            public int? PassLowCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk check items that pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassMediumCount")]
            [Validation(Required=false)]
            public int? PassMediumCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>843E4805-****-7EE12FA8DBFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The summary information about the configuration checks on cloud services.</para>
        /// </summary>
        [NameInMap("Summarys")]
        [Validation(Required=false)]
        public List<GetCheckSummaryResponseBodySummarys> Summarys { get; set; }
        public class GetCheckSummaryResponseBodySummarys : TeaModel {
            /// <summary>
            /// <para>The number of detected risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The number of check items that pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public long? PassCount { get; set; }

            /// <summary>
            /// <para>The information about the check items.</para>
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckSummaryResponseBodySummarysStandards> Standards { get; set; }
            public class GetCheckSummaryResponseBodySummarysStandards : TeaModel {
                /// <summary>
                /// <para>The number of check items that failed to pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public int? FailCount { get; set; }

                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of check items that pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// <para>The number of <b>high-risk</b> items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelHighCount")]
                [Validation(Required=false)]
                public int? RiskLevelHighCount { get; set; }

                /// <summary>
                /// <para>The number of <b>low-risk</b> items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelLowCount")]
                [Validation(Required=false)]
                public int? RiskLevelLowCount { get; set; }

                /// <summary>
                /// <para>The number of <b>medium-risk</b> items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelMediumCount")]
                [Validation(Required=false)]
                public int? RiskLevelMediumCount { get; set; }

                /// <summary>
                /// <para>The name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Identity and permission management</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The standard statistics of the check items.</para>
                /// </summary>
                [NameInMap("StandardStatistic")]
                [Validation(Required=false)]
                public GetCheckSummaryResponseBodySummarysStandardsStandardStatistic StandardStatistic { get; set; }
                public class GetCheckSummaryResponseBodySummarysStandardsStandardStatistic : TeaModel {
                    /// <summary>
                    /// <para>The number of unchecked check items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("NotCheckCount")]
                    [Validation(Required=false)]
                    public int? NotCheckCount { get; set; }

                    /// <summary>
                    /// <para>The number of unchecked high-risk check items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckHighCount")]
                    [Validation(Required=false)]
                    public int? NotCheckHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of unchecked low-risk check items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckLowCount")]
                    [Validation(Required=false)]
                    public int? NotCheckLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of unchecked medium-risk check items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckMediumCount")]
                    [Validation(Required=false)]
                    public int? NotCheckMediumCount { get; set; }

                    /// <summary>
                    /// <para>The number of check items that failed to pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("NotPassCount")]
                    [Validation(Required=false)]
                    public int? NotPassCount { get; set; }

                    /// <summary>
                    /// <para>The number of high-risk check items that failed to pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassHighCount")]
                    [Validation(Required=false)]
                    public int? NotPassHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of low-risk check items that failed to pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassLowCount")]
                    [Validation(Required=false)]
                    public int? NotPassLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of medium-risk check items that failed to pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassMediumCount")]
                    [Validation(Required=false)]
                    public int? NotPassMediumCount { get; set; }

                    /// <summary>
                    /// <para>The number of check items that pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("PassCount")]
                    [Validation(Required=false)]
                    public int? PassCount { get; set; }

                    /// <summary>
                    /// <para>The number of high-risk check items that pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PassHighCount")]
                    [Validation(Required=false)]
                    public int? PassHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of low-risk check items that pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PassLowCount")]
                    [Validation(Required=false)]
                    public int? PassLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of medium-risk check items that pass the check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PassMediumCount")]
                    [Validation(Required=false)]
                    public int? PassMediumCount { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMPLIANCE</b></description></item>
            /// <item><description><b>RISK</b></description></item>
            /// <item><description><b>IDENTITY_PERMISSION</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDENTITY_PERMISSION</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The risk statistics by type.</para>
            /// </summary>
            [NameInMap("TypeStatistic")]
            [Validation(Required=false)]
            public GetCheckSummaryResponseBodySummarysTypeStatistic TypeStatistic { get; set; }
            public class GetCheckSummaryResponseBodySummarysTypeStatistic : TeaModel {
                /// <summary>
                /// <para>The number of unchecked check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NotCheckCount")]
                [Validation(Required=false)]
                public int? NotCheckCount { get; set; }

                /// <summary>
                /// <para>The number of unchecked high-risk check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckHighCount")]
                [Validation(Required=false)]
                public int? NotCheckHighCount { get; set; }

                /// <summary>
                /// <para>The number of unchecked low-risk check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckLowCount")]
                [Validation(Required=false)]
                public int? NotCheckLowCount { get; set; }

                /// <summary>
                /// <para>The number of unchecked medium-risk check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckMediumCount")]
                [Validation(Required=false)]
                public int? NotCheckMediumCount { get; set; }

                /// <summary>
                /// <para>The number of check items that failed to pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NotPassCount")]
                [Validation(Required=false)]
                public int? NotPassCount { get; set; }

                /// <summary>
                /// <para>The number of high-risk check items that failed to pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassHighCount")]
                [Validation(Required=false)]
                public int? NotPassHighCount { get; set; }

                /// <summary>
                /// <para>The number of low-risk check items that failed to pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassLowCount")]
                [Validation(Required=false)]
                public int? NotPassLowCount { get; set; }

                /// <summary>
                /// <para>The number of medium-risk check items that failed to pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassMediumCount")]
                [Validation(Required=false)]
                public int? NotPassMediumCount { get; set; }

                /// <summary>
                /// <para>The number of check items that pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// <para>The number of high-risk check items that pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassHighCount")]
                [Validation(Required=false)]
                public int? PassHighCount { get; set; }

                /// <summary>
                /// <para>The number of low-risk check items that pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassLowCount")]
                [Validation(Required=false)]
                public int? PassLowCount { get; set; }

                /// <summary>
                /// <para>The number of medium-risk check items that pass the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassMediumCount")]
                [Validation(Required=false)]
                public int? PassMediumCount { get; set; }

            }

        }

    }

}

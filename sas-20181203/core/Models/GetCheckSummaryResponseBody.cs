// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics information related to the number of check items.</para>
        /// </summary>
        [NameInMap("OverallItemStatistic")]
        [Validation(Required=false)]
        public GetCheckSummaryResponseBodyOverallItemStatistic OverallItemStatistic { get; set; }
        public class GetCheckSummaryResponseBodyOverallItemStatistic : TeaModel {
            /// <summary>
            /// <para>The number of check items published by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>620</para>
            /// </summary>
            [NameInMap("ReleaseCount")]
            [Validation(Required=false)]
            public int? ReleaseCount { get; set; }

            /// <summary>
            /// <para>The number of check items currently owned by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("ResultCount")]
            [Validation(Required=false)]
            public int? ResultCount { get; set; }

        }

        /// <summary>
        /// <para>The overall risk statistics information.</para>
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
            /// <para>The number of unchecked check items with a high risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckHighCount")]
            [Validation(Required=false)]
            public int? NotCheckHighCount { get; set; }

            /// <summary>
            /// <para>The number of unchecked check items with a low risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckLowCount")]
            [Validation(Required=false)]
            public int? NotCheckLowCount { get; set; }

            /// <summary>
            /// <para>The number of unchecked check items with a medium risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotCheckMediumCount")]
            [Validation(Required=false)]
            public int? NotCheckMediumCount { get; set; }

            /// <summary>
            /// <para>The number of check items that failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NotPassCount")]
            [Validation(Required=false)]
            public int? NotPassCount { get; set; }

            /// <summary>
            /// <para>The number of failed check items with a high risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassHighCount")]
            [Validation(Required=false)]
            public int? NotPassHighCount { get; set; }

            /// <summary>
            /// <para>The number of failed check items with a low risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassLowCount")]
            [Validation(Required=false)]
            public int? NotPassLowCount { get; set; }

            /// <summary>
            /// <para>The number of failed check items with a medium risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassMediumCount")]
            [Validation(Required=false)]
            public int? NotPassMediumCount { get; set; }

            /// <summary>
            /// <para>The number of check items that passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// <para>The number of passed check items with a high risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassHighCount")]
            [Validation(Required=false)]
            public int? PassHighCount { get; set; }

            /// <summary>
            /// <para>The number of passed check items with a low risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassLowCount")]
            [Validation(Required=false)]
            public int? PassLowCount { get; set; }

            /// <summary>
            /// <para>The number of passed check items with a medium risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PassMediumCount")]
            [Validation(Required=false)]
            public int? PassMediumCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>843E4805-****-7EE12FA8DBFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The overview results.</para>
        /// </summary>
        [NameInMap("Summarys")]
        [Validation(Required=false)]
        public List<GetCheckSummaryResponseBodySummarys> Summarys { get; set; }
        public class GetCheckSummaryResponseBodySummarys : TeaModel {
            /// <summary>
            /// <para>The number of risk items detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The number of check items that passed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public long? PassCount { get; set; }

            /// <summary>
            /// <para>The standard output of check items.</para>
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckSummaryResponseBodySummarysStandards> Standards { get; set; }
            public class GetCheckSummaryResponseBodySummarysStandards : TeaModel {
                /// <summary>
                /// <para>The number of check items that failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public int? FailCount { get; set; }

                /// <summary>
                /// <para>The check item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of check items that passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// <para>The number of check items with a <b>high</b> risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelHighCount")]
                [Validation(Required=false)]
                public int? RiskLevelHighCount { get; set; }

                /// <summary>
                /// <para>The number of check items with a <b>low</b> risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelLowCount")]
                [Validation(Required=false)]
                public int? RiskLevelLowCount { get; set; }

                /// <summary>
                /// <para>The number of check items with a <b>medium</b> risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelMediumCount")]
                [Validation(Required=false)]
                public int? RiskLevelMediumCount { get; set; }

                /// <summary>
                /// <para>The check item name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>身份权限管理</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The risk statistics information for the standard.</para>
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
                    /// <para>The number of unchecked check items with a high risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckHighCount")]
                    [Validation(Required=false)]
                    public int? NotCheckHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of unchecked check items with a low risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckLowCount")]
                    [Validation(Required=false)]
                    public int? NotCheckLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of unchecked check items with a medium risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotCheckMediumCount")]
                    [Validation(Required=false)]
                    public int? NotCheckMediumCount { get; set; }

                    /// <summary>
                    /// <para>The number of check items that failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("NotPassCount")]
                    [Validation(Required=false)]
                    public int? NotPassCount { get; set; }

                    /// <summary>
                    /// <para>The number of failed check items with a high risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassHighCount")]
                    [Validation(Required=false)]
                    public int? NotPassHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of failed check items with a low risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassLowCount")]
                    [Validation(Required=false)]
                    public int? NotPassLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of failed check items with a medium risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotPassMediumCount")]
                    [Validation(Required=false)]
                    public int? NotPassMediumCount { get; set; }

                    /// <summary>
                    /// <para>The number of check items that passed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("PassCount")]
                    [Validation(Required=false)]
                    public int? PassCount { get; set; }

                    /// <summary>
                    /// <para>The number of passed check items with a high risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PassHighCount")]
                    [Validation(Required=false)]
                    public int? PassHighCount { get; set; }

                    /// <summary>
                    /// <para>The number of passed check items with a low risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PassLowCount")]
                    [Validation(Required=false)]
                    public int? PassLowCount { get; set; }

                    /// <summary>
                    /// <para>The number of passed check items with a medium risk level.</para>
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
            /// <para>The check item type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMPLIANCE</b>: Compliance.</description></item>
            /// <item><description><b>RISK</b>: Security risk.</description></item>
            /// <item><description><b>IDENTITY_PERMISSION</b>: Identity and access management.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDENTITY_PERMISSION</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The risk statistics information for the risk category.</para>
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
                /// <para>The number of unchecked check items with a high risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckHighCount")]
                [Validation(Required=false)]
                public int? NotCheckHighCount { get; set; }

                /// <summary>
                /// <para>The number of unchecked check items with a low risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckLowCount")]
                [Validation(Required=false)]
                public int? NotCheckLowCount { get; set; }

                /// <summary>
                /// <para>The number of unchecked check items with a medium risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotCheckMediumCount")]
                [Validation(Required=false)]
                public int? NotCheckMediumCount { get; set; }

                /// <summary>
                /// <para>The number of check items that failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NotPassCount")]
                [Validation(Required=false)]
                public int? NotPassCount { get; set; }

                /// <summary>
                /// <para>The number of failed check items with a high risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassHighCount")]
                [Validation(Required=false)]
                public int? NotPassHighCount { get; set; }

                /// <summary>
                /// <para>The number of failed check items with a low risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassLowCount")]
                [Validation(Required=false)]
                public int? NotPassLowCount { get; set; }

                /// <summary>
                /// <para>The number of failed check items with a medium risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NotPassMediumCount")]
                [Validation(Required=false)]
                public int? NotPassMediumCount { get; set; }

                /// <summary>
                /// <para>The number of check items that passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// <para>The number of passed check items with a high risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassHighCount")]
                [Validation(Required=false)]
                public int? PassHighCount { get; set; }

                /// <summary>
                /// <para>The number of passed check items with a low risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassLowCount")]
                [Validation(Required=false)]
                public int? PassLowCount { get; set; }

                /// <summary>
                /// <para>The number of passed check items with a medium risk level.</para>
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

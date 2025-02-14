// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckRiskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of risk scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>An array consisting of the statistics on check items that are used in risk scenarios.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCheckRiskStatisticsResponseBodyData> Data { get; set; }
        public class GetCheckRiskStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of high-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// <para>The number of low-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            /// <summary>
            /// <para>The number of passed check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>143</para>
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// <para>The name of the risk scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECURITY</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The statistics on check items that are used in the risk scenario by baseline type.</para>
            /// </summary>
            [NameInMap("SubStatistics")]
            [Validation(Required=false)]
            public List<GetCheckRiskStatisticsResponseBodyDataSubStatistics> SubStatistics { get; set; }
            public class GetCheckRiskStatisticsResponseBodyDataSubStatistics : TeaModel {
                /// <summary>
                /// <para>The name of the baseline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weak_password</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The number of high-risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HighWarningCount")]
                [Validation(Required=false)]
                public int? HighWarningCount { get; set; }

                /// <summary>
                /// <para>The number of low-risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LowWarningCount")]
                [Validation(Required=false)]
                public int? LowWarningCount { get; set; }

                /// <summary>
                /// <para>The number of medium-risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MediumWarningCount")]
                [Validation(Required=false)]
                public int? MediumWarningCount { get; set; }

                /// <summary>
                /// <para>The number of passed check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// <para>The total number of check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>The baseline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weak_password</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// <para>The total number of check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>219</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C455672-2490-5211-84EC-420C7818****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Historical check item statistics.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public GetCheckRiskStatisticsResponseBodySummary Summary { get; set; }
        public class GetCheckRiskStatisticsResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>Check items handled today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HandledCheckToday")]
            [Validation(Required=false)]
            public int? HandledCheckToday { get; set; }

            /// <summary>
            /// <para>A risk item exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HandledCheckTotal")]
            [Validation(Required=false)]
            public int? HandledCheckTotal { get; set; }

            /// <summary>
            /// <para>Total days since check items were handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("HandledDays")]
            [Validation(Required=false)]
            public int? HandledDays { get; set; }

            /// <summary>
            /// <para>Check items that failed to pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskCheckCnt")]
            [Validation(Required=false)]
            public int? RiskCheckCnt { get; set; }

            /// <summary>
            /// <para>Days since check items failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RiskDays")]
            [Validation(Required=false)]
            public int? RiskDays { get; set; }

            /// <summary>
            /// <para>Risks to be handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RiskWarningCnt")]
            [Validation(Required=false)]
            public int? RiskWarningCnt { get; set; }

        }

    }

}

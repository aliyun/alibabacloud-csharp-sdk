// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 09:36:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nir-38abb318b27b49cc9a01</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ni-8svmpe0yso2bhzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4838F3F2-30E1-5D82-B25A-B9FE33BC3E25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 09:35:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating</para>
        /// </description></item>
        /// <item><description><para>Active</para>
        /// </description></item>
        /// <item><description><para>Running</para>
        /// </description></item>
        /// <item><description><para>Inactive</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The summary information.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DescribeNisInspectionReportSummaryResponseBodySummary Summary { get; set; }
        public class DescribeNisInspectionReportSummaryResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>The number of inspection items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("CheckItemCount")]
            [Validation(Required=false)]
            public int? CheckItemCount { get; set; }

            /// <summary>
            /// <para>The number of inspected resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CheckResourceCount")]
            [Validation(Required=false)]
            public int? CheckResourceCount { get; set; }

            /// <summary>
            /// <para>The pass rate summary.</para>
            /// </summary>
            [NameInMap("PassRateSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary> PassRateSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary : TeaModel {
                /// <summary>
                /// <para>The pass rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.98</para>
                /// </summary>
                [NameInMap("PassRate")]
                [Validation(Required=false)]
                public double? PassRate { get; set; }

                /// <summary>
                /// <para>The scope of the pass rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Stability</para>
                /// </summary>
                [NameInMap("PassRateScope")]
                [Validation(Required=false)]
                public string PassRateScope { get; set; }

            }

            /// <summary>
            /// <para>The risk summary.</para>
            /// </summary>
            [NameInMap("RiskSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary> RiskSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary : TeaModel {
                /// <summary>
                /// <para>The number of resources associated with the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// <para>The number of risks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HighRisk</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The risk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StabilityRisk</para>
                /// </summary>
                [NameInMap("RiskType")]
                [Validation(Required=false)]
                public string RiskType { get; set; }

            }

        }

    }

}

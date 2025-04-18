// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-03 09:36:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nir-38abb318b27b49cc9a01</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ni-8svmpe0yso2bhzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4838F3F2-30E1-5D82-B25A-B9FE33BC3E25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-03 09:35:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DescribeNisInspectionReportSummaryResponseBodySummary Summary { get; set; }
        public class DescribeNisInspectionReportSummaryResponseBodySummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("CheckItemCount")]
            [Validation(Required=false)]
            public int? CheckItemCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CheckResourceCount")]
            [Validation(Required=false)]
            public int? CheckResourceCount { get; set; }

            [NameInMap("PassRateSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary> PassRateSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.98</para>
                /// </summary>
                [NameInMap("PassRate")]
                [Validation(Required=false)]
                public double? PassRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Stability</para>
                /// </summary>
                [NameInMap("PassRateScope")]
                [Validation(Required=false)]
                public string PassRateScope { get; set; }

            }

            [NameInMap("RiskSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary> RiskSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HighRisk</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
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

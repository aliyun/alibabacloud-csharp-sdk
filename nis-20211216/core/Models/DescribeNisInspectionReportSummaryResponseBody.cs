// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportSummaryResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DescribeNisInspectionReportSummaryResponseBodySummary Summary { get; set; }
        public class DescribeNisInspectionReportSummaryResponseBodySummary : TeaModel {
            [NameInMap("CheckItemCount")]
            [Validation(Required=false)]
            public int? CheckItemCount { get; set; }

            [NameInMap("CheckResourceCount")]
            [Validation(Required=false)]
            public int? CheckResourceCount { get; set; }

            [NameInMap("PassRateSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary> PassRateSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryPassRateSummary : TeaModel {
                [NameInMap("PassRate")]
                [Validation(Required=false)]
                public double? PassRate { get; set; }

                [NameInMap("PassRateScope")]
                [Validation(Required=false)]
                public string PassRateScope { get; set; }

            }

            [NameInMap("RiskSummary")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary> RiskSummary { get; set; }
            public class DescribeNisInspectionReportSummaryResponseBodySummaryRiskSummary : TeaModel {
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("RiskType")]
                [Validation(Required=false)]
                public string RiskType { get; set; }

            }

        }

    }

}

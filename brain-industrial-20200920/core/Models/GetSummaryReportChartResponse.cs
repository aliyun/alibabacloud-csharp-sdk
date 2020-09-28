// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetSummaryReportChartResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("SummaryLineChartDataRsp")]
        [Validation(Required=true)]
        public GetSummaryReportChartResponseSummaryLineChartDataRsp SummaryLineChartDataRsp { get; set; }
        public class GetSummaryReportChartResponseSummaryLineChartDataRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("SummaryLineChartData")]
            [Validation(Required=true)]
            public GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartData SummaryLineChartData { get; set; }
            public class GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartData : TeaModel {
                [NameInMap("MultipleScoreList")]
                [Validation(Required=true)]
                public List<GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataMultipleScoreList> MultipleScoreList { get; set; }
                public class GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataMultipleScoreList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                }

                [NameInMap("OperationRateList")]
                [Validation(Required=true)]
                public List<GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataOperationRateList> OperationRateList { get; set; }
                public class GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataOperationRateList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                }

                [NameInMap("PerformMetricsList")]
                [Validation(Required=true)]
                public List<GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataPerformMetricsList> PerformMetricsList { get; set; }
                public class GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataPerformMetricsList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                }

                [NameInMap("ValidOperationRateList")]
                [Validation(Required=true)]
                public List<GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataValidOperationRateList> ValidOperationRateList { get; set; }
                public class GetSummaryReportChartResponseSummaryLineChartDataRspSummaryLineChartDataValidOperationRateList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                }

            }
        };

    }

}

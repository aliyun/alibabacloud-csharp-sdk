// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetSummaryReportDataTrendResponse : TeaModel {
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

        [NameInMap("SummaryTrendData")]
        [Validation(Required=true)]
        public GetSummaryReportDataTrendResponseSummaryTrendData SummaryTrendData { get; set; }
        public class GetSummaryReportDataTrendResponseSummaryTrendData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("Data")]
            [Validation(Required=true)]
            public GetSummaryReportDataTrendResponseSummaryTrendDataData Data { get; set; }
            public class GetSummaryReportDataTrendResponseSummaryTrendDataData : TeaModel {
                [NameInMap("Op2")]
                [Validation(Required=true)]
                public List<GetSummaryReportDataTrendResponseSummaryTrendDataDataOp2> Op2 { get; set; }
                public class GetSummaryReportDataTrendResponseSummaryTrendDataDataOp2 : TeaModel {
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

                [NameInMap("Op")]
                [Validation(Required=true)]
                public List<GetSummaryReportDataTrendResponseSummaryTrendDataDataOp> Op { get; set; }
                public class GetSummaryReportDataTrendResponseSummaryTrendDataDataOp : TeaModel {
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

                [NameInMap("Op1")]
                [Validation(Required=true)]
                public List<GetSummaryReportDataTrendResponseSummaryTrendDataDataOp1> Op1 { get; set; }
                public class GetSummaryReportDataTrendResponseSummaryTrendDataDataOp1 : TeaModel {
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

                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<GetSummaryReportDataTrendResponseSummaryTrendDataDataPv> Pv { get; set; }
                public class GetSummaryReportDataTrendResponseSummaryTrendDataDataPv : TeaModel {
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

                [NameInMap("Sp")]
                [Validation(Required=true)]
                public List<GetSummaryReportDataTrendResponseSummaryTrendDataDataSp> Sp { get; set; }
                public class GetSummaryReportDataTrendResponseSummaryTrendDataDataSp : TeaModel {
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

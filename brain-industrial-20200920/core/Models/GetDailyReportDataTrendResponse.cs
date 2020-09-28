// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDailyReportDataTrendResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TagsValuesRsp")]
        [Validation(Required=true)]
        public GetDailyReportDataTrendResponseTagsValuesRsp TagsValuesRsp { get; set; }
        public class GetDailyReportDataTrendResponseTagsValuesRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("Data")]
            [Validation(Required=true)]
            public GetDailyReportDataTrendResponseTagsValuesRspData Data { get; set; }
            public class GetDailyReportDataTrendResponseTagsValuesRspData : TeaModel {
                [NameInMap("Op")]
                [Validation(Required=true)]
                public List<GetDailyReportDataTrendResponseTagsValuesRspDataOp> Op { get; set; }
                public class GetDailyReportDataTrendResponseTagsValuesRspDataOp : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Op1")]
                [Validation(Required=true)]
                public List<GetDailyReportDataTrendResponseTagsValuesRspDataOp1> Op1 { get; set; }
                public class GetDailyReportDataTrendResponseTagsValuesRspDataOp1 : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Op2")]
                [Validation(Required=true)]
                public List<GetDailyReportDataTrendResponseTagsValuesRspDataOp2> Op2 { get; set; }
                public class GetDailyReportDataTrendResponseTagsValuesRspDataOp2 : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Sp")]
                [Validation(Required=true)]
                public List<GetDailyReportDataTrendResponseTagsValuesRspDataSp> Sp { get; set; }
                public class GetDailyReportDataTrendResponseTagsValuesRspDataSp : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<GetDailyReportDataTrendResponseTagsValuesRspDataPv> Pv { get; set; }
                public class GetDailyReportDataTrendResponseTagsValuesRspDataPv : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

            }
        };

    }

}

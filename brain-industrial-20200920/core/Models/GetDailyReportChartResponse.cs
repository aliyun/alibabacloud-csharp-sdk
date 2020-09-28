// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDailyReportChartResponse : TeaModel {
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

        [NameInMap("DayLineChartDataRsp")]
        [Validation(Required=true)]
        public GetDailyReportChartResponseDayLineChartDataRsp DayLineChartDataRsp { get; set; }
        public class GetDailyReportChartResponseDayLineChartDataRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("DayLineChartData")]
            [Validation(Required=true)]
            public GetDailyReportChartResponseDayLineChartDataRspDayLineChartData DayLineChartData { get; set; }
            public class GetDailyReportChartResponseDayLineChartDataRspDayLineChartData : TeaModel {
                [NameInMap("Harris")]
                [Validation(Required=true)]
                public List<GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataHarris> Harris { get; set; }
                public class GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataHarris : TeaModel {
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

                [NameInMap("CloseLoop")]
                [Validation(Required=true)]
                public List<GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataCloseLoop> CloseLoop { get; set; }
                public class GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataCloseLoop : TeaModel {
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

                [NameInMap("Bode")]
                [Validation(Required=true)]
                public List<GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataBode> Bode { get; set; }
                public class GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataBode : TeaModel {
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

                [NameInMap("ResidualStage")]
                [Validation(Required=true)]
                public List<GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataResidualStage> ResidualStage { get; set; }
                public class GetDailyReportChartResponseDayLineChartDataRspDayLineChartDataResidualStage : TeaModel {
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

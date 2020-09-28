// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPidProjectReportOverviewResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetPidProjectReportOverviewResponseData Data { get; set; }
        public class GetPidProjectReportOverviewResponseData : TeaModel {
            [NameInMap("PerformMetrics")]
            [Validation(Required=true)]
            public float? PerformMetrics { get; set; }
            [NameInMap("OperationRate")]
            [Validation(Required=true)]
            public long OperationRate { get; set; }
            [NameInMap("AllPerformMetricsList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataAllPerformMetricsList> AllPerformMetricsList { get; set; }
            public class GetPidProjectReportOverviewResponseDataAllPerformMetricsList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("KeyPerformMetricsList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataKeyPerformMetricsList> KeyPerformMetricsList { get; set; }
            public class GetPidProjectReportOverviewResponseDataKeyPerformMetricsList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("AllOperationRateList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataAllOperationRateList> AllOperationRateList { get; set; }
            public class GetPidProjectReportOverviewResponseDataAllOperationRateList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("KeyOperationRateList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataKeyOperationRateList> KeyOperationRateList { get; set; }
            public class GetPidProjectReportOverviewResponseDataKeyOperationRateList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("LoopScoreList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataLoopScoreList> LoopScoreList { get; set; }
            public class GetPidProjectReportOverviewResponseDataLoopScoreList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("LoopOperationRateList")]
            [Validation(Required=true)]
            public List<GetPidProjectReportOverviewResponseDataLoopOperationRateList> LoopOperationRateList { get; set; }
            public class GetPidProjectReportOverviewResponseDataLoopOperationRateList : TeaModel {
                public string Xlabel { get; set; }
                public string Ylabel { get; set; }
            }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public GetPidProjectReportOverviewResponseDataStatus Status { get; set; }
            public class GetPidProjectReportOverviewResponseDataStatus : TeaModel {
                [NameInMap("All")]
                [Validation(Required=true)]
                public GetPidProjectReportOverviewResponseDataStatusAll All { get; set; }
                public class GetPidProjectReportOverviewResponseDataStatusAll : TeaModel {
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public long Best { get; set; }
                    [NameInMap("Good")]
                    [Validation(Required=true)]
                    public long Good { get; set; }
                    [NameInMap("Middle")]
                    [Validation(Required=true)]
                    public long Middle { get; set; }
                    [NameInMap("Bad")]
                    [Validation(Required=true)]
                    public long Bad { get; set; }
                    [NameInMap("OpenLoop")]
                    [Validation(Required=true)]
                    public long OpenLoop { get; set; }
                };

                [NameInMap("Key")]
                [Validation(Required=true)]
                public GetPidProjectReportOverviewResponseDataStatusKey Key { get; set; }
                public class GetPidProjectReportOverviewResponseDataStatusKey : TeaModel {
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public long Best { get; set; }
                    [NameInMap("Good")]
                    [Validation(Required=true)]
                    public long Good { get; set; }
                    [NameInMap("Middle")]
                    [Validation(Required=true)]
                    public long Middle { get; set; }
                    [NameInMap("Bad")]
                    [Validation(Required=true)]
                    public long Bad { get; set; }
                    [NameInMap("OpenLoop")]
                    [Validation(Required=true)]
                    public long OpenLoop { get; set; }
                };

            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCardStatusStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardStatusStatisticsResponseBodyData Data { get; set; }
        public class GetCardStatusStatisticsResponseBodyData : TeaModel {
            [NameInMap("ErrorStopStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataErrorStopStatisticsDTO ErrorStopStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataErrorStopStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ExhaustStopStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataExhaustStopStatisticsDTO ExhaustStopStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataExhaustStopStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ExpireStopStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataExpireStopStatisticsDTO ExpireStopStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataExpireStopStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("FlowOutStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataFlowOutStatisticsDTO FlowOutStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataFlowOutStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ManageStopStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataManageStopStatisticsDTO ManageStopStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataManageStopStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("RiskWaringStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataRiskWaringStatisticsDTO RiskWaringStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataRiskWaringStatisticsDTO : TeaModel {
                [NameInMap("LeftFlowPercentageWarnCount")]
                [Validation(Required=false)]
                public long? LeftFlowPercentageWarnCount { get; set; }

                [NameInMap("StopCount")]
                [Validation(Required=false)]
                public long? StopCount { get; set; }

                [NameInMap("WaringTotalCount")]
                [Validation(Required=false)]
                public long? WaringTotalCount { get; set; }

                [NameInMap("WarningCount")]
                [Validation(Required=false)]
                public long? WarningCount { get; set; }

            }

            [NameInMap("SingCardPeriodLeftFlowWarnDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataSingCardPeriodLeftFlowWarnDTO SingCardPeriodLeftFlowWarnDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataSingCardPeriodLeftFlowWarnDTO : TeaModel {
                [NameInMap("LessFlowPercentage10Count")]
                [Validation(Required=false)]
                public long? LessFlowPercentage10Count { get; set; }

                [NameInMap("LessFlowPercentage30Count")]
                [Validation(Required=false)]
                public long? LessFlowPercentage30Count { get; set; }

            }

            [NameInMap("UnCertifiedStopStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataUnCertifiedStopStatisticsDTO UnCertifiedStopStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataUnCertifiedStopStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("UnbindResumeStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataUnbindResumeStatisticsDTO UnbindResumeStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataUnbindResumeStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("WeekWarnStatisticsDTO")]
            [Validation(Required=false)]
            public GetCardStatusStatisticsResponseBodyDataWeekWarnStatisticsDTO WeekWarnStatisticsDTO { get; set; }
            public class GetCardStatusStatisticsResponseBodyDataWeekWarnStatisticsDTO : TeaModel {
                [NameInMap("PoolCount")]
                [Validation(Required=false)]
                public long? PoolCount { get; set; }

                [NameInMap("SameFlowCardCount")]
                [Validation(Required=false)]
                public long? SameFlowCardCount { get; set; }

                [NameInMap("SingleCardCount")]
                [Validation(Required=false)]
                public long? SingleCardCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

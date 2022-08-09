// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class CardStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CardStatisticsResponseBodyData Data { get; set; }
        public class CardStatisticsResponseBodyData : TeaModel {
            [NameInMap("ErrorStopStatisticsDTO")]
            [Validation(Required=false)]
            public CardStatisticsResponseBodyDataErrorStopStatisticsDTO ErrorStopStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataErrorStopStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataExhaustStopStatisticsDTO ExhaustStopStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataExhaustStopStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataExpireStopStatisticsDTO ExpireStopStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataExpireStopStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataFlowOutStatisticsDTO FlowOutStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataFlowOutStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataManageStopStatisticsDTO ManageStopStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataManageStopStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataRiskWaringStatisticsDTO RiskWaringStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataRiskWaringStatisticsDTO : TeaModel {
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
            [NameInMap("UnCertifiedStopStatisticsDTO")]
            [Validation(Required=false)]
            public CardStatisticsResponseBodyDataUnCertifiedStopStatisticsDTO UnCertifiedStopStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataUnCertifiedStopStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataUnbindResumeStatisticsDTO UnbindResumeStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataUnbindResumeStatisticsDTO : TeaModel {
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
            public CardStatisticsResponseBodyDataWeekWarnStatisticsDTO WeekWarnStatisticsDTO { get; set; }
            public class CardStatisticsResponseBodyDataWeekWarnStatisticsDTO : TeaModel {
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
        };

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

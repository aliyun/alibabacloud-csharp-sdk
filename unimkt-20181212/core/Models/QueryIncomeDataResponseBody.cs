// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryIncomeDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryIncomeDataResponseBodyModel Model { get; set; }
        public class QueryIncomeDataResponseBodyModel : TeaModel {
            [NameInMap("AccEstIncomeRate")]
            [Validation(Required=false)]
            public string AccEstIncomeRate { get; set; }

            [NameInMap("AccessStatus")]
            [Validation(Required=false)]
            public long? AccessStatus { get; set; }

            [NameInMap("AccumulatedIncome")]
            [Validation(Required=false)]
            public long? AccumulatedIncome { get; set; }

            [NameInMap("AdSlotClickRate")]
            [Validation(Required=false)]
            public string AdSlotClickRate { get; set; }

            [NameInMap("AdSlotHitRate")]
            [Validation(Required=false)]
            public string AdSlotHitRate { get; set; }

            [NameInMap("AdSlotHitTimes")]
            [Validation(Required=false)]
            public long? AdSlotHitTimes { get; set; }

            [NameInMap("AdSlotId")]
            [Validation(Required=false)]
            public string AdSlotId { get; set; }

            [NameInMap("AdSlotName")]
            [Validation(Required=false)]
            public string AdSlotName { get; set; }

            [NameInMap("AdSlotRequests")]
            [Validation(Required=false)]
            public long? AdSlotRequests { get; set; }

            [NameInMap("AdSlotShowRate")]
            [Validation(Required=false)]
            public string AdSlotShowRate { get; set; }

            [NameInMap("AdSlotType")]
            [Validation(Required=false)]
            public string AdSlotType { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("ClickTimes")]
            [Validation(Required=false)]
            public long? ClickTimes { get; set; }

            [NameInMap("Ecpm")]
            [Validation(Required=false)]
            public long? Ecpm { get; set; }

            [NameInMap("EcpmRate")]
            [Validation(Required=false)]
            public string EcpmRate { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("EstimatedIncome")]
            [Validation(Required=false)]
            public long? EstimatedIncome { get; set; }

            [NameInMap("LastDayEstimatedIncome")]
            [Validation(Required=false)]
            public long? LastDayEstimatedIncome { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaName")]
            [Validation(Required=false)]
            public string MediaName { get; set; }

            [NameInMap("ShowTimes")]
            [Validation(Required=false)]
            public long? ShowTimes { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("ThisDaysEstIncome")]
            [Validation(Required=false)]
            public long? ThisDaysEstIncome { get; set; }

            [NameInMap("ThisDaysEstIncomeRate")]
            [Validation(Required=false)]
            public string ThisDaysEstIncomeRate { get; set; }

            [NameInMap("ThisMonEstIncomeRate")]
            [Validation(Required=false)]
            public string ThisMonEstIncomeRate { get; set; }

            [NameInMap("ThisMonEstimatedIncome")]
            [Validation(Required=false)]
            public long? ThisMonEstimatedIncome { get; set; }

            [NameInMap("ThisYearEstIncomeRate")]
            [Validation(Required=false)]
            public string ThisYearEstIncomeRate { get; set; }

            [NameInMap("ThisYearIncome")]
            [Validation(Required=false)]
            public long? ThisYearIncome { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

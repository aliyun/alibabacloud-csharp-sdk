// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListSuccessInstanceAmountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=true)]
        public ListSuccessInstanceAmountResponseInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class ListSuccessInstanceAmountResponseInstanceStatusTrend : TeaModel {
            [NameInMap("TodayTrend")]
            [Validation(Required=true)]
            public List<ListSuccessInstanceAmountResponseInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseInstanceStatusTrendTodayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("YesterdayTrend")]
            [Validation(Required=true)]
            public List<ListSuccessInstanceAmountResponseInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseInstanceStatusTrendYesterdayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("AvgTrend")]
            [Validation(Required=true)]
            public List<ListSuccessInstanceAmountResponseInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class ListSuccessInstanceAmountResponseInstanceStatusTrendAvgTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
        };

    }

}

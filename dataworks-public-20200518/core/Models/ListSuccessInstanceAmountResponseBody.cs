// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListSuccessInstanceAmountResponseBody : TeaModel {
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public ListSuccessInstanceAmountResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrend : TeaModel {
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

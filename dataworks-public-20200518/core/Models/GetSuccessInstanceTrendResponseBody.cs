// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSuccessInstanceTrendResponseBody : TeaModel {
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public GetSuccessInstanceTrendResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrend : TeaModel {
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

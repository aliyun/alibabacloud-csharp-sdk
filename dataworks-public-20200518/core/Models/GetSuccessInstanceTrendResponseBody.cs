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
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

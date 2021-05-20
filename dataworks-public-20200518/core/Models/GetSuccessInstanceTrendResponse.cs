// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSuccessInstanceTrendResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=true)]
        public GetSuccessInstanceTrendResponseInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class GetSuccessInstanceTrendResponseInstanceStatusTrend : TeaModel {
            [NameInMap("TodayTrend")]
            [Validation(Required=true)]
            public List<GetSuccessInstanceTrendResponseInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseInstanceStatusTrendTodayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("YesterdayTrend")]
            [Validation(Required=true)]
            public List<GetSuccessInstanceTrendResponseInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseInstanceStatusTrendYesterdayTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
            [NameInMap("AvgTrend")]
            [Validation(Required=true)]
            public List<GetSuccessInstanceTrendResponseInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class GetSuccessInstanceTrendResponseInstanceStatusTrendAvgTrend : TeaModel {
                public int? Count { get; set; }
                public string TimePoint { get; set; }
            }
        };

    }

}

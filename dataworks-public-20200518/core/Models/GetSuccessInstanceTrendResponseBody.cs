// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSuccessInstanceTrendResponseBody : TeaModel {
        /// <summary>
        /// The trend of statistics on the instance status in different time periods.
        /// </summary>
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public GetSuccessInstanceTrendResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrend : TeaModel {
            /// <summary>
            /// The average trend.
            /// </summary>
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. Valid values: 00:00 to 23:00.
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// The trend on the current day.
            /// </summary>
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. Valid values: 00:00 to 23:00.
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// The trend on the previous day.
            /// </summary>
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. Valid values: 00:00 to 23:00.
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

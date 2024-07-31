// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListSuccessInstanceAmountResponseBody : TeaModel {
        /// <summary>
        /// Indicates the trend of the number of auto triggered node instances that are successfully run every hour on the hour of the current day.
        /// </summary>
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public ListSuccessInstanceAmountResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrend : TeaModel {
            /// <summary>
            /// The average trend.
            /// </summary>
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                /// <summary>
                /// The number of instances that are successfully run.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. The value is an exact hour that ranges from 00:00 to 23:00, such as 00:00, 01:00, or 02:00.
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// The trend of the number of auto triggered node instances that are successfully run on the current day.
            /// </summary>
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                /// <summary>
                /// The number of instances that are successfully run.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. The value is an exact hour that ranges from 00:00 to 23:00, such as 00:00, 01:00, or 02:00.
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// The trend of the number of auto triggered node instances that are successfully run one day earlier than the current day.
            /// </summary>
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                /// <summary>
                /// The number of instances that are successfully run.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The point in time. The value is an exact hour that ranges from 00:00 to 23:00, such as 00:00, 01:00, or 02:00.
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

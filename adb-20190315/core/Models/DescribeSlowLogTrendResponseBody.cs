// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query. The end time must be later than the start time. The maximum time range that can be specified is seven days. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The information about the trend of slow query logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogTrendResponseBodyItems Items { get; set; }
        public class DescribeSlowLogTrendResponseBodyItems : TeaModel {
            [NameInMap("SlowLogTrendItem")]
            [Validation(Required=false)]
            public List<DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItem> SlowLogTrendItem { get; set; }
            public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItem : TeaModel {
                /// <summary>
                /// The trend of slow query logs. The value is AnalyticDB_SlowLogTrend.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The performance metrics.
                /// </summary>
                [NameInMap("Series")]
                [Validation(Required=false)]
                public DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeries Series { get; set; }
                public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeries : TeaModel {
                    [NameInMap("SeriesItem")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeriesSeriesItem> SeriesItem { get; set; }
                    public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeriesSeriesItem : TeaModel {
                        /// <summary>
                        /// The name of the performance metric.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The values of the performance metric.
                        /// </summary>
                        [NameInMap("Values")]
                        [Validation(Required=false)]
                        public string Values { get; set; }

                    }

                }

                /// <summary>
                /// The unit of performance metrics.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

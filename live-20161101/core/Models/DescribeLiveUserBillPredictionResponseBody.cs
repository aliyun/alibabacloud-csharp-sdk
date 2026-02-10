// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserBillPredictionResponseBody : TeaModel {
        [NameInMap("BillPredictionData")]
        [Validation(Required=false)]
        public DescribeLiveUserBillPredictionResponseBodyBillPredictionData BillPredictionData { get; set; }
        public class DescribeLiveUserBillPredictionResponseBodyBillPredictionData : TeaModel {
            [NameInMap("BillPredictionDataItem")]
            [Validation(Required=false)]
            public List<DescribeLiveUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem> BillPredictionDataItem { get; set; }
            public class DescribeLiveUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("TimeStp")]
                [Validation(Required=false)]
                public string TimeStp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The metering method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hour_flow: pay by hourly data transfer</description></item>
        /// <item><description>day_bandwidth: pay by daily bandwidth</description></item>
        /// <item><description>month_95: pay by monthly 95th percentile bandwidth</description></item>
        /// <item><description>month_avg_day_bandwidth: pay by average daily peak bandwidth per month</description></item>
        /// <item><description>month_4th_day_bandwidth: pay by 4th peak bandwidth per month</description></item>
        /// <item><description>month_avg_day_95: pay by average daily 95th percentile bandwidth per month</description></item>
        /// <item><description>month_95_night_half: pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00</description></item>
        /// <item><description>hour_vas: pay by value-added services per hour</description></item>
        /// <item><description>day_count: pay by daily requests</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day_bandwidth</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>The end time. If you do not specify the request parameter EndTime, the end time is the current time by default. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-25T10:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B95BE680-5A6A-1CAD-8AB1-09DFF5D6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time. If you do not specify the request parameter StartTime, the start time is 00:00 on the first day of the month by default. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

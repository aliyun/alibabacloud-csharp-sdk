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
        /// <para>The billing method. The following billing methods are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>hour_flow: Pay-by-traffic on an hourly basis.</para>
        /// </description></item>
        /// <item><description><para>day_bandwidth: Pay-by-bandwidth on a daily basis.</para>
        /// </description></item>
        /// <item><description><para>month_95: Pay-by-monthly 95th percentile peak bandwidth.</para>
        /// </description></item>
        /// <item><description><para>month_avg_day_bandwidth: Pay-by-monthly average of daily peak bandwidth.</para>
        /// </description></item>
        /// <item><description><para>month_4th_day_bandwidth: Pay-by-monthly 4th peak bandwidth.</para>
        /// </description></item>
        /// <item><description><para>month_avg_day_95: Pay-by-monthly average of daily 95th percentile peak bandwidth.</para>
        /// </description></item>
        /// <item><description><para>month_95_night_half: Pay-by-nightly 95th percentile peak bandwidth with a 50% discount.</para>
        /// </description></item>
        /// <item><description><para>hour_vas: Pay-for-value-added services on an hourly basis.</para>
        /// </description></item>
        /// <item><description><para>day_count: Pay-by-daily request count.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day_bandwidth</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the ISO 8601 standard.
        /// Format: YYYY-MM-DDThh:mm:ssZ. The default value is the current time.</para>
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
        /// <para>The start time of the query. The time is in UTC and follows the ISO 8601 standard.
        /// Format: YYYY-MM-DDThh:mm:ssZ. The default value is 00:00 on the first day of the month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

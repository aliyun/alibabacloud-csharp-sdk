// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillPredictionResponseBody : TeaModel {
        /// <summary>
        /// <para>The estimated bill data.</para>
        /// </summary>
        [NameInMap("BillPredictionData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillPredictionResponseBodyBillPredictionData BillPredictionData { get; set; }
        public class DescribeCdnUserBillPredictionResponseBodyBillPredictionData : TeaModel {
            [NameInMap("BillPredictionDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem> BillPredictionDataItem { get; set; }
            public class DescribeCdnUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem : TeaModel {
                /// <summary>
                /// <para>The billable region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>The time when the value used as the estimated value is generated. This parameter is returned only if the metering method is pay by 95th percentile, pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00, or pay by 4th peak bandwidth per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-10-15T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStp")]
                [Validation(Required=false)]
                public string TimeStp { get; set; }

                /// <summary>
                /// <para>The estimated value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The metering method.</para>
        /// <remarks>
        /// <para>If the metering method ends with _overseas, the billable region is outside the Chinese mainland. For example, BillType&quot;: &quot;month_avg_day_bandwidth_overseas specifies a billable region outside the Chinese mainland and that the metering method is pay by daily peak bandwidth per month.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hour_flow: pay by hourly data transfer</description></item>
        /// <item><description>day_bandwidth: pay by daily bandwidth</description></item>
        /// <item><description>month_95: pay by monthly 95th percentile bandwidth.</description></item>
        /// <item><description>month_avg_day_bandwidth: pay by average daily peak bandwidth per month</description></item>
        /// <item><description>month_4th_day_bandwidth: pay by monthly 4th peak bandwidth</description></item>
        /// <item><description>month_avg_day_95: pay by average daily 95th percentile bandwidth per month</description></item>
        /// <item><description>month_95_night_half: pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00.</description></item>
        /// <item><description>hour_vas: pay by value-added services per hour</description></item>
        /// <item><description>day_count: pay by daily requests</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>month_95</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>The end time of the estimation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-25T10:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the estimation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

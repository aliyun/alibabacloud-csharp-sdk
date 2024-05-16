// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillPredictionResponseBody : TeaModel {
        /// <summary>
        /// The estimated bill data.
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
                /// The billable region.
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// The time when the value used as the estimated value is generated. This parameter is returned only if the metering method is pay by 95th percentile, pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00, or pay by 4th peak bandwidth per month.
                /// </summary>
                [NameInMap("TimeStp")]
                [Validation(Required=false)]
                public string TimeStp { get; set; }

                /// <summary>
                /// The estimated value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

        /// <summary>
        /// The metering method.
        /// 
        /// > If the metering method ends with _overseas, the billable region is outside the Chinese mainland. For example, BillType": "month_avg_day_bandwidth_overseas specifies a billable region outside the Chinese mainland and that the metering method is pay by daily peak bandwidth per month.
        /// 
        /// Valid values:
        /// 
        /// *   hour_flow: pay by hourly data transfer
        /// *   day_bandwidth: pay by daily bandwidth
        /// *   month_95: pay by monthly 95th percentile bandwidth.
        /// *   month_avg_day_bandwidth: pay by average daily peak bandwidth per month
        /// *   month_4th_day_bandwidth: pay by monthly 4th peak bandwidth
        /// *   month_avg_day_95: pay by average daily 95th percentile bandwidth per month
        /// *   month_95_night_half: pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00.
        /// *   hour_vas: pay by value-added services per hour
        /// *   day_count: pay by daily requests
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// The end time of the estimation.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the estimation.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

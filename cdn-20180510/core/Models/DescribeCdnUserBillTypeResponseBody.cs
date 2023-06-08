// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillTypeResponseBody : TeaModel {
        /// <summary>
        /// Details about the metering methods returned.
        /// </summary>
        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeCdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                /// <summary>
                /// The metering method.
                /// 
                /// > If the metering method is suffixed with \*\*\_overseas\*\*, the billable region is outside the Chinese mainland. For example, "BillType": "month_avg_day_bandwidth_overseas" indicates that the metering method is pay by average daily peak bandwidth per month in a billable region outside the Chinese mainland.
                /// 
                /// Valid values:
                /// 
                /// *   hour_flow: pay by hourly data transfer
                /// *   day_bandwidth: pay by daily bandwidth
                /// *   month\_95: pay by monthly 95th percentile bandwidth
                /// *   month_avg_day_bandwidth: pay by average daily peak bandwidth per month
                /// *   month\_4th_day_bandwidth: pay by monthly 4th peak bandwidth
                /// *   month_avg_day\_95: pay by average daily 95th percentile bandwidth per month
                /// *   month\_95\_night_half: pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00
                /// *   hour_vas: pay by value-added services per hour
                /// *   quic_hour_count: pay by hourly QUIC requests
                /// *   day_count: pay by daily requests
                /// *   hour_count: pay by hourly requests
                /// *   day\_95: pay by daily 95th percentile bandwidth
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// The billing cycle.
                /// </summary>
                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                /// <summary>
                /// The dimension. Valid values:
                /// 
                /// *   flow: traffic and bandwidth
                /// *   vas: value-added services (HTTPS and requests for dynamic content)
                /// *   quic: the number of QUIC requests
                /// *   websocket: the WebSocket communications protocol
                /// *   rtlog2sls: log entries delivered to Log Service in real time
                /// *   stationflow: traffic over the internal network
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// The time when the metering method ended.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The name of the product.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The time when the metering method started.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

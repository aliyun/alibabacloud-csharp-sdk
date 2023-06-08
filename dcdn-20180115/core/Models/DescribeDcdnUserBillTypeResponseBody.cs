// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillTypeResponseBody : TeaModel {
        /// <summary>
        /// The information about the metering method.
        /// </summary>
        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeDcdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                /// <summary>
                /// The metering method. Valid values:
                /// 
                /// *   **hour_flow**: pay by hourly traffic
                /// *   **day_bandwidth**: pay by daily bandwidth
                /// *   **month\_95**: pay by monthly 95th percentile
                /// *   **month_avg_day_bandwidth**: pay by average daily peak bandwidth per month
                /// *   **month\_4th_day_bandwidth**: pay by 4th peak bandwidth per month
                /// *   **month_avg_day\_95**: pay by average daily 95th percentile per month
                /// *   **month\_95\_night_half**: pay by 95th percentile (50% off during nighttime)
                /// *   **hour_vas**: pay by value-added service per month
                /// *   **quic_hour_count**: pay by QUIC request per hour
                /// *   **hour_count**: pay by request per hour
                /// *   **rtlog_count_day**: pay by the number of real-time logs per day
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
                /// *   **flow**: network traffic and bandwidth
                /// *   **vas**: value-added services (HTTPS and requests for dynamic content)
                /// *   **websocket**: WebSocket
                /// *   **quic**: QUIC requests
                /// *   **rtlog2sls**: log entries delivered to Log Service in real time
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// The time when the metering method ends.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The time when the metering method takes effect.
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

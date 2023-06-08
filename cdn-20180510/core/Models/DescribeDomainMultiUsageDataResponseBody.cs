// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMultiUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range that was queried.
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
        /// The information about requests collected every 5 minutes.
        /// </summary>
        [NameInMap("RequestPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The number of requests.
                /// </summary>
                [NameInMap("Request")]
                [Validation(Required=false)]
                public long? Request { get; set; }

                /// <summary>
                /// The timestamp of the returned number of requests.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The type.
                /// 
                /// >  The value is Simple for Alibaba Cloud CDN.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The start of the time range that was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The statistics of network traffic collected every 5 minutes.
        /// </summary>
        [NameInMap("TrafficPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// The bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The startstamp of the returned usage data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The type of requests. Valid values:
                /// 
                /// *   **StaticHttps**: static HTTPS requests
                /// *   **DynamicHttps**: dynamic HTTPS requests
                /// *   **DynamicHttp**: dynamic HTTP requests
                /// *   **StaticQuic**: static QUIC requests
                /// *   **DynamicQuic**: dynamic QUIC requests
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}

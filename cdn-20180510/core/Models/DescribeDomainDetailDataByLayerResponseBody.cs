// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// The number of IPv6 requests per second.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainDetailDataByLayerResponseBodyData Data { get; set; }
        public class DescribeDomainDetailDataByLayerResponseBodyData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailDataByLayerResponseBodyDataDataModule> DataModule { get; set; }
            public class DescribeDomainDetailDataByLayerResponseBodyDataDataModule : TeaModel {
                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public long? Acc { get; set; }

                /// <summary>
                /// The bandwidth of IPv6 requests. Unit: bit/s.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// The number of requests.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// - You can call this operation up to 20 times per second per account.
                /// - If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
                /// 
                /// **Time granularity**
                /// 
                /// The following table describes the time granularity, the time period within which historical data is available, and the data delay, which vary with the maximum time range per query. 
                /// 
                /// | Time granularity | Maximum time range per query | Historical data available | Data delay |
                /// | ---------------- | ---------------------------- | ------------------------- | ---------- |
                /// | 5 minutes | 3 days | 93 days | 15 minutes |
                /// | 1 hour | 31 days | 186 days | 4 hours |
                /// | 1 days | 366 days | 366 days | 04:00 on the next day |
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// The bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("Ipv6Acc")]
                [Validation(Required=false)]
                public long? Ipv6Acc { get; set; }

                /// <summary>
                /// The number of IPv6 requests.
                /// </summary>
                [NameInMap("Ipv6Bps")]
                [Validation(Required=false)]
                public float? Ipv6Bps { get; set; }

                /// <summary>
                /// The amount of network traffic generated by IPv6 requests. Unit: bytes.
                /// </summary>
                [NameInMap("Ipv6Qps")]
                [Validation(Required=false)]
                public float? Ipv6Qps { get; set; }

                /// <summary>
                /// The proportions of HTTP status codes.
                /// </summary>
                [NameInMap("Ipv6Traf")]
                [Validation(Required=false)]
                public long? Ipv6Traf { get; set; }

                /// <summary>
                /// The number of requests.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The bandwidth of IPv6 requests. Unit: bit/s.
                /// </summary>
                [NameInMap("Traf")]
                [Validation(Required=false)]
                public long? Traf { get; set; }

            }

        }

        /// <summary>
        /// The number of queries per second.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

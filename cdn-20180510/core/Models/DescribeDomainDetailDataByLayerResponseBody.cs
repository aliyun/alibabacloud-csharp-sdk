// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// Details about the accelerated domain names.
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
                /// The number of requests.
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public long? Acc { get; set; }

                /// <summary>
                /// The bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The distribution of HTTP status codes.
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// The number of IPv6 requests.
                /// </summary>
                [NameInMap("Ipv6Acc")]
                [Validation(Required=false)]
                public long? Ipv6Acc { get; set; }

                /// <summary>
                /// The IPv6 bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("Ipv6Bps")]
                [Validation(Required=false)]
                public float? Ipv6Bps { get; set; }

                /// <summary>
                /// The QPS over IPv6.
                /// </summary>
                [NameInMap("Ipv6Qps")]
                [Validation(Required=false)]
                public float? Ipv6Qps { get; set; }

                /// <summary>
                /// The IPv6 traffic. Unit: bytes.
                /// </summary>
                [NameInMap("Ipv6Traf")]
                [Validation(Required=false)]
                public long? Ipv6Traf { get; set; }

                /// <summary>
                /// The QPS.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// The timestamp of the returned data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The amount of network traffic. Unit: bytes.
                /// </summary>
                [NameInMap("Traf")]
                [Validation(Required=false)]
                public long? Traf { get; set; }

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

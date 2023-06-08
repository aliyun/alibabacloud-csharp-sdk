// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The amount of back-to-origin traffic returned at each time interval. Unit: bytes.
        /// </summary>
        [NameInMap("OriginTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval OriginTrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginTrafficDataResponseBodyOriginTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The amount of back-to-origin traffic that was consumed to deliver dynamic content over HTTP.
                /// </summary>
                [NameInMap("DynamicHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginTraffic { get; set; }

                /// <summary>
                /// The amount of back-to-origin traffic that was consumed to deliver dynamic content over HTTPS.
                /// </summary>
                [NameInMap("DynamicHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginTraffic { get; set; }

                /// <summary>
                /// The amount of back-to-origin traffic.
                /// </summary>
                [NameInMap("OriginTraffic")]
                [Validation(Required=false)]
                public float? OriginTraffic { get; set; }

                /// <summary>
                /// The amount of back-to-origin traffic that was consumed to deliver static content over HTTP.
                /// </summary>
                [NameInMap("StaticHttpOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpOriginTraffic { get; set; }

                /// <summary>
                /// The amount of back-to-origin traffic that was consumed to deliver static content over HTTPS.
                /// </summary>
                [NameInMap("StaticHttpsOriginTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginTraffic { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

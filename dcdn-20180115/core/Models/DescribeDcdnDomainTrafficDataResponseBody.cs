// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTrafficDataResponseBody : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The network traffic returned at each time interval. Unit: bytes.
        /// </summary>
        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The network traffic that was consumed to deliver dynamic content over HTTP.
                /// </summary>
                [NameInMap("DynamicHttpTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpTraffic { get; set; }

                /// <summary>
                /// The network traffic that was consumed to deliver dynamic content over HTTPS.
                /// </summary>
                [NameInMap("DynamicHttpsTraffic")]
                [Validation(Required=false)]
                public float? DynamicHttpsTraffic { get; set; }

                /// <summary>
                /// The network traffic that was consumed to deliver static content over HTTP.
                /// </summary>
                [NameInMap("StaticHttpTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpTraffic { get; set; }

                /// <summary>
                /// The network traffic that was consumed to deliver static content over HTTPS.
                /// </summary>
                [NameInMap("StaticHttpsTraffic")]
                [Validation(Required=false)]
                public float? StaticHttpsTraffic { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The total amount of network traffic.
                /// </summary>
                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public float? Traffic { get; set; }

            }

        }

    }

}

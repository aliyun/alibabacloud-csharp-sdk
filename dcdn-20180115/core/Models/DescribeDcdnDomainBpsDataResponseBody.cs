// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainBpsDataResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth data returned at each interval.
        /// </summary>
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The bandwidth value. Unit: bit/s.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed to deliver dynamic content over HTTP. Unit: bit/s.
                /// </summary>
                [NameInMap("DynamicHttpBps")]
                [Validation(Required=false)]
                public float? DynamicHttpBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed to deliver dynamic content over HTTPS. Unit: bit/s.
                /// </summary>
                [NameInMap("DynamicHttpsBps")]
                [Validation(Required=false)]
                public float? DynamicHttpsBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed to deliver static content over HTTP. Unit: bit/s.
                /// </summary>
                [NameInMap("StaticHttpBps")]
                [Validation(Required=false)]
                public float? StaticHttpBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed to deliver static content over HTTPS. Unit: bit/s.
                /// </summary>
                [NameInMap("StaticHttpsBps")]
                [Validation(Required=false)]
                public float? StaticHttpsBps { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The time interval between the data entries returned.
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

    }

}

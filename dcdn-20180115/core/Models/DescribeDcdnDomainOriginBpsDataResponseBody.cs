// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainOriginBpsDataResponseBody : TeaModel {
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
        /// The origin bandwidth data returned at each time interval. Unit: bit/s.
        /// </summary>
        [NameInMap("OriginBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval OriginBpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainOriginBpsDataResponseBodyOriginBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The bandwidth that was consumed for fetching dynamic content from the origin over HTTP.
                /// </summary>
                [NameInMap("DynamicHttpOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpOriginBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed for fetching dynamic content from the origin over HTTPS.
                /// </summary>
                [NameInMap("DynamicHttpsOriginBps")]
                [Validation(Required=false)]
                public float? DynamicHttpsOriginBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed for fetching content from the origin.
                /// </summary>
                [NameInMap("OriginBps")]
                [Validation(Required=false)]
                public float? OriginBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed for fetching static content from the origin over HTTP.
                /// </summary>
                [NameInMap("StaticHttpOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpOriginBps { get; set; }

                /// <summary>
                /// The bandwidth that was consumed for fetching static content from the origin over HTTPS.
                /// </summary>
                [NameInMap("StaticHttpsOriginBps")]
                [Validation(Required=false)]
                public float? StaticHttpsOriginBps { get; set; }

                /// <summary>
                /// The timestamp of the returned data.
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
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

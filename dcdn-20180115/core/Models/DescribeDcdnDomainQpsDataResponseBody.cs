// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainQpsDataResponseBody : TeaModel {
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
        /// The QPS returned at each time interval.
        /// </summary>
        [NameInMap("QpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval QpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The total number of requests.
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public float? Acc { get; set; }

                /// <summary>
                /// The number of requests for dynamic content delivery over HTTP.
                /// </summary>
                [NameInMap("DynamicHttpAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpAcc { get; set; }

                /// <summary>
                /// The QPS for dynamic content delivery over HTTP.
                /// </summary>
                [NameInMap("DynamicHttpQps")]
                [Validation(Required=false)]
                public float? DynamicHttpQps { get; set; }

                /// <summary>
                /// The number of requests for dynamic content delivery over HTTPS.
                /// </summary>
                [NameInMap("DynamicHttpsAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpsAcc { get; set; }

                /// <summary>
                /// The QPS for dynamic content delivery over HTTPS.
                /// </summary>
                [NameInMap("DynamicHttpsQps")]
                [Validation(Required=false)]
                public float? DynamicHttpsQps { get; set; }

                /// <summary>
                /// The total QPS.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// The number of requests for static content delivery over HTTP.
                /// </summary>
                [NameInMap("StaticHttpAcc")]
                [Validation(Required=false)]
                public float? StaticHttpAcc { get; set; }

                /// <summary>
                /// The QPS for static content delivery over HTTP.
                /// </summary>
                [NameInMap("StaticHttpQps")]
                [Validation(Required=false)]
                public float? StaticHttpQps { get; set; }

                /// <summary>
                /// The number of requests for static content delivery over HTTPS.
                /// </summary>
                [NameInMap("StaticHttpsAcc")]
                [Validation(Required=false)]
                public float? StaticHttpsAcc { get; set; }

                /// <summary>
                /// The QPS for static content delivery over HTTPS.
                /// </summary>
                [NameInMap("StaticHttpsQps")]
                [Validation(Required=false)]
                public float? StaticHttpsQps { get; set; }

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

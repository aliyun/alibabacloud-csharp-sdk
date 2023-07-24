// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBody : TeaModel {
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
        /// 
        /// The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The proportions of HTTP status codes at each time interval.
        /// </summary>
        [NameInMap("RealTimeSrcHttpCodeData")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeData RealTimeSrcHttpCodeData { get; set; }
        public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageData : TeaModel {
                /// <summary>
                /// The timestamp of the returned data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The proportions of the HTTP status codes.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("RealTimeSrcCodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageDataValueRealTimeSrcCodeProportionData> RealTimeSrcCodeProportionData { get; set; }
                    public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBodyRealTimeSrcHttpCodeDataUsageDataValueRealTimeSrcCodeProportionData : TeaModel {
                        /// <summary>
                        /// The HTTP status code returned.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The number of HTTP status codes.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// The proportion of the HTTP status code.
                        /// </summary>
                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }

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
        /// 
        /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

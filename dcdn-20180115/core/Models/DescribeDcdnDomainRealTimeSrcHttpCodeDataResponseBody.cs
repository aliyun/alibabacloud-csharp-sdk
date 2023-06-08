// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The proportions of HTTP status codes.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The proportion of the HTTP status code.
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
                /// The number of HTTP status codes.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// - You can call this operation up to 10 times per second per account.
                /// - If you do not set the StartTime or EndTime parameter, data collected over the last one hour is queried. If you set both the StartTime and EndTime parameters, data collected within the specified time range is queried.
                /// 
                /// **Time granularity**The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay. 
                /// 
                /// | Time granularity | Maximum time range per query | Historical data available | Data delay |
                /// | ---------------- | ---------------------------- | ------------------------- | ---------- |
                /// | 1 minute | 1 hour | 7 days | 5 minutes |
                /// | 5 minutes | 3 days | 93 days | 15 minutes |
                /// | 1 hour | 31 days | 186 days | 4 hours |
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
                        /// Queries the proportions of HTTP status codes returned during back-to-origin routing.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The timestamp of the data returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The proportions of HTTP status codes at each time interval.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

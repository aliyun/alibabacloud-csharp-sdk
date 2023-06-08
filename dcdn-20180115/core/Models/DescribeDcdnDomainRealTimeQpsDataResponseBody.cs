// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeQpsDataResponseBody : TeaModel {
        /// <summary>
        /// The accelerated domain name. Separate multiple accelerated domain names with commas (,).
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                /// <summary>
                /// The name of the Internet service provider (ISP).
                /// 
                /// You can call the [DescribeDcdnRegionAndIsp](~~207199~~) operation to query ISPs.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// The QPS data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// - You can call this operation up to 10 times per second per account.
        /// - If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
        /// 
        /// **Time granularity**The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay. 
        /// 
        /// | Time granularity | Maximum time range per query | Historical data available | Data delay |
        /// | ---------------- | ---------------------------- | ------------------------- | ---------- |
        /// | 1 minute | 1 hour | 7 days | 5 minutes |
        /// | 5 minutes | 3 days | 93 days | 15 minutes |
        /// | 1 hour | 31 days | 186 days | 4 hours |
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

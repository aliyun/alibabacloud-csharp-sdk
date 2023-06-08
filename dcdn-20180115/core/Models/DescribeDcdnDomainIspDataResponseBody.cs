// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIspDataResponseBody : TeaModel {
        /// <summary>
        /// The total amount of network traffic.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The total number of requests.
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
        /// The number of queries per second.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The access statistics by ISP.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The average response speed. Unit: byte/ms.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDcdnDomainIspDataResponseBodyValue Value { get; set; }
        public class DescribeDcdnDomainIspDataResponseBodyValue : TeaModel {
            [NameInMap("IspProportionData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainIspDataResponseBodyValueIspProportionData> IspProportionData { get; set; }
            public class DescribeDcdnDomainIspDataResponseBodyValueIspProportionData : TeaModel {
                /// <summary>
                /// The proportion of network traffic. For example, a value of 90 indicates that 90% of network traffic was coming from the specified ISP.
                /// </summary>
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                /// <summary>
                /// The name of the ISP.
                /// </summary>
                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                /// <summary>
                /// The bandwidth.
                /// </summary>
                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                /// <summary>
                /// The information about the ISP.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                /// <summary>
                /// The total amount of network traffic.
                /// </summary>
                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                /// <summary>
                /// The name of the ISP.
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// > 
                /// *   You can call this operation up to 100 times per second.
                /// *   If **StartTime** is set but **EndTime** is not set, the data within the hour that starts from **StartTime** is queried.
                /// *   If **EndTime** is set but **StartTime** is not set, the data within the last hour that precedes **EndTime** is queried.
                /// *   You can query data of a domain name or all domain names that belong to your account.
                /// *   You can view data that is collected over the last seven days. The interval at which data is queried is based on the time range specified by **StartTime** and **EndTime**.
                ///     *   **If the time range is shorter than or equal to one hour**, data is queried every minute.
                ///     *   **If the time range is longer than 1 hour but shorter than or equal to three days**, data is queried every five minutes.
                ///     *   **If the time range is longer than three days but shorter than or equal to seven days**, data is queried every hour.
                /// </summary>
                [NameInMap("IspEname")]
                [Validation(Required=false)]
                public string IspEname { get; set; }

                /// <summary>
                /// The information about the ISP.
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                /// <summary>
                /// The average response time. Unit: milliseconds.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// The average response size. Unit: bytes.
                /// </summary>
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                /// <summary>
                /// The proportion of requests.
                /// </summary>
                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}

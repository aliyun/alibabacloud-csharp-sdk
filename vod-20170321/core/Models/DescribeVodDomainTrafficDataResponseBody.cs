// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval between the returned entries. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The domain name for CDN.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range in which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
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
        /// The beginning of the time range in which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The total traffic.
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public string TotalTraffic { get; set; }

        /// <summary>
        /// The network traffic data that is collected for each interval.
        /// </summary>
        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeVodDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The volume of the network traffic in mainland China. Unit: byte.
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// The volume of the HTTPS network traffic on L1 nodes in mainland China. Unit: byte.
                /// </summary>
                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                /// <summary>
                /// The volume of the HTTPS network traffic on L1 nodes outside mainland China. Unit: byte.
                /// </summary>
                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                /// <summary>
                /// The total volume of the HTTPS network traffic on L1 nodes. Unit: byte.
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// The volume of the network traffic outside mainland China. Unit: byte.
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The total volume of the network traffic. Unit: byte.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}

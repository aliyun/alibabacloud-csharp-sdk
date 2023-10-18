// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcBpsDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval between the entries returned. Unit: seconds.
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
        /// Details about the origin bandwidth data returned at each time interval. Unit: bit/s.
        /// </summary>
        [NameInMap("SrcBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval SrcBpsDataPerInterval { get; set; }
        public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The bandwidth values of origin HTTPS requests.
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The bandwidth value at each time interval.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

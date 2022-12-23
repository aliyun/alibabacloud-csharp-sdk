// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The region where the data was queried.
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

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
        /// The type of the content based on which the data is generated. Valid values:
        /// 
        /// *   **static**
        /// *   **dynamic**
        /// *   **all**
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The details of traffic or bandwidth data.
        /// </summary>
        [NameInMap("UsageDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainUsageDataResponseBodyUsageDataPerInterval UsageDataPerInterval { get; set; }
        public class DescribeVodDomainUsageDataResponseBodyUsageDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainUsageDataResponseBodyUsageDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainUsageDataResponseBodyUsageDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The traffic or bandwidth data. The unit of bandwidth is bit/s.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}

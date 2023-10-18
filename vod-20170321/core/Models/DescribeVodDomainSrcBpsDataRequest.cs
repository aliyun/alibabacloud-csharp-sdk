// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcBpsDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
        /// 
        /// If you leave this parameter empty, the origin bandwidth data for all accelerated domain names is queried by default.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time interval between the data entries to return. Unit: seconds. Valid values:
        /// 
        /// *   **300**: 5 minutes
        /// *   **3600**: 1 hour
        /// *   **86400**: 1 day
        /// 
        /// > The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. For more information, see the **Time granularity** section of this topic.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// If you leave this parameter empty, the origin bandwidth data that is generated in the last 24 hours is queried by default.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

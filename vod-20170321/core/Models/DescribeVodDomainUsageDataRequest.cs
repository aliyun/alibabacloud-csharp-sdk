// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// The region in which you want to query data. Default value: CN. Valid values:
        /// 
        /// *   **CN**: the Chinese mainland.
        /// *   **OverSeas**: outside the Chinese mainland.
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The accelerated domain name. If you leave this parameter empty, the merged data of all your accelerated domain names is returned. Separate multiple accelerated domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the data to return. Valid values:
        /// 
        /// *   **bps**: bandwidth
        /// *   **traf**: traffic
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The time interval between the data entries to return. Unit: seconds. Valid values: **300** (5 minutes), **3600** (1 hour), and **86400** (1 day).
        /// 
        /// *   If **Interval** is set to **300**, you can query usage data in the last six months. The maximum time range per query that can be specified is three days.
        /// *   If **Interval** is set to **3600** or **86400**, you can query usage data of the previous year.
        /// *   If you do not set the **Interval** parameter, the maximum time range that you can query is one month. If you specify a time range of 1 to 3 days, the time interval between the entries that are returned is 1 hour. If you specify a time range of at least 4 days, the time interval between the entries that are returned is 1 day.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The type of content that you want to query. Valid values:
        /// 
        /// *   **static**: static content
        /// *   **dynamic**: dynamic requests
        /// *   **all**: all content
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

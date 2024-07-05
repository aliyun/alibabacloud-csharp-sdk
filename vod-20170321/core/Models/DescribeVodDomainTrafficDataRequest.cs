// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainTrafficDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name.
        /// 
        /// *   If you leave this parameter empty, the merged data of all your accelerated domain names is returned.
        /// *   You can specify multiple domain names and separate them with commas (,). You can specify a maximum of 500 domain names in each call.
        /// *   To obtain the accelerated domain name, perform the following steps: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management > CDN Configuration > Domain Names**. On the Domain Names page, view the accelerated domain names. Alternatively, you can call the [DescribeVodUserDomains](~~DescribeVodUserDomains~~) operation to query the accelerated domain names.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time granularity of the query. Unit: seconds. Valid values: **300**, **3600**, and **86400**. If you leave this parameter empty or specify an invalid value, the default value is used. The supported time granularity varies based on the time range specified by `EndTime` and `StartTime`. The following content describes the supported time granularity.
        /// 
        /// *   Time range per query < 3 days: **300** (default), **3600**, and **86400**
        /// *   3 days ≤ Time range per query < 31 days: **3600** (default) and **86400**
        /// *   31 days ≤ Time range per query ≤ 366 days: **86400** (default)
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP). If you leave this parameter empty, all ISPs are queried.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region. If you leave this parameter empty, all regions are queried. You can specify only the China (Shanghai) region.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The start of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataRequest : TeaModel {
        /// <summary>
        /// The domain name to be queried. If you do not specify this parameter, the merged data of all your domain names for CDN is returned. You can specify multiple domain names. Separate them with commas (,).
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
        /// The query interval. Unit: seconds. Valid values: **300**, **3600**, and **86400**.
        /// 
        /// *   If the time range to query is less than 3 days, valid values are **300**, **3600**, and **86400**. The default value is 300.
        /// *   If the time range to query is from 3 to less than 31 days, valid values are **3600** and **86400**. The default value is 3600.
        /// *   If the time range to query is from 31 to 90 days, the valid value is **86400**.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP). If you do not specify this parameter, the data of all ISPs is returned.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region. If you do not specify this parameter, the data in all regions is returned. Only data in the China (Shanghai) region can be queried.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > The minimum query interval is 5 minutes. If you do not specify this parameter, the data in the last 24 hours is queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

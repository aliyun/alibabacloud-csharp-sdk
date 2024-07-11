// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebReportTopIpRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// >  A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query the domain names for which forwarding rules are configured.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// >  This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The interval at which data is collected. Unit: seconds. Valid values are 300, 3600, and 86400.
        /// 
        /// *   If the time span between StartTime and EndTime is less than 3 days (3 days excluded), valid values are 300, 3600, and 86400.
        /// *   If the time span between StartTime and EndTime is from 3 to 31 days (31 days excluded), valid values are 3600 and 86400.
        /// *   If the time span between StartTime and EndTime is 31 days or longer, the valid value is 86400.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The source of the statistics. Valid value:
        /// 
        /// *   **visit**: indicates all IP addresses.
        /// *   **block**: indicates blocked IP addresses.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// >  This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The maximum number of entries to return.
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public int? Top { get; set; }

    }

}

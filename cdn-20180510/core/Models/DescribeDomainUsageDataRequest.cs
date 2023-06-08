// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// The ID of the billable region. Valid values:
        /// 
        /// *   **CN** (default): inside the Chinese mainland
        /// *   **OverSeas**: outside the Chinese mainland
        /// *   **AP1**: Asia Pacific 1
        /// *   **AP2**: Asia Pacific 2
        /// *   **AP3**: Asia Pacific 3
        /// *   **NA**: North America
        /// *   **SA**: South America
        /// *   **EU**: Europe
        /// *   **MEAA**: Middle East and Africa
        /// *   **all**: all the preceding billable regions
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The protocol of the data that you want to query. Valid values:
        /// 
        /// *   **http**: HTTP
        /// *   **https**: HTTPS
        /// *   **quic**: QUIC
        /// *   **all** (default): HTTP, HTTPS, and QUIC
        /// </summary>
        [NameInMap("DataProtocol")]
        [Validation(Required=false)]
        public string DataProtocol { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify up to 100 domain names in each request. Separate multiple domain names with commas (,).
        /// 
        /// > If you leave this parameter empty, the usage data of all accelerated domain names in your Alibaba Cloud account is returned.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time. The maximum time range that can be specified is 31 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the data that you want to query. Valid values:
        /// 
        /// *   **bps**: bandwidth
        /// *   **traf**: traffic
        /// *   **acc**: requests
        /// 
        /// > If you set this parameter to **acc**, the **Area** parameter is not supported.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The time granularity of the data entries. Unit: seconds. Valid values: **300** (5 minutes), **3600** (1 hour), and **86400** (1 day).
        /// 
        /// *   If **Interval** is set to **300**, you can query usage data in the last 6 months. The maximum time range per query that can be specified is 3 days.
        /// *   If **Interval** is set to **3600** or **86400**, you can query usage data of the previous year.
        /// *   If you leave the **Interval** parameter empty, the maximum time range that you can query is 1 month. If you specify a time range of 1 to 3 days, the time interval between the entries that are returned is 1 hour. If you specify a time range of at least 4 days, the time interval between the entries that are returned is 1 day.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > Data is collected every 5 minutes.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The type of content that you want to query. Valid values:
        /// 
        /// *   **static**: static content
        /// *   **dynamic**: dynamic content
        /// *   **all** (default): both static and dynamic content
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

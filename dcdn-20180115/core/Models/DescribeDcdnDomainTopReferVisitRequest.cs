// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopReferVisitRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify only one domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The method that is used to arrange the returned application information. Valid values:
        /// 
        /// *   **traf**: by network traffic
        /// *   **pv**: by the number of visits
        /// 
        /// Default value: **pv**.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The start of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// To query the data on a specified day, use the yyyy-MM-ddT16:00:00Z format.
        /// 
        /// If you leave this parameter empty, data collected in the last 24 hours is queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

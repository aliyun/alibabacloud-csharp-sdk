// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainMultiUsageDataRequest : TeaModel {
        /// <summary>
        /// If this parameter is not set, data of all your accelerated domain names is queried.
        /// 
        /// You can specify one or more accelerated domain names. Separate domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end time must be later than the start time.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
        /// *   The time must be in UTC.
        /// *   You must set both the start time and the end time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
        /// *   The time must be in UTC.
        /// *   The minimum data granularity is 5 minutes.
        /// *   If you do not set this parameter, data in the last 24 hours is queried.
        /// *   You must set both the start time and the end time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

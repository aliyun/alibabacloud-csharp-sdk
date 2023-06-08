// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCcActivityLogRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify multiple domain names and separate them with commas (,).
        /// 
        /// If you do not specify this parameter, data of all accelerated domain names under your account is queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The page number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// A custom rule name. Valid values:
        /// 
        /// *   default_normal: rule for the normal mode
        /// *   default_attack: rule for the emergency mode
        /// 
        /// If you leave this parameter empty, events that triggered rate limiting based on all rules are queried.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// The minimum time granularity of data collection is 5 minutes.
        /// 
        /// If you leave this parameter empty, the data collected over the last 24 hours is queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The trigger of rate limiting by which you want to query data.
        /// 
        /// If you leave this parameter empty, all events that triggered rate limiting are queried.
        /// </summary>
        [NameInMap("TriggerObject")]
        [Validation(Required=false)]
        public string TriggerObject { get; set; }

        /// <summary>
        /// The value of the trigger.
        /// 
        /// If you leave this parameter empty, all events recorded for the trigger are queried.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCcActivityLogRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify one or more domain names. Separate multiple domain names with commas (,).
        /// 
        /// If you leave this parameter empty, the data of all domain names is queried.
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
        /// The page number of the returned page. Default value: **1**.
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
        /// The name of the rule.
        /// 
        /// *   default_normal in normal mode
        /// *   default_attack in emergency mode
        /// *   A custom rule name in custom mode. Example: test2.
        /// 
        /// If you leave this parameter empty, all events that triggered rate limiting are queried.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// The minimum data granularity is 5 minutes.
        /// 
        /// If you leave this parameter empty, the data collected over the last 24 hours is queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The object that triggered rate limiting.
        /// 
        /// If you leave this parameter empty, all events that triggered rate limiting are queried.
        /// </summary>
        [NameInMap("TriggerObject")]
        [Validation(Required=false)]
        public string TriggerObject { get; set; }

        /// <summary>
        /// The value of the object that triggered rate limiting.
        /// 
        /// If you leave this parameter empty, all events that triggered rate limiting are queried.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

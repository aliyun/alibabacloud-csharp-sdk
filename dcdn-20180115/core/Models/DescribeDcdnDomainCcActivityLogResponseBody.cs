// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCcActivityLogResponseBody : TeaModel {
        /// <summary>
        /// The log data of the event that triggered rate limiting.
        /// </summary>
        [NameInMap("ActivityLog")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainCcActivityLogResponseBodyActivityLog> ActivityLog { get; set; }
        public class DescribeDcdnDomainCcActivityLogResponseBodyActivityLog : TeaModel {
            /// <summary>
            /// The action that was triggered.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The accelerated domain name whose ICP filing status you want to update.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The name of the rule that was triggered.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The timestamp of the data returned.
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// The object that triggered the blocking event.
            /// </summary>
            [NameInMap("TriggerObject")]
            [Validation(Required=false)]
            public string TriggerObject { get; set; }

            /// <summary>
            /// The period of time during which rate limiting remains effective.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// The value of the trigger for rate limiting.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

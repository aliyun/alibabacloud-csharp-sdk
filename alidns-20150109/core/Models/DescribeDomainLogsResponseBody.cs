// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainLogsResponseBody : TeaModel {
        /// <summary>
        /// The details about the operation logs that are queried.
        /// </summary>
        [NameInMap("DomainLogs")]
        [Validation(Required=false)]
        public DescribeDomainLogsResponseBodyDomainLogs DomainLogs { get; set; }
        public class DescribeDomainLogsResponseBodyDomainLogs : TeaModel {
            [NameInMap("DomainLog")]
            [Validation(Required=false)]
            public List<DescribeDomainLogsResponseBodyDomainLogsDomainLog> DomainLog { get; set; }
            public class DescribeDomainLogsResponseBodyDomainLogsDomainLog : TeaModel {
                /// <summary>
                /// The operation performed.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The time when the operation was performed.
                /// </summary>
                [NameInMap("ActionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates when the operation was performed.
                /// </summary>
                [NameInMap("ActionTimestamp")]
                [Validation(Required=false)]
                public long? ActionTimestamp { get; set; }

                /// <summary>
                /// The IP address from which the operation was performed.
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The message for the operation.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of operation logs returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of operation logs returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

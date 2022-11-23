// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainLogsResponseBody : TeaModel {
        [NameInMap("DomainLogs")]
        [Validation(Required=false)]
        public DescribeDomainLogsResponseBodyDomainLogs DomainLogs { get; set; }
        public class DescribeDomainLogsResponseBodyDomainLogs : TeaModel {
            [NameInMap("DomainLog")]
            [Validation(Required=false)]
            public List<DescribeDomainLogsResponseBodyDomainLogsDomainLog> DomainLog { get; set; }
            public class DescribeDomainLogsResponseBodyDomainLogsDomainLog : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ActionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("ActionTimestamp")]
                [Validation(Required=false)]
                public long? ActionTimestamp { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSubDomainRecordsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainRecords")]
        [Validation(Required=false)]
        public DescribeSubDomainRecordsResponseBodyDomainRecords DomainRecords { get; set; }
        public class DescribeSubDomainRecordsResponseBodyDomainRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<DescribeSubDomainRecordsResponseBodyDomainRecordsRecord> Record { get; set; }
            public class DescribeSubDomainRecordsResponseBodyDomainRecordsRecord : TeaModel {
                public string Status { get; set; }
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Value { get; set; }
                public long? TTL { get; set; }
                public string Line { get; set; }
                public string RecordId { get; set; }
                public long? Priority { get; set; }
                public string RR { get; set; }
                public string DomainName { get; set; }
                public bool? Locked { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}

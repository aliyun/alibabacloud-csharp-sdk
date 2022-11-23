// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordsResponseBody : TeaModel {
        [NameInMap("DomainRecords")]
        [Validation(Required=false)]
        public DescribeDomainRecordsResponseBodyDomainRecords DomainRecords { get; set; }
        public class DescribeDomainRecordsResponseBodyDomainRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<DescribeDomainRecordsResponseBodyDomainRecordsRecord> Record { get; set; }
            public class DescribeDomainRecordsResponseBodyDomainRecordsRecord : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                [NameInMap("RR")]
                [Validation(Required=false)]
                public string RR { get; set; }

                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TTL")]
                [Validation(Required=false)]
                public long? TTL { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

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

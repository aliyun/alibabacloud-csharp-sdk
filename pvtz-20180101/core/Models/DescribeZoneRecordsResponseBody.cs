// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneRecordsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public DescribeZoneRecordsResponseBodyRecords Records { get; set; }
        public class DescribeZoneRecordsResponseBodyRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<DescribeZoneRecordsResponseBodyRecordsRecord> Record { get; set; }
            public class DescribeZoneRecordsResponseBodyRecordsRecord : TeaModel {
                public string Status { get; set; }
                public string Type { get; set; }
                public string Value { get; set; }
                public int? Ttl { get; set; }
                public string Remark { get; set; }
                public long? RecordId { get; set; }
                public string Rr { get; set; }
                public int? Priority { get; set; }
            }
        };

    }

}

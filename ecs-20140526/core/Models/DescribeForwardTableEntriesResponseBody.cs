// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public DescribeForwardTableEntriesResponseBodyForwardTableEntries ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            [NameInMap("ForwardTableEntry")]
            [Validation(Required=false)]
            public List<DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry> ForwardTableEntry { get; set; }
            public class DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry : TeaModel {
                public string ExternalIp { get; set; }
                public string ExternalPort { get; set; }
                public string ForwardEntryId { get; set; }
                public string ForwardTableId { get; set; }
                public string InternalIp { get; set; }
                public string InternalPort { get; set; }
                public string IpProtocol { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

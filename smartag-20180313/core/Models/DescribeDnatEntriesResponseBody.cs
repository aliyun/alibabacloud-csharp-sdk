// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeDnatEntriesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DnatEntries")]
        [Validation(Required=false)]
        public DescribeDnatEntriesResponseBodyDnatEntries DnatEntries { get; set; }
        public class DescribeDnatEntriesResponseBodyDnatEntries : TeaModel {
            [NameInMap("DnatEntry")]
            [Validation(Required=false)]
            public List<DescribeDnatEntriesResponseBodyDnatEntriesDnatEntry> DnatEntry { get; set; }
            public class DescribeDnatEntriesResponseBodyDnatEntriesDnatEntry : TeaModel {
                public string Type { get; set; }
                public string SagId { get; set; }
                public string InternalIp { get; set; }
                public string InternalPort { get; set; }
                public string IpProtocol { get; set; }
                public string ExternalPort { get; set; }
                public string DnatEntryId { get; set; }
                public string ExternalIp { get; set; }
            }
        };

    }

}

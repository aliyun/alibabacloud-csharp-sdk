// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeDnatEntriesResponseBody : TeaModel {
        [NameInMap("DnatEntries")]
        [Validation(Required=false)]
        public DescribeDnatEntriesResponseBodyDnatEntries DnatEntries { get; set; }
        public class DescribeDnatEntriesResponseBodyDnatEntries : TeaModel {
            [NameInMap("DnatEntry")]
            [Validation(Required=false)]
            public List<DescribeDnatEntriesResponseBodyDnatEntriesDnatEntry> DnatEntry { get; set; }
            public class DescribeDnatEntriesResponseBodyDnatEntriesDnatEntry : TeaModel {
                [NameInMap("DnatEntryId")]
                [Validation(Required=false)]
                public string DnatEntryId { get; set; }

                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public string ExternalIp { get; set; }

                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public string InternalIp { get; set; }

                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("SagId")]
                [Validation(Required=false)]
                public string SagId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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

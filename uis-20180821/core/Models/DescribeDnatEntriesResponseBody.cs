// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
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

        [NameInMap("UisDnatEntries")]
        [Validation(Required=false)]
        public DescribeDnatEntriesResponseBodyUisDnatEntries UisDnatEntries { get; set; }
        public class DescribeDnatEntriesResponseBodyUisDnatEntries : TeaModel {
            [NameInMap("UisDnatEntry")]
            [Validation(Required=false)]
            public List<DescribeDnatEntriesResponseBodyUisDnatEntriesUisDnatEntry> UisDnatEntry { get; set; }
            public class DescribeDnatEntriesResponseBodyUisDnatEntriesUisDnatEntry : TeaModel {
                public int? OriginalPort { get; set; }
                public int? DestinationPort { get; set; }
                public string OriginalIp { get; set; }
                public string IpProtocol { get; set; }
                public string UisDnatId { get; set; }
                public string DestinationIp { get; set; }
            }
        };

    }

}

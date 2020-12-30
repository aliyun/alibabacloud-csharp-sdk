// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSnatEntriesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatEntries")]
        [Validation(Required=false)]
        public DescribeSnatEntriesResponseBodySnatEntries SnatEntries { get; set; }
        public class DescribeSnatEntriesResponseBodySnatEntries : TeaModel {
            [NameInMap("SnatEntry")]
            [Validation(Required=false)]
            public List<DescribeSnatEntriesResponseBodySnatEntriesSnatEntry> SnatEntry { get; set; }
            public class DescribeSnatEntriesResponseBodySnatEntriesSnatEntry : TeaModel {
                public string CidrBlock { get; set; }
                public long? CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string SnatIp { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

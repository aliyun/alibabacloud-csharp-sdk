// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindOsVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OsVersionList")]
        [Validation(Required=false)]
        public FindOsVersionsResponseBodyOsVersionList OsVersionList { get; set; }
        public class FindOsVersionsResponseBodyOsVersionList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindOsVersionsResponseBodyOsVersionListItems> Items { get; set; }
            public class FindOsVersionsResponseBodyOsVersionListItems : TeaModel {
                public long? Id { get; set; }
                public string DeviceModelId { get; set; }
                public string SystemVersion { get; set; }
                public string Status { get; set; }
                public string IsMilestone { get; set; }
                public string IsForceUpgrade { get; set; }
                public string IsSilentUpgrade { get; set; }
                public string IsForceReboot { get; set; }
                public string IsForceNightUpgrade { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string Remark { get; set; }
                public string StatusName { get; set; }
                public string DeviceModelName { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifyTimestamp { get; set; }
            }
        };

    }

}

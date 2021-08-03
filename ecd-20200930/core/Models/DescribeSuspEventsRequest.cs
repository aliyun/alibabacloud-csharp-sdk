// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        [NameInMap("ParentEventType")]
        [Validation(Required=false)]
        public string ParentEventType { get; set; }

        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

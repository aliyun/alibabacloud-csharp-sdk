// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumOcuStatisticDataShrinkRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string GroupShrink { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsRequest : TeaModel {
        [NameInMap("AlertTitle")]
        [Validation(Required=false)]
        public string AlertTitle { get; set; }

        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("IsDefend")]
        [Validation(Required=false)]
        public string IsDefend { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public List<string> Level { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class Incident : TeaModel {
        [NameInMap("ActionTime")]
        [Validation(Required=false)]
        public long? ActionTime { get; set; }

        [NameInMap("AlertCount")]
        [Validation(Required=false)]
        public long? AlertCount { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("GroupingData")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupingData { get; set; }

        [NameInMap("GroupingId")]
        [Validation(Required=false)]
        public string GroupingId { get; set; }

        [NameInMap("GroupingKey")]
        [Validation(Required=false)]
        public string GroupingKey { get; set; }

        [NameInMap("IncidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("IncidentStatus")]
        [Validation(Required=false)]
        public string IncidentStatus { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StrategyUuid")]
        [Validation(Required=false)]
        public string StrategyUuid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTimeSpan : TeaModel {
        [NameInMap("dayOfWeek")]
        [Validation(Required=false)]
        public List<int?> DayOfWeek { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("gmtOffset")]
        [Validation(Required=false)]
        public string GmtOffset { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

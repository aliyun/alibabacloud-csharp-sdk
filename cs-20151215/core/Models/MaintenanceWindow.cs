// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MaintenanceWindow : TeaModel {
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("maintenance_time")]
        [Validation(Required=false)]
        public string MaintenanceTime { get; set; }

        [NameInMap("weekly_period")]
        [Validation(Required=false)]
        public string WeeklyPeriod { get; set; }

    }

}
